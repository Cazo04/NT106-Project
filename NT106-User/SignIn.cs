using Newtonsoft.Json;
using NT106_Admin;
using NT106_WebServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_User
{
    public partial class SignIn : Form
    {

        public SignIn()
        {
            InitializeComponent();
        }

        private void llbSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            this.Hide();
            signup.ShowDialog();
            this.Show();
        }

        private async void btnGetStarted_Click(object sender, EventArgs e)
        {
            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.ShowProgress(this, "Signing in...");

            SignInModel signInModel = new SignInModel();
            signInModel.UsernameOrEmail = tbUsernameOrEmail.Text;
            signInModel.Password = tbPassword.Text;

            string json = JsonConvert.SerializeObject(signInModel);

            HttpClientService httpClientService = new HttpClientService();
            string response = await httpClientService.PostAsync("/user/signin", json);
            if (response.Contains("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserToken userToken = JsonConvert.DeserializeObject<UserToken>(response);
                if (userToken.Token != null)
                {
                    //MessageBox.Show("Sign in successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Storage.SaveEncryptedData(userToken.Token);
                    progressDialog.CloseProgress(this);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sign in failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void pbShow_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == false)
            {
                pbHide.BringToFront();
                tbPassword.PasswordChar = true;
            }
        }
    }
}
