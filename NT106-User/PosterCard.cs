using NT106_WebServer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_User
{
    public partial class PosterCard : UserControl
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
        public string MovieId { get; set; }
        public PosterCard()
        {
            InitializeComponent();
            Settings();

            this.Load += PosterCard_Load;
            //lbType.MakeRounded(10);
            //lbScore.MakeRounded(10);
            //lbContentRating.MakeRounded(10);
            //lbName.MakeRounded(10);

            foreach (Control control in this.Controls)
            {
                control.MouseEnter += new EventHandler(ChildControl_MouseEnter);
                control.MouseLeave += new EventHandler(ChildControl_MouseLeave);
            }
            RegisterMouseClickEventForChildren(Controls);
            originalBackColor = BackColor;
        }

        private void PosterCard_Load(object sender, EventArgs e)
        {
            lbType.MakeRounded(10);
            lbScore.MakeRounded(10);
            lbContentRating.MakeRounded(10);
        }

        public void SetData(MovieModel.Movie movie)
        {
            MovieId = movie.MovieId;
            imgPoster.ImageLocation = movie.PosterURL;
            lbName.Text = movie.MovieName;
            lbContentRating.Text = movie.ContentRating;
            lbScore.Text = movie.IMDbScore.ToString() + "/10";
            lbType.Text = movie.IsTVShows ? "TV Series" : "Movies";
        }
        public event EventHandler<CustomEventArgs> ControlClicked;
        private void RegisterMouseClickEventForChildren(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                control.MouseClick += new MouseEventHandler(ChildControl_Click);

                if (control.HasChildren)
                {
                    RegisterMouseClickEventForChildren(control.Controls);
                }
            }
        }

        private void Settings()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            imgPoster.Height = (int)(Height * 0.85);
            lbContentRating.Top = imgPoster.Bottom - lbContentRating.Height - 10;
            lbName.Top = imgPoster.Bottom + (int)(Height * 0.03);
            lbScore.Location = new Point(Width - lbScore.Width - 10, lbScore.Location.Y);
        }

        private void PosterCard_Resize(object sender, EventArgs e)
        {
            Settings();
        }

        private void PosterCard_MouseEnter(object sender, EventArgs e)
        {
            ApplyHoverEffect();
        }

        private void PosterCard_MouseLeave(object sender, EventArgs e)
        {
            RemoveHoverEffect();
        }
        private void ChildControl_MouseEnter(object sender, EventArgs e)
        {
            ApplyHoverEffect();
        }
        private void ChildControl_MouseLeave(object sender, EventArgs e)
        {
            RemoveHoverEffect();
        }
        private Color originalBackColor;
        private void ApplyHoverEffect()
        {
            this.BackColor = DarkenColor(this.originalBackColor, 0.2f);
            this.Cursor = Cursors.Hand;
        }
        private void RemoveHoverEffect()
        {
            BackColor = originalBackColor;
            Cursor = Cursors.Default;
        }
        private Color LightenColor(Color color, float factor)
        {
            factor = Math.Min(Math.Max(factor, 0), 1);
            int red = (int)(color.R + (255 - color.R) * factor);
            int green = (int)(color.G + (255 - color.G) * factor);
            int blue = (int)(color.B + (255 - color.B) * factor);
            return Color.FromArgb(color.A, red, green, blue);
        }
        public static Color DarkenColor(Color color, float factor)
        {
            factor = Math.Min(Math.Max(factor, 0), 1);
            int red = (int)(color.R * (1 - factor));
            int green = (int)(color.G * (1 - factor));
            int blue = (int)(color.B * (1 - factor));

            return Color.FromArgb(color.A, red, green, blue);
        }

        private void PosterCard_Click(object sender, EventArgs e)
        {
            OnControlClicked();
        }
        private void ChildControl_Click(object sender, MouseEventArgs e)
        {
            OnControlClicked();
        }
        protected virtual void OnControlClicked()
        {
            ControlClicked?.Invoke(this, new CustomEventArgs(MovieId));
        }
        public class CustomEventArgs : EventArgs
        {
            public string MovieId { get; }

            public CustomEventArgs(string MovieId)
            {
                this.MovieId = MovieId;
            }
        }
    }
}
