using Mysqlx.Connection;
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
using static NT106_WebServer.Models.MovieModel;

namespace NT106_User
{
    public partial class WatchListItem : UserControl
    {
        public WatchListItem()
        {
            InitializeComponent();
        }
        private string movieId;
        public async Task LoadData(MovieModel movie)
        {
            movieId = movie.MovieInfo.MovieId;
            lbMovieName.Text = movie.MovieInfo.MovieName;
            lbReleaseDate.Text = movie.MovieInfo.ReleaseDate.ToString("yyyy-MM-dd");
            lbIMDbScore.Text = movie.MovieInfo.IMDbScore.ToString();
            int hours = movie.MovieInfo.Duration / 3600;
            int minutes = (movie.MovieInfo.Duration % 3600) / 60;
            lbDuration.Text = $"{hours}h{minutes}m";
            lbDescription.Text = movie.MovieInfo.Description;
            lbContentRating.Text = movie.MovieInfo.ContentRating;
            lbRatingCount.Text = movie.MovieInfo.RatingCount.ToString();
            lbType.Text = movie.MovieInfo.IsTVShows ? "TV Series" : "Movies";
            flpGenres.Controls.Clear();
            foreach (var genre in movie.Genres)
            {
                Label label = new Label();
                label.Text = genre;
                label.BackColor = lbBaseGenres.BackColor;
                label.ForeColor = lbBaseGenres.ForeColor;
                label.AutoSize = true;
                label.Padding = lbBaseGenres.Padding;
                label.Font = lbBaseGenres.Font;
                flpGenres.Controls.Add(label);
            }
            if (!movie.MovieInfo.IsTVShows)
            {
                //tlpSeasons.Visible = false;
                lbSeasons.Visible = false;
                flpSeasons.Visible = false;
            }
            else
            {
                lbDuration.Visible = false;
                flpSeasons.Controls.Clear();
                foreach (var season in movie.Seasons)
                {
                    Button btn = new Button();
                    btn.Text = season.Name;
                    btn.BackColor = btnBaseSeasons.BackColor;
                    btn.ForeColor = btnBaseSeasons.ForeColor;
                    btn.AutoSize = true;
                    btn.Padding = btnBaseSeasons.Padding;
                    btn.Font = btnBaseSeasons.Font;
                    flpSeasons.Controls.Add(btn);
                }
            }
            pnPoster.ImageLocation = movie.MovieInfo.PosterURL;
        }       
        private async void btnRemove_Click(object sender, EventArgs e)
        {
            ProgressDialogForm dialogForm = new ProgressDialogForm();
            dialogForm.TopLevel = false;
            dialogForm.Dock = DockStyle.Fill;
            dialogForm.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(dialogForm);
            dialogForm.BringToFront();
            dialogForm.ShowProgress(this);

            HttpClientService service = new HttpClientService();
            string response = await service.GetAsync("/user/removewatchlist?episodeId=" + movieId);
            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Removed from watchlist", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dialogForm.CloseProgress(this);
            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
            }
            this.Dispose();            
        }
    }
}
