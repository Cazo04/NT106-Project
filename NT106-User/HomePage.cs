using Newtonsoft.Json;
using NT106_Admin;
using NT106_WebServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_User
{
    public partial class HomePage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public HomePage()
        {
            InitializeComponent();
            lbTitle1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lbTitle1.Width, lbTitle1.Height, 10, 10));
            lbHighlyRated.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, lbHighlyRated.Width, lbHighlyRated.Height, 10, 10));
            FindAllPosterCard(this);
        }
        private void FindAllPosterCard(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is PosterCard posterCard)
                {
                    posterCard.ControlClicked += PosterCard_ControlClicked;
                }
                if (c.HasChildren)
                {
                    FindAllPosterCard(c);
                }
            }
        }
        private void PosterCard_ControlClicked(object sender, PosterCard.CustomEventArgs e)
        {
            //MessageBox.Show(e.MovieId);
            ChangeInfoPage(e.MovieId);
        }
        private void ChangeInfoPage(string movieId)
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
                control.Visible = false;
            }

            MovieInfoPage info = new MovieInfoPage(movieId);
            info.TopLevel = false;
            info.Dock = DockStyle.Fill;
            info.FormBorderStyle = FormBorderStyle.None;           
            this.Controls.Add(info);
            info.BringToFront();
            info.Show();
            info.FormClosed += Info_FormClosed;
        }
        private void Info_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
                control.Visible = true;
            }
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadNewReleases();
            LoadTopScore();
        }
        private async void LoadNewReleases()
        {
            ProgressDialogForm progressDialog = new ProgressDialogForm();  
            progressDialog.TopLevel = false;
            progressDialog.Dock = DockStyle.Fill;
            progressDialog.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(progressDialog);
            progressDialog.BringToFront();
            
            progressDialog.ShowProgress(flpNewReleases, "Loading new releases...");

            HttpClientService service = new HttpClientService();
            string response = await service.GetAsync("/home/getnewmovies");
            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            flpNewReleases.Controls.Clear();
            List<MovieModel.Movie> movies = JsonConvert.DeserializeObject<List<MovieModel.Movie>>(response);
            foreach (MovieModel.Movie movie in movies)
            {
                PosterCard posterCard = new PosterCard();
                posterCard.Size = new Size(286, 573);
                posterCard.SetData(movie);
                posterCard.ControlClicked += PosterCard_ControlClicked;
                flpNewReleases.Controls.Add(posterCard);
            }
            progressDialog.CloseProgress(flpNewReleases);
        }
        private async void LoadTopScore()
        {
            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.TopLevel = false;
            progressDialog.Dock = DockStyle.Fill;
            progressDialog.FormBorderStyle = FormBorderStyle.None;
            panel5.Controls.Add(progressDialog);
            progressDialog.BringToFront();

            progressDialog.ShowProgress(flpHighlyRated, "Loading top score movies...");

            HttpClientService service = new HttpClientService();
            string response = await service.GetAsync("/user/gettopmoviesbyimdbscorebutnotinnewmovies");
            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            flpHighlyRated.Controls.Clear();
            List<MovieModel.Movie> movies = JsonConvert.DeserializeObject<List<MovieModel.Movie>>(response);
            foreach (MovieModel.Movie movie in movies)
            {
                PosterCard posterCard = new PosterCard();
                posterCard.SetData(movie);
                posterCard.ControlClicked += PosterCard_ControlClicked;
                flpHighlyRated.Controls.Add(posterCard);
            }
            progressDialog.CloseProgress(flpHighlyRated);
        }
    }
}
