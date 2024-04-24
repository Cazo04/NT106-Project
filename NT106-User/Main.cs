using System.Windows.Forms;

namespace NT106_User
{
    public partial class Main : Form
    {

        private LoginControl loginControl;
        private bool loginControlVisible = false;

        public Main()
        {
            InitializeComponent();
        }

        private void miLogin_Click(object sender, EventArgs e)
        {
            if (!loginControlVisible)
            {
                ShowLoginControl();
            }
            else
            {
                HideLoginControl();
            }
        }

        private void ShowLoginControl()
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

            loginControlVisible = true; 
        }

        private void HideLoginControl()
        {
            loginControl.Visible = false;

            ShowOriginalControls();

            loginControlVisible = false; 
        }

        private void ShowOriginalControls()
        {
            foreach (Control control in this.Controls)
            {
                control.Visible = true;
            }
        }


    }
}
