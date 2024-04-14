using Minecraft_Server_Console.Views;
using System.Collections.ObjectModel;

namespace Minecraft_Server_Console.Forms
{
    public partial class PlayersView : UserControl
    {
        private readonly ObservableCollection<string> _players = [];

        public PlayersView()
        {
            InitializeComponent();
            ServerConsoleView.PlayerJoined += PlayerJoinedHandler;
            ServerConsoleView.PlayerLefted += PlayerLeftedHandler;
            _players.CollectionChanged += PlayerListChanged;
        }

        private void PlayerJoinedHandler(object sender, ServerEventArgs e)
        {
            _players.Add(e.PlayerName);
        }

        private void PlayerLeftedHandler(object sender, ServerEventArgs e)
        {
            _ = _players.Remove(e.PlayerName);
        }

        private void PlayerListChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            FLP_Main.Controls.Clear();

            if(_players.Count > 0)
            {
                LBL_NoPlayerWarning.Hide();
                FLP_Main.Show();
            }
            else
            {
                LBL_NoPlayerWarning.Show();
                FLP_Main.Hide();
                return;
            }

            foreach(string? player in _players.OrderBy(s => s)) // Order alphabetically
            {
                PlayerDisplayView playerDisplay = new(player);
                FLP_Main.Controls.Add(playerDisplay);
            }
        }
    }
}