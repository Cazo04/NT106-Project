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
    public partial class LoginControl : UserControl
    {
        private Signup signUpControl;

        public LoginControl()
        {
            InitializeComponent();

        }

        private void llbSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;

            if (signUpControl == null)
            {
                signUpControl = new Signup();

                if (Parent != null)
                {
                    Parent.Controls.Add(signUpControl);
                    signUpControl.Visible = true;
                    signUpControl.Left = (ClientSize.Width - signUpControl.Width) / 2;
                    signUpControl.Top = (ClientSize.Height - signUpControl.Height) / 2;
                }
            }
            else
            {
                signUpControl.Visible = true;
            }

        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {

        }
    }
}
