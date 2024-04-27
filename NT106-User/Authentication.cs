using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_User
{
    public partial class Authentication : Form
    {
        LoginControl loginControl;
        Signup signUpControl;

        public Authentication()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {

            if (loginControl == null)
            {
                loginControl = new LoginControl();
                loginControl.Dock = DockStyle.Fill;
                pnAuthentication.Controls.Clear();
                pnAuthentication.Controls.Add(loginControl);
                loginControl.Visible = true;
            }
            else
            {
                loginControl.Visible = true;
            }
            
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

            if (signUpControl == null)
            {
                signUpControl = new Signup();
                signUpControl.Dock = DockStyle.Fill;
                pnAuthentication.Controls.Clear(); 
                pnAuthentication.Controls.Add(signUpControl);
                signUpControl.Visible = true;
            }
            else
            {
                signUpControl.Visible = true;
            }
        }
    }
}
