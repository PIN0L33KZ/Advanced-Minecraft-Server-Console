namespace Minecraft_Server_Console.Views
{
    partial class PlayerDisplayView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            PNL_Background = new Guna.UI2.WinForms.Guna2ShadowPanel();
            BTN_OpPlayer = new Guna.UI2.WinForms.Guna2Button();
            BTN_BanPlayer = new Guna.UI2.WinForms.Guna2Button();
            BTN_KickPlayer = new Guna.UI2.WinForms.Guna2Button();
            LBL_PlayerName = new Label();
            PBX_PlayerHead = new PictureBox();
            ToolTip = new ToolTip(components);
            PNL_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBX_PlayerHead).BeginInit();
            SuspendLayout();
            // 
            // PNL_Background
            // 
            PNL_Background.BackColor = Color.Transparent;
            PNL_Background.Controls.Add(BTN_OpPlayer);
            PNL_Background.Controls.Add(BTN_BanPlayer);
            PNL_Background.Controls.Add(BTN_KickPlayer);
            PNL_Background.Controls.Add(LBL_PlayerName);
            PNL_Background.Controls.Add(PBX_PlayerHead);
            PNL_Background.Dock = DockStyle.Fill;
            PNL_Background.FillColor = Color.FromArgb(49, 52, 58);
            PNL_Background.Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PNL_Background.ForeColor = Color.FromArgb(219, 219, 219);
            PNL_Background.Location = new Point(0, 0);
            PNL_Background.Margin = new Padding(4);
            PNL_Background.Name = "PNL_Background";
            PNL_Background.Padding = new Padding(15);
            PNL_Background.Radius = 5;
            PNL_Background.ShadowColor = Color.Black;
            PNL_Background.ShadowDepth = 50;
            PNL_Background.Size = new Size(272, 103);
            PNL_Background.TabIndex = 0;
            // 
            // BTN_OpPlayer
            // 
            BTN_OpPlayer.Animated = true;
            BTN_OpPlayer.BorderColor = Color.FromArgb(64, 67, 75);
            BTN_OpPlayer.BorderRadius = 2;
            BTN_OpPlayer.BorderThickness = 2;
            BTN_OpPlayer.Cursor = Cursors.Hand;
            BTN_OpPlayer.CustomizableEdges = customizableEdges7;
            BTN_OpPlayer.DisabledState.BorderColor = Color.DarkGray;
            BTN_OpPlayer.DisabledState.CustomBorderColor = Color.DarkGray;
            BTN_OpPlayer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BTN_OpPlayer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BTN_OpPlayer.FillColor = Color.FromArgb(64, 67, 75);
            BTN_OpPlayer.Font = new Font("Segoe UI", 9F);
            BTN_OpPlayer.ForeColor = Color.White;
            BTN_OpPlayer.HoverState.BorderColor = Color.White;
            BTN_OpPlayer.Image = Properties.Resources.op_Player;
            BTN_OpPlayer.ImageSize = new Size(25, 25);
            BTN_OpPlayer.Location = new Point(110, 56);
            BTN_OpPlayer.Margin = new Padding(5, 10, 5, 10);
            BTN_OpPlayer.Name = "BTN_OpPlayer";
            BTN_OpPlayer.ShadowDecoration.CustomizableEdges = customizableEdges8;
            BTN_OpPlayer.Size = new Size(35, 35);
            BTN_OpPlayer.TabIndex = 3;
            ToolTip.SetToolTip(BTN_OpPlayer, "Make player an operator.");
            BTN_OpPlayer.Click += BTN_OpPlayer_Click;
            // 
            // BTN_BanPlayer
            // 
            BTN_BanPlayer.Animated = true;
            BTN_BanPlayer.BorderColor = Color.FromArgb(64, 67, 75);
            BTN_BanPlayer.BorderRadius = 2;
            BTN_BanPlayer.BorderThickness = 2;
            BTN_BanPlayer.Cursor = Cursors.Hand;
            BTN_BanPlayer.CustomizableEdges = customizableEdges9;
            BTN_BanPlayer.DisabledState.BorderColor = Color.DarkGray;
            BTN_BanPlayer.DisabledState.CustomBorderColor = Color.DarkGray;
            BTN_BanPlayer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BTN_BanPlayer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BTN_BanPlayer.FillColor = Color.FromArgb(64, 67, 75);
            BTN_BanPlayer.Font = new Font("Segoe UI", 9F);
            BTN_BanPlayer.ForeColor = Color.White;
            BTN_BanPlayer.HoverState.BorderColor = Color.White;
            BTN_BanPlayer.Image = Properties.Resources.ban_player;
            BTN_BanPlayer.ImageSize = new Size(25, 25);
            BTN_BanPlayer.Location = new Point(155, 56);
            BTN_BanPlayer.Margin = new Padding(5, 10, 5, 10);
            BTN_BanPlayer.Name = "BTN_BanPlayer";
            BTN_BanPlayer.ShadowDecoration.CustomizableEdges = customizableEdges10;
            BTN_BanPlayer.Size = new Size(35, 35);
            BTN_BanPlayer.TabIndex = 3;
            ToolTip.SetToolTip(BTN_BanPlayer, "Ban player.");
            BTN_BanPlayer.Click += BTN_BanPlayer_Click;
            // 
            // BTN_KickPlayer
            // 
            BTN_KickPlayer.Animated = true;
            BTN_KickPlayer.BorderColor = Color.FromArgb(64, 67, 75);
            BTN_KickPlayer.BorderRadius = 2;
            BTN_KickPlayer.BorderThickness = 2;
            BTN_KickPlayer.Cursor = Cursors.Hand;
            BTN_KickPlayer.CustomizableEdges = customizableEdges11;
            BTN_KickPlayer.DisabledState.BorderColor = Color.DarkGray;
            BTN_KickPlayer.DisabledState.CustomBorderColor = Color.DarkGray;
            BTN_KickPlayer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BTN_KickPlayer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BTN_KickPlayer.FillColor = Color.FromArgb(64, 67, 75);
            BTN_KickPlayer.Font = new Font("Segoe UI", 9F);
            BTN_KickPlayer.ForeColor = Color.White;
            BTN_KickPlayer.HoverState.BorderColor = Color.White;
            BTN_KickPlayer.Image = Properties.Resources.kick_player;
            BTN_KickPlayer.ImageSize = new Size(25, 25);
            BTN_KickPlayer.Location = new Point(200, 56);
            BTN_KickPlayer.Margin = new Padding(5, 10, 5, 10);
            BTN_KickPlayer.Name = "BTN_KickPlayer";
            BTN_KickPlayer.ShadowDecoration.CustomizableEdges = customizableEdges12;
            BTN_KickPlayer.Size = new Size(35, 35);
            BTN_KickPlayer.TabIndex = 3;
            ToolTip.SetToolTip(BTN_KickPlayer, "Kick player.");
            BTN_KickPlayer.Click += BTN_KickPlayer_Click;
            // 
            // LBL_PlayerName
            // 
            LBL_PlayerName.AutoEllipsis = true;
            LBL_PlayerName.Font = new Font("Microsoft YaHei UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_PlayerName.Location = new Point(88, 15);
            LBL_PlayerName.Name = "LBL_PlayerName";
            LBL_PlayerName.Size = new Size(166, 31);
            LBL_PlayerName.TabIndex = 1;
            LBL_PlayerName.Text = "Notch";
            // 
            // PBX_PlayerHead
            // 
            PBX_PlayerHead.ErrorImage = Properties.Resources.player_bust_placeholder;
            PBX_PlayerHead.Location = new Point(25, 21);
            PBX_PlayerHead.Margin = new Padding(10);
            PBX_PlayerHead.Name = "PBX_PlayerHead";
            PBX_PlayerHead.Size = new Size(60, 60);
            PBX_PlayerHead.SizeMode = PictureBoxSizeMode.StretchImage;
            PBX_PlayerHead.TabIndex = 0;
            PBX_PlayerHead.TabStop = false;
            // 
            // PlayerDisplayView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(PNL_Background);
            Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(219, 219, 219);
            Margin = new Padding(4);
            Name = "PlayerDisplayView";
            Size = new Size(272, 103);
            PNL_Background.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBX_PlayerHead).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel PNL_Background;
        private PictureBox PBX_PlayerHead;
        private Label LBL_PlayerName;
        private Guna.UI2.WinForms.Guna2Button BTN_KickPlayer;
        private Guna.UI2.WinForms.Guna2Button BTN_OpPlayer;
        private Guna.UI2.WinForms.Guna2Button BTN_BanPlayer;
        private ToolTip ToolTip;
    }
}
