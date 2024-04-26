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
        public MoviesManager()
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
        }


    }
}
