using System.Windows.Forms;

namespace NT106_User
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            Authentication authentication = new Authentication();
            authentication.ShowDialog();
        }
    }
}
