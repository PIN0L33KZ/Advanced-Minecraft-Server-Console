namespace Minecraft_Server_Console.Views
{
    partial class FRM_AddReasonDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AddReasonDialog));
            LBL_ReasonTitle = new Label();
            TBX_Reason = new Guna.UI2.WinForms.Guna2TextBox();
            BTN_Continue = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // LBL_ReasonTitle
            // 
            LBL_ReasonTitle.AutoSize = true;
            LBL_ReasonTitle.Font = new Font("Microsoft YaHei UI", 11.25F);
            LBL_ReasonTitle.Location = new Point(14, 16);
            LBL_ReasonTitle.Margin = new Padding(5);
            LBL_ReasonTitle.Name = "LBL_ReasonTitle";
            LBL_ReasonTitle.Size = new Size(93, 20);
            LBL_ReasonTitle.TabIndex = 0;
            LBL_ReasonTitle.Text = "Add reason";
            // 
            // TBX_Reason
            // 
            TBX_Reason.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TBX_Reason.Animated = true;
            TBX_Reason.AutoCompleteCustomSource.AddRange(new string[] { "?", "ability", "advancement", "alwaysday", "attribute", "ban", "ban-ip", "banlist", "bossbar", "camera", "camerashake", "changesetting", "clear", "clearspawnpoint", "clone", "connect", "damage", "data", "datapack", "daylock", "debug", "dedicatedwsserver", "defaultgamemode", "deop", "dialogue", "difficulty", "effect", "enchant", "event", "execute", "experience", "fill", "fillbiome", "fog", "forceload", "function", "gamemode", "gamerule", "gametest", "give", "help", "immutableworld", "item", "jfr", "kick", "kill", "list", "locate", "loot", "me", "mobevent", "msg", "music", "op", "ops", "pardon", "pardon-ip", "particle", "perf", "permission", "place", "playanimation", "playsound", "publish", "random", "recipe", "reload", "remove", "replaceitem", "return", "ride", "save", "save-all", "save-off", "save-on", "say", "schedule", "scoreboard", "script", "scriptevent", "seed", "setblock", "setidletimeout", "setmaxplayers", "setworldspawn", "spawnpoint", "spectate", "spreadplayers", "stop", "stopsound", "structure", "summon", "tag", "team", "teammsg", "teleport", "tell", "tellraw", "testfor", "testforblock", "testforblocks", "tickingarea", "time", "title", "titleraw", "tm", "toggledownfall", "tp", "trigger", "transferserver", "volumearea", "w", "wb", "weather", "whitelist", "worldborder", "worldbuilder", "wsserver", "xp", "?", "/ability", "/advancement", "/alwaysday", "/attribute", "/ban", "/ban-ip", "/banlist", "/bossbar", "/camera", "/camerashake", "/changesetting", "/clear", "/clearspawnpoint", "/clone", "/connect", "/damage", "/data", "/datapack", "/daylock", "/debug", "/dedicatedwsserver", "/defaultgamemode", "/deop", "/dialogue", "/difficulty", "/effect", "/enchant", "/event", "/execute", "/experience", "/fill", "/fillbiome", "/fog", "/forceload", "/function", "/gamemode", "/gamerule", "/gametest", "/give", "/help", "/immutableworld", "/item", "/jfr", "/kick", "/kill", "/list", "/locate", "/loot", "/me", "/mobevent", "/msg", "/music", "/op", "/ops", "/pardon", "/pardon-ip", "/particle", "/perf", "/permission", "/place", "/playanimation", "/playsound", "/publish", "/random", "/recipe", "/reload", "/remove", "/replaceitem", "/return", "/ride", "/save", "/save-all", "/save-off", "/save-on", "/say", "/schedule", "/scoreboard", "/script", "/scriptevent", "/seed", "/setblock", "/setidletimeout", "/setmaxplayers", "/setworldspawn", "/spawnpoint", "/spectate", "/spreadplayers", "/stop", "/stopsound", "/structure", "/summon", "/tag", "/team", "/teammsg", "/teleport", "/tell", "/tellraw", "/testfor", "/testforblock", "/testforblocks", "/tickingarea", "/time", "/title", "/titleraw", "/tm", "/toggledownfall", "/tp", "/trigger", "/transferserver", "/volumearea", "/w", "/wb", "/weather", "/whitelist", "/worldborder", "/worldbuilder", "/wsserver", "/xp" });
            TBX_Reason.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TBX_Reason.BorderColor = Color.FromArgb(64, 67, 75);
            TBX_Reason.BorderRadius = 5;
            TBX_Reason.BorderThickness = 2;
            TBX_Reason.CustomizableEdges = customizableEdges1;
            TBX_Reason.DefaultText = "";
            TBX_Reason.DisabledState.BorderColor = Color.DarkGray;
            TBX_Reason.DisabledState.FillColor = Color.DarkGray;
            TBX_Reason.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            TBX_Reason.DisabledState.PlaceholderForeColor = Color.DarkGray;
            TBX_Reason.FillColor = Color.FromArgb(49, 52, 58);
            TBX_Reason.FocusedState.BorderColor = Color.FromArgb(37, 93, 213);
            TBX_Reason.Font = new Font("Microsoft YaHei UI", 11.25F);
            TBX_Reason.ForeColor = Color.FromArgb(219, 219, 219);
            TBX_Reason.Location = new Point(15, 48);
            TBX_Reason.Margin = new Padding(6, 7, 6, 7);
            TBX_Reason.Name = "TBX_Reason";
            TBX_Reason.PasswordChar = '\0';
            TBX_Reason.PlaceholderForeColor = Color.FromArgb(110, 110, 110);
            TBX_Reason.PlaceholderText = "Enter your reason here.";
            TBX_Reason.SelectedText = "";
            TBX_Reason.ShadowDecoration.CustomizableEdges = customizableEdges2;
            TBX_Reason.Size = new Size(368, 35);
            TBX_Reason.TabIndex = 1;
            TBX_Reason.WordWrap = false;
            // 
            // BTN_Continue
            // 
            BTN_Continue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BTN_Continue.Animated = true;
            BTN_Continue.BorderColor = Color.FromArgb(37, 93, 213);
            BTN_Continue.BorderRadius = 5;
            BTN_Continue.BorderThickness = 2;
            BTN_Continue.Cursor = Cursors.Hand;
            BTN_Continue.CustomizableEdges = customizableEdges3;
            BTN_Continue.DisabledState.BorderColor = Color.DarkGray;
            BTN_Continue.DisabledState.CustomBorderColor = Color.DarkGray;
            BTN_Continue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BTN_Continue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BTN_Continue.FillColor = Color.FromArgb(37, 93, 213);
            BTN_Continue.Font = new Font("Microsoft YaHei UI", 11.25F);
            BTN_Continue.ForeColor = Color.White;
            BTN_Continue.HoverState.BorderColor = Color.White;
            BTN_Continue.Location = new Point(151, 95);
            BTN_Continue.Margin = new Padding(5);
            BTN_Continue.Name = "BTN_Continue";
            BTN_Continue.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BTN_Continue.Size = new Size(97, 36);
            BTN_Continue.TabIndex = 2;
            BTN_Continue.Text = "Continue";
            BTN_Continue.Click += BTN_Continue_Click;
            // 
            // FRM_AddReasonDialog
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 37, 41);
            ClientSize = new Size(398, 145);
            Controls.Add(BTN_Continue);
            Controls.Add(TBX_Reason);
            Controls.Add(LBL_ReasonTitle);
            Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(219, 219, 219);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM_AddReasonDialog";
            Text = "Reason";
            Load += FRM_AddReasonDialog_Load;
            KeyDown += AddReasonDialog_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBL_ReasonTitle;
        private Guna.UI2.WinForms.Guna2TextBox TBX_Reason;
        private Guna.UI2.WinForms.Guna2Button BTN_Continue;
    }
}