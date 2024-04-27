using NT106_Admin.Models;

namespace NT106_Admin
{
    public partial class Dashboard : Form
    {
        private ProgressDialogForm progressDialog;
        public Dashboard()
        {
            InitializeComponent();
            progressDialog = new ProgressDialogForm();
            progressDialog.StartPosition = FormStartPosition.CenterParent;
        }
        private AdminToken _adminToken;
        private void btnMovies_Click(object sender, EventArgs e)
        {
            MoviesManager moviesManager = new MoviesManager(_adminToken);
            moviesManager.TopLevel = false;
            moviesManager.Dock = DockStyle.Fill;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(moviesManager);
            moviesManager.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Storage.DeleteEncryptedData();
            _adminToken = new AdminToken();
            Login login = new Login();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                _adminToken = login.AdminToken;
                Storage.SaveEncryptedData(_adminToken.Token);
            }
            else
            {
                this.Close();
            }
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            string? token = Storage.ReadEncryptedData();
            if (token != null)
            {
                _adminToken = new AdminToken
                {
                    Token = token
                };
                if (await CheckConnection(false))
                {
                    return;
                }
                Storage.DeleteEncryptedData();
            }
            Login login = new Login();
            DialogResult result = login.ShowDialog();        
            if (result == DialogResult.OK)
            {
                _adminToken = login.AdminToken;
                Storage.SaveEncryptedData(_adminToken.Token);
            }
            else
            {
                this.Close();
            }
        }
        private void ShowLoadingDialog()
        {
            progressDialog.Show(this);
            this.Enabled = false;
        }
        private void HideLoadingDialog()
        {
            progressDialog.Hide();
            this.Enabled = true;
        }
        private async Task<bool> CheckConnection(bool showMessage = true)
        {
            ShowLoadingDialog();
            HttpClientService httpClientService = new HttpClientService(_adminToken.Token);
            string response = await httpClientService.GetAsync("/admin/checktoken");
            HideLoadingDialog();
            if (response.Contains("Error"))
            {
                if (showMessage) MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (showMessage) MessageBox.Show(response, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }           
        }
        private async void btnCheckConnection_Click(object sender, EventArgs e)
        {
            await CheckConnection();
        }
    }
}
