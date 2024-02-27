namespace Minecraft_Server_Console.Forms
{
    partial class PlayersView
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
            FLP_Main = new FlowLayoutPanel();
            VSB_PlayersList = new Guna.UI2.WinForms.Guna2VScrollBar();
            HSB_PlayerList = new Guna.UI2.WinForms.Guna2HScrollBar();
            LBL_NoPlayerWarning = new Label();
            SuspendLayout();
            // 
            // FLP_Main
            // 
            FLP_Main.AutoScroll = true;
            FLP_Main.Dock = DockStyle.Fill;
            FLP_Main.Location = new Point(0, 0);
            FLP_Main.Name = "FLP_Main";
            FLP_Main.Size = new Size(639, 379);
            FLP_Main.TabIndex = 0;
            FLP_Main.Visible = false;
            // 
            // VSB_PlayersList
            // 
            VSB_PlayersList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            VSB_PlayersList.BackColor = Color.FromArgb(49, 52, 58);
            VSB_PlayersList.BindingContainer = FLP_Main;
            VSB_PlayersList.BorderRadius = 5;
            VSB_PlayersList.FillColor = Color.FromArgb(49, 52, 58);
            VSB_PlayersList.InUpdate = false;
            VSB_PlayersList.LargeChange = 10;
            VSB_PlayersList.Location = new Point(621, 0);
            VSB_PlayersList.Margin = new Padding(4);
            VSB_PlayersList.MouseWheelBarPartitions = 1;
            VSB_PlayersList.Name = "VSB_PlayersList";
            VSB_PlayersList.ScrollbarSize = 18;
            VSB_PlayersList.Size = new Size(18, 379);
            VSB_PlayersList.TabIndex = 7;
            VSB_PlayersList.ThumbColor = Color.FromArgb(64, 67, 75);
            VSB_PlayersList.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // HSB_PlayerList
            // 
            HSB_PlayerList.BackColor = Color.FromArgb(49, 52, 58);
            HSB_PlayerList.BindingContainer = FLP_Main;
            HSB_PlayerList.BorderRadius = 5;
            HSB_PlayerList.FillColor = Color.FromArgb(49, 52, 58);
            HSB_PlayerList.InUpdate = false;
            HSB_PlayerList.LargeChange = 10;
            HSB_PlayerList.Location = new Point(0, 361);
            HSB_PlayerList.Margin = new Padding(4);
            HSB_PlayerList.MouseWheelBarPartitions = 1;
            HSB_PlayerList.Name = "HSB_PlayerList";
            HSB_PlayerList.ScrollbarSize = 18;
            HSB_PlayerList.Size = new Size(639, 18);
            HSB_PlayerList.TabIndex = 6;
            HSB_PlayerList.ThumbColor = Color.FromArgb(64, 67, 75);
            HSB_PlayerList.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            // 
            // LBL_NoPlayerWarning
            // 
            LBL_NoPlayerWarning.Anchor = AnchorStyles.None;
            LBL_NoPlayerWarning.AutoSize = true;
            LBL_NoPlayerWarning.Font = new Font("Nunito Sans Normal", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_NoPlayerWarning.ForeColor = Color.FromArgb(182, 182, 182);
            LBL_NoPlayerWarning.Location = new Point(111, 170);
            LBL_NoPlayerWarning.Name = "LBL_NoPlayerWarning";
            LBL_NoPlayerWarning.Size = new Size(416, 39);
            LBL_NoPlayerWarning.TabIndex = 8;
            LBL_NoPlayerWarning.Text = "No players are currently online.";
            // 
            // PlayersView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 37, 41);
            Controls.Add(HSB_PlayerList);
            Controls.Add(VSB_PlayersList);
            Controls.Add(FLP_Main);
            Controls.Add(LBL_NoPlayerWarning);
            Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(219, 219, 219);
            Margin = new Padding(4);
            Name = "PlayersView";
            Size = new Size(639, 379);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel FLP_Main;
        private Guna.UI2.WinForms.Guna2VScrollBar VSB_PlayersList;
        private Guna.UI2.WinForms.Guna2HScrollBar HSB_PlayerList;
        private Label LBL_NoPlayerWarning;
    }
}
