using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Server_Console.Forms
{
    public partial class PlayersView : UserControl
    {
        public event EventHandler? PlayerJoined;
        public event EventHandler? PlayerLefted;

        public PlayersView()
        {
            InitializeComponent();
        }
    }
}
