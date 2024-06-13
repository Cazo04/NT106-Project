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
        private string open;
        public Setting(string open = "Profile")
        {
            InitializeComponent();
            this.open = open;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            if (open == "Profile")
                btnProfile.PerformClick();
            else if (open == "Watchlist")
                btnWatchlist.PerformClick();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Dock = DockStyle.Fill;
            profile.TopLevel = false;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(profile);
            profile.Show();
        }

        private void btnWatchlist_Click(object sender, EventArgs e)
        {
            Watchlist watchlist = new Watchlist();
            watchlist.Dock = DockStyle.Fill;
            watchlist.TopLevel = false;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(watchlist);
            watchlist.Show();
        }
    }
}
