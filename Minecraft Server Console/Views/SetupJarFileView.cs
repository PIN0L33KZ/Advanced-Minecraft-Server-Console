using Minecraft_Server_Console.Classes.JSON;
using Minecraft_Server_Console.Forms;
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
                    FRM_DialogBox dialogBox = new("Error", "Unable to update Versions.\n" + ex.Message, DialogBoxButtons.OK, DialogIcons.Error) { Owner = FindForm() };
                    _ = dialogBox.ShowDialog();
                    dialogBox.Dispose();
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
                TransitionMaster.Show(ProgressIndicator);
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
                FRM_DialogBox dialogBox = new("Error", "Unable to update Types.\n" + ex.Message, DialogBoxButtons.OK, DialogIcons.Error) { Owner = FindForm() };
                _ = dialogBox.ShowDialog();
                dialogBox.Dispose();
                Application.Exit();
            }
            #endregion
        }

        private void BTN_Continue_Click(object sender, EventArgs e)
        {
            if(CBX_GameVersion.SelectedIndex == -1 || CBX_ServerType.SelectedIndex == -1)
            {
                return;
            }

            TransitionMaster.Hide(BTN_Continue, true);

            TransitionMaster.Show(PSB_DownloadProgress, true);
            TransitionMaster.Show(LBL_DownloadProgress, true);

            using WebClient webClient = new();
            try
            {
                webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
                webClient.DownloadFileCompleted += WebClient_DownloadComplete;
                webClient.DownloadFileAsync(new Uri($"https://serverjars.com/api/fetchJar/servers/{CBX_ServerType.SelectedItem}/{CBX_GameVersion.SelectedItem}"), Properties.Application.Default.ApplicationPath + @"\server.jar");
            }
            catch(Exception ex)
            {
                FRM_DialogBox dialogBox = new("Error", "Unable to download your Java file.\n" + ex.Message, DialogBoxButtons.OK, DialogIcons.Error) { Owner = FindForm() };
                _ = dialogBox.ShowDialog();
                dialogBox.Dispose();
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

        private void CBX_GameVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBX_GameVersion.SelectedIndex != -1)
            {
                TransitionMaster.Show(BTN_Continue);
            }
        }
    }
}