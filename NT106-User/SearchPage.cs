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
    public partial class SearchPage : Form
    {
        public SearchPage()
        {
            InitializeComponent();
            foreach (Control control in flpMovies.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.CheckedChanged += ContentRatingRadioButton_CheckedChanged;
                }
            }

            foreach (Control control in flpTVShows.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.CheckedChanged += ContentRatingRadioButton_CheckedChanged;
                }
            }

            foreach (Control control in flpOtherContentRating.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.CheckedChanged += ContentRatingRadioButton_CheckedChanged;
                }
            }
            foreach (Control control in flpType.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.CheckedChanged += TypeRadioButton_CheckedChanged;
                }
            }
            foreach (Control control in flpOrderBy.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.CheckedChanged += OrderByRadioButton_CheckedChanged;
                }
            }

            string[] genres = new string[]
{
    "Action",
    "Adventure",
    "Animation",
    "Biography",
    "Comedy",
    "Crime",
    "Documentary",
    "Drama",
    "Family",
    "Fantasy",
    "Film-Noir",
    "History",
    "Horror",
    "Music",
    "Musical",
    "Mystery",
    "Romance",
    "Sci-Fi",
    "Short",
    "Sport",
    "Thriller",
    "War",
    "Western"
};
            foreach (string genre in genres)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = genre;
                checkBox.Tag = genre;
                checkBox.ForeColor = Color.White;
                checkBox.BackColor = Color.FromArgb(27, 40, 56);
                checkBox.AutoSize = true;
                flpGenres.Controls.Add(checkBox);
            }
        }
        private string? contentRating;
        private void ContentRatingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                if (flpMovies.Controls.Contains(selectedRadioButton))
                {
                    UncheckOtherRadioButtons(flpTVShows);
                    UncheckOtherRadioButtons(flpOtherContentRating);
                }
                else if (flpTVShows.Controls.Contains(selectedRadioButton))
                {
                    UncheckOtherRadioButtons(flpMovies);
                    UncheckOtherRadioButtons(flpOtherContentRating);
                }
                else if (flpOtherContentRating.Controls.Contains(selectedRadioButton))
                {
                    UncheckOtherRadioButtons(flpMovies);
                    UncheckOtherRadioButtons(flpTVShows);
                }
                contentRating = selectedRadioButton.Tag.ToString();
            }
        }
        private void UncheckOtherRadioButtons(FlowLayoutPanel panel)
        {
            foreach (RadioButton rb in panel.Controls)
            {
                if (rb.Checked)
                {
                    rb.Checked = false;
                }
            }
        }
        private string? type;
        private void TypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                type = selectedRadioButton.Tag.ToString();
            }
        }
        private string orderBy;
        private void OrderByRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                orderBy = selectedRadioButton.Tag.ToString();
            }
        }
        private void btnClearGenres_Click(object sender, EventArgs e)
        {
            foreach (Control control in flpGenres.Controls)
            {
                if (control is CheckBox checkBox)
                checkBox.Checked = false;
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            List<string> genres = new List<string>();
            foreach (Control control in flpGenres.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    if (checkBox.Checked)
                    {
                        genres.Add(checkBox.Text);
                    }
                }                
            }

            contentRating = contentRating == "None" ? null : contentRating;
            type = type == "None" ? null : type;
            orderBy = orderBy == "None" ? "ReleaseDate" : orderBy;
            orderBy = orderBy == null ? "ReleaseDate" : orderBy;

            bool? isTVShow = null;
            if (type == "TVShows")
            {
                isTVShow = true;
            }
            else if (type == "Movies")
            {
                isTVShow = false;
            }
            
            MovieModel.Search search = new MovieModel.Search()
            {
                MovieName = string.IsNullOrEmpty(tbMovieName.Text) ? null : tbMovieName.Text,
                ContentRating = contentRating,
                IsTVShows = isTVShow,
                OrderBy = orderBy,
                Genres = genres.Count == 0 ? null : genres,
                IsDESC = rbDesc.Checked
            };

            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.ShowProgress(this, "Searching...");

            HttpClientService service = new HttpClientService();
            string response = await service.PostAsync("/user/searchmovie", JsonConvert.SerializeObject(search));
            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressDialog.CloseProgress(this);
                return;
            } else
            {
                flpResult.Controls.Clear();
                List<MovieModel.Movie> movies = JsonConvert.DeserializeObject<List<MovieModel.Movie>>(response);
                foreach (MovieModel.Movie movie in movies)
                {
                    PosterCard posterCard = new PosterCard();
                    posterCard.SetData(movie);
                    posterCard.ControlClicked += PosterCard_ControlClicked;
                    flpResult.Controls.Add(posterCard);
                }
                progressDialog.CloseProgress(this);
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
    }
}
