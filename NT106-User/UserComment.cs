using Newtonsoft.Json;
using NT106_Admin;
using NT106_API_Server.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NT106_API_Server.Models.CommentModel;

namespace NT106_User
{
    public partial class UserComment : UserControl
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
        public static string FormatDate(DateTime date)
        {
            string format;
            if (date.Year == DateTime.Now.Year)
            {
                format = "dd MMM";
            }
            else
            {
                format = "dd MMM, yyyy";
            }
            return date.ToString(format, CultureInfo.InvariantCulture);
        }
        private string? episodeId;
        public UserComment(string? episodeId = null)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            lbContent.MaximumSize = new Size(panel2.Width - 20, 0);
            this.episodeId = episodeId;
        }

        private void UserComment_Resize(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
            lbContent.MaximumSize = new Size(panel2.Width - 20, 0);
        }
        private CommentModel comment;
        private Vote userVote;
        public async Task SetData(CommentModel comment)
        {
            this.comment = comment;
            lbUserName.Text = comment.Username;
            lbContent.Text = comment.Content;
            lbDate.Text = "POSTED: " + FormatDate(comment.CreateDate);
            lbStatus.Text = comment.IsPositive ? "Recommended" : "Not Recommended";
            lbContent.Text = comment.Content;
            lbNumOfReviews.Text = comment.ReviewNum.ToString() + " reviews";
            lbNumOfHelpfull.Text = comment.UpVote.ToString() + " people found this review helpful";

            if (comment.IsPositive)
            {
                imgStatus.Image = Properties.Resources.like;
                pnImgBackground.BackColor = Color.FromArgb(25, 65, 93);
            }
            else
            {
                imgStatus.Image = Properties.Resources.dislike;
                pnImgBackground.BackColor = Color.FromArgb(79, 30, 35);
            }

            if (Storage.TempUserId != null)
            {
                panel3.Visible = true;
                panel3.Enabled = false;

                panel6.Visible = true;
                panel6.Enabled = true;

                panel4.Visible = true;
                panel4.Enabled = true;

                CommentModel.Vote vote = new CommentModel.Vote
                {
                    CommentId = comment.Id,
                    UserId = Storage.TempUserId
                };

                HttpClientService service = new HttpClientService();
                string response = await service.PostAsync("/user/getvotecommentbycommentidanduserid", JsonConvert.SerializeObject(vote));
                if (response.StartsWith("Error"))
                {
                    //MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    panel6.Visible = false;
                    panel6.Enabled = false;
                }
                else
                {
                    //MessageBox.Show(response);
                    CommentModel.Vote userVote = JsonConvert.DeserializeObject<CommentModel.Vote>(response);
                    this.userVote = userVote;
                    if (userVote.IsUpVote)
                    {
                        lbVoteStatus.Text = "You found this review helpful";
                        lbVoteStatus.ForeColor = Color.FromArgb(96, 182, 231);
                    }
                    else
                    {
                        lbVoteStatus.Text = "You found this review not helpful";
                        lbVoteStatus.ForeColor = Color.FromArgb(224, 98, 99);
                    }
                    panel4.Visible = false;
                    panel4.Enabled = false;
                }
                panel3.Enabled = true;

                if (Storage.TempUserId == comment.UserId)
                {
                    lbYourReview.Visible = true;
                }
                else lbYourReview.Visible = false;
            } else {
                panel3.Enabled = false;
                panel3.Visible = false;
            }
        }
        private async void SendVote(bool isUpVote)
        {
            CommentModel.Vote vote = new CommentModel.Vote
            {
                CommentId = comment.Id,
                UserId = Storage.TempUserId,
                IsUpVote = isUpVote
            };

            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.TopLevel = false;
            progressDialog.Dock = DockStyle.Fill;
            progressDialog.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(progressDialog);
            progressDialog.BringToFront();
            progressDialog.ShowProgress(panel3);

            HttpClientService service = new HttpClientService();
            string response = await service.PostAsync("/user/votecomment", JsonConvert.SerializeObject(vote));
            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                response = await service.GetAsync("/user/getcommentbyid?commentId=" + comment.Id);
                if (response.StartsWith("Error"))
                {
                    MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CommentModel newComment = JsonConvert.DeserializeObject<CommentModel>(response);
                    await SetData(newComment);
                }
            }

            progressDialog.CloseProgress(panel3);
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            SendVote(true);
        }

        private async void btnRemoveVote_Click(object sender, EventArgs e)
        {
            if (userVote == null)
            {
                return;
            }

            ProgressDialogForm progressDialog = new ProgressDialogForm();
            progressDialog.TopLevel = false;
            progressDialog.Dock = DockStyle.Fill;
            progressDialog.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(progressDialog);
            progressDialog.BringToFront();
            progressDialog.ShowProgress(this);

            HttpClientService service = new HttpClientService();
            string response = await service.PostAsync("/user/unvotecomment", JsonConvert.SerializeObject(userVote));
            if (response.StartsWith("Error"))
            {
                MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                response = await service.GetAsync("/user/getcommentbyid?commentId=" + comment.Id);
                if (response.StartsWith("Error"))
                {
                    MessageBox.Show(response, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CommentModel newComment = JsonConvert.DeserializeObject<CommentModel>(response);
                    await SetData(newComment);
                }
            }
            progressDialog.CloseProgress(this);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            SendVote(false);
        }
    }
}
