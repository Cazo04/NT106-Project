using Newtonsoft.Json;
using NT106_Admin.Models;
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

namespace NT106_Admin
{
    public partial class MoviesManager : Form
    {
        public AdminToken _adminToken;
        public MoviesManager(AdminToken _adminToken)
        {
            InitializeComponent();

            cbbContentRating.Items.Add("Movie Ratings: G - General Audiences");
            cbbContentRating.Items.Add("Movie Ratings: PG - Parental Guidance Suggested");
            cbbContentRating.Items.Add("Movie Ratings: PG-13 - Parents Strongly Cautioned");
            cbbContentRating.Items.Add("Movie Ratings: R - Restricted");
            cbbContentRating.Items.Add("Movie Ratings: NC-17 - Adults Only");

            cbbContentRating.Items.Add("TV Ratings: TV-Y - All Children");
            cbbContentRating.Items.Add("TV Ratings: TV-Y7 - Directed to Older Children");
            cbbContentRating.Items.Add("TV Ratings: TV-Y7-FV - Directed to Older Children - Fantasy Violence");
            cbbContentRating.Items.Add("TV Ratings: TV-G - General Audience");
            cbbContentRating.Items.Add("TV Ratings: TV-PG - Parental Guidance Suggested");
            cbbContentRating.Items.Add("TV Ratings: TV-14 - Parents Strongly Cautioned");
            cbbContentRating.Items.Add("TV Ratings: TV-MA - Mature Audience Only");

            cbbContentRating.Items.Add("Other: Not - Not Yet Rated");

            cbbContentRating.SelectedIndex = 0;

            this._adminToken = _adminToken;
        }

        private async void LoadListMovies(int offset = 0)
        {
            dgvMovies.Rows.Clear();
            int moviesCount = 0;
            HttpClientService service = new HttpClientService(_adminToken.Token);
            string response = await service.GetAsync("/admin/moviesmanager?offset="+ offset.ToString());
            if (response.Contains("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                List<MovieModel.Movie> movies = JsonConvert.DeserializeObject<List<MovieModel.Movie>>(response);
                foreach (var movie in movies)
                {
                    dgvMovies.Rows.Add(movie.MovieId, movie.MovieName, movie.ReleaseDate.ToString("yyyy-MM-dd"), movie.Duration, movie.ContentRating, movie.IMDbScore, movie.IsTVShows);
                }
                moviesCount = movies.Count + offset * 100;
            }
            response = await service.GetAsync("/admin/moviescount");
            if (response.Contains("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int totalMovies = JsonConvert.DeserializeObject<int>(response);
                lbCountMovies.Text = $"{moviesCount}/{totalMovies} Movies";
                lbPageMovies.Text = $"Page: {offset + 1}";
            }

        }

        private void MoviesManager_Load(object sender, EventArgs e)
        {
            LoadListMovies();
        }
    }
}
