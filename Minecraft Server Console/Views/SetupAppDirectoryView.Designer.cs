namespace Minecraft_Server_Console.Views
{
    partial class SetupAppDirectoryView
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
            LBL_ViewHeading = new Label();
            BTN_Continue = new Guna.UI2.WinForms.Guna2Button();
            ELP_Main = new Guna.UI2.WinForms.Guna2Elipse(components);
            BTN_SelectDirectory = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // LBL_ViewHeading
            // 
            LBL_ViewHeading.Anchor = AnchorStyles.Top;
            LBL_ViewHeading.AutoSize = true;
            LBL_ViewHeading.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_ViewHeading.Location = new Point(29, 10);
            LBL_ViewHeading.Margin = new Padding(10);
            LBL_ViewHeading.Name = "LBL_ViewHeading";
            LBL_ViewHeading.Size = new Size(447, 26);
            LBL_ViewHeading.TabIndex = 0;
            LBL_ViewHeading.Text = "Please select a directory to store your files in.";
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
            BTN_Continue.DisabledState.BorderColor = Color.DarkGray;
            BTN_Continue.DisabledState.CustomBorderColor = Color.DarkGray;
            BTN_Continue.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BTN_Continue.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BTN_Continue.FillColor = Color.FromArgb(37, 93, 213);
            BTN_Continue.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTN_Continue.ForeColor = Color.White;
            BTN_Continue.HoverState.BorderColor = Color.White;
            BTN_Continue.Location = new Point(393, 124);
            BTN_Continue.Margin = new Padding(10);
            BTN_Continue.Name = "BTN_Continue";
            BTN_Continue.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BTN_Continue.Size = new Size(101, 30);
            BTN_Continue.TabIndex = 1;
            BTN_Continue.Text = "Continue";
            BTN_Continue.Click += BTN_Continue_Click;
            // 
            // ELP_Main
            // 
            ELP_Main.BorderRadius = 5;
            // 
            // BTN_SelectDirectory
            // 
            BTN_SelectDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BTN_SelectDirectory.Animated = true;
            BTN_SelectDirectory.BorderColor = Color.Empty;
            BTN_SelectDirectory.BorderRadius = 5;
            BTN_SelectDirectory.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            BTN_SelectDirectory.BorderThickness = 2;
            BTN_SelectDirectory.Cursor = Cursors.Hand;
            BTN_SelectDirectory.CustomizableEdges = customizableEdges3;
            BTN_SelectDirectory.DisabledState.BorderColor = Color.DarkGray;
            BTN_SelectDirectory.DisabledState.CustomBorderColor = Color.DarkGray;
            BTN_SelectDirectory.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BTN_SelectDirectory.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BTN_SelectDirectory.FillColor = Color.FromArgb(49, 52, 58);
            BTN_SelectDirectory.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTN_SelectDirectory.ForeColor = Color.FromArgb(219, 219, 219);
            BTN_SelectDirectory.HoverState.BorderColor = Color.FromArgb(219, 219, 219);
            BTN_SelectDirectory.Location = new Point(10, 57);
            BTN_SelectDirectory.Margin = new Padding(10);
            BTN_SelectDirectory.Name = "BTN_SelectDirectory";
            BTN_SelectDirectory.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BTN_SelectDirectory.Size = new Size(484, 44);
            BTN_SelectDirectory.TabIndex = 2;
            BTN_SelectDirectory.Text = "Click here to choose a directory...";
            BTN_SelectDirectory.Click += BTN_SelectDirectory_Click;
            // 
            // SetupAppDirectoryView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 37, 41);
            Controls.Add(BTN_SelectDirectory);
            Controls.Add(BTN_Continue);
            Controls.Add(LBL_ViewHeading);
            Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(219, 219, 219);
            Margin = new Padding(4);
            Name = "SetupAppDirectoryView";
            Size = new Size(504, 164);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBL_ViewHeading;
        private Guna.UI2.WinForms.Guna2Button BTN_Continue;
        private Guna.UI2.WinForms.Guna2Elipse ELP_Main;
        private Guna.UI2.WinForms.Guna2Button BTN_SelectDirectory;
    }
}
