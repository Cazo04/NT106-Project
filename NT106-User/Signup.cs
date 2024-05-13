using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NT106_Admin;
using NT106_WebServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_User
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private async void btnSignup_Click(object sender, EventArgs e)
        {
            SignUpModel signUpModel = new SignUpModel();
            signUpModel.FullName = tbFullName.Text;
            signUpModel.Birthdate = dtpDateOfBirth.Value;
            signUpModel.Username = tbUsername.Text;
            signUpModel.Email = tbEmail.Text;
            signUpModel.Password = tbPassword.Text;
            signUpModel.ConfirmPassword = tbConfirmpassword.Text;

            if (signUpModel.Password != signUpModel.ConfirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match");
                return;
            }

            string json = JsonConvert.SerializeObject(signUpModel);
            HttpClientService service = new HttpClientService("None");  
            var response = await service.PostAsync("/user/signupchecker", json);
            if (response.Contains("Error"))
            {
                string[] parts = response.Split(new string[] { " - " }, 2, StringSplitOptions.None);
                JToken jToken = JToken.Parse(parts[1]);
                string message = "Status:" + jToken["status"].ToString() +'\n';
                message += "Errors:" + jToken["errors"].ToString();
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                response = await service.PostAsync("/user/signup", json);
                if (response.Contains("Error"))
                {                   
                    MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    //MessageBox.Show("Sign up successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
