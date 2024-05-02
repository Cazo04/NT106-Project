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
    public partial class Setting : Form
    {
        private string userId;
        public Setting(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            btnProfile.PerformClick();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(userId);
            profile.Dock = DockStyle.Fill;
            profile.TopLevel = false;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(profile);            
            profile.Show();
        }
    }
}
