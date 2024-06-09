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
        public void SetData(CommentModel comment)
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
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            CommentModel.Vote vote = new CommentModel.Vote
            {
                CommentId = comment.Id,
                UserId = NT106_Admin.Storage.TempUserId,
                IsUpVote = true
            };
        }
    }
}
