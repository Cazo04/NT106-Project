using System.Windows.Forms;

namespace NT106_User
{
    public partial class Main : Form
    {

        public LoginControl loginControl;

        public Main()
        {
            InitializeComponent();
        }

        private void miLogin_Click(object? sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control != menuStrip1)
                {
                    control.Visible = false;
                }
            }

            if (loginControl == null)
            {

                loginControl = new LoginControl();
                this.Controls.Add(loginControl);
                loginControl.Left = (this.ClientSize.Width - loginControl.Width) / 2;
                loginControl.Top = (this.ClientSize.Height - loginControl.Height) / 2;
            }
            else
            {

                loginControl.Visible = true;
            }
        }

        private void miUser_Click(object? sender, EventArgs e)
        {
            pnUser.Visible = true;
        }



        private void ShowOriginalControls()
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = true;
            }
            pnUser.Visible = false;
        }

        private void miHome_Click(object sender, EventArgs e)
        {
            ShowOriginalControls();

            if (loginControl != null)
            {
                loginControl.Visible = false;

                if (loginControl.signUpControl != null)
                {
                    loginControl.signUpControl.Visible = false;
                }
            }


        }

        public void UpdateSignInButton()
        {

            if (miLogin != null)
            {
                miLogin.Text = "User";
                miLogin.Click -= miLogin_Click;
                miLogin.Click += miUser_Click;
            }

            foreach (Control control in this.Controls)
            {
                if (control != menuStrip1)
                {
                    control.Visible = false;
                }
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.ShowDialog();
        }
    }
}
