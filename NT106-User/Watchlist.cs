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
    public partial class Watchlist : Form
    {
        public Watchlist()
        {
            InitializeComponent();
        }

        private async void Watchlist_Load(object sender, EventArgs e)
        {
            ProgressDialogForm progressDialogForm = new ProgressDialogForm();
            progressDialogForm.TopLevel = false;
            progressDialogForm.Dock = DockStyle.Fill;
            progressDialogForm.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(progressDialogForm);
            progressDialogForm.BringToFront();
            progressDialogForm.ShowProgress(this);

            HttpClientService service = new HttpClientService(); 
            string response = await service.GetAsync("/user/getmoviesfromwatchlist");
            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                pnWatchlist.Controls.Clear();
                List<MovieModel> movies = JsonConvert.DeserializeObject<List<MovieModel>>(response);
                foreach (MovieModel movie in movies)
                {
                    WatchListItem movieItem = new WatchListItem();
                    movieItem.Dock = DockStyle.Top;
                    movieItem.Margin = new Padding(0, 0, 0, 10);
                    pnWatchlist.Controls.Add(movieItem);
                    movieItem.LoadData(movie);
                }
            }


            progressDialogForm.CloseProgress(this);
        }
    }
}
