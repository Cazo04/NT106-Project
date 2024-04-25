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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            btnRefreshMovies = new Button();
            cMovieID = new DataGridViewTextBoxColumn();
            cMovieName = new DataGridViewTextBoxColumn();
            cReleaseDate = new DataGridViewTextBoxColumn();
            cDuration = new DataGridViewTextBoxColumn();
            cContentRating = new DataGridViewTextBoxColumn();
            cIMDbScore = new DataGridViewTextBoxColumn();
            cIsTVShows = new DataGridViewCheckBoxColumn();
            cView = new DataGridViewButtonColumn();
            cDel = new DataGridViewButtonColumn();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cMovieID, cMovieName, cReleaseDate, cDuration, cContentRating, cIMDbScore, cIsTVShows, cView, cDel });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(450, 561);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 598);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnRefreshMovies);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 37);
            panel2.TabIndex = 2;
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
            // 
            // cMovieID
            // 
            cMovieID.HeaderText = "Movie ID";
            cMovieID.Name = "cMovieID";
            cMovieID.ReadOnly = true;
            // 
            // cMovieName
            // 
            cMovieName.HeaderText = "Movie Name";
            cMovieName.Name = "cMovieName";
            cMovieName.ReadOnly = true;
            // 
            // cReleaseDate
            // 
            cReleaseDate.HeaderText = "Release Date";
            cReleaseDate.Name = "cReleaseDate";
            cReleaseDate.ReadOnly = true;
            // 
            // cDuration
            // 
            cDuration.HeaderText = "Duration (s)";
            cDuration.Name = "cDuration";
            cDuration.ReadOnly = true;
            // 
            // cContentRating
            // 
            cContentRating.HeaderText = "Content Rating";
            cContentRating.Name = "cContentRating";
            cContentRating.ReadOnly = true;
            // 
            // cIMDbScore
            // 
            cIMDbScore.HeaderText = "IMDb Score";
            cIMDbScore.Name = "cIMDbScore";
            cIMDbScore.ReadOnly = true;
            // 
            // cIsTVShows
            // 
            cIsTVShows.HeaderText = "Is TV Shows";
            cIsTVShows.Name = "cIsTVShows";
            cIsTVShows.ReadOnly = true;
            // 
            // cView
            // 
            cView.HeaderText = "View";
            cView.Name = "cView";
            cView.ReadOnly = true;
            // 
            // cDel
            // 
            cDel.HeaderText = "Del";
            cDel.Name = "cDel";
            cDel.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 561);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(450, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5, 0, 0, 0);
            panel4.Size = new Size(387, 598);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(5, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(382, 417);
            panel5.TabIndex = 0;
            // 
            // MoviesManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 598);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MoviesManager";
            Text = "MoviesManager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private DataGridViewTextBoxColumn cMovieID;
        private DataGridViewTextBoxColumn cMovieName;
        private DataGridViewTextBoxColumn cReleaseDate;
        private DataGridViewTextBoxColumn cDuration;
        private DataGridViewTextBoxColumn cContentRating;
        private DataGridViewTextBoxColumn cIMDbScore;
        private DataGridViewCheckBoxColumn cIsTVShows;
        private DataGridViewButtonColumn cView;
        private DataGridViewButtonColumn cDel;
        private Panel panel2;
        private Button btnRefreshMovies;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}