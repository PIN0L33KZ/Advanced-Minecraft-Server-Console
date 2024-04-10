namespace Minecraft_Server_Console.Views
{
    public partial class FRM_AddReasonDialog : Form
    {
        public string reason { get; private set; }

        public FRM_AddReasonDialog()
        {
            InitializeComponent();
        }

        private void FRM_AddReasonDialog_Load(object sender, EventArgs e)
        {
            // Center form on parent form.
            int x = Owner.Left + ((Owner.Width - Width) / 2);
            int y = Owner.Top + ((Owner.Height - Height) / 2);

            Location = new System.Drawing.Point(x, y);
        }

        private void AddReasonDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                DialogResult = DialogResult.Cancel;
                Close();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BTN_Continue.PerformClick();
            }
        }

        private void BTN_Continue_Click(object sender, EventArgs e)
        {
            reason = TBX_Reason.Text.Trim();

            if(reason == "")
                reason = "No details given!";

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}