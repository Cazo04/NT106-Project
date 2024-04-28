using Newtonsoft.Json;
using NT106_Admin.Models;
using NT106_WebServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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

            cbbContentRating.Items.Add("Movie: G - General Audiences");
            cbbContentRating.Items.Add("Movie: PG - Parental Guidance Suggested");
            cbbContentRating.Items.Add("Movie: PG-13 - Parents Strongly Cautioned");
            cbbContentRating.Items.Add("Movie: R - Restricted");
            cbbContentRating.Items.Add("Movie: NC-17 - Adults Only");

            cbbContentRating.Items.Add("TV: TV-Y - All Children");
            cbbContentRating.Items.Add("TV: TV-Y7 - Directed to Older Children");
            cbbContentRating.Items.Add("TV: TV-Y7-FV - Directed to Older Children - Fantasy Violence");
            cbbContentRating.Items.Add("TV: TV-G - General Audience");
            cbbContentRating.Items.Add("TV: TV-PG - Parental Guidance Suggested");
            cbbContentRating.Items.Add("TV: TV-14 - Parents Strongly Cautioned");
            cbbContentRating.Items.Add("TV: TV-MA - Mature Audience Only");

            cbbContentRating.Items.Add("Other: Not - Not Yet Rated");

            cbbContentRating.SelectedIndex = 0;

            SetControlsReadOnly();

            this._adminToken = _adminToken;
        }

        private void SetControlsReadOnly()
        {
            // TextBoxes
            tbMovieId.ReadOnly = true;
            tbMovieName.ReadOnly = true;
            tbDuration.ReadOnly = true;
            tbIMDbScore.ReadOnly = true;
            tbRatingCount.ReadOnly = true;
            tbPosterURL.ReadOnly = true;
            tbTrailerURL.ReadOnly = true;
            tbDescription.ReadOnly = true;

            // CheckBox
            cbIsTVShows.Enabled = false;

            // ComboBox
            cbbContentRating.Enabled = false;

            // DateTimePicker
            dtpReleaseDate.Enabled = false;
        }

        private async void LoadListMovies(int offset = 0)
        {
            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.ShowProgress(this, "Loading movies, please wait...");

            int moviesCount = 0;
            HttpClientService service = new HttpClientService(_adminToken.Token);
            string response = await service.GetAsync("/admin/moviesmanager?offset=" + offset.ToString());
            if (response.Contains("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressDialog.CloseProgress(this);
                return;
            }
            else
            {
                List<MovieModel.Movie> movies = JsonConvert.DeserializeObject<List<MovieModel.Movie>>(response);
                if (movies.Count == 0)
                {
                    MessageBox.Show("No more movies to show, return", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbPageNumber.Text = (lastOffset + 1).ToString();
                    progressDialog.CloseProgress(this);
                    return;
                }
                dgvMovies.Rows.Clear();
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
                progressDialog.CloseProgress(this);
                return;
            }
            else
            {
                int totalMovies = JsonConvert.DeserializeObject<int>(response);
                lbCountMovies.Text = $"{moviesCount}/{totalMovies} Movies";
                tbPageNumber.Text = (offset + 1).ToString();
                lastOffset = offset;
            }

            progressDialog.CloseProgress(this);
        }

        private int lastOffset = 0;

        private async void LoadMovie(string movieId)
        {
            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.ShowProgress(this, "Loading movie details, please wait...");

            HttpClientService service = new HttpClientService(_adminToken.Token);
            string response = await service.GetAsync("/admin/getmovie?movieId=" + movieId);
            if (response.Contains("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressDialog.CloseProgress(this);
                return;
            }
            else
            {
                MovieModel movie = JsonConvert.DeserializeObject<MovieModel>(response);
                LoadMovieDetail(movie);
            }

            progressDialog.CloseProgress(this);
        }

        private void LoadMovieDetail(MovieModel movie)
        {
            tbMovieId.Text = movie.MovieInfo.MovieId;
            tbMovieName.Text = movie.MovieInfo.MovieName;
            dtpReleaseDate.Value = movie.MovieInfo.ReleaseDate;
            tbDuration.Text = movie.MovieInfo.Duration.ToString();
            for (int i = 0; i < cbbContentRating.Items.Count; i++)
            {
                var parts = cbbContentRating.Items[i].ToString().Split(' ');
                if (parts.Length > 1)
                {
                    string value = parts[1].Trim();
                    //string description = valueParts[1].Trim();
                    //MessageBox.Show(value);
                    if (value == movie.MovieInfo.ContentRating)
                    {
                        cbbContentRating.SelectedIndex = i;
                        break;
                    }
                }
            }
            tbIMDbScore.Text = movie.MovieInfo.IMDbScore.ToString();
            tbRatingCount.Text = movie.MovieInfo.RatingCount.ToString();
            tbPosterURL.Text = movie.MovieInfo.PosterURL;
            tbTrailerURL.Text = movie.MovieInfo.TrailerURL;
            tbDescription.Text = movie.MovieInfo.Description;
            cbIsTVShows.Checked = movie.MovieInfo.IsTVShows;

            LoadImageFromURL(movie.MovieInfo.PosterURL, imgPreviewPoster);
            wmpPreviewTrailer.URL = movie.MovieInfo.TrailerURL;

            dgvCreators.Rows.Clear();
            foreach (var creator in movie.Creators)
            {
                dgvCreators.Rows.Add(creator.Id, creator.Name);
            }
            dgvDirectors.Rows.Clear();
            foreach (var director in movie.Directors)
            {
                dgvDirectors.Rows.Add(director.Id, director.Name);
            }
            dgvWriters.Rows.Clear();
            foreach (var writer in movie.Writers)
            {
                dgvWriters.Rows.Add(writer.Id, writer.Name);
            }
            dgvSeasons.Rows.Clear();
            int j = 0;
            foreach (var season in movie.Seasons)
            {
                dgvSeasons.Rows.Add(++j, season.Name);
            }
        }

        private void LoadImageFromURL(string url, PictureBox pictureBox)
        {
            try
            {
                pictureBox.Load(url);
            }
            catch (Exception)
            {
                pictureBox.Image = null;
            }
        }

        private void MoviesManager_Load(object sender, EventArgs e)
        {
            LoadListMovies();
        }

        private void tbPageNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGoToPage_Click(object sender, EventArgs e)
        {
            int offset = int.Parse(tbPageNumber.Text) - 1;
            LoadListMovies(offset);
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            int offset = int.Parse(tbPageNumber.Text) - 1;
            if (offset <= 0)
            {
                MessageBox.Show("This is the first page", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            LoadListMovies(offset - 1);
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            int offset = int.Parse(tbPageNumber.Text) - 1;
            LoadListMovies(offset + 1);
        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMovies.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (dgvMovies.Columns[e.ColumnIndex].HeaderText == "Del")
                {
                    //dgvMovies.Rows.RemoveAt(e.RowIndex);
                }
                else if (dgvMovies.Columns[e.ColumnIndex].HeaderText == "View")
                {
                    string movieId = dgvMovies.Rows[e.RowIndex].Cells["cMovieID"].Value.ToString();
                    LoadMovie(movieId);
                }
            }
        }

        private async void btnGetDataUrl_Click(object sender, EventArgs e)
        {
            string url = tbIMDbURL.Text.Trim();
            url = WebUtility.UrlEncode(url);

            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.ShowProgress(this, "Loading movie details, please wait...");

            HttpClientService service = new HttpClientService(_adminToken.Token);
            string response = await service.GetAsync("/admin/getmoviedatafromimdb?url=" + url);

            if (response.Contains("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressDialog.CloseProgress(this);
                return;
            }
            else
            {
                MovieModel movie = JsonConvert.DeserializeObject<MovieModel>(response);
                LoadMovieDetail(movie);
                progressDialog.CloseProgress(this);
            }
        }

        private async void LoadListEpisodes(string movieId, string seasonId = "0")
        {
            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.ShowProgress(this, "Loading episodes, please wait...");

            HttpClientService service = new HttpClientService(_adminToken.Token);
            string url = $"/admin/episodesmanager?movieId={movieId}&seasonId={seasonId}";
            string response = await service.GetAsync(url);
            if (response.Contains("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressDialog.CloseProgress(this);
                return;
            }
            else
            {
                MovieModel movie = JsonConvert.DeserializeObject<MovieModel>(response);
                dgvEpisodes.Rows.Clear();
                foreach (var episode in movie.Episodess)
                {
                    dgvEpisodes.Rows.Add(episode.Id, episode.Episode, ((DateTime)episode.ReleaseDate).ToString("yyyy-MM-dd"), episode.Duration, episode.Image, null, episode.Title, episode.AggregateRating, episode.VoteCount);
                }
            }

            progressDialog.CloseProgress(this);

            for (int i = 0; i < dgvEpisodes.Rows.Count; i++)
            {
                string imageUrl = dgvEpisodes.Rows[i].Cells[4].Value.ToString();
                LoadImageIntoDataGridViewAsync(imageUrl, i, 5, dgvEpisodes);
            }
        }
        public async Task LoadImageIntoDataGridViewAsync(string imageUrl, int rowIndex, int colIndex, DataGridView dgv)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(imageUrl);
                if (response.IsSuccessStatusCode)
                {
                    var imageStream = await response.Content.ReadAsStreamAsync();
                    Image image = Image.FromStream(imageStream);

                    dgv.Invoke(new Action(() =>
                    {
                        if (dgv.Rows.Count > rowIndex && rowIndex >= 0)
                        {
                            dgv.Rows[rowIndex].Cells[colIndex].Value = image;
                        }
                    }));
                }
                else
                {
                    MessageBox.Show("Không thể tải ảnh.");
                }
            }
        }

        private void dgvSeasons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSeasons.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (dgvSeasons.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    string seasonId = dgvSeasons.Rows[e.RowIndex].Cells[1].Value.ToString();
                    LoadListEpisodes(tbMovieId.Text, seasonId);

                    foreach (DataGridViewRow row in dgvSeasons.Rows)
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }

                    dgvSeasons.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }
        private async void LoadEpisode(string episodeId)
        {
            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.ShowProgress(this, "Loading episode details, please wait...");

            HttpClientService service = new HttpClientService(_adminToken.Token);
            string response = await service.GetAsync("/admin/episodemanager?episodeId=" + episodeId);
            if (response.Contains("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressDialog.CloseProgress(this);
                return;
            }
            else
            {
                MovieModel.Episodes episode = JsonConvert.DeserializeObject<MovieModel.Episodes>(response);
                LoadEpisodeDetail(episode);
            }

            progressDialog.CloseProgress(this);
        }
        private void LoadEpisodeDetail(MovieModel.Episodes episode)
        {
            tbEpId.Text = episode.Id;
            tbEpisode.Text = episode.Episode;
            dtpEpReleaseDate.Value = (DateTime)episode.ReleaseDate;
            tbEpDuration.Text = episode.Duration.ToString();
            tbEpImage.Text = episode.Image;
            tbEpImageCaption.Text = episode.ImageCaption;
            tbEpTitle.Text = episode.Title;
            tbEpPlot.Text = episode.Plot;
            tbEpAggregateRating.Text = episode.AggregateRating.ToString();
            tbEpVoteCount.Text = episode.VoteCount.ToString();

            LoadImageFromURL(episode.Image, imgEpPreviewImage);

            dgvEpCreators.Rows.Clear();
            foreach (var creator in episode.Creators)
            {
                dgvEpCreators.Rows.Add(creator.Person.Id, creator.Person.Name);
            }
            dgvEpDirectors.Rows.Clear();
            foreach (var director in episode.Directors)
            {
                dgvEpDirectors.Rows.Add(director.Person.Id, director.Person.Name);
            }
            dgvEpWriters.Rows.Clear();
            foreach (var writer in episode.Writers)
            {
                dgvEpWriters.Rows.Add(writer.Person.Id, writer.Person.Name);
            }
            dgvEpGenres.Rows.Clear();
            int j = 0;
            foreach (var genre in episode.Genres)
            {
                dgvEpGenres.Rows.Add(++j, genre.Name);
            }
            dgvEpCasts.Rows.Clear();
            foreach (var cast in episode.Casts)
            {
                dgvEpCasts.Rows.Add(cast.Person.Id, cast.Person.Name, cast.Person.Image, null, cast.CharacterName);
            }
            for (int i = 0; i < dgvEpCasts.Rows.Count; i++)
            {
                string imageUrl = dgvEpCasts.Rows[i].Cells[2].Value.ToString();
                LoadImageIntoDataGridViewAsync(imageUrl, i, 3, dgvEpCasts);
            }
        }
        private void dgvEpisodes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvEpisodes.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                string episodeId = dgvEpisodes.Rows[e.RowIndex].Cells[0].Value.ToString();
                LoadEpisode(episodeId);
            }
        }
    }
}
