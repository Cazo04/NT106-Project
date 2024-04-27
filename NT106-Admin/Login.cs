using Newtonsoft.Json;
using NT106_Admin.Models;
using NT106_WebServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_Admin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public AdminToken AdminToken { get; set; }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            SignInModel model = new SignInModel
            {
                UsernameOrEmail = tbUsername.Text,
                Password = tbPassword.Text
            };
            using (ProgressDialogForm progressDialog = new ProgressDialogForm())
            {
                progressDialog.StartPosition = FormStartPosition.CenterParent;
                progressDialog.Show(this);
                try
                {
                    HttpClientService httpClientService = new HttpClientService("None");
                    string response = await httpClientService.PostAsync("/admin/login", JsonConvert.SerializeObject(model));
                    if (response.Contains("Error"))
                    {
                        MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //MessageBox.Show(response, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AdminToken = JsonConvert.DeserializeObject<AdminToken>(response);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                finally
                {
                    progressDialog.Close();
                }
            }           
        }
    }
}
