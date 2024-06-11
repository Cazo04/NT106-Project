using Newtonsoft.Json;
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

namespace NT106_Admin
{
    public partial class UserManager : Form
    {
        public UserManager()
        {
            InitializeComponent();
        }
        private List<UserModel> users;
        private async Task LoadUsers(int offset = 0)
        {
            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.ShowProgress(this, "Loading users...");
            HttpClientService service = new HttpClientService();
            string response = await service.GetAsync("/admin/getusers?offset=" + offset.ToString());

            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<UserModel> users = JsonConvert.DeserializeObject<List<UserModel>>(response);
                this.users = users;
                dgvUsers.Rows.Clear();
                foreach (UserModel user in users)
                {
                    dgvUsers.Rows.Add(user.Id, user.Username, user.FullName, user.Email, user.SMS, user.DateOfBirth.Value.ToString("yyyy-MM-dd"), user.ReviewNum, user.Avatar);
                }
            }
            progressDialog.CloseProgress(this);
        }
        private void UserManager_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string userId = dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                UserModel user = users.FirstOrDefault(u => u.Id == userId);
                tbUserId.Text = userId;
                tbFullName.Text = user.FullName;
                tbUsername.Text = user.Username;
                tbEmail.Text = user.Email;
                tbSMS.Text = user.SMS;
                dtpDateOfBirth.Value = user.DateOfBirth.Value;
                tbAvatar.Text = user.Avatar;
                lbReviewNum.Text = user.ReviewNum.ToString();
            }
        }

        private async void btnChangePassword_Click(object sender, EventArgs e)
        {
            string userId = tbUserId.Text;
            string newPassword = tbPassword.Text;
            string confirmPassword = tbConfirmPassword.Text;
            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("New password and confirm password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ChangePasswordModel changePassword = new ChangePasswordModel()
            {
                UserId = userId,
                NewPassword = newPassword,
                OldPassword = "NoneNone"
            };

            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.ShowProgress(this, "Changing password...");
            HttpClientService service = new HttpClientService();
            string response = await service.PostAsync("/admin/changeuserpassword", JsonConvert.SerializeObject(changePassword));
            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(response, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPassword.Text = "";
                tbConfirmPassword.Text = "";
            }
            progressDialog.CloseProgress(this);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            UserModel user = users.FirstOrDefault(u => u.Id == tbUserId.Text);
            UserModel updateUser = new UserModel();
            updateUser.Id = user.Id;
            updateUser.Username = tbUsername.Text.Trim() != user.Username ? tbUsername.Text.Trim() : user.Username;
            updateUser.FullName = tbFullName.Text.Trim() != user.FullName ? tbFullName.Text.Trim() : user.FullName;
            updateUser.Email = tbEmail.Text.Trim() != user.Email ? tbEmail.Text.Trim() : user.Email;
            updateUser.SMS = tbSMS.Text.Trim() != user.SMS ? tbSMS.Text.Trim() : user.SMS;
            updateUser.DateOfBirth = dtpDateOfBirth.Value != user.DateOfBirth ? dtpDateOfBirth.Value : user.DateOfBirth;
            updateUser.Avatar = tbAvatar.Text.Trim() != user.Avatar ? tbAvatar.Text.Trim() : user.Avatar;

            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.ShowProgress(this, "Saving user...");
            HttpClientService service = new HttpClientService();
            string response = await service.PostAsync("/admin/updateuser", JsonConvert.SerializeObject(updateUser));
            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(response, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            progressDialog.CloseProgress(this);
        }
    }
}
