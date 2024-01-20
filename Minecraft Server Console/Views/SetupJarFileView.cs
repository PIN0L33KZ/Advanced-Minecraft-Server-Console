﻿using Minecraft_Server_Console.Classes.JSON;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Net;

namespace Minecraft_Server_Console.Views
{
    public partial class SetupJarFileView : UserControl
    {
        public event EventHandler? ContinueButtonClicked;
        private ServerTypesRoot _serverTypesApiResponse;
        private ServerVersionsRoot _serverVersionsApiResponse;

        public SetupJarFileView()
        {
            InitializeComponent();
        }

        private async void CBX_ServerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBX_ServerType.SelectedIndex == -1)
            {
                return;
            }

            TransitionMaster.Show(ProgressIndicator);
            LBL_GameVersion.Hide();
            CBX_GameVersion.Hide();

            CBX_GameVersion.Items.Clear();

            // Fetch versions
            #region prefill server versions combobox
            using(WebClient webClient = new())
            {
                try
                {
                    string jsonString = await webClient.DownloadStringTaskAsync($"https://serverjars.com/api/fetchAll/servers/{CBX_ServerType.SelectedItem}/200");

                    _serverVersionsApiResponse = JsonConvert.DeserializeObject<ServerVersionsRoot>(jsonString);

                    // Prefill Combobox.
                    foreach(ServerVersionsResponse version in _serverVersionsApiResponse.response)
                    {
                        _ = CBX_GameVersion.Items.Add(version.version);
                    }

                    CBX_GameVersion.SelectedIndex = 0;
                }
                catch(Exception ex)
                {
                    _ = MessageBox.Show("Unable to update Serverversions.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion
            TransitionMaster.Hide(ProgressIndicator);
            TransitionMaster.Show(LBL_GameVersion, true);
            TransitionMaster.Show(CBX_GameVersion, true);
        }

        private async void SetupJarFileView_Load(object sender, EventArgs e)
        {
            #region prefill server type combobox
            using WebClient webClient = new();
            try
            {
                string jsonString = await webClient.DownloadStringTaskAsync(@"https://serverjars.com/api/fetchTypes/");

                _serverTypesApiResponse = JsonConvert.DeserializeObject<ServerTypesRoot>(jsonString);

                // Prefill Combobox.
                foreach(string type in _serverTypesApiResponse.response.servers)
                {
                    _ = CBX_ServerType.Items.Add(type);
                }

                TransitionMaster.Hide(ProgressIndicator);
                TransitionMaster.Show(LBL_ServerType, true);
                TransitionMaster.Show(CBX_ServerType, true);
            }
            catch(Exception ex)
            {
                _ = MessageBox.Show("Unable to update Servertypes.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void BTN_Continue_Click(object sender, EventArgs e)
        {
            if(CBX_GameVersion.SelectedIndex == -1 || CBX_ServerType.SelectedIndex == -1)
            {
                return;
            }

            TransitionMaster.Show(PSB_DownloadProgress);
            TransitionMaster.Show(LBL_DownloadProgress);

            using WebClient webClient = new();
            try
            {
                TransitionMaster.Hide(BTN_Continue);
                webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
                webClient.DownloadFileCompleted += WebClient_DownloadComplete;
                webClient.DownloadFileAsync(new Uri($"https://serverjars.com/api/fetchJar/servers/{CBX_ServerType.SelectedItem}/{CBX_GameVersion.SelectedItem}"), Properties.Application.Default.ApplicationPath + @"\server.jar");
            }
            catch(Exception ex)
            {
                _ = MessageBox.Show("Unable to download your Java file.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            PSB_DownloadProgress.Value = e.ProgressPercentage;
        }

        private void WebClient_DownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            ContinueButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}