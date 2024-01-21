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
            ((System.ComponentModel.ISupportInitialize)PBX_Icon).BeginInit();
            SuspendLayout();
            // 
            // PBX_Icon
            // 
            PBX_Icon.Anchor = AnchorStyles.Left;
            PBX_Icon.Location = new Point(12, 43);
            PBX_Icon.Name = "PBX_Icon";
            PBX_Icon.Size = new Size(50, 50);
            PBX_Icon.SizeMode = PictureBoxSizeMode.StretchImage;
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
            BTN_One.Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_One.ForeColor = Color.White;
            BTN_One.HoverState.BorderColor = Color.White;
            BTN_One.Location = new Point(316, 137);
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
            BTN_Two.Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_Two.ForeColor = Color.White;
            BTN_Two.HoverState.BorderColor = Color.White;
            BTN_Two.Location = new Point(206, 137);
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
            LBL_Message.AutoEllipsis = true;
            LBL_Message.Location = new Point(75, 19);
            LBL_Message.Margin = new Padding(10);
            LBL_Message.Name = "LBL_Message";
            LBL_Message.Size = new Size(331, 98);
            LBL_Message.TabIndex = 3;
            LBL_Message.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FRM_DialogBox
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(35, 37, 41);
            ClientSize = new Size(425, 192);
            Controls.Add(LBL_Message);
            Controls.Add(BTN_Two);
            Controls.Add(BTN_One);
            Controls.Add(PBX_Icon);
            Font = new Font("Nunito Sans Normal", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(219, 219, 219);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM_DialogBox";
            Load += FRM_DialogBox_Load;
            KeyDown += FRM_DialogBox_KeyDown;
            ((System.ComponentModel.ISupportInitialize)PBX_Icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PBX_Icon;
        private Guna.UI2.WinForms.Guna2Button BTN_One;
        private Guna.UI2.WinForms.Guna2Button BTN_Two;
        private Label LBL_Message;
    }
}