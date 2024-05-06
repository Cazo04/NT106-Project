namespace NT106_Admin
{
    partial class MoviesManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesManager));
            dgvMovies = new DataGridView();
            cMovieID = new DataGridViewTextBoxColumn();
            cMovieName = new DataGridViewTextBoxColumn();
            cReleaseDate = new DataGridViewTextBoxColumn();
            cDuration = new DataGridViewTextBoxColumn();
            cContentRating = new DataGridViewTextBoxColumn();
            cIMDbScore = new DataGridViewTextBoxColumn();
            cIsTVShows = new DataGridViewCheckBoxColumn();
            cView = new DataGridViewButtonColumn();
            cDel = new DataGridViewButtonColumn();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel23 = new Panel();
            btnPreviousPage = new Button();
            btnNextPage = new Button();
            tableLayoutPanel22 = new TableLayoutPanel();
            lbCountMovies = new Label();
            panel24 = new Panel();
            btnGoToPage = new Button();
            lbPageMovies = new Label();
            tbPageNumber = new TextBox();
            btnRefreshMovies = new Button();
            panel4 = new Panel();
            panel10 = new Panel();
            tableLayoutPanel12 = new TableLayoutPanel();
            btnClear = new Button();
            btnUpdate = new Button();
            btnSubmit = new Button();
            panel8 = new Panel();
            dgvWriters = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            label15 = new Label();
            panel7 = new Panel();
            dgvDirectors = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            label14 = new Label();
            panel6 = new Panel();
            dgvCreators = new DataGridView();
            cId = new DataGridViewTextBoxColumn();
            cName = new DataGridViewTextBoxColumn();
            label13 = new Label();
            panel5 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            tbMovieId = new TextBox();
            tableLayoutPanel27 = new TableLayoutPanel();
            label36 = new Label();
            tbMovieName = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            dtpReleaseDate = new DateTimePicker();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            tbDuration = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label5 = new Label();
            cbbContentRating = new ComboBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label8 = new Label();
            tbIMDbScore = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label7 = new Label();
            tbRatingCount = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label6 = new Label();
            tbPosterURL = new TextBox();
            imgPreviewPoster = new PictureBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            label9 = new Label();
            wmpPreviewTrailer = new AxWMPLib.AxWindowsMediaPlayer();
            tableLayoutPanel31 = new TableLayoutPanel();
            tbTrailerURL = new TextBox();
            btnLoadTrailer = new Button();
            tableLayoutPanel9 = new TableLayoutPanel();
            label10 = new Label();
            tbDescription = new TextBox();
            cbIsTVShows = new CheckBox();
            label1 = new Label();
            panel11 = new Panel();
            tableLayoutPanel11 = new TableLayoutPanel();
            btnGetDataUrl = new Button();
            btnGoToWeb = new Button();
            tableLayoutPanel10 = new TableLayoutPanel();
            label12 = new Label();
            tbIMDbURL = new TextBox();
            label11 = new Label();
            panel9 = new Panel();
            dgvSeasons = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            cSeasonEdit = new DataGridViewButtonColumn();
            label16 = new Label();
            panel12 = new Panel();
            dgvEpisodes = new DataGridView();
            cEpId = new DataGridViewTextBoxColumn();
            cNumber = new DataGridViewTextBoxColumn();
            cEpReleaseDate = new DataGridViewTextBoxColumn();
            cEpDuration = new DataGridViewTextBoxColumn();
            cEpImage = new DataGridViewTextBoxColumn();
            cPreviewImage = new DataGridViewImageColumn();
            cEpTitle = new DataGridViewTextBoxColumn();
            cEpAggregateRating = new DataGridViewTextBoxColumn();
            cEpVoteCount = new DataGridViewTextBoxColumn();
            cEpEdit = new DataGridViewButtonColumn();
            cEpDel = new DataGridViewButtonColumn();
            label17 = new Label();
            panel13 = new Panel();
            panel14 = new Panel();
            btnSubmitEpisodes = new Button();
            tableLayoutPanel13 = new TableLayoutPanel();
            btnResolveHTML = new Button();
            btnRefreshEpisodes = new Button();
            tableLayoutPanel14 = new TableLayoutPanel();
            label18 = new Label();
            tbEpisodeHTML = new TextBox();
            label19 = new Label();
            panel15 = new Panel();
            panel16 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            tableLayoutPanel15 = new TableLayoutPanel();
            label20 = new Label();
            tbEpId = new TextBox();
            tableLayoutPanel28 = new TableLayoutPanel();
            label37 = new Label();
            tbEpisode = new TextBox();
            tableLayoutPanel25 = new TableLayoutPanel();
            label31 = new Label();
            tbEpTitle = new TextBox();
            tableLayoutPanel16 = new TableLayoutPanel();
            label21 = new Label();
            dtpEpReleaseDate = new DateTimePicker();
            tableLayoutPanel17 = new TableLayoutPanel();
            label22 = new Label();
            tbEpDuration = new TextBox();
            tableLayoutPanel19 = new TableLayoutPanel();
            label24 = new Label();
            tbEpAggregateRating = new TextBox();
            tableLayoutPanel20 = new TableLayoutPanel();
            label25 = new Label();
            tbEpVoteCount = new TextBox();
            tableLayoutPanel21 = new TableLayoutPanel();
            label26 = new Label();
            tbEpImage = new TextBox();
            imgEpPreviewImage = new PictureBox();
            tableLayoutPanel23 = new TableLayoutPanel();
            label28 = new Label();
            tbEpImageCaption = new TextBox();
            tableLayoutPanel24 = new TableLayoutPanel();
            label30 = new Label();
            tbEpPlot = new TextBox();
            tableLayoutPanel18 = new TableLayoutPanel();
            btnEpSubmit = new Button();
            btnEpUpdate = new Button();
            label29 = new Label();
            panel25 = new Panel();
            tableLayoutPanel29 = new TableLayoutPanel();
            btnEpGetData = new Button();
            btnEpGoToWebsite = new Button();
            tableLayoutPanel30 = new TableLayoutPanel();
            label38 = new Label();
            tbEpURL = new TextBox();
            label39 = new Label();
            panel17 = new Panel();
            panel21 = new Panel();
            dgvEpGenres = new DataGridView();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            label33 = new Label();
            panel18 = new Panel();
            dgvEpWriters = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            label23 = new Label();
            panel19 = new Panel();
            dgvEpDirectors = new DataGridView();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            label27 = new Label();
            panel20 = new Panel();
            dgvEpCreators = new DataGridView();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            label32 = new Label();
            panel22 = new Panel();
            dgvEpCasts = new DataGridView();
            cCastId = new DataGridViewTextBoxColumn();
            cCastName = new DataGridViewTextBoxColumn();
            cCastImage = new DataGridViewTextBoxColumn();
            cCastPreviewImage = new DataGridViewImageColumn();
            cCastCharacter = new DataGridViewTextBoxColumn();
            cCastDel = new DataGridViewButtonColumn();
            label34 = new Label();
            tableLayoutPanel26 = new TableLayoutPanel();
            label35 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel23.SuspendLayout();
            tableLayoutPanel22.SuspendLayout();
            panel24.SuspendLayout();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWriters).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirectors).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCreators).BeginInit();
            panel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel27.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPreviewPoster).BeginInit();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wmpPreviewTrailer).BeginInit();
            tableLayoutPanel31.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            panel11.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeasons).BeginInit();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpisodes).BeginInit();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            panel15.SuspendLayout();
            panel16.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            tableLayoutPanel28.SuspendLayout();
            tableLayoutPanel25.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            tableLayoutPanel17.SuspendLayout();
            tableLayoutPanel19.SuspendLayout();
            tableLayoutPanel20.SuspendLayout();
            tableLayoutPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgEpPreviewImage).BeginInit();
            tableLayoutPanel23.SuspendLayout();
            tableLayoutPanel24.SuspendLayout();
            tableLayoutPanel18.SuspendLayout();
            panel25.SuspendLayout();
            tableLayoutPanel29.SuspendLayout();
            tableLayoutPanel30.SuspendLayout();
            panel17.SuspendLayout();
            panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpGenres).BeginInit();
            panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpWriters).BeginInit();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpDirectors).BeginInit();
            panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpCreators).BeginInit();
            panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpCasts).BeginInit();
            tableLayoutPanel26.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMovies
            // 
            dgvMovies.AllowUserToAddRows = false;
            dgvMovies.AllowUserToDeleteRows = false;
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Columns.AddRange(new DataGridViewColumn[] { cMovieID, cMovieName, cReleaseDate, cDuration, cContentRating, cIMDbScore, cIsTVShows, cView, cDel });
            dgvMovies.Dock = DockStyle.Fill;
            dgvMovies.Location = new Point(0, 0);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.ReadOnly = true;
            dgvMovies.RowHeadersWidth = 30;
            dgvMovies.Size = new Size(926, 610);
            dgvMovies.TabIndex = 0;
            dgvMovies.CellContentClick += dgvMovies_CellContentClick;
            // 
            // cMovieID
            // 
            cMovieID.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cMovieID.HeaderText = "Movie ID";
            cMovieID.MinimumWidth = 8;
            cMovieID.Name = "cMovieID";
            cMovieID.ReadOnly = true;
            cMovieID.Width = 79;
            // 
            // cMovieName
            // 
            cMovieName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cMovieName.HeaderText = "Movie Name";
            cMovieName.MinimumWidth = 8;
            cMovieName.Name = "cMovieName";
            cMovieName.ReadOnly = true;
            // 
            // cReleaseDate
            // 
            cReleaseDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cReleaseDate.HeaderText = "Release Date";
            cReleaseDate.MinimumWidth = 8;
            cReleaseDate.Name = "cReleaseDate";
            cReleaseDate.ReadOnly = true;
            cReleaseDate.Width = 98;
            // 
            // cDuration
            // 
            cDuration.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cDuration.HeaderText = "Duration (s)";
            cDuration.MinimumWidth = 8;
            cDuration.Name = "cDuration";
            cDuration.ReadOnly = true;
            cDuration.Width = 94;
            // 
            // cContentRating
            // 
            cContentRating.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cContentRating.HeaderText = "Content Rating";
            cContentRating.MinimumWidth = 8;
            cContentRating.Name = "cContentRating";
            cContentRating.ReadOnly = true;
            cContentRating.Width = 112;
            // 
            // cIMDbScore
            // 
            cIMDbScore.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cIMDbScore.HeaderText = "IMDb Score";
            cIMDbScore.MinimumWidth = 8;
            cIMDbScore.Name = "cIMDbScore";
            cIMDbScore.ReadOnly = true;
            cIMDbScore.Width = 93;
            // 
            // cIsTVShows
            // 
            cIsTVShows.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            cIsTVShows.HeaderText = "Is TV Shows";
            cIsTVShows.MinimumWidth = 8;
            cIsTVShows.Name = "cIsTVShows";
            cIsTVShows.ReadOnly = true;
            cIsTVShows.Width = 74;
            // 
            // cView
            // 
            cView.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            cView.HeaderText = "View";
            cView.MinimumWidth = 8;
            cView.Name = "cView";
            cView.ReadOnly = true;
            cView.Text = "View";
            cView.Width = 38;
            // 
            // cDel
            // 
            cDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            cDel.HeaderText = "Del";
            cDel.MinimumWidth = 8;
            cDel.Name = "cDel";
            cDel.ReadOnly = true;
            cDel.Text = "Del";
            cDel.Width = 30;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 647);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvMovies);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(926, 610);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel23);
            panel2.Controls.Add(btnRefreshMovies);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(926, 37);
            panel2.TabIndex = 2;
            // 
            // panel23
            // 
            panel23.Controls.Add(btnPreviousPage);
            panel23.Controls.Add(btnNextPage);
            panel23.Controls.Add(tableLayoutPanel22);
            panel23.Dock = DockStyle.Right;
            panel23.Location = new Point(537, 0);
            panel23.Name = "panel23";
            panel23.Size = new Size(389, 37);
            panel23.TabIndex = 1;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.Location = new Point(251, 8);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(60, 23);
            btnPreviousPage.TabIndex = 2;
            btnPreviousPage.Text = "Previous";
            btnPreviousPage.UseVisualStyleBackColor = true;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(321, 8);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(62, 23);
            btnNextPage.TabIndex = 1;
            btnNextPage.Text = "Next";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // tableLayoutPanel22
            // 
            tableLayoutPanel22.ColumnCount = 2;
            tableLayoutPanel22.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.8571434F));
            tableLayoutPanel22.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.1428566F));
            tableLayoutPanel22.Controls.Add(lbCountMovies, 0, 0);
            tableLayoutPanel22.Controls.Add(panel24, 1, 0);
            tableLayoutPanel22.Dock = DockStyle.Left;
            tableLayoutPanel22.Location = new Point(0, 0);
            tableLayoutPanel22.Name = "tableLayoutPanel22";
            tableLayoutPanel22.RowCount = 1;
            tableLayoutPanel22.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel22.Size = new Size(245, 37);
            tableLayoutPanel22.TabIndex = 0;
            // 
            // lbCountMovies
            // 
            lbCountMovies.AutoSize = true;
            lbCountMovies.Dock = DockStyle.Left;
            lbCountMovies.Location = new Point(3, 0);
            lbCountMovies.Name = "lbCountMovies";
            lbCountMovies.Size = new Size(73, 37);
            lbCountMovies.TabIndex = 0;
            lbCountMovies.Text = "??/?? Movies";
            lbCountMovies.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel24
            // 
            panel24.Controls.Add(btnGoToPage);
            panel24.Controls.Add(lbPageMovies);
            panel24.Controls.Add(tbPageNumber);
            panel24.Location = new Point(108, 3);
            panel24.Name = "panel24";
            panel24.Size = new Size(134, 31);
            panel24.TabIndex = 1;
            // 
            // btnGoToPage
            // 
            btnGoToPage.Location = new Point(79, 4);
            btnGoToPage.Name = "btnGoToPage";
            btnGoToPage.Size = new Size(39, 23);
            btnGoToPage.TabIndex = 1;
            btnGoToPage.Text = "Go";
            btnGoToPage.UseVisualStyleBackColor = true;
            btnGoToPage.Click += btnGoToPage_Click;
            // 
            // lbPageMovies
            // 
            lbPageMovies.AutoSize = true;
            lbPageMovies.Location = new Point(3, 8);
            lbPageMovies.Name = "lbPageMovies";
            lbPageMovies.Size = new Size(36, 15);
            lbPageMovies.TabIndex = 1;
            lbPageMovies.Text = "Page:";
            lbPageMovies.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbPageNumber
            // 
            tbPageNumber.Location = new Point(41, 5);
            tbPageNumber.Name = "tbPageNumber";
            tbPageNumber.Size = new Size(32, 23);
            tbPageNumber.TabIndex = 1;
            tbPageNumber.KeyPress += tbPageNumber_KeyPress;
            // 
            // btnRefreshMovies
            // 
            btnRefreshMovies.Dock = DockStyle.Left;
            btnRefreshMovies.Location = new Point(0, 0);
            btnRefreshMovies.Name = "btnRefreshMovies";
            btnRefreshMovies.Size = new Size(99, 37);
            btnRefreshMovies.TabIndex = 0;
            btnRefreshMovies.Text = "Refresh";
            btnRefreshMovies.UseVisualStyleBackColor = true;
            btnRefreshMovies.Click += btnRefreshMovies_Click;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel11);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(926, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5, 0, 0, 0);
            panel4.Size = new Size(387, 647);
            panel4.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Controls.Add(tableLayoutPanel12);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(5, 2023);
            panel10.Name = "panel10";
            panel10.Size = new Size(365, 48);
            panel10.TabIndex = 5;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 3;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            tableLayoutPanel12.Controls.Add(btnClear, 2, 0);
            tableLayoutPanel12.Controls.Add(btnUpdate, 1, 0);
            tableLayoutPanel12.Controls.Add(btnSubmit, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(0, 0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(365, 48);
            tableLayoutPanel12.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Left;
            btnClear.Location = new Point(253, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(83, 42);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Dock = DockStyle.Left;
            btnUpdate.Location = new Point(128, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(83, 42);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Dock = DockStyle.Left;
            btnSubmit.Location = new Point(3, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(83, 42);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(dgvWriters);
            panel8.Controls.Add(label15);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(5, 1801);
            panel8.Name = "panel8";
            panel8.Size = new Size(365, 222);
            panel8.TabIndex = 3;
            // 
            // dgvWriters
            // 
            dgvWriters.AllowUserToAddRows = false;
            dgvWriters.AllowUserToDeleteRows = false;
            dgvWriters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWriters.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvWriters.Dock = DockStyle.Top;
            dgvWriters.Location = new Point(0, 25);
            dgvWriters.Name = "dgvWriters";
            dgvWriters.ReadOnly = true;
            dgvWriters.RowHeadersWidth = 62;
            dgvWriters.Size = new Size(365, 163);
            dgvWriters.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Id";
            dataGridViewTextBoxColumn3.MinimumWidth = 8;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Name";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Top;
            label15.Font = new Font("Segoe UI", 13F);
            label15.Location = new Point(0, 0);
            label15.Name = "label15";
            label15.Size = new Size(68, 25);
            label15.TabIndex = 5;
            label15.Text = "Writers";
            // 
            // panel7
            // 
            panel7.Controls.Add(dgvDirectors);
            panel7.Controls.Add(label14);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(5, 1576);
            panel7.Name = "panel7";
            panel7.Size = new Size(365, 225);
            panel7.TabIndex = 2;
            // 
            // dgvDirectors
            // 
            dgvDirectors.AllowUserToAddRows = false;
            dgvDirectors.AllowUserToDeleteRows = false;
            dgvDirectors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirectors.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dgvDirectors.Dock = DockStyle.Top;
            dgvDirectors.Location = new Point(0, 25);
            dgvDirectors.Name = "dgvDirectors";
            dgvDirectors.ReadOnly = true;
            dgvDirectors.RowHeadersWidth = 62;
            dgvDirectors.Size = new Size(365, 170);
            dgvDirectors.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Top;
            label14.Font = new Font("Segoe UI", 13F);
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(83, 25);
            label14.TabIndex = 3;
            label14.Text = "Directors";
            // 
            // panel6
            // 
            panel6.Controls.Add(dgvCreators);
            panel6.Controls.Add(label13);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(5, 1362);
            panel6.Name = "panel6";
            panel6.Size = new Size(365, 214);
            panel6.TabIndex = 1;
            // 
            // dgvCreators
            // 
            dgvCreators.AllowUserToAddRows = false;
            dgvCreators.AllowUserToDeleteRows = false;
            dgvCreators.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCreators.Columns.AddRange(new DataGridViewColumn[] { cId, cName });
            dgvCreators.Dock = DockStyle.Top;
            dgvCreators.Location = new Point(0, 25);
            dgvCreators.Name = "dgvCreators";
            dgvCreators.ReadOnly = true;
            dgvCreators.RowHeadersWidth = 62;
            dgvCreators.Size = new Size(365, 170);
            dgvCreators.TabIndex = 2;
            // 
            // cId
            // 
            cId.HeaderText = "Id";
            cId.MinimumWidth = 8;
            cId.Name = "cId";
            cId.ReadOnly = true;
            cId.Width = 150;
            // 
            // cName
            // 
            cName.HeaderText = "Name";
            cName.MinimumWidth = 8;
            cName.Name = "cName";
            cName.ReadOnly = true;
            cName.Width = 150;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Top;
            label13.Font = new Font("Segoe UI", 13F);
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(78, 25);
            label13.TabIndex = 1;
            label13.Text = "Creators";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveBorder;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(flowLayoutPanel1);
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(5, 139);
            panel5.Margin = new Padding(3, 5, 3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(365, 1223);
            panel5.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tableLayoutPanel3);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel27);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel4);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel7);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel6);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel5);
            flowLayoutPanel1.Controls.Add(imgPreviewPoster);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel8);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel9);
            flowLayoutPanel1.Controls.Add(cbIsTVShows);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 25);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(363, 1196);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(tbMovieId, 0, 1);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel3.Size = new Size(327, 56);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Left;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(20, 25);
            label4.TabIndex = 1;
            label4.Text = "Id:";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbMovieId
            // 
            tbMovieId.Dock = DockStyle.Fill;
            tbMovieId.Location = new Point(3, 28);
            tbMovieId.Name = "tbMovieId";
            tbMovieId.Size = new Size(321, 23);
            tbMovieId.TabIndex = 2;
            // 
            // tableLayoutPanel27
            // 
            tableLayoutPanel27.ColumnCount = 1;
            tableLayoutPanel27.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel27.Controls.Add(label36, 0, 0);
            tableLayoutPanel27.Controls.Add(tbMovieName, 0, 1);
            tableLayoutPanel27.Location = new Point(3, 65);
            tableLayoutPanel27.Name = "tableLayoutPanel27";
            tableLayoutPanel27.RowCount = 2;
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel27.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel27.Size = new Size(327, 56);
            tableLayoutPanel27.TabIndex = 3;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Dock = DockStyle.Left;
            label36.Location = new Point(3, 0);
            label36.Name = "label36";
            label36.Size = new Size(78, 25);
            label36.TabIndex = 1;
            label36.Text = "Movie Name:";
            label36.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbMovieName
            // 
            tbMovieName.Dock = DockStyle.Fill;
            tbMovieName.Location = new Point(3, 28);
            tbMovieName.Name = "tbMovieName";
            tbMovieName.Size = new Size(321, 23);
            tbMovieName.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(dtpReleaseDate, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 127);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel1.Size = new Size(327, 56);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 1;
            label2.Text = "Release Date:";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Dock = DockStyle.Fill;
            dtpReleaseDate.Format = DateTimePickerFormat.Short;
            dtpReleaseDate.Location = new Point(3, 28);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(321, 23);
            dtpReleaseDate.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(tbDuration, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 189);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel2.Size = new Size(327, 56);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 1;
            label3.Text = "Duration:";
            label3.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbDuration
            // 
            tbDuration.Dock = DockStyle.Fill;
            tbDuration.Location = new Point(3, 28);
            tbDuration.Name = "tbDuration";
            tbDuration.Size = new Size(321, 23);
            tbDuration.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Controls.Add(cbbContentRating, 0, 1);
            tableLayoutPanel4.Location = new Point(3, 251);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel4.Size = new Size(327, 56);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 1;
            label5.Text = "Content Rating:";
            label5.TextAlign = ContentAlignment.BottomLeft;
            // 
            // cbbContentRating
            // 
            cbbContentRating.Dock = DockStyle.Fill;
            cbbContentRating.FormattingEnabled = true;
            cbbContentRating.Location = new Point(3, 28);
            cbbContentRating.Name = "cbbContentRating";
            cbbContentRating.Size = new Size(321, 23);
            cbbContentRating.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(label8, 0, 0);
            tableLayoutPanel7.Controls.Add(tbIMDbScore, 0, 1);
            tableLayoutPanel7.Location = new Point(3, 313);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel7.Size = new Size(327, 56);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Left;
            label8.Location = new Point(3, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 25);
            label8.TabIndex = 1;
            label8.Text = "IMDb Score:";
            label8.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbIMDbScore
            // 
            tbIMDbScore.Dock = DockStyle.Fill;
            tbIMDbScore.Location = new Point(3, 28);
            tbIMDbScore.Name = "tbIMDbScore";
            tbIMDbScore.Size = new Size(321, 23);
            tbIMDbScore.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(label7, 0, 0);
            tableLayoutPanel6.Controls.Add(tbRatingCount, 0, 1);
            tableLayoutPanel6.Location = new Point(3, 375);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel6.Size = new Size(327, 56);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Left;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 25);
            label7.TabIndex = 1;
            label7.Text = "Rating Count:";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbRatingCount
            // 
            tbRatingCount.Dock = DockStyle.Fill;
            tbRatingCount.Location = new Point(3, 28);
            tbRatingCount.Name = "tbRatingCount";
            tbRatingCount.Size = new Size(321, 23);
            tbRatingCount.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Controls.Add(tbPosterURL, 0, 1);
            tableLayoutPanel5.Location = new Point(3, 437);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel5.Size = new Size(327, 56);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Left;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 1;
            label6.Text = "Poster URL:";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbPosterURL
            // 
            tbPosterURL.Dock = DockStyle.Fill;
            tbPosterURL.Location = new Point(3, 28);
            tbPosterURL.Name = "tbPosterURL";
            tbPosterURL.Size = new Size(321, 23);
            tbPosterURL.TabIndex = 2;
            // 
            // imgPreviewPoster
            // 
            imgPreviewPoster.Location = new Point(3, 499);
            imgPreviewPoster.Name = "imgPreviewPoster";
            imgPreviewPoster.Size = new Size(359, 226);
            imgPreviewPoster.SizeMode = PictureBoxSizeMode.Zoom;
            imgPreviewPoster.TabIndex = 4;
            imgPreviewPoster.TabStop = false;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(label9, 0, 0);
            tableLayoutPanel8.Controls.Add(wmpPreviewTrailer, 0, 2);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel31, 0, 1);
            tableLayoutPanel8.Location = new Point(3, 731);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 47.61905F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 52.38095F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 173F));
            tableLayoutPanel8.Size = new Size(356, 224);
            tableLayoutPanel8.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Left;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(65, 24);
            label9.TabIndex = 1;
            label9.Text = "Trailer URL:";
            label9.TextAlign = ContentAlignment.BottomLeft;
            // 
            // wmpPreviewTrailer
            // 
            wmpPreviewTrailer.Dock = DockStyle.Fill;
            wmpPreviewTrailer.Enabled = true;
            wmpPreviewTrailer.Location = new Point(3, 53);
            wmpPreviewTrailer.Name = "wmpPreviewTrailer";
            wmpPreviewTrailer.OcxState = (AxHost.State)resources.GetObject("wmpPreviewTrailer.OcxState");
            wmpPreviewTrailer.Size = new Size(350, 168);
            wmpPreviewTrailer.TabIndex = 5;
            // 
            // tableLayoutPanel31
            // 
            tableLayoutPanel31.ColumnCount = 2;
            tableLayoutPanel31.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.5228653F));
            tableLayoutPanel31.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.4771366F));
            tableLayoutPanel31.Controls.Add(tbTrailerURL, 0, 0);
            tableLayoutPanel31.Controls.Add(btnLoadTrailer, 1, 0);
            tableLayoutPanel31.Dock = DockStyle.Fill;
            tableLayoutPanel31.Location = new Point(2, 26);
            tableLayoutPanel31.Margin = new Padding(2);
            tableLayoutPanel31.Name = "tableLayoutPanel31";
            tableLayoutPanel31.RowCount = 1;
            tableLayoutPanel31.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel31.Size = new Size(352, 22);
            tableLayoutPanel31.TabIndex = 6;
            // 
            // tbTrailerURL
            // 
            tbTrailerURL.Dock = DockStyle.Fill;
            tbTrailerURL.Location = new Point(3, 3);
            tbTrailerURL.Name = "tbTrailerURL";
            tbTrailerURL.Size = new Size(273, 23);
            tbTrailerURL.TabIndex = 3;
            // 
            // btnLoadTrailer
            // 
            btnLoadTrailer.Location = new Point(281, 2);
            btnLoadTrailer.Margin = new Padding(2);
            btnLoadTrailer.Name = "btnLoadTrailer";
            btnLoadTrailer.Size = new Size(68, 18);
            btnLoadTrailer.TabIndex = 4;
            btnLoadTrailer.Text = "Load";
            btnLoadTrailer.UseVisualStyleBackColor = true;
            btnLoadTrailer.Click += btnLoadTrailer_Click;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(label10, 0, 0);
            tableLayoutPanel9.Controls.Add(tbDescription, 0, 1);
            tableLayoutPanel9.Location = new Point(3, 961);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 18.84058F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 81.1594238F));
            tableLayoutPanel9.Size = new Size(359, 138);
            tableLayoutPanel9.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Left;
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(70, 26);
            label10.TabIndex = 1;
            label10.Text = "Description:";
            label10.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbDescription
            // 
            tbDescription.Dock = DockStyle.Fill;
            tbDescription.Location = new Point(3, 29);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(353, 106);
            tbDescription.TabIndex = 2;
            // 
            // cbIsTVShows
            // 
            cbIsTVShows.AutoSize = true;
            cbIsTVShows.Location = new Point(3, 1105);
            cbIsTVShows.Name = "cbIsTVShows";
            cbIsTVShows.Size = new Size(76, 19);
            cbIsTVShows.TabIndex = 6;
            cbIsTVShows.Text = "TV Shows";
            cbIsTVShows.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 0;
            label1.Text = "Movie Data Entry";
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.ControlDark;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(tableLayoutPanel11);
            panel11.Controls.Add(tableLayoutPanel10);
            panel11.Controls.Add(label11);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(5, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(365, 139);
            panel11.TabIndex = 6;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.7534256F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.2465744F));
            tableLayoutPanel11.Controls.Add(btnGetDataUrl, 0, 0);
            tableLayoutPanel11.Controls.Add(btnGoToWeb, 1, 0);
            tableLayoutPanel11.Dock = DockStyle.Top;
            tableLayoutPanel11.Location = new Point(0, 92);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(363, 34);
            tableLayoutPanel11.TabIndex = 4;
            // 
            // btnGetDataUrl
            // 
            btnGetDataUrl.Dock = DockStyle.Left;
            btnGetDataUrl.Location = new Point(3, 3);
            btnGetDataUrl.Name = "btnGetDataUrl";
            btnGetDataUrl.Size = new Size(75, 28);
            btnGetDataUrl.TabIndex = 0;
            btnGetDataUrl.Text = "Get Data";
            btnGetDataUrl.UseVisualStyleBackColor = true;
            btnGetDataUrl.Click += btnGetDataUrl_Click;
            // 
            // btnGoToWeb
            // 
            btnGoToWeb.Dock = DockStyle.Left;
            btnGoToWeb.Location = new Point(96, 3);
            btnGoToWeb.Name = "btnGoToWeb";
            btnGoToWeb.Size = new Size(114, 28);
            btnGoToWeb.TabIndex = 1;
            btnGoToWeb.Text = "Go to website";
            btnGoToWeb.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(label12, 0, 0);
            tableLayoutPanel10.Controls.Add(tbIMDbURL, 0, 1);
            tableLayoutPanel10.Dock = DockStyle.Top;
            tableLayoutPanel10.Location = new Point(0, 25);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel10.Size = new Size(363, 67);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Left;
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(63, 29);
            label12.TabIndex = 1;
            label12.Text = "IMDb URL:";
            label12.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbIMDbURL
            // 
            tbIMDbURL.Dock = DockStyle.Fill;
            tbIMDbURL.Location = new Point(3, 32);
            tbIMDbURL.Name = "tbIMDbURL";
            tbIMDbURL.Size = new Size(357, 23);
            tbIMDbURL.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Top;
            label11.Font = new Font("Segoe UI", 13F);
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(178, 25);
            label11.TabIndex = 1;
            label11.Text = "Get Data From IMDb";
            // 
            // panel9
            // 
            panel9.Controls.Add(dgvSeasons);
            panel9.Controls.Add(label16);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(1313, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(303, 647);
            panel9.TabIndex = 4;
            // 
            // dgvSeasons
            // 
            dgvSeasons.AllowUserToAddRows = false;
            dgvSeasons.AllowUserToDeleteRows = false;
            dgvSeasons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSeasons.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, cSeasonEdit });
            dgvSeasons.Dock = DockStyle.Fill;
            dgvSeasons.Location = new Point(0, 25);
            dgvSeasons.Name = "dgvSeasons";
            dgvSeasons.ReadOnly = true;
            dgvSeasons.RowHeadersWidth = 62;
            dgvSeasons.Size = new Size(303, 622);
            dgvSeasons.TabIndex = 8;
            dgvSeasons.CellContentClick += dgvSeasons_CellContentClick;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "#";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Name";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // cSeasonEdit
            // 
            cSeasonEdit.HeaderText = "Edit";
            cSeasonEdit.MinimumWidth = 8;
            cSeasonEdit.Name = "cSeasonEdit";
            cSeasonEdit.ReadOnly = true;
            cSeasonEdit.Text = "Edit";
            cSeasonEdit.Width = 150;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Top;
            label16.Font = new Font("Segoe UI", 13F);
            label16.Location = new Point(0, 0);
            label16.Name = "label16";
            label16.Size = new Size(77, 25);
            label16.TabIndex = 7;
            label16.Text = "Seasons";
            // 
            // panel12
            // 
            panel12.Controls.Add(dgvEpisodes);
            panel12.Controls.Add(label17);
            panel12.Dock = DockStyle.Left;
            panel12.Location = new Point(1945, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(1139, 647);
            panel12.TabIndex = 5;
            // 
            // dgvEpisodes
            // 
            dgvEpisodes.AllowUserToAddRows = false;
            dgvEpisodes.AllowUserToDeleteRows = false;
            dgvEpisodes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEpisodes.Columns.AddRange(new DataGridViewColumn[] { cEpId, cNumber, cEpReleaseDate, cEpDuration, cEpImage, cPreviewImage, cEpTitle, cEpAggregateRating, cEpVoteCount, cEpEdit, cEpDel });
            dgvEpisodes.Dock = DockStyle.Fill;
            dgvEpisodes.Location = new Point(0, 25);
            dgvEpisodes.Name = "dgvEpisodes";
            dgvEpisodes.ReadOnly = true;
            dgvEpisodes.RowHeadersWidth = 62;
            dgvEpisodes.RowTemplate.Height = 100;
            dgvEpisodes.Size = new Size(1139, 622);
            dgvEpisodes.TabIndex = 8;
            dgvEpisodes.CellContentClick += dgvEpisodes_CellContentClick;
            // 
            // cEpId
            // 
            cEpId.HeaderText = "Id";
            cEpId.MinimumWidth = 8;
            cEpId.Name = "cEpId";
            cEpId.ReadOnly = true;
            cEpId.Width = 150;
            // 
            // cNumber
            // 
            cNumber.HeaderText = "Number";
            cNumber.MinimumWidth = 8;
            cNumber.Name = "cNumber";
            cNumber.ReadOnly = true;
            cNumber.Width = 150;
            // 
            // cEpReleaseDate
            // 
            cEpReleaseDate.HeaderText = "Release Date";
            cEpReleaseDate.MinimumWidth = 8;
            cEpReleaseDate.Name = "cEpReleaseDate";
            cEpReleaseDate.ReadOnly = true;
            cEpReleaseDate.Width = 150;
            // 
            // cEpDuration
            // 
            cEpDuration.HeaderText = "Duration (s)";
            cEpDuration.MinimumWidth = 8;
            cEpDuration.Name = "cEpDuration";
            cEpDuration.ReadOnly = true;
            cEpDuration.Width = 150;
            // 
            // cEpImage
            // 
            cEpImage.HeaderText = "Image";
            cEpImage.MinimumWidth = 8;
            cEpImage.Name = "cEpImage";
            cEpImage.ReadOnly = true;
            cEpImage.Width = 150;
            // 
            // cPreviewImage
            // 
            cPreviewImage.HeaderText = "Preview Image";
            cPreviewImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            cPreviewImage.MinimumWidth = 8;
            cPreviewImage.Name = "cPreviewImage";
            cPreviewImage.ReadOnly = true;
            cPreviewImage.Width = 200;
            // 
            // cEpTitle
            // 
            cEpTitle.HeaderText = "Title";
            cEpTitle.MinimumWidth = 8;
            cEpTitle.Name = "cEpTitle";
            cEpTitle.ReadOnly = true;
            cEpTitle.Width = 150;
            // 
            // cEpAggregateRating
            // 
            cEpAggregateRating.HeaderText = "Aggregate Rating";
            cEpAggregateRating.MinimumWidth = 8;
            cEpAggregateRating.Name = "cEpAggregateRating";
            cEpAggregateRating.ReadOnly = true;
            cEpAggregateRating.Width = 150;
            // 
            // cEpVoteCount
            // 
            cEpVoteCount.HeaderText = "Vote Count";
            cEpVoteCount.MinimumWidth = 8;
            cEpVoteCount.Name = "cEpVoteCount";
            cEpVoteCount.ReadOnly = true;
            cEpVoteCount.Width = 150;
            // 
            // cEpEdit
            // 
            cEpEdit.HeaderText = "Edit";
            cEpEdit.MinimumWidth = 8;
            cEpEdit.Name = "cEpEdit";
            cEpEdit.ReadOnly = true;
            cEpEdit.Text = "Edit";
            cEpEdit.Width = 150;
            // 
            // cEpDel
            // 
            cEpDel.HeaderText = "Del";
            cEpDel.MinimumWidth = 8;
            cEpDel.Name = "cEpDel";
            cEpDel.ReadOnly = true;
            cEpDel.Width = 150;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = DockStyle.Top;
            label17.Font = new Font("Segoe UI", 13F);
            label17.Location = new Point(0, 0);
            label17.Name = "label17";
            label17.Size = new Size(83, 25);
            label17.TabIndex = 7;
            label17.Text = "Episodes";
            // 
            // panel13
            // 
            panel13.Controls.Add(panel14);
            panel13.Dock = DockStyle.Left;
            panel13.Location = new Point(1616, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(329, 647);
            panel13.TabIndex = 6;
            // 
            // panel14
            // 
            panel14.BackColor = SystemColors.ControlDark;
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(btnSubmitEpisodes);
            panel14.Controls.Add(tableLayoutPanel13);
            panel14.Controls.Add(tableLayoutPanel14);
            panel14.Controls.Add(label19);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(329, 467);
            panel14.TabIndex = 7;
            // 
            // btnSubmitEpisodes
            // 
            btnSubmitEpisodes.Location = new Point(3, 397);
            btnSubmitEpisodes.Name = "btnSubmitEpisodes";
            btnSubmitEpisodes.Size = new Size(75, 23);
            btnSubmitEpisodes.TabIndex = 5;
            btnSubmitEpisodes.Text = "Submit";
            btnSubmitEpisodes.UseVisualStyleBackColor = true;
            btnSubmitEpisodes.Click += btnSubmitEpisodes_Click;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.92049F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.07951F));
            tableLayoutPanel13.Controls.Add(btnResolveHTML, 0, 0);
            tableLayoutPanel13.Controls.Add(btnRefreshEpisodes, 1, 0);
            tableLayoutPanel13.Dock = DockStyle.Top;
            tableLayoutPanel13.Location = new Point(0, 360);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(327, 34);
            tableLayoutPanel13.TabIndex = 4;
            // 
            // btnResolveHTML
            // 
            btnResolveHTML.Dock = DockStyle.Left;
            btnResolveHTML.Location = new Point(3, 3);
            btnResolveHTML.Name = "btnResolveHTML";
            btnResolveHTML.Size = new Size(106, 28);
            btnResolveHTML.TabIndex = 0;
            btnResolveHTML.Text = "Resolve HTML";
            btnResolveHTML.UseVisualStyleBackColor = true;
            btnResolveHTML.Click += btnResolveHTML_Click;
            // 
            // btnRefreshEpisodes
            // 
            btnRefreshEpisodes.Dock = DockStyle.Left;
            btnRefreshEpisodes.Location = new Point(127, 3);
            btnRefreshEpisodes.Name = "btnRefreshEpisodes";
            btnRefreshEpisodes.Size = new Size(75, 28);
            btnRefreshEpisodes.TabIndex = 1;
            btnRefreshEpisodes.Text = "Refresh";
            btnRefreshEpisodes.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 1;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel14.Controls.Add(label18, 0, 0);
            tableLayoutPanel14.Controls.Add(tbEpisodeHTML, 0, 1);
            tableLayoutPanel14.Dock = DockStyle.Top;
            tableLayoutPanel14.Location = new Point(0, 25);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 2;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 9.850746F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 90.1492538F));
            tableLayoutPanel14.Size = new Size(327, 335);
            tableLayoutPanel14.TabIndex = 3;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Dock = DockStyle.Left;
            label18.Location = new Point(3, 0);
            label18.Name = "label18";
            label18.Size = new Size(73, 33);
            label18.TabIndex = 1;
            label18.Text = "HTML Input:";
            label18.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbEpisodeHTML
            // 
            tbEpisodeHTML.Dock = DockStyle.Fill;
            tbEpisodeHTML.Location = new Point(3, 36);
            tbEpisodeHTML.MaxLength = 200767;
            tbEpisodeHTML.Multiline = true;
            tbEpisodeHTML.Name = "tbEpisodeHTML";
            tbEpisodeHTML.ScrollBars = ScrollBars.Vertical;
            tbEpisodeHTML.Size = new Size(321, 296);
            tbEpisodeHTML.TabIndex = 2;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Dock = DockStyle.Top;
            label19.Font = new Font("Segoe UI", 13F);
            label19.Location = new Point(0, 0);
            label19.Name = "label19";
            label19.Size = new Size(179, 25);
            label19.TabIndex = 1;
            label19.Text = "Get Data From HTML";
            // 
            // panel15
            // 
            panel15.AutoScroll = true;
            panel15.Controls.Add(panel16);
            panel15.Controls.Add(panel25);
            panel15.Dock = DockStyle.Left;
            panel15.Location = new Point(3084, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(368, 647);
            panel15.TabIndex = 7;
            // 
            // panel16
            // 
            panel16.BackColor = SystemColors.ActiveBorder;
            panel16.BorderStyle = BorderStyle.FixedSingle;
            panel16.Controls.Add(flowLayoutPanel2);
            panel16.Controls.Add(label29);
            panel16.Dock = DockStyle.Top;
            panel16.Location = new Point(0, 139);
            panel16.Margin = new Padding(3, 5, 3, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(351, 1165);
            panel16.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(tableLayoutPanel15);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel28);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel25);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel16);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel17);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel19);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel20);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel21);
            flowLayoutPanel2.Controls.Add(imgEpPreviewImage);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel23);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel24);
            flowLayoutPanel2.Controls.Add(tableLayoutPanel18);
            flowLayoutPanel2.Location = new Point(0, 25);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(366, 1105);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 1;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.Controls.Add(label20, 0, 0);
            tableLayoutPanel15.Controls.Add(tbEpId, 0, 1);
            tableLayoutPanel15.Location = new Point(3, 3);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 2;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel15.Size = new Size(327, 56);
            tableLayoutPanel15.TabIndex = 3;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Dock = DockStyle.Left;
            label20.Location = new Point(3, 0);
            label20.Name = "label20";
            label20.Size = new Size(20, 25);
            label20.TabIndex = 1;
            label20.Text = "Id:";
            label20.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbEpId
            // 
            tbEpId.Dock = DockStyle.Fill;
            tbEpId.Location = new Point(3, 28);
            tbEpId.Name = "tbEpId";
            tbEpId.Size = new Size(321, 23);
            tbEpId.TabIndex = 2;
            // 
            // tableLayoutPanel28
            // 
            tableLayoutPanel28.ColumnCount = 1;
            tableLayoutPanel28.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel28.Controls.Add(label37, 0, 0);
            tableLayoutPanel28.Controls.Add(tbEpisode, 0, 1);
            tableLayoutPanel28.Location = new Point(3, 65);
            tableLayoutPanel28.Name = "tableLayoutPanel28";
            tableLayoutPanel28.RowCount = 2;
            tableLayoutPanel28.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel28.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel28.Size = new Size(327, 56);
            tableLayoutPanel28.TabIndex = 3;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Dock = DockStyle.Left;
            label37.Location = new Point(3, 0);
            label37.Name = "label37";
            label37.Size = new Size(51, 25);
            label37.TabIndex = 1;
            label37.Text = "Episode:";
            label37.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbEpisode
            // 
            tbEpisode.Dock = DockStyle.Fill;
            tbEpisode.Location = new Point(3, 28);
            tbEpisode.Name = "tbEpisode";
            tbEpisode.Size = new Size(321, 23);
            tbEpisode.TabIndex = 2;
            // 
            // tableLayoutPanel25
            // 
            tableLayoutPanel25.ColumnCount = 1;
            tableLayoutPanel25.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel25.Controls.Add(label31, 0, 0);
            tableLayoutPanel25.Controls.Add(tbEpTitle, 0, 1);
            tableLayoutPanel25.Location = new Point(3, 127);
            tableLayoutPanel25.Name = "tableLayoutPanel25";
            tableLayoutPanel25.RowCount = 2;
            tableLayoutPanel25.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel25.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel25.Size = new Size(327, 56);
            tableLayoutPanel25.TabIndex = 3;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Dock = DockStyle.Left;
            label31.Location = new Point(3, 0);
            label31.Name = "label31";
            label31.Size = new Size(32, 25);
            label31.TabIndex = 1;
            label31.Text = "Title:";
            label31.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbEpTitle
            // 
            tbEpTitle.Dock = DockStyle.Fill;
            tbEpTitle.Location = new Point(3, 28);
            tbEpTitle.Name = "tbEpTitle";
            tbEpTitle.Size = new Size(321, 23);
            tbEpTitle.TabIndex = 2;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 1;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel16.Controls.Add(label21, 0, 0);
            tableLayoutPanel16.Controls.Add(dtpEpReleaseDate, 0, 1);
            tableLayoutPanel16.Location = new Point(3, 189);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 2;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel16.Size = new Size(327, 56);
            tableLayoutPanel16.TabIndex = 3;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Dock = DockStyle.Left;
            label21.Location = new Point(3, 0);
            label21.Name = "label21";
            label21.Size = new Size(76, 25);
            label21.TabIndex = 1;
            label21.Text = "Release Date:";
            label21.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dtpEpReleaseDate
            // 
            dtpEpReleaseDate.Dock = DockStyle.Fill;
            dtpEpReleaseDate.Format = DateTimePickerFormat.Short;
            dtpEpReleaseDate.Location = new Point(3, 28);
            dtpEpReleaseDate.Name = "dtpEpReleaseDate";
            dtpEpReleaseDate.Size = new Size(321, 23);
            dtpEpReleaseDate.TabIndex = 2;
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.ColumnCount = 1;
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel17.Controls.Add(label22, 0, 0);
            tableLayoutPanel17.Controls.Add(tbEpDuration, 0, 1);
            tableLayoutPanel17.Location = new Point(3, 251);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.RowCount = 2;
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel17.Size = new Size(327, 56);
            tableLayoutPanel17.TabIndex = 3;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Dock = DockStyle.Left;
            label22.Location = new Point(3, 0);
            label22.Name = "label22";
            label22.Size = new Size(56, 25);
            label22.TabIndex = 1;
            label22.Text = "Duration:";
            label22.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbEpDuration
            // 
            tbEpDuration.Dock = DockStyle.Fill;
            tbEpDuration.Location = new Point(3, 28);
            tbEpDuration.Name = "tbEpDuration";
            tbEpDuration.Size = new Size(321, 23);
            tbEpDuration.TabIndex = 2;
            // 
            // tableLayoutPanel19
            // 
            tableLayoutPanel19.ColumnCount = 1;
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel19.Controls.Add(label24, 0, 0);
            tableLayoutPanel19.Controls.Add(tbEpAggregateRating, 0, 1);
            tableLayoutPanel19.Location = new Point(3, 313);
            tableLayoutPanel19.Name = "tableLayoutPanel19";
            tableLayoutPanel19.RowCount = 2;
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel19.Size = new Size(327, 56);
            tableLayoutPanel19.TabIndex = 3;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Dock = DockStyle.Left;
            label24.Location = new Point(3, 0);
            label24.Name = "label24";
            label24.Size = new Size(71, 25);
            label24.TabIndex = 1;
            label24.Text = "IMDb Score:";
            label24.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbEpAggregateRating
            // 
            tbEpAggregateRating.Dock = DockStyle.Fill;
            tbEpAggregateRating.Location = new Point(3, 28);
            tbEpAggregateRating.Name = "tbEpAggregateRating";
            tbEpAggregateRating.Size = new Size(321, 23);
            tbEpAggregateRating.TabIndex = 2;
            // 
            // tableLayoutPanel20
            // 
            tableLayoutPanel20.ColumnCount = 1;
            tableLayoutPanel20.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel20.Controls.Add(label25, 0, 0);
            tableLayoutPanel20.Controls.Add(tbEpVoteCount, 0, 1);
            tableLayoutPanel20.Location = new Point(3, 375);
            tableLayoutPanel20.Name = "tableLayoutPanel20";
            tableLayoutPanel20.RowCount = 2;
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel20.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel20.Size = new Size(327, 56);
            tableLayoutPanel20.TabIndex = 3;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Dock = DockStyle.Left;
            label25.Location = new Point(3, 0);
            label25.Name = "label25";
            label25.Size = new Size(80, 25);
            label25.TabIndex = 1;
            label25.Text = "Rating Count:";
            label25.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbEpVoteCount
            // 
            tbEpVoteCount.Dock = DockStyle.Fill;
            tbEpVoteCount.Location = new Point(3, 28);
            tbEpVoteCount.Name = "tbEpVoteCount";
            tbEpVoteCount.Size = new Size(321, 23);
            tbEpVoteCount.TabIndex = 2;
            // 
            // tableLayoutPanel21
            // 
            tableLayoutPanel21.ColumnCount = 1;
            tableLayoutPanel21.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel21.Controls.Add(label26, 0, 0);
            tableLayoutPanel21.Controls.Add(tbEpImage, 0, 1);
            tableLayoutPanel21.Location = new Point(3, 437);
            tableLayoutPanel21.Name = "tableLayoutPanel21";
            tableLayoutPanel21.RowCount = 2;
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel21.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel21.Size = new Size(327, 56);
            tableLayoutPanel21.TabIndex = 3;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Dock = DockStyle.Left;
            label26.Location = new Point(3, 0);
            label26.Name = "label26";
            label26.Size = new Size(67, 25);
            label26.TabIndex = 1;
            label26.Text = "Image URL:";
            label26.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbEpImage
            // 
            tbEpImage.Dock = DockStyle.Fill;
            tbEpImage.Location = new Point(3, 28);
            tbEpImage.Name = "tbEpImage";
            tbEpImage.Size = new Size(321, 23);
            tbEpImage.TabIndex = 2;
            // 
            // imgEpPreviewImage
            // 
            imgEpPreviewImage.Image = Properties.Resources.Oppenheimer;
            imgEpPreviewImage.Location = new Point(3, 499);
            imgEpPreviewImage.Name = "imgEpPreviewImage";
            imgEpPreviewImage.Size = new Size(359, 226);
            imgEpPreviewImage.SizeMode = PictureBoxSizeMode.Zoom;
            imgEpPreviewImage.TabIndex = 4;
            imgEpPreviewImage.TabStop = false;
            // 
            // tableLayoutPanel23
            // 
            tableLayoutPanel23.ColumnCount = 1;
            tableLayoutPanel23.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel23.Controls.Add(label28, 0, 0);
            tableLayoutPanel23.Controls.Add(tbEpImageCaption, 0, 1);
            tableLayoutPanel23.Location = new Point(3, 731);
            tableLayoutPanel23.Name = "tableLayoutPanel23";
            tableLayoutPanel23.RowCount = 2;
            tableLayoutPanel23.RowStyles.Add(new RowStyle(SizeType.Percent, 18.84058F));
            tableLayoutPanel23.RowStyles.Add(new RowStyle(SizeType.Percent, 81.1594238F));
            tableLayoutPanel23.Size = new Size(359, 138);
            tableLayoutPanel23.TabIndex = 3;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Dock = DockStyle.Left;
            label28.Location = new Point(3, 0);
            label28.Name = "label28";
            label28.Size = new Size(88, 26);
            label28.TabIndex = 1;
            label28.Text = "Image Caption:";
            label28.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbEpImageCaption
            // 
            tbEpImageCaption.Dock = DockStyle.Fill;
            tbEpImageCaption.Location = new Point(3, 29);
            tbEpImageCaption.Multiline = true;
            tbEpImageCaption.Name = "tbEpImageCaption";
            tbEpImageCaption.Size = new Size(353, 106);
            tbEpImageCaption.TabIndex = 2;
            // 
            // tableLayoutPanel24
            // 
            tableLayoutPanel24.ColumnCount = 1;
            tableLayoutPanel24.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel24.Controls.Add(label30, 0, 0);
            tableLayoutPanel24.Controls.Add(tbEpPlot, 0, 1);
            tableLayoutPanel24.Location = new Point(3, 875);
            tableLayoutPanel24.Name = "tableLayoutPanel24";
            tableLayoutPanel24.RowCount = 2;
            tableLayoutPanel24.RowStyles.Add(new RowStyle(SizeType.Percent, 18.84058F));
            tableLayoutPanel24.RowStyles.Add(new RowStyle(SizeType.Percent, 81.1594238F));
            tableLayoutPanel24.Size = new Size(359, 138);
            tableLayoutPanel24.TabIndex = 3;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Dock = DockStyle.Left;
            label30.Location = new Point(3, 0);
            label30.Name = "label30";
            label30.Size = new Size(31, 26);
            label30.TabIndex = 1;
            label30.Text = "Plot:";
            label30.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbEpPlot
            // 
            tbEpPlot.Dock = DockStyle.Fill;
            tbEpPlot.Location = new Point(3, 29);
            tbEpPlot.Multiline = true;
            tbEpPlot.Name = "tbEpPlot";
            tbEpPlot.Size = new Size(353, 106);
            tbEpPlot.TabIndex = 2;
            // 
            // tableLayoutPanel18
            // 
            tableLayoutPanel18.ColumnCount = 2;
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.50562F));
            tableLayoutPanel18.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.49438F));
            tableLayoutPanel18.Controls.Add(btnEpSubmit, 0, 0);
            tableLayoutPanel18.Controls.Add(btnEpUpdate, 1, 0);
            tableLayoutPanel18.Location = new Point(3, 1019);
            tableLayoutPanel18.Name = "tableLayoutPanel18";
            tableLayoutPanel18.RowCount = 1;
            tableLayoutPanel18.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel18.Size = new Size(356, 45);
            tableLayoutPanel18.TabIndex = 5;
            // 
            // btnEpSubmit
            // 
            btnEpSubmit.Dock = DockStyle.Left;
            btnEpSubmit.Location = new Point(3, 3);
            btnEpSubmit.Name = "btnEpSubmit";
            btnEpSubmit.Size = new Size(112, 39);
            btnEpSubmit.TabIndex = 0;
            btnEpSubmit.Text = "Submit";
            btnEpSubmit.UseVisualStyleBackColor = true;
            // 
            // btnEpUpdate
            // 
            btnEpUpdate.Dock = DockStyle.Left;
            btnEpUpdate.Location = new Point(165, 3);
            btnEpUpdate.Name = "btnEpUpdate";
            btnEpUpdate.Size = new Size(95, 39);
            btnEpUpdate.TabIndex = 1;
            btnEpUpdate.Text = "Update";
            btnEpUpdate.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Dock = DockStyle.Top;
            label29.Font = new Font("Segoe UI", 13F);
            label29.Location = new Point(0, 0);
            label29.Name = "label29";
            label29.Size = new Size(162, 25);
            label29.TabIndex = 0;
            label29.Text = "Episode Data Entry";
            // 
            // panel25
            // 
            panel25.BackColor = SystemColors.ControlDark;
            panel25.BorderStyle = BorderStyle.FixedSingle;
            panel25.Controls.Add(tableLayoutPanel29);
            panel25.Controls.Add(tableLayoutPanel30);
            panel25.Controls.Add(label39);
            panel25.Dock = DockStyle.Top;
            panel25.Location = new Point(0, 0);
            panel25.Name = "panel25";
            panel25.Size = new Size(351, 139);
            panel25.TabIndex = 7;
            // 
            // tableLayoutPanel29
            // 
            tableLayoutPanel29.ColumnCount = 2;
            tableLayoutPanel29.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.7534256F));
            tableLayoutPanel29.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.2465744F));
            tableLayoutPanel29.Controls.Add(btnEpGetData, 0, 0);
            tableLayoutPanel29.Controls.Add(btnEpGoToWebsite, 1, 0);
            tableLayoutPanel29.Dock = DockStyle.Top;
            tableLayoutPanel29.Location = new Point(0, 92);
            tableLayoutPanel29.Name = "tableLayoutPanel29";
            tableLayoutPanel29.RowCount = 1;
            tableLayoutPanel29.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel29.Size = new Size(349, 34);
            tableLayoutPanel29.TabIndex = 4;
            // 
            // btnEpGetData
            // 
            btnEpGetData.Dock = DockStyle.Left;
            btnEpGetData.Location = new Point(3, 3);
            btnEpGetData.Name = "btnEpGetData";
            btnEpGetData.Size = new Size(75, 28);
            btnEpGetData.TabIndex = 0;
            btnEpGetData.Text = "Get Data";
            btnEpGetData.UseVisualStyleBackColor = true;
            btnEpGetData.Click += btnEpGetData_Click;
            // 
            // btnEpGoToWebsite
            // 
            btnEpGoToWebsite.Dock = DockStyle.Left;
            btnEpGoToWebsite.Location = new Point(92, 3);
            btnEpGoToWebsite.Name = "btnEpGoToWebsite";
            btnEpGoToWebsite.Size = new Size(114, 28);
            btnEpGoToWebsite.TabIndex = 1;
            btnEpGoToWebsite.Text = "Go to website";
            btnEpGoToWebsite.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel30
            // 
            tableLayoutPanel30.ColumnCount = 1;
            tableLayoutPanel30.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel30.Controls.Add(label38, 0, 0);
            tableLayoutPanel30.Controls.Add(tbEpURL, 0, 1);
            tableLayoutPanel30.Dock = DockStyle.Top;
            tableLayoutPanel30.Location = new Point(0, 25);
            tableLayoutPanel30.Name = "tableLayoutPanel30";
            tableLayoutPanel30.RowCount = 2;
            tableLayoutPanel30.RowStyles.Add(new RowStyle(SizeType.Percent, 44.6428566F));
            tableLayoutPanel30.RowStyles.Add(new RowStyle(SizeType.Percent, 55.3571434F));
            tableLayoutPanel30.Size = new Size(349, 67);
            tableLayoutPanel30.TabIndex = 3;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Dock = DockStyle.Left;
            label38.Location = new Point(3, 0);
            label38.Name = "label38";
            label38.Size = new Size(107, 29);
            label38.TabIndex = 1;
            label38.Text = "IMDb Episode URL:";
            label38.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbEpURL
            // 
            tbEpURL.Dock = DockStyle.Fill;
            tbEpURL.Location = new Point(3, 32);
            tbEpURL.Name = "tbEpURL";
            tbEpURL.Size = new Size(343, 23);
            tbEpURL.TabIndex = 2;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Dock = DockStyle.Top;
            label39.Font = new Font("Segoe UI", 13F);
            label39.Location = new Point(0, 0);
            label39.Name = "label39";
            label39.Size = new Size(246, 25);
            label39.TabIndex = 1;
            label39.Text = "Get Episode Data From IMDb";
            // 
            // panel17
            // 
            panel17.Controls.Add(panel21);
            panel17.Controls.Add(panel18);
            panel17.Controls.Add(panel19);
            panel17.Controls.Add(panel20);
            panel17.Dock = DockStyle.Left;
            panel17.Location = new Point(3452, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(353, 647);
            panel17.TabIndex = 8;
            // 
            // panel21
            // 
            panel21.Controls.Add(dgvEpGenres);
            panel21.Controls.Add(label33);
            panel21.Dock = DockStyle.Top;
            panel21.Location = new Point(0, 661);
            panel21.Name = "panel21";
            panel21.Size = new Size(353, 222);
            panel21.TabIndex = 7;
            // 
            // dgvEpGenres
            // 
            dgvEpGenres.AllowUserToAddRows = false;
            dgvEpGenres.AllowUserToDeleteRows = false;
            dgvEpGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEpGenres.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14 });
            dgvEpGenres.Dock = DockStyle.Top;
            dgvEpGenres.Location = new Point(0, 25);
            dgvEpGenres.Name = "dgvEpGenres";
            dgvEpGenres.ReadOnly = true;
            dgvEpGenres.RowHeadersWidth = 62;
            dgvEpGenres.Size = new Size(353, 163);
            dgvEpGenres.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "#";
            dataGridViewTextBoxColumn13.MinimumWidth = 8;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Name";
            dataGridViewTextBoxColumn14.MinimumWidth = 8;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            dataGridViewTextBoxColumn14.Width = 150;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Dock = DockStyle.Top;
            label33.Font = new Font("Segoe UI", 13F);
            label33.Location = new Point(0, 0);
            label33.Name = "label33";
            label33.Size = new Size(66, 25);
            label33.TabIndex = 5;
            label33.Text = "Genres";
            // 
            // panel18
            // 
            panel18.Controls.Add(dgvEpWriters);
            panel18.Controls.Add(label23);
            panel18.Dock = DockStyle.Top;
            panel18.Location = new Point(0, 439);
            panel18.Name = "panel18";
            panel18.Size = new Size(353, 222);
            panel18.TabIndex = 6;
            // 
            // dgvEpWriters
            // 
            dgvEpWriters.AllowUserToAddRows = false;
            dgvEpWriters.AllowUserToDeleteRows = false;
            dgvEpWriters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEpWriters.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgvEpWriters.Dock = DockStyle.Top;
            dgvEpWriters.Location = new Point(0, 25);
            dgvEpWriters.Name = "dgvEpWriters";
            dgvEpWriters.ReadOnly = true;
            dgvEpWriters.RowHeadersWidth = 62;
            dgvEpWriters.Size = new Size(353, 163);
            dgvEpWriters.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Id";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Name";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 150;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Dock = DockStyle.Top;
            label23.Font = new Font("Segoe UI", 13F);
            label23.Location = new Point(0, 0);
            label23.Name = "label23";
            label23.Size = new Size(68, 25);
            label23.TabIndex = 5;
            label23.Text = "Writers";
            // 
            // panel19
            // 
            panel19.Controls.Add(dgvEpDirectors);
            panel19.Controls.Add(label27);
            panel19.Dock = DockStyle.Top;
            panel19.Location = new Point(0, 214);
            panel19.Name = "panel19";
            panel19.Size = new Size(353, 225);
            panel19.TabIndex = 5;
            // 
            // dgvEpDirectors
            // 
            dgvEpDirectors.AllowUserToAddRows = false;
            dgvEpDirectors.AllowUserToDeleteRows = false;
            dgvEpDirectors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEpDirectors.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dgvEpDirectors.Dock = DockStyle.Top;
            dgvEpDirectors.Location = new Point(0, 25);
            dgvEpDirectors.Name = "dgvEpDirectors";
            dgvEpDirectors.ReadOnly = true;
            dgvEpDirectors.RowHeadersWidth = 62;
            dgvEpDirectors.Size = new Size(353, 170);
            dgvEpDirectors.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Id";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Name";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 150;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Dock = DockStyle.Top;
            label27.Font = new Font("Segoe UI", 13F);
            label27.Location = new Point(0, 0);
            label27.Name = "label27";
            label27.Size = new Size(83, 25);
            label27.TabIndex = 3;
            label27.Text = "Directors";
            // 
            // panel20
            // 
            panel20.Controls.Add(dgvEpCreators);
            panel20.Controls.Add(label32);
            panel20.Dock = DockStyle.Top;
            panel20.Location = new Point(0, 0);
            panel20.Name = "panel20";
            panel20.Size = new Size(353, 214);
            panel20.TabIndex = 4;
            // 
            // dgvEpCreators
            // 
            dgvEpCreators.AllowUserToAddRows = false;
            dgvEpCreators.AllowUserToDeleteRows = false;
            dgvEpCreators.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEpCreators.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dgvEpCreators.Dock = DockStyle.Top;
            dgvEpCreators.Location = new Point(0, 25);
            dgvEpCreators.Name = "dgvEpCreators";
            dgvEpCreators.ReadOnly = true;
            dgvEpCreators.RowHeadersWidth = 62;
            dgvEpCreators.Size = new Size(353, 170);
            dgvEpCreators.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Id";
            dataGridViewTextBoxColumn11.MinimumWidth = 8;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Name";
            dataGridViewTextBoxColumn12.MinimumWidth = 8;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 150;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Dock = DockStyle.Top;
            label32.Font = new Font("Segoe UI", 13F);
            label32.Location = new Point(0, 0);
            label32.Name = "label32";
            label32.Size = new Size(78, 25);
            label32.TabIndex = 1;
            label32.Text = "Creators";
            // 
            // panel22
            // 
            panel22.Controls.Add(dgvEpCasts);
            panel22.Controls.Add(label34);
            panel22.Dock = DockStyle.Left;
            panel22.Location = new Point(3805, 0);
            panel22.Name = "panel22";
            panel22.Size = new Size(608, 647);
            panel22.TabIndex = 9;
            // 
            // dgvEpCasts
            // 
            dgvEpCasts.AllowUserToAddRows = false;
            dgvEpCasts.AllowUserToDeleteRows = false;
            dgvEpCasts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEpCasts.Columns.AddRange(new DataGridViewColumn[] { cCastId, cCastName, cCastImage, cCastPreviewImage, cCastCharacter, cCastDel });
            dgvEpCasts.Dock = DockStyle.Fill;
            dgvEpCasts.Location = new Point(0, 25);
            dgvEpCasts.Name = "dgvEpCasts";
            dgvEpCasts.ReadOnly = true;
            dgvEpCasts.RowHeadersWidth = 62;
            dgvEpCasts.RowTemplate.Height = 200;
            dgvEpCasts.Size = new Size(608, 622);
            dgvEpCasts.TabIndex = 2;
            // 
            // cCastId
            // 
            cCastId.HeaderText = "Id";
            cCastId.MinimumWidth = 8;
            cCastId.Name = "cCastId";
            cCastId.ReadOnly = true;
            cCastId.Width = 150;
            // 
            // cCastName
            // 
            cCastName.HeaderText = "Name";
            cCastName.MinimumWidth = 8;
            cCastName.Name = "cCastName";
            cCastName.ReadOnly = true;
            cCastName.Width = 150;
            // 
            // cCastImage
            // 
            cCastImage.HeaderText = "Image";
            cCastImage.MinimumWidth = 8;
            cCastImage.Name = "cCastImage";
            cCastImage.ReadOnly = true;
            cCastImage.Width = 150;
            // 
            // cCastPreviewImage
            // 
            cCastPreviewImage.HeaderText = "Preview Image";
            cCastPreviewImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            cCastPreviewImage.MinimumWidth = 8;
            cCastPreviewImage.Name = "cCastPreviewImage";
            cCastPreviewImage.ReadOnly = true;
            cCastPreviewImage.Width = 150;
            // 
            // cCastCharacter
            // 
            cCastCharacter.HeaderText = "Character";
            cCastCharacter.MinimumWidth = 8;
            cCastCharacter.Name = "cCastCharacter";
            cCastCharacter.ReadOnly = true;
            cCastCharacter.Width = 150;
            // 
            // cCastDel
            // 
            cCastDel.HeaderText = "Del";
            cCastDel.MinimumWidth = 8;
            cCastDel.Name = "cCastDel";
            cCastDel.ReadOnly = true;
            cCastDel.Width = 150;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Dock = DockStyle.Top;
            label34.Font = new Font("Segoe UI", 13F);
            label34.Location = new Point(0, 0);
            label34.Name = "label34";
            label34.Size = new Size(54, 25);
            label34.TabIndex = 1;
            label34.Text = "Casts";
            // 
            // tableLayoutPanel26
            // 
            tableLayoutPanel26.ColumnCount = 1;
            tableLayoutPanel26.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel26.Controls.Add(label35, 0, 0);
            tableLayoutPanel26.Location = new Point(0, 0);
            tableLayoutPanel26.Name = "tableLayoutPanel26";
            tableLayoutPanel26.RowCount = 2;
            tableLayoutPanel26.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel26.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel26.Size = new Size(200, 100);
            tableLayoutPanel26.TabIndex = 0;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Dock = DockStyle.Left;
            label35.Location = new Point(3, 0);
            label35.Name = "label35";
            label35.Size = new Size(78, 20);
            label35.TabIndex = 1;
            label35.Text = "Movie Name:";
            label35.TextAlign = ContentAlignment.BottomLeft;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 2;
            // 
            // MoviesManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1362, 664);
            Controls.Add(panel22);
            Controls.Add(panel17);
            Controls.Add(panel15);
            Controls.Add(panel12);
            Controls.Add(panel13);
            Controls.Add(panel9);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MoviesManager";
            Text = "MoviesManager";
            Load += MoviesManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel23.ResumeLayout(false);
            tableLayoutPanel22.ResumeLayout(false);
            tableLayoutPanel22.PerformLayout();
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            panel4.ResumeLayout(false);
            panel10.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWriters).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDirectors).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCreators).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel27.ResumeLayout(false);
            tableLayoutPanel27.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgPreviewPoster).EndInit();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)wmpPreviewTrailer).EndInit();
            tableLayoutPanel31.ResumeLayout(false);
            tableLayoutPanel31.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSeasons).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpisodes).EndInit();
            panel13.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            tableLayoutPanel28.ResumeLayout(false);
            tableLayoutPanel28.PerformLayout();
            tableLayoutPanel25.ResumeLayout(false);
            tableLayoutPanel25.PerformLayout();
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            tableLayoutPanel17.ResumeLayout(false);
            tableLayoutPanel17.PerformLayout();
            tableLayoutPanel19.ResumeLayout(false);
            tableLayoutPanel19.PerformLayout();
            tableLayoutPanel20.ResumeLayout(false);
            tableLayoutPanel20.PerformLayout();
            tableLayoutPanel21.ResumeLayout(false);
            tableLayoutPanel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgEpPreviewImage).EndInit();
            tableLayoutPanel23.ResumeLayout(false);
            tableLayoutPanel23.PerformLayout();
            tableLayoutPanel24.ResumeLayout(false);
            tableLayoutPanel24.PerformLayout();
            tableLayoutPanel18.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            tableLayoutPanel29.ResumeLayout(false);
            tableLayoutPanel30.ResumeLayout(false);
            tableLayoutPanel30.PerformLayout();
            panel17.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpGenres).EndInit();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpWriters).EndInit();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpDirectors).EndInit();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpCreators).EndInit();
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpCasts).EndInit();
            tableLayoutPanel26.ResumeLayout(false);
            tableLayoutPanel26.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMovies;
        private Panel panel1;
        private Panel panel2;
        private Button btnRefreshMovies;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private TextBox tbMovieId;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private TextBox tbDuration;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label8;
        private TextBox tbIMDbScore;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label7;
        private TextBox tbRatingCount;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label6;
        private TextBox tbPosterURL;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private PictureBox imgPreviewPoster;
        private Panel panel10;
        private Panel panel9;
        private Panel panel11;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label9;
        private AxWMPLib.AxWindowsMediaPlayer wmpPreviewTrailer;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label10;
        private TextBox tbDescription;
        private CheckBox cbIsTVShows;
        private TableLayoutPanel tableLayoutPanel11;
        private Button btnGetDataUrl;
        private Button btnGoToWeb;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label12;
        private TextBox tbIMDbURL;
        private Label label11;
        private Label label13;
        private DataGridView dgvCreators;
        private DataGridViewTextBoxColumn cId;
        private DataGridViewTextBoxColumn cName;
        private DataGridView dgvSeasons;
        private Label label16;
        private DataGridView dgvWriters;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label label15;
        private DataGridView dgvDirectors;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label14;
        private TableLayoutPanel tableLayoutPanel12;
        private Button btnClear;
        private Button btnUpdate;
        private Button btnSubmit;
        private DateTimePicker dtpReleaseDate;
        private ComboBox cbbContentRating;
        private Panel panel12;
        private DataGridView dgvEpisodes;
        private Label label17;
        private Panel panel13;
        private Panel panel14;
        private TableLayoutPanel tableLayoutPanel13;
        private Button btnResolveHTML;
        private Button btnRefreshEpisodes;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label18;
        private TextBox tbEpisodeHTML;
        private Label label19;
        private Panel panel15;
        private Panel panel16;
        private FlowLayoutPanel flowLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel15;
        private Label label20;
        private TextBox tbEpId;
        private TableLayoutPanel tableLayoutPanel16;
        private Label label21;
        private DateTimePicker dtpEpReleaseDate;
        private TableLayoutPanel tableLayoutPanel17;
        private Label label22;
        private TextBox tbEpDuration;
        private TableLayoutPanel tableLayoutPanel19;
        private Label label24;
        private TextBox tbEpAggregateRating;
        private TableLayoutPanel tableLayoutPanel20;
        private Label label25;
        private TextBox tbEpVoteCount;
        private TableLayoutPanel tableLayoutPanel21;
        private Label label26;
        private TextBox tbEpImage;
        private PictureBox imgEpPreviewImage;
        private TableLayoutPanel tableLayoutPanel23;
        private Label label28;
        private TextBox tbEpImageCaption;
        private Label label29;
        private TableLayoutPanel tableLayoutPanel25;
        private Label label31;
        private TextBox tbEpTitle;
        private TableLayoutPanel tableLayoutPanel24;
        private Label label30;
        private TextBox tbEpPlot;
        private Panel panel17;
        private Panel panel18;
        private DataGridView dgvEpWriters;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Label label23;
        private Panel panel19;
        private DataGridView dgvEpDirectors;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Label label27;
        private Panel panel20;
        private DataGridView dgvEpCreators;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Label label32;
        private Panel panel21;
        private DataGridView dgvEpGenres;
        private Label label33;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private Panel panel22;
        private DataGridView dgvEpCasts;
        private Label label34;
        private TableLayoutPanel tableLayoutPanel18;
        private Button btnEpSubmit;
        private Button btnEpUpdate;
        private Panel panel23;
        private TableLayoutPanel tableLayoutPanel22;
        private Label lbCountMovies;
        private Label lbPageMovies;
        private TextBox tbPageNumber;
        private Panel panel24;
        private Button btnGoToPage;
        private Button btnPreviousPage;
        private Button btnNextPage;
        private TableLayoutPanel tableLayoutPanel27;
        private Label label36;
        private TextBox tbMovieName;
        private TableLayoutPanel tableLayoutPanel26;
        private Label label35;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn cSeasonEdit;
        private TableLayoutPanel tableLayoutPanel28;
        private Label label37;
        private TextBox tbEpisode;
        private DataGridViewTextBoxColumn cEpId;
        private DataGridViewTextBoxColumn cNumber;
        private DataGridViewTextBoxColumn cEpReleaseDate;
        private DataGridViewTextBoxColumn cEpDuration;
        private DataGridViewTextBoxColumn cEpImage;
        private DataGridViewImageColumn cPreviewImage;
        private DataGridViewTextBoxColumn cEpTitle;
        private DataGridViewTextBoxColumn cEpAggregateRating;
        private DataGridViewTextBoxColumn cEpVoteCount;
        private DataGridViewButtonColumn cEpEdit;
        private DataGridViewButtonColumn cEpDel;
        private DataGridViewTextBoxColumn cCastId;
        private DataGridViewTextBoxColumn cCastName;
        private DataGridViewTextBoxColumn cCastImage;
        private DataGridViewImageColumn cCastPreviewImage;
        private DataGridViewTextBoxColumn cCastCharacter;
        private DataGridViewButtonColumn cCastDel;
        private Panel panel25;
        private TableLayoutPanel tableLayoutPanel29;
        private Button btnEpGetData;
        private Button btnEpGoToWebsite;
        private TableLayoutPanel tableLayoutPanel30;
        private Label label38;
        private TextBox tbEpURL;
        private Label label39;
        private Button btnSubmitEpisodes;
        private TableLayoutPanel tableLayoutPanel31;
        private TextBox tbTrailerURL;
        private Button btnLoadTrailer;
        private DataGridViewTextBoxColumn cMovieID;
        private DataGridViewTextBoxColumn cMovieName;
        private DataGridViewTextBoxColumn cReleaseDate;
        private DataGridViewTextBoxColumn cDuration;
        private DataGridViewTextBoxColumn cContentRating;
        private DataGridViewTextBoxColumn cIMDbScore;
        private DataGridViewCheckBoxColumn cIsTVShows;
        private DataGridViewButtonColumn cView;
        private DataGridViewButtonColumn cDel;
    }
}