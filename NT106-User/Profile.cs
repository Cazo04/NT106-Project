using Newtonsoft.Json;
using NT106_Admin;
using NT106_WebServer.Models;
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
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private async void Profile_Load(object sender, EventArgs e)
        {
            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.ShowProgress(this, "Loading profile...");

            HttpClientService service = new HttpClientService();
            string response = await service.GetAsync("/user/getuser");
            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressDialog.CloseProgress(this);
                return;
            }
            else
            {
                UserModel user = JsonConvert.DeserializeObject<UserModel>(response);
                lbUsername.Text = "@" + user.Username;
                tbFullName.Text = user.FullName;
                tbEmail.Text = user.Email;
                dtpDateOfBirth.Value = (user.DateOfBirth == null ? new DateTime() : (DateTime)user.DateOfBirth);
                tbSMS.Text = user.SMS;
                //if (user.Avatar != null)
                //{
                //    pbAvatar.Image = Image.FromStream(new MemoryStream(Convert.FromBase64String(user.Avatar)));
                //}
                progressDialog.CloseProgress(this);
            }
        }

        private async void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.Text != tbConfirmNewPassword.Text)
            {
                MessageBox.Show("New password and confirm password are not the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ProgressDialogForm dialogForm = new ProgressDialogForm();
            dialogForm.ShowProgress(this, "Changing password...");

            ChangePasswordModel changePasswordModel = new ChangePasswordModel();
            changePasswordModel.OldPassword = tbOldPassword.Text;
            changePasswordModel.NewPassword = tbNewPassword.Text;

            string json = JsonConvert.SerializeObject(changePasswordModel);

            HttpClientService service = new HttpClientService();
            string response = await service.PostAsync("/user/changepassword", json);
            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserToken userToken = JsonConvert.DeserializeObject<UserToken>(response);
                if (userToken.Token != null)
                {
                    Storage.SaveEncryptedData(userToken.Token);
                }
                MessageBox.Show("Change password successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbConfirmNewPassword.Text = "";
                tbNewPassword.Text = "";
                tbOldPassword.Text = "";
            }
            dialogForm.CloseProgress(this);
        }

        private void pbShow1_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.PasswordChar == false)
            {
                pbHide1.BringToFront();
                tbNewPassword.PasswordChar = true;
                tbOldPassword.PasswordChar = true;
                tbConfirmNewPassword.PasswordChar = true;
            }
        }

        private void pbHide1_Click(object sender, EventArgs e)
        {
            if (tbNewPassword.PasswordChar == true)
            {
                pbShow1.BringToFront();
                tbNewPassword.PasswordChar = false;
                tbOldPassword.PasswordChar = false;
                tbConfirmNewPassword.PasswordChar = false;
            }
        }
    }
}
