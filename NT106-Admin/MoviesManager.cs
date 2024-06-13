using Newtonsoft.Json;
using NT106_WebServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using static NT106_WebServer.Models.MovieModel;

namespace NT106_Admin
{
    public partial class MoviesManager : Form
    {
        public AdminToken _adminToken;
        private const string IMDb_BASE_URL = "https://www.imdb.com/title/";
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

            tbEpId.ReadOnly = true;
            tbEpisode.ReadOnly = true;
            tbEpDuration.ReadOnly = true;
            tbEpImage.ReadOnly = true;
            tbEpImageCaption.ReadOnly = true;
            tbEpTitle.ReadOnly = true;
            tbEpPlot.ReadOnly = true;
            tbEpAggregateRating.ReadOnly = true;
            tbEpVoteCount.ReadOnly = true;


            // CheckBox
            cbIsTVShows.Enabled = false;

            // ComboBox
            cbbContentRating.Enabled = false;

            // DateTimePicker
            dtpReleaseDate.Enabled = false;

            dtpEpReleaseDate.Enabled = false;
        }
        private void ClearEpisodeDetail(bool isFromDatabase = true)
        {
            if (isFromDatabase)
            {
                tbEpId.Text = "";
                tbEpisode.Text = "";
                tbEpTitle.Text = "";
            }
            tbEpURL.Text = "";
            dtpEpReleaseDate.Value = DateTime.Now;
            tbEpDuration.Text = "";
            tbEpImage.Text = "";
            tbEpImageCaption.Text = "";
            tbEpPlot.Text = "";
            tbEpAggregateRating.Text = "";
            tbEpVoteCount.Text = "";

            imgEpPreviewImage.Image = null;

            dgvEpCreators.Rows.Clear();
            dgvEpDirectors.Rows.Clear();
            dgvEpWriters.Rows.Clear();
            dgvEpGenres.Rows.Clear();
            dgvEpCasts.Rows.Clear();
        }
        private void ClearEpisodes()
        {
            seasonNow = "";
            dgvEpisodes.Rows.Clear();
            ClearEpisodeDetail();
        }

        private async void LoadListMovies(int offset = 0)
        {
            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.ShowProgress(this, "Loading movies, please wait...");

            if (offset < 0)
            {
                MessageBox.Show("Invalid offset", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressDialog.CloseProgress(this);
                return;
            }

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
            tbPageNumber.Text = (offset + 1).ToString();
            lastOffset = offset;
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
                ClearEpisodes();
                LoadMovieDetail(movie);
            }

            progressDialog.CloseProgress(this);

            
        }

        private async void LoadMovieDetail(MovieModel movie)
        {
            tbIMDbURL.Text = IMDb_BASE_URL + movie.MovieInfo.MovieId;
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

            imgPreviewPoster.ImageLocation = movie.MovieInfo.PosterURL;
            //LoadImageFromURL(movie.MovieInfo.PosterURL, imgPreviewPoster);
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

            if (!movie.MovieInfo.IsTVShows)
            {
                panel12.Visible = false;
                panel13.Visible = false;
                panel18.Visible = false;
                panel19.Visible = false;
                panel20.Visible = false;
                panel9.Visible = false;
                flowLayoutPanel2.Visible = false;
                lbEpData.Visible = false;
                tbEpURL.Text = IMDb_BASE_URL + movie.MovieInfo.MovieId;
                LoadEpisode(tbMovieId.Text, false);
            }
            else
            {
                panel12.Visible = true;
                panel13.Visible = true;
                panel18.Visible = true;
                panel19.Visible = true;
                panel20.Visible = true;
                lbEpData.Visible = true;
                flowLayoutPanel2.Visible = true;
                panel9.Visible = true;
                tbEpURL.Text = "";
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
                //ClearEpisodes();
                MovieModel movie = JsonConvert.DeserializeObject<MovieModel>(response);
                dgvEpisodes.Rows.Clear();
                foreach (var episode in movie.Episodess)
                {
                    dgvEpisodes.Rows.Add(episode.Id, episode.Episode, ((DateTime)episode.ReleaseDate).ToString("yyyy-MM-dd"), episode.Duration, episode.Image, null, episode.Title, episode.AggregateRating, episode.VoteCount);
                }
                for (int i = 0; i < dgvEpisodes.Rows.Count; i++)
                {
                    string imageUrl = dgvEpisodes.Rows[i].Cells[4].Value.ToString();
                    LoadImageIntoDataGridViewAsync(imageUrl, i, 5, dgvEpisodes);
                }
            }

            progressDialog.CloseProgress(this);
           
            ClearEpisodeDetail();
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
                    seasonNow = seasonId;

                    if (!cbIsTVShows.Checked)
                    {
                        LoadEpisode(tbMovieId.Text, false);
                    }
                    else

                        LoadListEpisodes(tbMovieId.Text, seasonId);


                    foreach (DataGridViewRow row in dgvSeasons.Rows)
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }

                    dgvSeasons.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }
        private async void LoadEpisode(string episodeId, bool isTVShow = true)
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
                LoadEpisodeDetail(episode, true, isTVShow);
            }

            progressDialog.CloseProgress(this);
        }
        private void LoadEpisodeDetail(MovieModel.Episodes episode, bool isFromDatabase = true, bool isTVShow = true)
        {
            ClearEpisodeDetail(isFromDatabase);

            tbEpURL.Text = IMDb_BASE_URL + episode.Id;
            if (isTVShow)
            {
                if (isFromDatabase)
                {
                    tbEpId.Text = episode.Id;
                    tbEpisode.Text = episode.Episode;
                    tbEpTitle.Text = episode.Title;
                }
                dtpEpReleaseDate.Value = (DateTime)episode.ReleaseDate;
                tbEpDuration.Text = episode.Duration.ToString();
                tbEpImage.Text = episode.Image;
                tbEpImageCaption.Text = episode.ImageCaption;
                tbEpPlot.Text = episode.Plot;
                tbEpAggregateRating.Text = episode.AggregateRating.ToString();
                tbEpVoteCount.Text = episode.VoteCount.ToString();

                LoadImageFromURL(episode.Image, imgEpPreviewImage);
            }

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
                if (dgvEpCasts.Rows[i].Cells[2].Value == null)
                {
                    continue;
                }
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

        private async void btnEpGetData_Click(object sender, EventArgs e)
        {
            string url = tbEpURL.Text.Trim();
            url = WebUtility.UrlEncode(url);

            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.ShowProgress(this, "Loading episode details, please wait...");

            HttpClientService service = new HttpClientService(_adminToken.Token);
            string response = await service.GetAsync("/admin/getepisodedatafromimdb?url=" + url);

            if (response.Contains("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressDialog.CloseProgress(this);
                return;
            }
            else
            {
                //MessageBox.Show(response, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MovieModel.Episodes episode = JsonConvert.DeserializeObject<MovieModel.Episodes>(response);
                LoadEpisodeDetail(episode, false);
                progressDialog.CloseProgress(this);
            }
        }
        private async void UploadMovieData(string method = "update")
        {
            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.ShowProgress(this, "Uploading movie details, please wait...");

            MovieModel movie = new MovieModel();
            movie.MovieInfo = new MovieModel.Movie();
            movie.MovieInfo.MovieId = tbMovieId.Text;
            movie.MovieInfo.MovieName = tbMovieName.Text;
            movie.MovieInfo.ReleaseDate = dtpReleaseDate.Value;
            movie.MovieInfo.Duration = int.Parse(tbDuration.Text);
            movie.MovieInfo.ContentRating = cbbContentRating.SelectedItem.ToString().Split(' ')[1].Trim();
            movie.MovieInfo.IMDbScore = double.Parse(tbIMDbScore.Text);
            movie.MovieInfo.RatingCount = int.Parse(tbRatingCount.Text);
            movie.MovieInfo.PosterURL = tbPosterURL.Text;
            movie.MovieInfo.TrailerURL = tbTrailerURL.Text;
            movie.MovieInfo.Description = tbDescription.Text;
            movie.MovieInfo.IsTVShows = cbIsTVShows.Checked;

            movie.Creators = new List<MovieModel.Person>();
            foreach (DataGridViewRow row in dgvCreators.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                movie.Creators.Add(new MovieModel.Person { Id = row.Cells[0].Value.ToString(), Name = row.Cells[1].Value.ToString() });
            }
            movie.Directors = new List<MovieModel.Person>();
            foreach (DataGridViewRow row in dgvDirectors.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                movie.Directors.Add(new MovieModel.Person { Id = row.Cells[0].Value.ToString(), Name = row.Cells[1].Value.ToString() });
            }
            movie.Writers = new List<MovieModel.Person>();
            foreach (DataGridViewRow row in dgvWriters.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                movie.Writers.Add(new MovieModel.Person { Id = row.Cells[0].Value.ToString(), Name = row.Cells[1].Value.ToString() });
            }
            movie.Seasons = new List<MovieModel.Season>();
            foreach (DataGridViewRow row in dgvSeasons.Rows)
            {
                if (row.Cells[1].Value != null)
                movie.Seasons.Add(new MovieModel.Season { Name = row.Cells[1].Value.ToString() });
            }

            HttpClientService service = new HttpClientService(_adminToken.Token);
            string json = JsonConvert.SerializeObject(movie);
            string response = await service.PostAsync("/admin/uploadbasicdataimdb?method=" + method, json);
            if (response.Contains("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show(response, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            progressDialog.CloseProgress(this);

            btnRefreshMovies.PerformClick();
        }

        private void btnRefreshMovies_Click(object sender, EventArgs e)
        {
            LoadListMovies(lastOffset);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UploadMovieData("insert");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UploadMovieData();
        }

        private string seasonNow = "";

        private void btnResolveHTML_Click(object sender, EventArgs e)
        {
            string htmlContent = tbEpisodeHTML.Text;

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(htmlContent);

            var episodeNodes = doc.DocumentNode.SelectNodes("//article[contains(@class,'episode-item-wrapper')]");

            if (episodeNodes != null)
            {
                dgvEpisodes.Rows.Clear();
                foreach (var episode in episodeNodes)
                {
                    var imgSrc = episode.SelectSingleNode(".//img[contains(@class,'ipc-image')]")?.GetAttributeValue("src", string.Empty);
                    var hrefValue = episode.SelectSingleNode(".//a[contains(@class,'ipc-title-link-wrapper')]")?.GetAttributeValue("href", string.Empty);
                    var extractedId = System.Text.RegularExpressions.Regex.Match(hrefValue, @"/title/(tt\d+)/").Groups[1].Value;

                    var descriptionNode = episode.SelectSingleNode(".//div[contains(@class,'ipc-html-content-inner-div')]");
                    var description = descriptionNode != null ? descriptionNode.InnerText : "";

                    var releaseDate = episode.SelectSingleNode(".//span[contains(@class,'sc-aafba987-10')]")?.InnerText;
                    if (releaseDate == null)
                    {
                        releaseDate = episode.SelectSingleNode(".//span[contains(@class,'sc-ccd6e31b-10')]")?.InnerText;
                    }
                    DateTime date = DateTime.Parse(releaseDate);
                    var formattedDate = date.ToString("yyyy-MM-dd");

                    var episodeTitle = episode.SelectSingleNode(".//div[contains(@class,'ipc-title__text')]")?.InnerText;

                    string title = "", seasonEpisode = "", seasonNumber = "", epNumber = "";
                    if (seasonNow == "Unknown")
                    {
                        title = episodeTitle;
                    }
                    else
                    {
                        var parts = episodeTitle.Split('∙').Select(p => p.Trim()).ToArray();
                        seasonEpisode = parts[0];
                        title = parts[1];
                        var match = System.Text.RegularExpressions.Regex.Match(seasonEpisode, @"S(\d+)\.E(\d+)");
                        seasonNumber = match.Groups[1].Value;
                        epNumber = match.Groups[2].Value;

                        if (seasonNumber != seasonNow)
                        {
                            MessageBox.Show($"Season number is not {seasonNow}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    var imdbRating = episode.SelectSingleNode(".//span[contains(@class,'ipc-rating-star--imdb')]")?.GetAttributeValue("aria-label", string.Empty);
                    var ratingMatch = System.Text.RegularExpressions.Regex.Match(imdbRating, @"\d+\.\d+");
                    var imdbRatingValue = ratingMatch.Value;

                    // Add data to DataGridView
                    dgvEpisodes.Rows.Add(extractedId, epNumber, formattedDate, null, imgSrc, null, title, imdbRatingValue, null, null, null);
                }
                foreach (DataGridViewRow row in dgvEpisodes.Rows)
                {
                    string imageUrl = row.Cells[4].Value.ToString();
                    LoadImageIntoDataGridViewAsync(imageUrl, row.Index, 5, dgvEpisodes);
                }
            }
        }

        private async void UploadEpisodesData()
        {
            ProgressDialogForm dialogForm = new ProgressDialogForm();
            dialogForm.ShowProgress(this, "Uploading episodes data, please wait...");

            List<MovieModel.Episodes> episodes = new List<MovieModel.Episodes>();
            foreach (DataGridViewRow row in dgvEpisodes.Rows)
            {
                MovieModel.Episodes episode = new MovieModel.Episodes();
                episode.MovieId = tbMovieId.Text;
                episode.Season = seasonNow;
                episode.Id = row.Cells[0].Value.ToString();
                episode.Episode = row.Cells[1].Value.ToString();
                episode.ReleaseDate = DateTime.Parse(row.Cells[2].Value.ToString());
                episode.Image = row.Cells[4].Value.ToString();
                episode.Title = row.Cells[6].Value.ToString();
                episode.AggregateRating = double.Parse(row.Cells[7].Value.ToString());

                episodes.Add(episode);
            }

            HttpClientService service = new HttpClientService(_adminToken.Token);
            string json = JsonConvert.SerializeObject(episodes);
            string response = await service.PostAsync("/admin/uploadepisodesdata", json);
            if (response.Contains("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dialogForm.CloseProgress(this);
                return;
            }
            else
            {
                //MessageBox.Show("Upload done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dialogForm.CloseProgress(this);

            LoadListEpisodes(tbMovieId.Text, seasonNow);
        }

        private void btnSubmitEpisodes_Click(object sender, EventArgs e)
        {
            UploadEpisodesData();
        }

        private async void btnEpSubmit_Click(object sender, EventArgs e)
        {
            ProgressDialogForm dialogForm = new ProgressDialogForm();
            dialogForm.ShowProgress(this, "Uploading episode detail, please wait...");

            MovieModel.Episodes episode = new MovieModel.Episodes();
            if (cbIsTVShows.Checked)
            {
                episode.MovieId = tbMovieId.Text;
                episode.Season = seasonNow;
                episode.Id = tbEpId.Text;
                episode.Episode = tbEpisode.Text;
                episode.ReleaseDate = dtpEpReleaseDate.Value;
                episode.Duration = int.Parse(tbEpDuration.Text);
                episode.Image = tbEpImage.Text;
                episode.ImageCaption = tbEpImageCaption.Text;
                episode.Title = tbEpTitle.Text;
                episode.Plot = tbEpPlot.Text;
                episode.AggregateRating = double.Parse(tbEpAggregateRating.Text);
                episode.VoteCount = int.Parse(tbEpVoteCount.Text);
            } else
            {
                episode.MovieId = tbMovieId.Text;
                episode.Season = seasonNow = "0";
                episode.Id = tbMovieId.Text;
            }

            episode.Creators = new List<MovieModel.EpisodeCreator>();
            foreach (DataGridViewRow row in dgvEpCreators.Rows)
            {
                episode.Creators.Add(new MovieModel.EpisodeCreator { Person = new MovieModel.Person { Id = row.Cells[0].Value.ToString(), Name = row.Cells[1].Value.ToString() } });
            }
            episode.Directors = new List<MovieModel.EpisodeDirectors>();
            foreach (DataGridViewRow row in dgvEpDirectors.Rows)
            {
                episode.Directors.Add(new MovieModel.EpisodeDirectors { Person = new MovieModel.Person { Id = row.Cells[0].Value.ToString(), Name = row.Cells[1].Value.ToString() } });
            }
            episode.Writers = new List<MovieModel.EpisodeWriters>();
            foreach (DataGridViewRow row in dgvEpWriters.Rows)
            {
                episode.Writers.Add(new MovieModel.EpisodeWriters { Person = new MovieModel.Person { Id = row.Cells[0].Value.ToString(), Name = row.Cells[1].Value.ToString() } });
            }
            episode.Genres = new List<MovieModel.EpisodeGenres>();
            foreach (DataGridViewRow row in dgvEpGenres.Rows)
            {
                episode.Genres.Add(new MovieModel.EpisodeGenres { Name = row.Cells[1].Value.ToString() });
            }
            episode.Casts = new List<MovieModel.Cast>();
            foreach (DataGridViewRow row in dgvEpCasts.Rows)
            {
                Cast cast = new MovieModel.Cast();
                cast.Person = new MovieModel.Person();
                cast.Person.Id = row.Cells[0].Value.ToString();
                cast.Person.Name = row.Cells[1].Value.ToString();
                cast.Person.Image = (row.Cells[2].Value == null ? null : row.Cells[2].Value.ToString());
                cast.CharacterName = row.Cells[4].Value.ToString();
                episode.Casts.Add(cast);
            }

            HttpClientService service = new HttpClientService(_adminToken.Token);
            string json = JsonConvert.SerializeObject(episode);
            
            string response = await service.PostAsync("/admin/uploadepisodedata", json);

            if (response.Contains("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dialogForm.CloseProgress(this);
                return;
            }
            else
            {
                //MessageBox.Show("Upload done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dialogForm.CloseProgress(this);

            LoadEpisode(episode.Id, cbIsTVShows.Checked);
            if (cbIsTVShows.Checked)
            {
                LoadListEpisodes(tbMovieId.Text, seasonNow);
            }
        }

        private void btnLoadTrailer_Click(object sender, EventArgs e)
        {
            wmpPreviewTrailer.URL = tbTrailerURL.Text;
        }
    }
}
