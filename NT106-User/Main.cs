using Newtonsoft.Json;
using NT106_Admin;
using NT106_WebServer.Models;
using System.Windows.Forms;

namespace NT106_User
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            pnUser.Width = 0;
        }

        private UserModel user;
        private string userId;

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Setting profile = new Setting(userId);
            profile.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            profile.ShowDialog();
            this.Show();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            DialogResult result = signIn.ShowDialog();
            if (result == DialogResult.OK)
            {
                CheckingAndSignin();
            }
        }

        private async void CheckingAndSignin()
        {
            var token = Storage.ReadEncryptedData();
            if (token != null)
            {
                ProgressDialogForm progressDialog = new ProgressDialogForm();
                progressDialog.ShowProgress(this, "Checking token...");

                //MessageBox.Show(token, "Token", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HttpClientService service = new HttpClientService(token);
                string response = await service.GetAsync("/user/getverybasicuser");
                if (response.StartsWith("Error"))
                {
                    MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressDialog.CloseProgress(this);
                    tlpnMiniUser.Visible = false;
                    pnUser.Visible = false;
                    Storage.DeleteEncryptedData();
                    return;
                }
                else
                {
                    //MessageBox.Show(response, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user = JsonConvert.DeserializeObject<UserModel>(response);
                    lbMiniUsername.Text = user.Username;
                    lbUsername.Text = user.Username;
                }

                btnSignin.Visible = false;
                progressDialog.CloseProgress(this);
                tlpnMiniUser.Visible = true;
                pnUser.Visible = true;
                userId = user.Id;
            }
            else
            {
                btnSignin.Visible = true;
                tlpnMiniUser.Visible = false;
                pnUser.Visible = false;
            }
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            CheckingAndSignin();
        }
        private void SwitchUserPanel()
        {
            if (pnUser.Width == 200)
            {
                pnUser.Width = 0;
            }
            else
            {
                pnUser.Width = 200;
            }
        }
        private void tlpnMiniUser_Click(object sender, EventArgs e)
        {
            SwitchUserPanel();
        }

        private void lbMiniUsername_Click(object sender, EventArgs e)
        {
            SwitchUserPanel();
        }

        private void imgMiniAvatar_Click(object sender, EventArgs e)
        {
            SwitchUserPanel();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Storage.DeleteEncryptedData();
            tlpnMiniUser.Visible = false;
            pnUser.Visible = false;
            btnSignin.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.TopLevel = false;
            home.Dock = DockStyle.Fill;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(home);
            home.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MovieInfoPage info = new MovieInfoPage();
            info.TopLevel = false;
            info.Dock = DockStyle.Fill;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(info);
            info.Show();
        }
    }
}
