namespace Minecraft_Server_Console.Forms
{
    public partial class FRM_DialogBox : Form
    {
        private readonly string _title;
        private readonly string _message;
        private readonly DialogBoxButtons _buttons;
        private readonly DialogIcons _icons;

        public FRM_DialogBox(string title, string message, DialogBoxButtons buttons, DialogIcons icons)
        {
            InitializeComponent();
            _title = title;
            _message = message;
            _buttons = buttons;
            _icons = icons;
        }

        private void FRM_DialogBox_Load(object sender, EventArgs e)
        {
            SetupDialog();

            // Center form on parent form.
            int x = Owner.Left + ((Owner.Width - Width) / 2);
            int y = Owner.Top + ((Owner.Height - Height) / 2);

            Location = new Point(x, y);
        }

        private void SetupDialog()
        {
            Text = _title;
            LBL_Message.Text = _message;

            switch(_buttons)
            {
                case DialogBoxButtons.OK:
                    BTN_One.Text = "OK";
                    BTN_One.Show();
                    BTN_Two.Hide();
                    break;

                case DialogBoxButtons.YesNo:
                    BTN_One.Text = "No";
                    BTN_One.Show();
                    BTN_Two.Text = "Yes";
                    BTN_Two.Show();
                    break;
            }

            switch(_icons)
            {
                case DialogIcons.Info:
                    PBX_Icon.Image = Properties.Resources.information;
                    break;

                case DialogIcons.Warning:
                    PBX_Icon.Image = Properties.Resources.warning;
                    break;

                case DialogIcons.Error:
                    PBX_Icon.Image = Properties.Resources.error;
                    break;

                case DialogIcons.Question:
                    PBX_Icon.Image = Properties.Resources.question;
                    break;
            }

            _ = BTN_One.Focus();
        }

        private void BTN_One_Click(object sender, EventArgs e)
        {
            switch(BTN_One.Text)
            {
                case "OK":
                    DialogResult = DialogResult.OK;
                    Close();
                    break;

                case "No":
                    DialogResult = DialogResult.No;
                    Close();
                    break;
            }
        }

        private void BTN_Two_Click(object sender, EventArgs e)
        {
            switch(BTN_Two.Text)
            {
                case "Yes":
                    DialogResult = DialogResult.Yes;
                    Close();
                    break;
            }
        }

        private void FRM_DialogBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }

    public enum DialogBoxButtons
    {
        OK,
        YesNo
    }

    public enum DialogIcons
    {
        Info,
        Warning,
        Error,
        Question
    }
}