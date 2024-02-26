namespace Minecraft_Server_Console.Views
{
    partial class ServerConsoleView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            PNL_SendCommandArea = new Panel();
            BTN_SendCommand = new Guna.UI2.WinForms.Guna2Button();
            TBX_Command = new Guna.UI2.WinForms.Guna2TextBox();
            FLP_ServerControls = new FlowLayoutPanel();
            BTN_StartServer = new Guna.UI2.WinForms.Guna2Button();
            BTN_ReloadServer = new Guna.UI2.WinForms.Guna2Button();
            BTN_StopServer = new Guna.UI2.WinForms.Guna2Button();
            ProgressIndicator = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            BTN_AgreeToEula = new Guna.UI2.WinForms.Guna2Button();
            TBX_ConsoleLog = new RichTextBox();
            VSB_ConsoleLog = new Guna.UI2.WinForms.Guna2VScrollBar();
            HSB_ConsoleLog = new Guna.UI2.WinForms.Guna2HScrollBar();
            ToolTip = new ToolTip(components);
            PNL_SendCommandArea.SuspendLayout();
            FLP_ServerControls.SuspendLayout();
            SuspendLayout();
            // 
            // PNL_SendCommandArea
            // 
            PNL_SendCommandArea.Controls.Add(BTN_SendCommand);
            PNL_SendCommandArea.Controls.Add(TBX_Command);
            PNL_SendCommandArea.Dock = DockStyle.Bottom;
            PNL_SendCommandArea.Enabled = false;
            PNL_SendCommandArea.Location = new Point(0, 411);
            PNL_SendCommandArea.Name = "PNL_SendCommandArea";
            PNL_SendCommandArea.Size = new Size(837, 63);
            PNL_SendCommandArea.TabIndex = 4;
            // 
            // BTN_SendCommand
            // 
            BTN_SendCommand.Anchor = AnchorStyles.Right;
            BTN_SendCommand.Animated = true;
            BTN_SendCommand.BorderColor = Color.FromArgb(37, 93, 213);
            BTN_SendCommand.BorderRadius = 5;
            BTN_SendCommand.BorderThickness = 2;
            BTN_SendCommand.Cursor = Cursors.Hand;
            BTN_SendCommand.CustomizableEdges = customizableEdges1;
            BTN_SendCommand.DisabledState.BorderColor = Color.DarkGray;
            BTN_SendCommand.DisabledState.CustomBorderColor = Color.DarkGray;
            BTN_SendCommand.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BTN_SendCommand.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BTN_SendCommand.FillColor = Color.FromArgb(37, 93, 213);
            BTN_SendCommand.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTN_SendCommand.ForeColor = Color.White;
            BTN_SendCommand.HoverState.BorderColor = Color.White;
            BTN_SendCommand.ImageAlign = HorizontalAlignment.Left;
            BTN_SendCommand.ImageSize = new Size(22, 22);
            BTN_SendCommand.Location = new Point(730, 12);
            BTN_SendCommand.Margin = new Padding(10);
            BTN_SendCommand.Name = "BTN_SendCommand";
            BTN_SendCommand.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BTN_SendCommand.Size = new Size(97, 36);
            BTN_SendCommand.TabIndex = 4;
            BTN_SendCommand.Text = "Send";
            ToolTip.SetToolTip(BTN_SendCommand, "Send command to server");
            BTN_SendCommand.Click += BTN_SendCommand_Click;
            // 
            // TBX_Command
            // 
            TBX_Command.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TBX_Command.Animated = true;
            TBX_Command.AutoCompleteCustomSource.AddRange(new string[] { "?", "ability", "advancement", "alwaysday", "attribute", "ban", "ban-ip", "banlist", "bossbar", "camera", "camerashake", "changesetting", "clear", "clearspawnpoint", "clone", "connect", "damage", "data", "datapack", "daylock", "debug", "dedicatedwsserver", "defaultgamemode", "deop", "dialogue", "difficulty", "effect", "enchant", "event", "execute", "experience", "fill", "fillbiome", "fog", "forceload", "function", "gamemode", "gamerule", "gametest", "give", "help", "immutableworld", "item", "jfr", "kick", "kill", "list", "locate", "loot", "me", "mobevent", "msg", "music", "op", "ops", "pardon", "pardon-ip", "particle", "perf", "permission", "place", "playanimation", "playsound", "publish", "random", "recipe", "reload", "remove", "replaceitem", "return", "ride", "save", "save-all", "save-off", "save-on", "say", "schedule", "scoreboard", "script", "scriptevent", "seed", "setblock", "setidletimeout", "setmaxplayers", "setworldspawn", "spawnpoint", "spectate", "spreadplayers", "stop", "stopsound", "structure", "summon", "tag", "team", "teammsg", "teleport", "tell", "tellraw", "testfor", "testforblock", "testforblocks", "tickingarea", "time", "title", "titleraw", "tm", "toggledownfall", "tp", "trigger", "transferserver", "volumearea", "w", "wb", "weather", "whitelist", "worldborder", "worldbuilder", "wsserver", "xp", "?", "/ability", "/advancement", "/alwaysday", "/attribute", "/ban", "/ban-ip", "/banlist", "/bossbar", "/camera", "/camerashake", "/changesetting", "/clear", "/clearspawnpoint", "/clone", "/connect", "/damage", "/data", "/datapack", "/daylock", "/debug", "/dedicatedwsserver", "/defaultgamemode", "/deop", "/dialogue", "/difficulty", "/effect", "/enchant", "/event", "/execute", "/experience", "/fill", "/fillbiome", "/fog", "/forceload", "/function", "/gamemode", "/gamerule", "/gametest", "/give", "/help", "/immutableworld", "/item", "/jfr", "/kick", "/kill", "/list", "/locate", "/loot", "/me", "/mobevent", "/msg", "/music", "/op", "/ops", "/pardon", "/pardon-ip", "/particle", "/perf", "/permission", "/place", "/playanimation", "/playsound", "/publish", "/random", "/recipe", "/reload", "/remove", "/replaceitem", "/return", "/ride", "/save", "/save-all", "/save-off", "/save-on", "/say", "/schedule", "/scoreboard", "/script", "/scriptevent", "/seed", "/setblock", "/setidletimeout", "/setmaxplayers", "/setworldspawn", "/spawnpoint", "/spectate", "/spreadplayers", "/stop", "/stopsound", "/structure", "/summon", "/tag", "/team", "/teammsg", "/teleport", "/tell", "/tellraw", "/testfor", "/testforblock", "/testforblocks", "/tickingarea", "/time", "/title", "/titleraw", "/tm", "/toggledownfall", "/tp", "/trigger", "/transferserver", "/volumearea", "/w", "/wb", "/weather", "/whitelist", "/worldborder", "/worldbuilder", "/wsserver", "/xp" });
            TBX_Command.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TBX_Command.BorderColor = Color.FromArgb(64, 67, 75);
            TBX_Command.BorderRadius = 5;
            TBX_Command.BorderThickness = 2;
            TBX_Command.CustomizableEdges = customizableEdges3;
            TBX_Command.DefaultText = "";
            TBX_Command.DisabledState.BorderColor = Color.DarkGray;
            TBX_Command.DisabledState.FillColor = Color.DarkGray;
            TBX_Command.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            TBX_Command.DisabledState.PlaceholderForeColor = Color.DarkGray;
            TBX_Command.FillColor = Color.FromArgb(49, 52, 58);
            TBX_Command.FocusedState.BorderColor = Color.FromArgb(37, 93, 213);
            TBX_Command.Font = new Font("Microsoft YaHei UI", 11.25F);
            TBX_Command.ForeColor = Color.FromArgb(219, 219, 219);
            TBX_Command.Location = new Point(17, 12);
            TBX_Command.Margin = new Padding(17, 20, 17, 20);
            TBX_Command.Name = "TBX_Command";
            TBX_Command.PasswordChar = '\0';
            TBX_Command.PlaceholderForeColor = Color.FromArgb(110, 110, 110);
            TBX_Command.PlaceholderText = "Enter server or game command here";
            TBX_Command.SelectedText = "";
            TBX_Command.ShadowDecoration.CustomizableEdges = customizableEdges4;
            TBX_Command.Size = new Size(700, 38);
            TBX_Command.TabIndex = 0;
            ToolTip.SetToolTip(TBX_Command, "Input your Minecraft command here");
            TBX_Command.WordWrap = false;
            TBX_Command.KeyDown += TBX_Command_KeyDown;
            // 
            // FLP_ServerControls
            // 
            FLP_ServerControls.Controls.Add(BTN_StartServer);
            FLP_ServerControls.Controls.Add(BTN_ReloadServer);
            FLP_ServerControls.Controls.Add(BTN_StopServer);
            FLP_ServerControls.Controls.Add(ProgressIndicator);
            FLP_ServerControls.Controls.Add(BTN_AgreeToEula);
            FLP_ServerControls.Dock = DockStyle.Top;
            FLP_ServerControls.Location = new Point(0, 0);
            FLP_ServerControls.Name = "FLP_ServerControls";
            FLP_ServerControls.Size = new Size(837, 61);
            FLP_ServerControls.TabIndex = 0;
            // 
            // BTN_StartServer
            // 
            BTN_StartServer.Animated = true;
            BTN_StartServer.BorderColor = Color.FromArgb(39, 197, 106);
            BTN_StartServer.BorderRadius = 5;
            BTN_StartServer.BorderThickness = 2;
            BTN_StartServer.Cursor = Cursors.Hand;
            BTN_StartServer.CustomizableEdges = customizableEdges5;
            BTN_StartServer.DisabledState.BorderColor = Color.DarkGray;
            BTN_StartServer.DisabledState.CustomBorderColor = Color.DarkGray;
            BTN_StartServer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BTN_StartServer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BTN_StartServer.FillColor = Color.FromArgb(39, 197, 106);
            BTN_StartServer.Font = new Font("Segoe UI", 9F);
            BTN_StartServer.ForeColor = Color.White;
            BTN_StartServer.HoverState.BorderColor = Color.White;
            BTN_StartServer.Image = Properties.Resources.start_server;
            BTN_StartServer.Location = new Point(10, 10);
            BTN_StartServer.Margin = new Padding(10, 10, 5, 10);
            BTN_StartServer.Name = "BTN_StartServer";
            BTN_StartServer.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BTN_StartServer.Size = new Size(40, 40);
            BTN_StartServer.TabIndex = 0;
            ToolTip.SetToolTip(BTN_StartServer, "Start server");
            BTN_StartServer.Click += BTN_StartServer_Click;
            // 
            // BTN_ReloadServer
            // 
            BTN_ReloadServer.Animated = true;
            BTN_ReloadServer.BorderColor = Color.FromArgb(243, 156, 18);
            BTN_ReloadServer.BorderRadius = 5;
            BTN_ReloadServer.BorderThickness = 2;
            BTN_ReloadServer.Cursor = Cursors.Hand;
            BTN_ReloadServer.CustomizableEdges = customizableEdges7;
            BTN_ReloadServer.DisabledState.BorderColor = Color.DarkGray;
            BTN_ReloadServer.DisabledState.CustomBorderColor = Color.DarkGray;
            BTN_ReloadServer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BTN_ReloadServer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BTN_ReloadServer.Enabled = false;
            BTN_ReloadServer.FillColor = Color.FromArgb(243, 156, 18);
            BTN_ReloadServer.Font = new Font("Segoe UI", 9F);
            BTN_ReloadServer.ForeColor = Color.White;
            BTN_ReloadServer.HoverState.BorderColor = Color.White;
            BTN_ReloadServer.Image = Properties.Resources.reload_server;
            BTN_ReloadServer.ImageSize = new Size(25, 25);
            BTN_ReloadServer.Location = new Point(60, 10);
            BTN_ReloadServer.Margin = new Padding(5, 10, 5, 10);
            BTN_ReloadServer.Name = "BTN_ReloadServer";
            BTN_ReloadServer.ShadowDecoration.CustomizableEdges = customizableEdges8;
            BTN_ReloadServer.Size = new Size(40, 40);
            BTN_ReloadServer.TabIndex = 1;
            ToolTip.SetToolTip(BTN_ReloadServer, "Reload server");
            BTN_ReloadServer.Click += BTN_ReloadServer_Click;
            // 
            // BTN_StopServer
            // 
            BTN_StopServer.Animated = true;
            BTN_StopServer.BorderColor = Color.FromArgb(255, 82, 82);
            BTN_StopServer.BorderRadius = 5;
            BTN_StopServer.BorderThickness = 2;
            BTN_StopServer.Cursor = Cursors.Hand;
            BTN_StopServer.CustomizableEdges = customizableEdges9;
            BTN_StopServer.DisabledState.BorderColor = Color.DarkGray;
            BTN_StopServer.DisabledState.CustomBorderColor = Color.DarkGray;
            BTN_StopServer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BTN_StopServer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BTN_StopServer.Enabled = false;
            BTN_StopServer.FillColor = Color.FromArgb(255, 82, 82);
            BTN_StopServer.Font = new Font("Segoe UI", 9F);
            BTN_StopServer.ForeColor = Color.White;
            BTN_StopServer.HoverState.BorderColor = Color.White;
            BTN_StopServer.Image = Properties.Resources.stop_server;
            BTN_StopServer.ImageSize = new Size(22, 22);
            BTN_StopServer.Location = new Point(110, 10);
            BTN_StopServer.Margin = new Padding(5, 10, 5, 10);
            BTN_StopServer.Name = "BTN_StopServer";
            BTN_StopServer.ShadowDecoration.CustomizableEdges = customizableEdges10;
            BTN_StopServer.Size = new Size(40, 40);
            BTN_StopServer.TabIndex = 2;
            ToolTip.SetToolTip(BTN_StopServer, "Stop server");
            BTN_StopServer.Click += BTN_StopServer_Click;
            // 
            // ProgressIndicator
            // 
            ProgressIndicator.Animated = true;
            ProgressIndicator.BackColor = Color.Transparent;
            ProgressIndicator.EnsureVisible = true;
            ProgressIndicator.FillColor = Color.FromArgb(49, 52, 58);
            ProgressIndicator.FillThickness = 5;
            ProgressIndicator.Font = new Font("Segoe UI", 12F);
            ProgressIndicator.ForeColor = Color.White;
            ProgressIndicator.Location = new Point(165, 14);
            ProgressIndicator.Margin = new Padding(10, 14, 10, 10);
            ProgressIndicator.Minimum = 0;
            ProgressIndicator.Name = "ProgressIndicator";
            ProgressIndicator.ProgressColor = Color.FromArgb(37, 93, 213);
            ProgressIndicator.ProgressColor2 = Color.FromArgb(68, 171, 237);
            ProgressIndicator.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            ProgressIndicator.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            ProgressIndicator.ProgressThickness = 5;
            ProgressIndicator.ShadowDecoration.CustomizableEdges = customizableEdges11;
            ProgressIndicator.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ProgressIndicator.Size = new Size(34, 34);
            ProgressIndicator.TabIndex = 5;
            ProgressIndicator.UseTransparentBackground = true;
            ProgressIndicator.Value = 90;
            ProgressIndicator.Visible = false;
            // 
            // BTN_AgreeToEula
            // 
            BTN_AgreeToEula.Animated = true;
            BTN_AgreeToEula.BorderColor = Color.FromArgb(37, 93, 213);
            BTN_AgreeToEula.BorderRadius = 5;
            BTN_AgreeToEula.BorderThickness = 2;
            BTN_AgreeToEula.Cursor = Cursors.Hand;
            BTN_AgreeToEula.CustomizableEdges = customizableEdges12;
            BTN_AgreeToEula.DisabledState.BorderColor = Color.DarkGray;
            BTN_AgreeToEula.DisabledState.CustomBorderColor = Color.DarkGray;
            BTN_AgreeToEula.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BTN_AgreeToEula.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BTN_AgreeToEula.FillColor = Color.FromArgb(37, 93, 213);
            BTN_AgreeToEula.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTN_AgreeToEula.ForeColor = Color.White;
            BTN_AgreeToEula.HoverState.BorderColor = Color.White;
            BTN_AgreeToEula.Image = Properties.Resources.agree_eula;
            BTN_AgreeToEula.ImageAlign = HorizontalAlignment.Left;
            BTN_AgreeToEula.ImageSize = new Size(22, 22);
            BTN_AgreeToEula.Location = new Point(214, 10);
            BTN_AgreeToEula.Margin = new Padding(5, 10, 5, 10);
            BTN_AgreeToEula.Name = "BTN_AgreeToEula";
            BTN_AgreeToEula.ShadowDecoration.CustomizableEdges = customizableEdges13;
            BTN_AgreeToEula.Size = new Size(161, 40);
            BTN_AgreeToEula.TabIndex = 3;
            BTN_AgreeToEula.Text = "Agree to EULA";
            BTN_AgreeToEula.TextAlign = HorizontalAlignment.Right;
            ToolTip.SetToolTip(BTN_AgreeToEula, "Agree to EULA");
            BTN_AgreeToEula.Visible = false;
            BTN_AgreeToEula.Click += BTN_AgreeToEula_Click;
            // 
            // TBX_ConsoleLog
            // 
            TBX_ConsoleLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TBX_ConsoleLog.BackColor = Color.FromArgb(49, 52, 58);
            TBX_ConsoleLog.BorderStyle = BorderStyle.None;
            TBX_ConsoleLog.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBX_ConsoleLog.ForeColor = Color.DarkGray;
            TBX_ConsoleLog.Location = new Point(10, 74);
            TBX_ConsoleLog.Margin = new Padding(10);
            TBX_ConsoleLog.Name = "TBX_ConsoleLog";
            TBX_ConsoleLog.ReadOnly = true;
            TBX_ConsoleLog.Size = new Size(817, 324);
            TBX_ConsoleLog.TabIndex = 5;
            TBX_ConsoleLog.Text = "";
            TBX_ConsoleLog.WordWrap = false;
            // 
            // VSB_ConsoleLog
            // 
            VSB_ConsoleLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            VSB_ConsoleLog.BackColor = Color.FromArgb(49, 52, 58);
            VSB_ConsoleLog.BindingContainer = TBX_ConsoleLog;
            VSB_ConsoleLog.BorderRadius = 5;
            VSB_ConsoleLog.FillColor = Color.FromArgb(49, 52, 58);
            VSB_ConsoleLog.InUpdate = false;
            VSB_ConsoleLog.LargeChange = 10;
            VSB_ConsoleLog.Location = new Point(809, 74);
            VSB_ConsoleLog.MouseWheelBarPartitions = 1;
            VSB_ConsoleLog.Name = "VSB_ConsoleLog";
            VSB_ConsoleLog.ScrollbarSize = 18;
            VSB_ConsoleLog.Size = new Size(18, 324);
            VSB_ConsoleLog.TabIndex = 6;
            VSB_ConsoleLog.ThumbColor = Color.FromArgb(64, 67, 75);
            VSB_ConsoleLog.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // HSB_ConsoleLog
            // 
            HSB_ConsoleLog.BackColor = Color.FromArgb(49, 52, 58);
            HSB_ConsoleLog.BindingContainer = TBX_ConsoleLog;
            HSB_ConsoleLog.BorderRadius = 5;
            HSB_ConsoleLog.FillColor = Color.FromArgb(49, 52, 58);
            HSB_ConsoleLog.InUpdate = false;
            HSB_ConsoleLog.LargeChange = 10;
            HSB_ConsoleLog.Location = new Point(10, 380);
            HSB_ConsoleLog.MouseWheelBarPartitions = 1;
            HSB_ConsoleLog.Name = "HSB_ConsoleLog";
            HSB_ConsoleLog.ScrollbarSize = 18;
            HSB_ConsoleLog.Size = new Size(817, 18);
            HSB_ConsoleLog.TabIndex = 5;
            HSB_ConsoleLog.ThumbColor = Color.FromArgb(64, 67, 75);
            HSB_ConsoleLog.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // ServerConsoleView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 37, 41);
            Controls.Add(HSB_ConsoleLog);
            Controls.Add(VSB_ConsoleLog);
            Controls.Add(TBX_ConsoleLog);
            Controls.Add(FLP_ServerControls);
            Controls.Add(PNL_SendCommandArea);
            DoubleBuffered = true;
            Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(219, 219, 219);
            Margin = new Padding(4);
            Name = "ServerConsoleView";
            Size = new Size(837, 474);
            PNL_SendCommandArea.ResumeLayout(false);
            FLP_ServerControls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel PNL_SendCommandArea;
        private FlowLayoutPanel FLP_ServerControls;
        private Guna.UI2.WinForms.Guna2Button BTN_StartServer;
        private Guna.UI2.WinForms.Guna2Button BTN_ReloadServer;
        private Guna.UI2.WinForms.Guna2Button BTN_StopServer;
        private Guna.UI2.WinForms.Guna2Button BTN_AgreeToEula;
        private Guna.UI2.WinForms.Guna2Button BTN_SendCommand;
        private Guna.UI2.WinForms.Guna2TextBox TBX_Command;
        private ToolTip ToolTip;
        internal RichTextBox TBX_ConsoleLog;
        private Guna.UI2.WinForms.Guna2VScrollBar VSB_ConsoleLog;
        private Guna.UI2.WinForms.Guna2HScrollBar HSB_ConsoleLog;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressIndicator;
    }
}
