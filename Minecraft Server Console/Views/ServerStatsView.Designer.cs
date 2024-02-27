namespace Minecraft_Server_Console.Views
{
    partial class ServerStatsView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            GBX_NetworkStats = new Guna.UI2.WinForms.Guna2GroupBox();
            LBL_ServerUptime = new Label();
            LBL_Ping = new Label();
            LBL_RemoteIP = new Label();
            LBL_LocalIP = new Label();
            ToolTip = new ToolTip(components);
            LBL_CpuUsage = new Label();
            LBL_RamUsage = new Label();
            GBX_HardwareStats = new Guna.UI2.WinForms.Guna2GroupBox();
            GPB_GameStats = new Guna.UI2.WinForms.Guna2GroupBox();
            LBL_ServerPort = new Label();
            LBL_GameVersion = new Label();
            GBX_NetworkStats.SuspendLayout();
            GBX_HardwareStats.SuspendLayout();
            GPB_GameStats.SuspendLayout();
            SuspendLayout();
            // 
            // GBX_NetworkStats
            // 
            GBX_NetworkStats.Anchor = AnchorStyles.None;
            GBX_NetworkStats.BackColor = Color.Transparent;
            GBX_NetworkStats.BorderColor = Color.FromArgb(64, 67, 75);
            GBX_NetworkStats.BorderRadius = 5;
            GBX_NetworkStats.BorderThickness = 2;
            GBX_NetworkStats.Controls.Add(LBL_ServerUptime);
            GBX_NetworkStats.Controls.Add(LBL_Ping);
            GBX_NetworkStats.Controls.Add(LBL_RemoteIP);
            GBX_NetworkStats.Controls.Add(LBL_LocalIP);
            GBX_NetworkStats.CustomBorderColor = Color.FromArgb(64, 67, 75);
            GBX_NetworkStats.CustomizableEdges = customizableEdges1;
            GBX_NetworkStats.FillColor = Color.FromArgb(49, 52, 58);
            GBX_NetworkStats.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GBX_NetworkStats.ForeColor = Color.FromArgb(219, 219, 219);
            GBX_NetworkStats.Location = new Point(28, 60);
            GBX_NetworkStats.Margin = new Padding(10);
            GBX_NetworkStats.Name = "GBX_NetworkStats";
            GBX_NetworkStats.ShadowDecoration.CustomizableEdges = customizableEdges2;
            GBX_NetworkStats.ShadowDecoration.Depth = 10;
            GBX_NetworkStats.ShadowDecoration.Shadow = new Padding(6);
            GBX_NetworkStats.Size = new Size(258, 215);
            GBX_NetworkStats.TabIndex = 0;
            GBX_NetworkStats.Text = "Network";
            GBX_NetworkStats.TextAlign = HorizontalAlignment.Center;
            GBX_NetworkStats.UseTransparentBackground = true;
            // 
            // LBL_ServerUptime
            // 
            LBL_ServerUptime.Font = new Font("Microsoft YaHei UI", 11.25F);
            LBL_ServerUptime.Location = new Point(20, 171);
            LBL_ServerUptime.Margin = new Padding(20, 5, 20, 5);
            LBL_ServerUptime.Name = "LBL_ServerUptime";
            LBL_ServerUptime.Size = new Size(218, 29);
            LBL_ServerUptime.TabIndex = 0;
            LBL_ServerUptime.Text = "Uptime: not started yet.";
            LBL_ServerUptime.TextAlign = ContentAlignment.MiddleCenter;
            ToolTip.SetToolTip(LBL_ServerUptime, "This is the total time your server is running.");
            LBL_ServerUptime.Click += LBL_RemoteIP_Click;
            // 
            // LBL_Ping
            // 
            LBL_Ping.Font = new Font("Microsoft YaHei UI", 11.25F);
            LBL_Ping.Location = new Point(20, 132);
            LBL_Ping.Margin = new Padding(20, 5, 20, 5);
            LBL_Ping.Name = "LBL_Ping";
            LBL_Ping.Size = new Size(218, 29);
            LBL_Ping.TabIndex = 0;
            LBL_Ping.Text = "Ping: 0/ms";
            LBL_Ping.TextAlign = ContentAlignment.MiddleCenter;
            ToolTip.SetToolTip(LBL_Ping, "Displays the roundtrip time to 8.8.8.8.");
            LBL_Ping.Click += LBL_RemoteIP_Click;
            // 
            // LBL_RemoteIP
            // 
            LBL_RemoteIP.Cursor = Cursors.Hand;
            LBL_RemoteIP.Font = new Font("Microsoft YaHei UI", 11.25F);
            LBL_RemoteIP.Location = new Point(20, 93);
            LBL_RemoteIP.Margin = new Padding(20, 5, 20, 5);
            LBL_RemoteIP.Name = "LBL_RemoteIP";
            LBL_RemoteIP.Size = new Size(218, 29);
            LBL_RemoteIP.TabIndex = 0;
            LBL_RemoteIP.Text = "Remote-IP: 0.0.0.0";
            LBL_RemoteIP.TextAlign = ContentAlignment.MiddleCenter;
            ToolTip.SetToolTip(LBL_RemoteIP, "Click to copy your remote adress");
            LBL_RemoteIP.Click += LBL_RemoteIP_Click;
            LBL_RemoteIP.MouseEnter += LBL_RemoteIP_MouseEnter;
            LBL_RemoteIP.MouseLeave += LBL_RemoteIP_MouseLeave;
            // 
            // LBL_LocalIP
            // 
            LBL_LocalIP.Cursor = Cursors.Hand;
            LBL_LocalIP.Font = new Font("Microsoft YaHei UI", 11.25F);
            LBL_LocalIP.Location = new Point(20, 54);
            LBL_LocalIP.Margin = new Padding(20, 5, 20, 5);
            LBL_LocalIP.Name = "LBL_LocalIP";
            LBL_LocalIP.Size = new Size(218, 29);
            LBL_LocalIP.TabIndex = 0;
            LBL_LocalIP.Text = "Local-IP: 0.0.0.0";
            LBL_LocalIP.TextAlign = ContentAlignment.MiddleCenter;
            ToolTip.SetToolTip(LBL_LocalIP, "Click to copy your local adress");
            LBL_LocalIP.Click += LBL_LocalIP_Click;
            // 
            // LBL_CpuUsage
            // 
            LBL_CpuUsage.Font = new Font("Microsoft YaHei UI", 11.25F);
            LBL_CpuUsage.Location = new Point(20, 112);
            LBL_CpuUsage.Margin = new Padding(20, 5, 20, 5);
            LBL_CpuUsage.Name = "LBL_CpuUsage";
            LBL_CpuUsage.Size = new Size(155, 29);
            LBL_CpuUsage.TabIndex = 0;
            LBL_CpuUsage.Text = "CPU usage: 0%";
            LBL_CpuUsage.TextAlign = ContentAlignment.MiddleCenter;
            ToolTip.SetToolTip(LBL_CpuUsage, "Your current system CPU usage.");
            LBL_CpuUsage.Click += LBL_LocalIP_Click;
            // 
            // LBL_RamUsage
            // 
            LBL_RamUsage.Font = new Font("Microsoft YaHei UI", 11.25F);
            LBL_RamUsage.Location = new Point(20, 73);
            LBL_RamUsage.Margin = new Padding(20, 5, 20, 5);
            LBL_RamUsage.Name = "LBL_RamUsage";
            LBL_RamUsage.Size = new Size(155, 29);
            LBL_RamUsage.TabIndex = 0;
            LBL_RamUsage.Text = "RAM usage: 0%";
            LBL_RamUsage.TextAlign = ContentAlignment.MiddleCenter;
            ToolTip.SetToolTip(LBL_RamUsage, "Your current system RAM usage.");
            LBL_RamUsage.Click += LBL_LocalIP_Click;
            // 
            // GBX_HardwareStats
            // 
            GBX_HardwareStats.Anchor = AnchorStyles.None;
            GBX_HardwareStats.BackColor = Color.Transparent;
            GBX_HardwareStats.BorderColor = Color.FromArgb(64, 67, 75);
            GBX_HardwareStats.BorderRadius = 5;
            GBX_HardwareStats.BorderThickness = 2;
            GBX_HardwareStats.Controls.Add(LBL_CpuUsage);
            GBX_HardwareStats.Controls.Add(LBL_RamUsage);
            GBX_HardwareStats.CustomBorderColor = Color.FromArgb(64, 67, 75);
            GBX_HardwareStats.CustomizableEdges = customizableEdges3;
            GBX_HardwareStats.FillColor = Color.FromArgb(49, 52, 58);
            GBX_HardwareStats.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            GBX_HardwareStats.ForeColor = Color.FromArgb(219, 219, 219);
            GBX_HardwareStats.Location = new Point(306, 60);
            GBX_HardwareStats.Margin = new Padding(10);
            GBX_HardwareStats.Name = "GBX_HardwareStats";
            GBX_HardwareStats.ShadowDecoration.CustomizableEdges = customizableEdges4;
            GBX_HardwareStats.ShadowDecoration.Depth = 10;
            GBX_HardwareStats.ShadowDecoration.Shadow = new Padding(6);
            GBX_HardwareStats.Size = new Size(195, 215);
            GBX_HardwareStats.TabIndex = 0;
            GBX_HardwareStats.Text = "Hardware";
            GBX_HardwareStats.TextAlign = HorizontalAlignment.Center;
            GBX_HardwareStats.UseTransparentBackground = true;
            // 
            // GPB_GameStats
            // 
            GPB_GameStats.Anchor = AnchorStyles.None;
            GPB_GameStats.BackColor = Color.Transparent;
            GPB_GameStats.BorderColor = Color.FromArgb(64, 67, 75);
            GPB_GameStats.BorderRadius = 5;
            GPB_GameStats.BorderThickness = 2;
            GPB_GameStats.Controls.Add(LBL_ServerPort);
            GPB_GameStats.Controls.Add(LBL_GameVersion);
            GPB_GameStats.CustomBorderColor = Color.FromArgb(64, 67, 75);
            GPB_GameStats.CustomizableEdges = customizableEdges5;
            GPB_GameStats.FillColor = Color.FromArgb(49, 52, 58);
            GPB_GameStats.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            GPB_GameStats.ForeColor = Color.FromArgb(219, 219, 219);
            GPB_GameStats.Location = new Point(521, 60);
            GPB_GameStats.Margin = new Padding(10);
            GPB_GameStats.Name = "GPB_GameStats";
            GPB_GameStats.ShadowDecoration.CustomizableEdges = customizableEdges6;
            GPB_GameStats.ShadowDecoration.Depth = 10;
            GPB_GameStats.ShadowDecoration.Shadow = new Padding(6);
            GPB_GameStats.Size = new Size(195, 215);
            GPB_GameStats.TabIndex = 0;
            GPB_GameStats.Text = "Game";
            GPB_GameStats.TextAlign = HorizontalAlignment.Center;
            GPB_GameStats.UseTransparentBackground = true;
            // 
            // LBL_ServerPort
            // 
            LBL_ServerPort.AutoEllipsis = true;
            LBL_ServerPort.Font = new Font("Microsoft YaHei UI", 11.25F);
            LBL_ServerPort.Location = new Point(20, 132);
            LBL_ServerPort.Margin = new Padding(20, 5, 20, 5);
            LBL_ServerPort.Name = "LBL_ServerPort";
            LBL_ServerPort.Size = new Size(155, 68);
            LBL_ServerPort.TabIndex = 0;
            LBL_ServerPort.Text = "No infos.";
            LBL_ServerPort.TextAlign = ContentAlignment.MiddleCenter;
            LBL_ServerPort.Click += LBL_LocalIP_Click;
            // 
            // LBL_GameVersion
            // 
            LBL_GameVersion.AutoEllipsis = true;
            LBL_GameVersion.Font = new Font("Microsoft YaHei UI", 11.25F);
            LBL_GameVersion.Location = new Point(20, 54);
            LBL_GameVersion.Margin = new Padding(20, 5, 20, 5);
            LBL_GameVersion.Name = "LBL_GameVersion";
            LBL_GameVersion.Size = new Size(155, 68);
            LBL_GameVersion.TabIndex = 0;
            LBL_GameVersion.Text = "No infos.";
            LBL_GameVersion.TextAlign = ContentAlignment.MiddleCenter;
            LBL_GameVersion.Click += LBL_LocalIP_Click;
            // 
            // ServerStatsView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 37, 41);
            Controls.Add(GPB_GameStats);
            Controls.Add(GBX_HardwareStats);
            Controls.Add(GBX_NetworkStats);
            Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(219, 219, 219);
            Margin = new Padding(4);
            Name = "ServerStatsView";
            Size = new Size(745, 334);
            Load += ServerStatsView_Load;
            GBX_NetworkStats.ResumeLayout(false);
            GBX_HardwareStats.ResumeLayout(false);
            GPB_GameStats.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GBX_NetworkStats;
        private Label LBL_LocalIP;
        private Label LBL_RemoteIP;
        private ToolTip ToolTip;
        private Label LBL_Ping;
        private Label LBL_ServerUptime;
        private Guna.UI2.WinForms.Guna2GroupBox GBX_HardwareStats;
        private Label label3;
        private Label LBL_RamUsage;
        private Label LBL_CpuUsage;
        private Guna.UI2.WinForms.Guna2GroupBox GPB_GameStats;
        private Label LBL_GameVersion;
        private Label LBL_ServerPort;
    }
}
