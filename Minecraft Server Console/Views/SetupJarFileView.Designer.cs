namespace Minecraft_Server_Console.Views
{
    partial class SetupJarFileView : UserControl
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupJarFileView));
            LBL_ViewHeading = new Label();
            BTN_Continue = new Guna.UI2.WinForms.Guna2Button();
            LBL_GameVersion = new Label();
            PNL_CenterContent = new Panel();
            PSB_DownloadProgress = new Guna.UI2.WinForms.Guna2ProgressBar();
            CBX_ServerType = new Guna.UI2.WinForms.Guna2ComboBox();
            LBL_ServerType = new Label();
            CBX_GameVersion = new Guna.UI2.WinForms.Guna2ComboBox();
            LBL_DownloadProgress = new Label();
            ProgressIndicator = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            TransitionMaster = new Guna.UI2.WinForms.Guna2Transition();
            PNL_CenterContent.SuspendLayout();
            SuspendLayout();
            // 
            // LBL_ViewHeading
            // 
            LBL_ViewHeading.Anchor = AnchorStyles.Top;
            LBL_ViewHeading.AutoSize = true;
            TransitionMaster.SetDecoration(LBL_ViewHeading, Guna.UI2.AnimatorNS.DecorationType.None);
            LBL_ViewHeading.Font = new Font("Nunito Sans Normal", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_ViewHeading.Location = new Point(163, 10);
            LBL_ViewHeading.Margin = new Padding(10);
            LBL_ViewHeading.Name = "LBL_ViewHeading";
            LBL_ViewHeading.Size = new Size(342, 27);
            LBL_ViewHeading.TabIndex = 0;
            LBL_ViewHeading.Text = "Please download a matching Java file.";
            // 
            // BTN_Continue
            // 
            BTN_Continue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BTN_Continue.Animated = true;
            BTN_Continue.BorderColor = Color.FromArgb(37, 93, 213);
            BTN_Continue.BorderRadius = 5;
            BTN_Continue.BorderThickness = 2;
            BTN_Continue.Cursor = Cursors.Hand;
            BTN_Continue.CustomizableEdges = customizableEdges1;
            TransitionMaster.SetDecoration(BTN_Continue, Guna.UI2.AnimatorNS.DecorationType.None);
            BTN_Continue.DisabledState.BorderColor = Color.DarkGray;
            BTN_Continue.DisabledState.CustomBorderColor = Color.DarkGray;
            BTN_Continue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BTN_Continue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BTN_Continue.FillColor = Color.FromArgb(37, 93, 213);
            BTN_Continue.Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_Continue.ForeColor = Color.White;
            BTN_Continue.HoverState.BorderColor = Color.White;
            BTN_Continue.Location = new Point(568, 282);
            BTN_Continue.Margin = new Padding(10);
            BTN_Continue.Name = "BTN_Continue";
            BTN_Continue.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BTN_Continue.Size = new Size(90, 36);
            BTN_Continue.TabIndex = 1;
            BTN_Continue.Text = "Continue";
            BTN_Continue.Click += BTN_Continue_Click;
            // 
            // LBL_GameVersion
            // 
            LBL_GameVersion.Anchor = AnchorStyles.Top;
            LBL_GameVersion.AutoSize = true;
            TransitionMaster.SetDecoration(LBL_GameVersion, Guna.UI2.AnimatorNS.DecorationType.None);
            LBL_GameVersion.Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_GameVersion.Location = new Point(187, 73);
            LBL_GameVersion.Margin = new Padding(10);
            LBL_GameVersion.Name = "LBL_GameVersion";
            LBL_GameVersion.Size = new Size(105, 22);
            LBL_GameVersion.TabIndex = 0;
            LBL_GameVersion.Text = "Game version:";
            LBL_GameVersion.TextAlign = ContentAlignment.MiddleRight;
            LBL_GameVersion.Visible = false;
            // 
            // PNL_CenterContent
            // 
            PNL_CenterContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PNL_CenterContent.Controls.Add(PSB_DownloadProgress);
            PNL_CenterContent.Controls.Add(CBX_ServerType);
            PNL_CenterContent.Controls.Add(LBL_ServerType);
            PNL_CenterContent.Controls.Add(CBX_GameVersion);
            PNL_CenterContent.Controls.Add(LBL_DownloadProgress);
            PNL_CenterContent.Controls.Add(LBL_GameVersion);
            PNL_CenterContent.Controls.Add(ProgressIndicator);
            TransitionMaster.SetDecoration(PNL_CenterContent, Guna.UI2.AnimatorNS.DecorationType.None);
            PNL_CenterContent.Location = new Point(10, 57);
            PNL_CenterContent.Margin = new Padding(10);
            PNL_CenterContent.Name = "PNL_CenterContent";
            PNL_CenterContent.Size = new Size(648, 211);
            PNL_CenterContent.TabIndex = 2;
            // 
            // PSB_DownloadProgress
            // 
            PSB_DownloadProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PSB_DownloadProgress.BackColor = Color.Transparent;
            PSB_DownloadProgress.BorderRadius = 5;
            PSB_DownloadProgress.CustomizableEdges = customizableEdges3;
            TransitionMaster.SetDecoration(PSB_DownloadProgress, Guna.UI2.AnimatorNS.DecorationType.None);
            PSB_DownloadProgress.FillColor = Color.FromArgb(49, 52, 58);
            PSB_DownloadProgress.Location = new Point(10, 179);
            PSB_DownloadProgress.Margin = new Padding(10);
            PSB_DownloadProgress.Name = "PSB_DownloadProgress";
            PSB_DownloadProgress.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.Solid;
            PSB_DownloadProgress.ProgressColor = Color.FromArgb(37, 93, 213);
            PSB_DownloadProgress.ProgressColor2 = Color.FromArgb(68, 171, 237);
            PSB_DownloadProgress.ShadowDecoration.CustomizableEdges = customizableEdges4;
            PSB_DownloadProgress.ShowText = true;
            PSB_DownloadProgress.Size = new Size(628, 22);
            PSB_DownloadProgress.TabIndex = 4;
            PSB_DownloadProgress.Text = "Downloading";
            PSB_DownloadProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            PSB_DownloadProgress.UseTransparentBackground = true;
            PSB_DownloadProgress.Visible = false;
            // 
            // CBX_ServerType
            // 
            CBX_ServerType.Anchor = AnchorStyles.Top;
            CBX_ServerType.BackColor = Color.Transparent;
            CBX_ServerType.BorderColor = Color.FromArgb(64, 67, 75);
            CBX_ServerType.BorderRadius = 10;
            CBX_ServerType.BorderThickness = 2;
            CBX_ServerType.CustomizableEdges = customizableEdges5;
            TransitionMaster.SetDecoration(CBX_ServerType, Guna.UI2.AnimatorNS.DecorationType.None);
            CBX_ServerType.DrawMode = DrawMode.OwnerDrawFixed;
            CBX_ServerType.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_ServerType.FillColor = Color.FromArgb(49, 52, 58);
            CBX_ServerType.FocusedColor = Color.FromArgb(37, 93, 213);
            CBX_ServerType.FocusedState.BorderColor = Color.FromArgb(37, 93, 213);
            CBX_ServerType.Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBX_ServerType.ForeColor = Color.FromArgb(219, 219, 219);
            CBX_ServerType.HoverState.BorderColor = Color.FromArgb(68, 171, 237);
            CBX_ServerType.ItemHeight = 30;
            CBX_ServerType.ItemsAppearance.BackColor = Color.FromArgb(49, 52, 58);
            CBX_ServerType.ItemsAppearance.SelectedBackColor = Color.FromArgb(64, 67, 75);
            CBX_ServerType.Location = new Point(306, 10);
            CBX_ServerType.Margin = new Padding(10);
            CBX_ServerType.MaxDropDownItems = 3;
            CBX_ServerType.Name = "CBX_ServerType";
            CBX_ServerType.ShadowDecoration.CustomizableEdges = customizableEdges6;
            CBX_ServerType.Size = new Size(140, 36);
            CBX_ServerType.TabIndex = 1;
            CBX_ServerType.Visible = false;
            CBX_ServerType.SelectedIndexChanged += CBX_ServerType_SelectedIndexChanged;
            // 
            // LBL_ServerType
            // 
            LBL_ServerType.Anchor = AnchorStyles.Top;
            LBL_ServerType.AutoSize = true;
            TransitionMaster.SetDecoration(LBL_ServerType, Guna.UI2.AnimatorNS.DecorationType.None);
            LBL_ServerType.Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_ServerType.Location = new Point(202, 17);
            LBL_ServerType.Margin = new Padding(10);
            LBL_ServerType.Name = "LBL_ServerType";
            LBL_ServerType.Size = new Size(90, 22);
            LBL_ServerType.TabIndex = 0;
            LBL_ServerType.Text = "Server type:";
            LBL_ServerType.TextAlign = ContentAlignment.MiddleRight;
            LBL_ServerType.Visible = false;
            // 
            // CBX_GameVersion
            // 
            CBX_GameVersion.Anchor = AnchorStyles.Top;
            CBX_GameVersion.BackColor = Color.Transparent;
            CBX_GameVersion.BorderColor = Color.FromArgb(64, 67, 75);
            CBX_GameVersion.BorderRadius = 10;
            CBX_GameVersion.BorderThickness = 2;
            CBX_GameVersion.CustomizableEdges = customizableEdges7;
            TransitionMaster.SetDecoration(CBX_GameVersion, Guna.UI2.AnimatorNS.DecorationType.None);
            CBX_GameVersion.DrawMode = DrawMode.OwnerDrawFixed;
            CBX_GameVersion.DropDownStyle = ComboBoxStyle.DropDownList;
            CBX_GameVersion.FillColor = Color.FromArgb(49, 52, 58);
            CBX_GameVersion.FocusedColor = Color.FromArgb(37, 93, 213);
            CBX_GameVersion.FocusedState.BorderColor = Color.FromArgb(37, 93, 213);
            CBX_GameVersion.Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBX_GameVersion.ForeColor = Color.FromArgb(219, 219, 219);
            CBX_GameVersion.HoverState.BorderColor = Color.FromArgb(68, 171, 237);
            CBX_GameVersion.IntegralHeight = false;
            CBX_GameVersion.ItemHeight = 30;
            CBX_GameVersion.ItemsAppearance.BackColor = Color.FromArgb(49, 52, 58);
            CBX_GameVersion.ItemsAppearance.SelectedBackColor = Color.FromArgb(64, 67, 75);
            CBX_GameVersion.Location = new Point(306, 66);
            CBX_GameVersion.Margin = new Padding(10);
            CBX_GameVersion.Name = "CBX_GameVersion";
            CBX_GameVersion.ShadowDecoration.CustomizableEdges = customizableEdges8;
            CBX_GameVersion.Size = new Size(140, 36);
            CBX_GameVersion.TabIndex = 1;
            CBX_GameVersion.Visible = false;
            // 
            // LBL_DownloadProgress
            // 
            LBL_DownloadProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LBL_DownloadProgress.AutoSize = true;
            TransitionMaster.SetDecoration(LBL_DownloadProgress, Guna.UI2.AnimatorNS.DecorationType.None);
            LBL_DownloadProgress.Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_DownloadProgress.Location = new Point(10, 151);
            LBL_DownloadProgress.Margin = new Padding(10);
            LBL_DownloadProgress.Name = "LBL_DownloadProgress";
            LBL_DownloadProgress.Size = new Size(200, 22);
            LBL_DownloadProgress.TabIndex = 0;
            LBL_DownloadProgress.Text = "Downloading your Java file...";
            LBL_DownloadProgress.TextAlign = ContentAlignment.MiddleRight;
            LBL_DownloadProgress.Visible = false;
            // 
            // ProgressIndicator
            // 
            ProgressIndicator.Anchor = AnchorStyles.None;
            ProgressIndicator.Animated = true;
            ProgressIndicator.BackColor = Color.Transparent;
            TransitionMaster.SetDecoration(ProgressIndicator, Guna.UI2.AnimatorNS.DecorationType.None);
            ProgressIndicator.EnsureVisible = true;
            ProgressIndicator.FillColor = Color.FromArgb(49, 52, 58);
            ProgressIndicator.FillThickness = 5;
            ProgressIndicator.Font = new Font("Segoe UI", 12F);
            ProgressIndicator.ForeColor = Color.White;
            ProgressIndicator.Location = new Point(289, 70);
            ProgressIndicator.Margin = new Padding(10);
            ProgressIndicator.Minimum = 0;
            ProgressIndicator.Name = "ProgressIndicator";
            ProgressIndicator.ProgressColor = Color.FromArgb(37, 93, 213);
            ProgressIndicator.ProgressColor2 = Color.FromArgb(68, 171, 237);
            ProgressIndicator.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            ProgressIndicator.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            ProgressIndicator.ProgressThickness = 5;
            ProgressIndicator.ShadowDecoration.CustomizableEdges = customizableEdges9;
            ProgressIndicator.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            ProgressIndicator.Size = new Size(71, 71);
            ProgressIndicator.TabIndex = 6;
            ProgressIndicator.UseTransparentBackground = true;
            ProgressIndicator.Value = 90;
            ProgressIndicator.Visible = false;
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
            // SetupJarFileView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 37, 41);
            Controls.Add(PNL_CenterContent);
            Controls.Add(BTN_Continue);
            Controls.Add(LBL_ViewHeading);
            TransitionMaster.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(219, 219, 219);
            Margin = new Padding(4);
            Name = "SetupJarFileView";
            Size = new Size(668, 328);
            Load += SetupJarFileView_Load;
            PNL_CenterContent.ResumeLayout(false);
            PNL_CenterContent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBL_ViewHeading;
        private Guna.UI2.WinForms.Guna2Button BTN_Continue;
        private Label LBL_GameVersion;
        private Panel PNL_CenterContent;
        private Guna.UI2.WinForms.Guna2ComboBox CBX_GameVersion;
        private Guna.UI2.WinForms.Guna2ComboBox CBX_ServerType;
        private Label LBL_ServerType;
        private Guna.UI2.WinForms.Guna2Transition TransitionMaster;
        private Guna.UI2.WinForms.Guna2ProgressBar PSB_DownloadProgress;
        private Label LBL_DownloadProgress;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressIndicator;
    }
}
