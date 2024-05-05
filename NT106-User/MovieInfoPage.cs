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
