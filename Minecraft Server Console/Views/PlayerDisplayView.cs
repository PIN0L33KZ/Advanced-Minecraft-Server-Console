namespace Minecraft_Server_Console.Views
{
    public partial class PlayerDisplayView : UserControl
    {
        public static event EventHandler<ServerEventArgs> PlayerKicked;
        public static event EventHandler<ServerEventArgs> PlayerBanned;
        public static event EventHandler<ServerEventArgs> PlayerGrantedOp;
        private readonly string _playerName;

        public PlayerDisplayView(string playerName)
        {
            InitializeComponent();
            _playerName = playerName;

            LoadPlayerData();
        }

        private async void LoadPlayerData()
        {
            LBL_PlayerName.Text = _playerName;

            string cubeSkinUrl = $"https://minotar.net/bust/{_playerName}/50";
            byte[] cubeSkinBytes = await DownloadSkin(cubeSkinUrl);

            if(cubeSkinBytes != null)
            {
                using MemoryStream stream = new(cubeSkinBytes);
                PBX_PlayerHead.Image = Image.FromStream(stream);
            }
            else
            {
                PBX_PlayerHead.Image = PBX_PlayerHead.ErrorImage;
            }
        }

        private static async Task<byte[]?> DownloadSkin(string url)
        {
            using HttpClient client = new();
            try
            {
                byte[] skinBytes = await client.GetByteArrayAsync(url);
                return skinBytes;
            }
            catch(Exception)
            {
                return null;
            }
        }

        private void BTN_KickPlayer_Click(object sender, EventArgs e)
        {
            PlayerKicked?.Invoke(null, new ServerEventArgs(_playerName));
        }

        private void BTN_BanPlayer_Click(object sender, EventArgs e)
        {
            PlayerBanned?.Invoke(null, new ServerEventArgs(_playerName));
        }

        private void BTN_OpPlayer_Click(object sender, EventArgs e)
        {
            PlayerGrantedOp?.Invoke(null, new ServerEventArgs(_playerName));
        }
    }
}