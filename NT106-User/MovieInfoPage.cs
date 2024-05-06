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
    public partial class MovieInfoPage : Form
    {
        private string movieId;
        public MovieInfoPage(string movieId)
        {
            InitializeComponent();
            this.movieId = movieId;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void MovieInfoPage_Load(object sender, EventArgs e)
        {
            ProgressDialogForm progressDialogForm = new ProgressDialogForm();
            progressDialogForm.ShowProgress(this);

            HttpClientService service = new HttpClientService();
            string response = await service.GetAsync("/user/getmovie?movieId="+movieId);
            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MovieModel movie = JsonConvert.DeserializeObject<MovieModel>(response);
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
                    tlpSeasons.Visible = false;
                    lbDuration.Visible = false;
                }
                else
                {
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
                if (movie.Directors.Count == 0)
                {
                    pnDirectors.Visible = false;
                }
                if (movie.Creators.Count == 0)
                {
                    pnCreators.Visible = false;
                }
                if (movie.Writers.Count == 0)
                {
                    pnWriters.Visible = false;
                }

                flpCasts.Controls.Clear();
                foreach (var cast in movie.Casts)
                {
                   PersonView personView = new PersonView();
                   personView.SetData(cast.Person, cast.CharacterName, movie.MovieInfo.IsTVShows ? cast.EpisodeCount : 0);
                   flpCasts.Controls.Add(personView);
                }
                LoadImageAsync(movie.MovieInfo.PosterURL);              
            }
            progressDialogForm.CloseProgress(this);
        }
        private async Task LoadImageAsync(string imageUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);

                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);

                        pnPoster.BackgroundImage = image;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
    }
}
