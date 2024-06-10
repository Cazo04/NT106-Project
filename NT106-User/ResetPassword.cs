using Newtonsoft.Json;
using NT106_Admin;
using NT106_API_Server.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace NT106_User
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private async void btnSendCode_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            if (email == "")
            {
                MessageBox.Show("Please enter your email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.ShowProgress(this, "Sending code...");

            HttpClientService service = new HttpClientService();
            string response = await service.GetAsync("/user/sendresetpasswordcode?email=" + HttpUtility.UrlEncode(email));

            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("The code has been sent to your email", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            progressDialog.CloseProgress(this);
        }

        private async void btnApply_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "")
            {
                MessageBox.Show("Please enter your email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbPassword.Text == "" || tbConfirmPassword.Text == "")
            {
                MessageBox.Show("Please enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbCode.Text == "")
            {
                MessageBox.Show("Please enter the code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ResetPasswordCodeModel resetPasswordCodeModel = new ResetPasswordCodeModel
            {
                Email = tbEmail.Text,
                Code = tbCode.Text,
                Password = tbPassword.Text
            };

            string json = JsonConvert.SerializeObject(resetPasswordCodeModel);

            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.ShowProgress(this, "Applying...");

            HttpClientService service = new HttpClientService();
            string response = await service.PostAsync("/user/resetpassword", json);
            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Password has been reset", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressDialog.CloseProgress(this);
                this.Close();
            }

            progressDialog.CloseProgress(this);
        }

        private void pbShow_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == false)
            {
                pbHide.BringToFront();
                tbPassword.PasswordChar = true;
            }
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == true)
            {
                pbShow.BringToFront();
                tbPassword.PasswordChar = false;
            }
        }

        private void pbShow1_Click(object sender, EventArgs e)
        {
            if (tbConfirmPassword.PasswordChar == false)
            {
                pbHide1.BringToFront();
                tbConfirmPassword.PasswordChar = true;
            }
        }

        private void pbHide1_Click(object sender, EventArgs e)
        {
            if (tbConfirmPassword.PasswordChar == true)
            {
                pbShow1.BringToFront();
                tbConfirmPassword.PasswordChar = false;
            }
        }
    }
}
