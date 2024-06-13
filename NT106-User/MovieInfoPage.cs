using Newtonsoft.Json;
using NT106_Admin;
using NT106_API_Server.Models;
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
        private MovieModel movie;
        public MovieInfoPage(string movieId)
        {
            InitializeComponent();
            this.movieId = movieId;
            lbReleaseDate.MakeRounded(10);
            lbType.MakeRounded(10);
            lbContentRating.MakeRounded(10);
            lbDuration.MakeRounded(10);
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
            string response = await service.GetAsync("/user/getmovie?movieId=" + movieId);
            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MovieModel movie = JsonConvert.DeserializeObject<MovieModel>(response);
                this.movie = movie;
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
                if (movie.Directors.Count == 0)
                {
                    pnDirectors.Visible = false;
                }
                else
                {
                    flpDirectors.Controls.Clear();
                    foreach (var director in movie.Directors)
                    {
                        PersonView personView = new PersonView();
                        personView.SetData(director);
                        flpDirectors.Controls.Add(personView);
                    }
                }
                if (movie.Creators.Count == 0)
                {
                    pnCreators.Visible = false;
                }
                else
                {
                    flpCreators.Controls.Clear();
                    foreach (var creator in movie.Creators)
                    {
                        PersonView personView = new PersonView();
                        personView.SetData(creator);
                        flpCreators.Controls.Add(personView);
                    }
                }
                if (movie.Writers.Count == 0)
                {
                    pnWriters.Visible = false;
                }
                else
                {
                    flpWriters.Controls.Clear();
                    foreach (var writer in movie.Writers)
                    {
                        PersonView personView = new PersonView();
                        personView.SetData(writer);
                        flpWriters.Controls.Add(personView);
                    }
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
            await CheckingWatchlist();
            progressDialogForm.CloseProgress(this);

            LoadComment();           
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
        private async void LoadComment()
        {
            ProgressDialogForm progressDialogForm = new ProgressDialogForm();
            progressDialogForm.ShowProgress(this);

            HttpClientService service = new HttpClientService();
            string response = await service.GetAsync("/user/gettopcommentsbyepisodeid?episodeId=" + movieId);
            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<CommentModel> comments = JsonConvert.DeserializeObject<List<CommentModel>>(response);
                pnTopComment.Controls.Clear();
                foreach (var comment in comments)
                {
                    UserComment commentUser = new UserComment(movieId);
                    commentUser.SetData(comment);
                    commentUser.Dock = DockStyle.Top;
                    commentUser.Margin = new Padding(0, 0, 0, 10);
                    pnTopComment.Controls.Add(commentUser);
                }
            }

            if (Storage.TempUserId != null)
            {
                response = await service.GetAsync($"/user/hasusercommented?userId={Storage.TempUserId}&episodeId={movieId}");
                if (response.StartsWith("Error"))
                {
                    MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool hasCommented = JsonConvert.DeserializeObject<bool>(response);
                    if (hasCommented)
                    {
                        pnWriteComment.Visible = false;
                    }
                }
            }
            else
            {
                pnWriteComment.Visible = false;
            }

            progressDialogForm.CloseProgress(this);
        }

        private async void btnSendComment_Click(object sender, EventArgs e)
        {
            string content = tbCommentContent.Text;
            if (string.IsNullOrWhiteSpace(content))
            {
                MessageBox.Show("Comment content cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool isPositive = rbPositive.Checked;

            CommentModel comment = new CommentModel
            {
                Content = content,
                EpisodeId = movieId,
                IsPositive = isPositive,
                UserId = Storage.TempUserId,
                CreateDate = DateTime.Now
            };

            ProgressDialogForm progressDialogForm = new ProgressDialogForm();
            progressDialogForm.ShowProgress(this);

            HttpClientService service = new HttpClientService();
            string response = await service.PostAsync("/user/insertcomment", JsonConvert.SerializeObject(comment));
            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Comment successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCommentContent.Text = "";
            }
            progressDialogForm.CloseProgress(this);
        }

        private void btnTrailer_Click(object sender, EventArgs e)
        {
            TrailerView trailerView = new TrailerView(movie.MovieInfo.TrailerURL);
            trailerView.ShowDialog();
        }
        private bool isWatchlisted = false;
        private async Task CheckingWatchlist()
        {
            if (Storage.TempUserId != null)
            {
                HttpClientService service = new HttpClientService();
                string response = await service.GetAsync($"/user/isepisodeinwatchlist?episodeId={movieId}");
                if (response.StartsWith("Error"))
                {
                    //MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool hasWatchlisted = JsonConvert.DeserializeObject<bool>(response);
                    if (hasWatchlisted)
                    {
                        btnWatchlist.BackgroundImage = Properties.Resources.bookmark_checked;
                        isWatchlisted = true;
                    } else
                    {
                        isWatchlisted = false;
                        btnWatchlist.BackgroundImage = Properties.Resources.bookmark;
                    }
                }
            }
            else
            {
                btnWatchlist.BackgroundImage = Properties.Resources.bookmark;
            }
        }

        private async void btnWatchlist_Click(object sender, EventArgs e)
        {
            ProgressDialogForm progressDialogForm = new ProgressDialogForm();
            progressDialogForm.ShowProgress(this);

            HttpClientService service = new HttpClientService();

            if (!isWatchlisted)
            {
                string response = await service.GetAsync("/user/addwatchlist?episodeId=" + movieId);
                if (response.StartsWith("Error"))
                {
                    MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Added to watchlist", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string response = await service.GetAsync("/user/removewatchlist?episodeId=" + movieId);
                if (response.StartsWith("Error"))
                {
                    MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Removed from watchlist", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            await CheckingWatchlist();
            progressDialogForm.CloseProgress(this);
        }
    }
}
