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
    public partial class PersonView : UserControl
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
        public PersonView()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void PesonView_Resize(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public void SetData(MovieModel.Person person, string characterName = "", int episodeCount = 0)
        {
            lbName.Text = person.Name;
            if (characterName != "") lbCharacterName.Text = "as " + characterName;
            else
            {
                lbCharacterName.Text = "";
                lbName.Font = new Font(lbName.Font.Name, 14, lbName.Font.Style);
            }
            if (episodeCount != 0) lbMore.Text = episodeCount.ToString() + " episodes";
            else
            {
                lbMore.Text = "";
            }
            if (person.Image != null)
            {
                imgAvatar.ImageLocation = person.Image;
            }
        }
    }
}
