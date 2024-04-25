namespace NT106_Admin
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            MoviesManager moviesManager = new MoviesManager();
            moviesManager.TopLevel = false;
            moviesManager.Dock = DockStyle.Fill;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(moviesManager);
            moviesManager.Show();
        }
    }
}
