namespace Minecraft_Server_Console
{
    partial class FRM_Console
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Console));
            TransitionMaster = new Guna.UI2.WinForms.Guna2Transition();
            TAC_Main = new Guna.UI2.WinForms.Guna2TabControl();
            TAP_ServerConsole = new TabPage();
            TAP_ServerStats = new TabPage();
            TAC_Main.SuspendLayout();
            SuspendLayout();
            // 
            // TransitionMaster
            // 
            TransitionMaster.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            TransitionMaster.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            TransitionMaster.DefaultAnimation = animation1;
            // 
            // TAC_Main
            // 
            TAC_Main.Alignment = TabAlignment.Left;
            TAC_Main.Controls.Add(TAP_ServerConsole);
            TAC_Main.Controls.Add(TAP_ServerStats);
            TransitionMaster.SetDecoration(TAC_Main, Guna.UI2.AnimatorNS.DecorationType.None);
            TAC_Main.Dock = DockStyle.Fill;
            TAC_Main.ItemSize = new Size(180, 40);
            TAC_Main.Location = new Point(0, 0);
            TAC_Main.Name = "TAC_Main";
            TAC_Main.SelectedIndex = 0;
            TAC_Main.Size = new Size(897, 470);
            TAC_Main.TabButtonHoverState.BorderColor = Color.Empty;
            TAC_Main.TabButtonHoverState.FillColor = Color.FromArgb(64, 67, 75);
            TAC_Main.TabButtonHoverState.Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TAC_Main.TabButtonHoverState.ForeColor = Color.FromArgb(219, 219, 219);
            TAC_Main.TabButtonHoverState.InnerColor = Color.Empty;
            TAC_Main.TabButtonIdleState.BorderColor = Color.Empty;
            TAC_Main.TabButtonIdleState.FillColor = Color.FromArgb(49, 52, 58);
            TAC_Main.TabButtonIdleState.Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TAC_Main.TabButtonIdleState.ForeColor = Color.FromArgb(182, 182, 182);
            TAC_Main.TabButtonIdleState.InnerColor = Color.Empty;
            TAC_Main.TabButtonSelectedState.BorderColor = Color.Empty;
            TAC_Main.TabButtonSelectedState.FillColor = Color.FromArgb(49, 52, 58);
            TAC_Main.TabButtonSelectedState.Font = new Font("Nunito Sans Normal", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TAC_Main.TabButtonSelectedState.ForeColor = Color.White;
            TAC_Main.TabButtonSelectedState.InnerColor = Color.FromArgb(37, 93, 213);
            TAC_Main.TabButtonSize = new Size(180, 40);
            TAC_Main.TabIndex = 0;
            TAC_Main.TabMenuBackColor = Color.FromArgb(49, 52, 58);
            TAC_Main.SelectedIndexChanged += TAC_Main_SelectedIndexChanged;
            // 
            // TAP_ServerConsole
            // 
            TAP_ServerConsole.BackColor = Color.FromArgb(35, 37, 41);
            TransitionMaster.SetDecoration(TAP_ServerConsole, Guna.UI2.AnimatorNS.DecorationType.None);
            TAP_ServerConsole.ForeColor = Color.FromArgb(219, 219, 219);
            TAP_ServerConsole.Location = new Point(184, 4);
            TAP_ServerConsole.Name = "TAP_ServerConsole";
            TAP_ServerConsole.Padding = new Padding(3);
            TAP_ServerConsole.Size = new Size(709, 462);
            TAP_ServerConsole.TabIndex = 0;
            TAP_ServerConsole.Text = "Console";
            // 
            // TAP_ServerStats
            // 
            TAP_ServerStats.BackColor = Color.FromArgb(35, 37, 41);
            TransitionMaster.SetDecoration(TAP_ServerStats, Guna.UI2.AnimatorNS.DecorationType.None);
            TAP_ServerStats.Location = new Point(184, 4);
            TAP_ServerStats.Name = "TAP_ServerStats";
            TAP_ServerStats.Padding = new Padding(3);
            TAP_ServerStats.Size = new Size(709, 462);
            TAP_ServerStats.TabIndex = 1;
            TAP_ServerStats.Text = "Stats";
            // 
            // FRM_Console
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 37, 41);
            ClientSize = new Size(897, 470);
            Controls.Add(TAC_Main);
            TransitionMaster.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(219, 219, 219);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(837, 474);
            Name = "FRM_Console";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Minecraft Server Console";
            FormClosing += FRM_Console_FormClosing;
            TAC_Main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Transition TransitionMaster;
        private Guna.UI2.WinForms.Guna2TabControl TAC_Main;
        private TabPage TAP_ServerConsole;
        private TabPage TAP_ServerStats;
    }
}
