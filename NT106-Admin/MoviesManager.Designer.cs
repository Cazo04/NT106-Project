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
            btnRefreshMovies = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
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
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 561);
            panel3.TabIndex = 3;
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
            panel5.Controls.Add(textBox6);
            panel5.Controls.Add(textBox4);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(textBox5);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(5, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(382, 417);
            panel5.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 0;
            label1.Text = "Movie Data Entry";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Movie Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 1;
            label3.Text = "Movie Name:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 23);
            textBox2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 161);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 1;
            label4.Text = "Movie Name:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(254, 23);
            textBox3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 213);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 1;
            label5.Text = "Movie Name:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 231);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(254, 23);
            textBox4.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 269);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 1;
            label6.Text = "Movie Name:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 287);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(254, 23);
            textBox5.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 321);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 1;
            label7.Text = "Movie Name:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 339);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(254, 23);
            textBox6.TabIndex = 2;
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
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Label label1;
        private Label label2;
        private TextBox textBox6;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
    }
}