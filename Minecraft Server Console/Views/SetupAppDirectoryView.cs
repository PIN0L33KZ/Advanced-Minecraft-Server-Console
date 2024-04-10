namespace Minecraft_Server_Console.Views
{
    public partial class SetupAppDirectoryView : UserControl
    {
        public event EventHandler? ContinueButtonClicked;
        private string _appDirectory = "";
        public SetupAppDirectoryView()
        {
            InitializeComponent();
        }

        private void BTN_SelectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fBD = new();

            if(fBD.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            BTN_SelectDirectory.Text = "Select directory " + fBD.SelectedPath + "?";
            BTN_SelectDirectory.Text = $"Select directory \"{fBD.SelectedPath}\"?";
            _appDirectory = fBD.SelectedPath;
        }

        private void BTN_Continue_Click(object sender, EventArgs e)
        {
            if(_appDirectory == "")
            {
                return;
            }

            Properties.Application.Default.ApplicationPath = _appDirectory;
            Properties.Application.Default.Save();
            ContinueButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}