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
            Setting profile = new Setting();
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
                    Storage.TempUserId = user.Id;
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
            ChangeColorButton(btnHome);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            SearchPage search = new SearchPage();
            search.TopLevel = false;
            search.Dock = DockStyle.Fill;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(search);
            search.Show();
            ChangeColorButton(btnInfo);
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            MoviesPage movies = new MoviesPage();
            movies.TopLevel = false;
            movies.Dock = DockStyle.Fill;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(movies);
            movies.Show();
            ChangeColorButton(btnMovies);
        }
        private void ChangeColorButton(Button button)
        {
            btnHome.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnMovies.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
            btnInfo.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);
            button.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
        }

        private void btnWatctlist_Click(object sender, EventArgs e)
        {
            Setting watchlist = new Setting("Watchlist");
            watchlist.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            watchlist.ShowDialog();
            this.Show();
        }
    }
}
