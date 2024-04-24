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

            if(signUpControl == null)
            {
                signUpControl = new Signup();

                if (this.Parent != null)
                {
                    this.Parent.Controls.Add(signUpControl);
                    signUpControl.Visible = true;
                    signUpControl.BringToFront();
                    signUpControl.Left = (this.Parent.ClientSize.Width - signUpControl.Width) / 2;
                    signUpControl.Top = (this.Parent.ClientSize.Height - signUpControl.Height) / 2;
                }               
            }
            else
            {
                signUpControl.Visible = true;
            }
        }
    }
}
