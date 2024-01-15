using Minecraft_Server_Console.Views;

namespace Minecraft_Server_Console
{
    public partial class FRM_Console : Form
    {
        private SetupAppDirectoryView? _setupDirectoryView;
        private SetupJarFileView? _setupJarFileView;
        private ServerConsoleView? _serverConsoleView;
        private ServerStatsView? _serverStatsView;

        public FRM_Console()
        {
            InitializeComponent();

            if(Properties.Application.Default.ApplicationPath.Length == 0 || !Directory.Exists(Properties.Application.Default.ApplicationPath))
            {
                AddSetupAppDirectoryView();
                return;
            }

            try
            {
                string[] javaFiles = Directory.GetFiles(Properties.Application.Default.ApplicationPath, "*.jar");
                if(javaFiles.Length > 0)
                {
                    AddServerConsoleView();
                    AddServerStatsView();
                    return;
                }

                _setupJarFileView = new SetupJarFileView() { Dock = DockStyle.Fill };
                AddSetupJarFileView();
            }
            catch(Exception ex)
            {
                _ = MessageBox.Show("Unable to check if Java files exists.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FRM_Console_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Exit application if view wasn't initialized.
            if(_serverConsoleView == null)
            {
                return;
            }

            // Exit application if server is not started.
            if(!_serverConsoleView.TBX_ConsoleLog.Text.Contains("INFO]: Done "))
            {
                return;
            }

            // Exit application if server was started but stopped.
            if(_serverConsoleView.TBX_ConsoleLog.Text.Contains("INFO]: Closing Server"))
            {
                return;
            }

            e.Cancel = true;
            _ = MessageBox.Show("Please shutdown your server befor exiting!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #region Add view to window
        private void AddSetupAppDirectoryView()
        {
            _setupDirectoryView = new SetupAppDirectoryView() { Dock = DockStyle.Fill };
            _setupDirectoryView.ContinueButtonClicked += SetupAppDirectoryView_ContinueButtonClicked;
            Controls.Add(_setupDirectoryView);
            _setupDirectoryView.BringToFront();
        }

        private void AddSetupJarFileView()
        {
            _setupJarFileView = new SetupJarFileView() { Dock = DockStyle.Fill };
            _setupJarFileView.ContinueButtonClicked += SetupJarFileView_ContinueButtonClicked;
            Controls.Add(_setupJarFileView);
            _setupJarFileView.BringToFront();
        }

        private void AddServerConsoleView()
        {
            _serverConsoleView = new ServerConsoleView() { Dock = DockStyle.Fill };
            TAP_ServerConsole.Controls.Add(_serverConsoleView);
            _serverConsoleView.BringToFront();
        }

        private void AddServerStatsView()
        {
            _serverStatsView = new ServerStatsView(_serverConsoleView) {  Dock = DockStyle.Fill };
            TAP_ServerStats.Controls.Add(_serverStatsView);
            _serverStatsView.BringToFront();
            _serverStatsView.Hide();
        }
        #endregion

        #region Continue buttons from setups
        private void SetupAppDirectoryView_ContinueButtonClicked(object? sender, EventArgs e)
        {
            Controls.Remove(_setupDirectoryView);
            _setupDirectoryView?.Dispose();

            AddSetupJarFileView();
        }

        private void SetupJarFileView_ContinueButtonClicked(object? sender, EventArgs e)
        {
            Controls.Remove(_setupJarFileView);
            _setupJarFileView?.Dispose();

            AddServerConsoleView();
            AddServerStatsView();
        }
        #endregion

        private void TAC_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(TAC_Main.SelectedIndex)
            {
                // Server Console Tab
                case 0:
                    // Hide all other views
                    _serverStatsView.Hide();
                    TransitionMaster.Show(_serverConsoleView);
                    break;

                case 1:
                    // Hide all other views
                    _serverConsoleView.Hide();
                    TransitionMaster.Show(_serverStatsView);
                    // Show stats view
                    break;
            }
        }
    }
}