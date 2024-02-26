namespace Minecraft_Server_Console.Forms
{
    partial class FRM_DialogBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DialogBox));
            PBX_Icon = new PictureBox();
            BTN_One = new Guna.UI2.WinForms.Guna2Button();
            BTN_Two = new Guna.UI2.WinForms.Guna2Button();
            LBL_Message = new Label();
            PNL_Content = new Panel();
            PNL_Buttons = new Panel();
            PNL_Icon = new Panel();
            ((System.ComponentModel.ISupportInitialize)PBX_Icon).BeginInit();
            PNL_Content.SuspendLayout();
            PNL_Buttons.SuspendLayout();
            PNL_Icon.SuspendLayout();
            SuspendLayout();
            // 
            // PBX_Icon
            // 
            PBX_Icon.Dock = DockStyle.Fill;
            PBX_Icon.Location = new Point(0, 0);
            PBX_Icon.Name = "PBX_Icon";
            PBX_Icon.Size = new Size(50, 114);
            PBX_Icon.SizeMode = PictureBoxSizeMode.AutoSize;
            PBX_Icon.TabIndex = 0;
            PBX_Icon.TabStop = false;
            // 
            // BTN_One
            // 
            BTN_One.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BTN_One.Animated = true;
            BTN_One.BorderColor = Color.FromArgb(37, 93, 213);
            BTN_One.BorderRadius = 5;
            BTN_One.BorderThickness = 2;
            BTN_One.Cursor = Cursors.Hand;
            BTN_One.CustomizableEdges = customizableEdges1;
            BTN_One.DisabledState.BorderColor = Color.DarkGray;
            BTN_One.DisabledState.CustomBorderColor = Color.DarkGray;
            BTN_One.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BTN_One.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BTN_One.FillColor = Color.FromArgb(37, 93, 213);
            BTN_One.Font = new Font("Microsoft YaHei UI", 11.25F);
            BTN_One.ForeColor = Color.White;
            BTN_One.HoverState.BorderColor = Color.White;
            BTN_One.Location = new Point(163, 23);
            BTN_One.Margin = new Padding(10);
            BTN_One.Name = "BTN_One";
            BTN_One.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BTN_One.Size = new Size(90, 36);
            BTN_One.TabIndex = 1;
            BTN_One.Visible = false;
            BTN_One.Click += BTN_One_Click;
            // 
            // BTN_Two
            // 
            BTN_Two.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BTN_Two.Animated = true;
            BTN_Two.BorderColor = Color.FromArgb(37, 93, 213);
            BTN_Two.BorderRadius = 5;
            BTN_Two.BorderThickness = 2;
            BTN_Two.Cursor = Cursors.Hand;
            BTN_Two.CustomizableEdges = customizableEdges3;
            BTN_Two.DisabledState.BorderColor = Color.DarkGray;
            BTN_Two.DisabledState.CustomBorderColor = Color.DarkGray;
            BTN_Two.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            BTN_Two.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            BTN_Two.FillColor = Color.FromArgb(37, 93, 213);
            BTN_Two.Font = new Font("Microsoft YaHei UI", 11.25F);
            BTN_Two.ForeColor = Color.White;
            BTN_Two.HoverState.BorderColor = Color.White;
            BTN_Two.Location = new Point(53, 23);
            BTN_Two.Margin = new Padding(10);
            BTN_Two.Name = "BTN_Two";
            BTN_Two.ShadowDecoration.CustomizableEdges = customizableEdges4;
            BTN_Two.Size = new Size(90, 36);
            BTN_Two.TabIndex = 0;
            BTN_Two.Visible = false;
            BTN_Two.Click += BTN_Two_Click;
            // 
            // LBL_Message
            // 
            LBL_Message.AutoSize = true;
            LBL_Message.Dock = DockStyle.Fill;
            LBL_Message.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBL_Message.Location = new Point(10, 10);
            LBL_Message.Margin = new Padding(10);
            LBL_Message.Name = "LBL_Message";
            LBL_Message.Size = new Size(73, 20);
            LBL_Message.TabIndex = 3;
            LBL_Message.Text = "message";
            LBL_Message.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PNL_Content
            // 
            PNL_Content.AutoSize = true;
            PNL_Content.Controls.Add(LBL_Message);
            PNL_Content.Dock = DockStyle.Fill;
            PNL_Content.Location = new Point(60, 10);
            PNL_Content.Name = "PNL_Content";
            PNL_Content.Padding = new Padding(10);
            PNL_Content.Size = new Size(260, 45);
            PNL_Content.TabIndex = 4;
            // 
            // PNL_Buttons
            // 
            PNL_Buttons.Controls.Add(BTN_Two);
            PNL_Buttons.Controls.Add(BTN_One);
            PNL_Buttons.Dock = DockStyle.Bottom;
            PNL_Buttons.Location = new Point(60, 55);
            PNL_Buttons.Name = "PNL_Buttons";
            PNL_Buttons.Size = new Size(260, 69);
            PNL_Buttons.TabIndex = 5;
            // 
            // PNL_Icon
            // 
            PNL_Icon.AutoSize = true;
            PNL_Icon.Controls.Add(PBX_Icon);
            PNL_Icon.Dock = DockStyle.Left;
            PNL_Icon.Location = new Point(10, 10);
            PNL_Icon.Name = "PNL_Icon";
            PNL_Icon.Size = new Size(50, 114);
            PNL_Icon.TabIndex = 6;
            // 
            // FRM_DialogBox
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(35, 37, 41);
            ClientSize = new Size(330, 134);
            Controls.Add(PNL_Content);
            Controls.Add(PNL_Buttons);
            Controls.Add(PNL_Icon);
            Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(219, 219, 219);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(346, 173);
            Name = "FRM_DialogBox";
            Padding = new Padding(10);
            Load += FRM_DialogBox_Load;
            KeyDown += FRM_DialogBox_KeyDown;
            ((System.ComponentModel.ISupportInitialize)PBX_Icon).EndInit();
            PNL_Content.ResumeLayout(false);
            PNL_Content.PerformLayout();
            PNL_Buttons.ResumeLayout(false);
            PNL_Icon.ResumeLayout(false);
            PNL_Icon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PBX_Icon;
        private Guna.UI2.WinForms.Guna2Button BTN_One;
        private Guna.UI2.WinForms.Guna2Button BTN_Two;
        private Label LBL_Message;
        private Panel PNL_Content;
        private Panel PNL_Buttons;
        private Panel PNL_Icon;
    }
}