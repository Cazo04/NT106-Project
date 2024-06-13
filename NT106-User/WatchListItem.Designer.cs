namespace NT106_User
{
    partial class WatchListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchListItem));
            panel1 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            lbDescription = new Label();
            tlpSeasons = new TableLayoutPanel();
            flpSeasons = new FlowLayoutPanel();
            btnBaseSeasons = new Button();
            lbSeasons = new Label();
            btnRemove = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbReleaseDate = new Label();
            lbType = new Label();
            lbContentRating = new Label();
            lbDuration = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            label2 = new Label();
            flpGenres = new FlowLayoutPanel();
            lbBaseGenres = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            lbIMDbScore = new Label();
            lbRatingCount = new Label();
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            lbMovieName = new Label();
            pnPoster = new PictureBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            tlpSeasons.SuspendLayout();
            flpSeasons.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            flpGenres.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnPoster).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(pnPoster);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 274);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(42, 44, 49);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(tlpSeasons);
            panel5.Controls.Add(tableLayoutPanel4);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(185, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5);
            panel5.Size = new Size(545, 274);
            panel5.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(lbDescription);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(535, 82);
            panel2.TabIndex = 4;
            // 
            // lbDescription
            // 
            lbDescription.AllowDrop = true;
            lbDescription.AutoSize = true;
            lbDescription.ForeColor = SystemColors.ControlLightLight;
            lbDescription.Location = new Point(3, 3);
            lbDescription.MaximumSize = new Size(520, 0);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(483, 90);
            lbDescription.TabIndex = 2;
            lbDescription.Text = resources.GetString("lbDescription.Text");
            // 
            // tlpSeasons
            // 
            tlpSeasons.ColumnCount = 3;
            tlpSeasons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 82F));
            tlpSeasons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSeasons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 71F));
            tlpSeasons.Controls.Add(flpSeasons, 1, 0);
            tlpSeasons.Controls.Add(lbSeasons, 0, 0);
            tlpSeasons.Controls.Add(btnRemove, 2, 0);
            tlpSeasons.Dock = DockStyle.Bottom;
            tlpSeasons.Location = new Point(5, 221);
            tlpSeasons.Name = "tlpSeasons";
            tlpSeasons.RowCount = 1;
            tlpSeasons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSeasons.Size = new Size(535, 48);
            tlpSeasons.TabIndex = 3;
            // 
            // flpSeasons
            // 
            flpSeasons.AutoScroll = true;
            flpSeasons.Controls.Add(btnBaseSeasons);
            flpSeasons.Dock = DockStyle.Fill;
            flpSeasons.Location = new Point(85, 3);
            flpSeasons.Name = "flpSeasons";
            flpSeasons.Padding = new Padding(3, 4, 3, 4);
            flpSeasons.Size = new Size(376, 42);
            flpSeasons.TabIndex = 0;
            flpSeasons.WrapContents = false;
            // 
            // btnBaseSeasons
            // 
            btnBaseSeasons.BackColor = Color.FromArgb(16, 24, 39);
            btnBaseSeasons.FlatAppearance.BorderColor = Color.FromArgb(16, 24, 39);
            btnBaseSeasons.FlatStyle = FlatStyle.Flat;
            btnBaseSeasons.ForeColor = SystemColors.ControlLightLight;
            btnBaseSeasons.Location = new Point(6, 7);
            btnBaseSeasons.Name = "btnBaseSeasons";
            btnBaseSeasons.Size = new Size(75, 23);
            btnBaseSeasons.TabIndex = 0;
            btnBaseSeasons.Text = "Base";
            btnBaseSeasons.UseVisualStyleBackColor = false;
            // 
            // lbSeasons
            // 
            lbSeasons.AutoSize = true;
            lbSeasons.Dock = DockStyle.Fill;
            lbSeasons.ForeColor = SystemColors.ControlLightLight;
            lbSeasons.Location = new Point(3, 0);
            lbSeasons.Name = "lbSeasons";
            lbSeasons.Size = new Size(76, 48);
            lbSeasons.TabIndex = 1;
            lbSeasons.Text = "Seasons list:";
            lbSeasons.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRemove
            // 
            btnRemove.BackgroundImage = Properties.Resources.delete;
            btnRemove.BackgroundImageLayout = ImageLayout.Zoom;
            btnRemove.Dock = DockStyle.Right;
            btnRemove.Location = new Point(492, 3);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(40, 42);
            btnRemove.TabIndex = 2;
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(5, 48);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(535, 91);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 47.0588226F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 52.9411774F));
            tableLayoutPanel5.Size = new Size(449, 85);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(lbReleaseDate);
            flowLayoutPanel1.Controls.Add(lbType);
            flowLayoutPanel1.Controls.Add(lbContentRating);
            flowLayoutPanel1.Controls.Add(lbDuration);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(443, 34);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // lbReleaseDate
            // 
            lbReleaseDate.AutoSize = true;
            lbReleaseDate.BackColor = Color.FromArgb(36, 36, 36);
            lbReleaseDate.ForeColor = SystemColors.HighlightText;
            lbReleaseDate.Location = new Point(3, 0);
            lbReleaseDate.Name = "lbReleaseDate";
            lbReleaseDate.Padding = new Padding(3);
            lbReleaseDate.Size = new Size(71, 21);
            lbReleaseDate.TabIndex = 0;
            lbReleaseDate.Text = "2024-04-10";
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.BackColor = Color.FromArgb(36, 36, 36);
            lbType.ForeColor = SystemColors.HighlightText;
            lbType.Location = new Point(80, 0);
            lbType.Name = "lbType";
            lbType.Padding = new Padding(3);
            lbType.Size = new Size(63, 21);
            lbType.TabIndex = 1;
            lbType.Text = "TV Shows";
            // 
            // lbContentRating
            // 
            lbContentRating.AutoSize = true;
            lbContentRating.BackColor = Color.FromArgb(36, 36, 36);
            lbContentRating.ForeColor = SystemColors.HighlightText;
            lbContentRating.Location = new Point(149, 0);
            lbContentRating.Name = "lbContentRating";
            lbContentRating.Padding = new Padding(3);
            lbContentRating.Size = new Size(50, 21);
            lbContentRating.TabIndex = 2;
            lbContentRating.Text = "TV-MA";
            // 
            // lbDuration
            // 
            lbDuration.AutoSize = true;
            lbDuration.BackColor = Color.FromArgb(25, 65, 93);
            lbDuration.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbDuration.ForeColor = Color.FromArgb(96, 182, 231);
            lbDuration.Location = new Point(205, 0);
            lbDuration.Name = "lbDuration";
            lbDuration.Padding = new Padding(3);
            lbDuration.Size = new Size(52, 21);
            lbDuration.TabIndex = 3;
            lbDuration.Text = "2h10m";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 55F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label2, 0, 0);
            tableLayoutPanel6.Controls.Add(flpGenres, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 43);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(443, 39);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(3, 3);
            label2.Margin = new Padding(3, 3, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Genres:";
            // 
            // flpGenres
            // 
            flpGenres.Controls.Add(lbBaseGenres);
            flpGenres.Dock = DockStyle.Fill;
            flpGenres.Location = new Point(58, 3);
            flpGenres.Name = "flpGenres";
            flpGenres.Size = new Size(382, 33);
            flpGenres.TabIndex = 1;
            // 
            // lbBaseGenres
            // 
            lbBaseGenres.AutoSize = true;
            lbBaseGenres.BackColor = Color.FromArgb(16, 24, 39);
            lbBaseGenres.ForeColor = Color.FromArgb(118, 182, 194);
            lbBaseGenres.Location = new Point(3, 0);
            lbBaseGenres.Name = "lbBaseGenres";
            lbBaseGenres.Padding = new Padding(2);
            lbBaseGenres.Size = new Size(42, 19);
            lbBaseGenres.TabIndex = 1;
            lbBaseGenres.Text = "label3";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.72973F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.27027F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 1, 0);
            tableLayoutPanel7.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Top;
            tableLayoutPanel7.Location = new Point(458, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(74, 37);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(lbIMDbScore, 0, 0);
            tableLayoutPanel8.Controls.Add(lbRatingCount, 0, 1);
            tableLayoutPanel8.Location = new Point(25, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(46, 31);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // lbIMDbScore
            // 
            lbIMDbScore.AutoSize = true;
            lbIMDbScore.ForeColor = SystemColors.ControlLightLight;
            lbIMDbScore.Location = new Point(3, 0);
            lbIMDbScore.Name = "lbIMDbScore";
            lbIMDbScore.Size = new Size(39, 15);
            lbIMDbScore.TabIndex = 0;
            lbIMDbScore.Text = "8.5/10";
            // 
            // lbRatingCount
            // 
            lbRatingCount.AutoSize = true;
            lbRatingCount.ForeColor = SystemColors.ControlLightLight;
            lbRatingCount.Location = new Point(3, 15);
            lbRatingCount.Name = "lbRatingCount";
            lbRatingCount.Size = new Size(31, 15);
            lbRatingCount.TabIndex = 0;
            lbRatingCount.Text = "9999";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(16, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(lbMovieName);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(5, 5);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(3, 6, 3, 3);
            panel6.Size = new Size(535, 43);
            panel6.TabIndex = 0;
            // 
            // lbMovieName
            // 
            lbMovieName.AutoSize = true;
            lbMovieName.Dock = DockStyle.Left;
            lbMovieName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbMovieName.ForeColor = SystemColors.ControlLightLight;
            lbMovieName.Location = new Point(3, 6);
            lbMovieName.Name = "lbMovieName";
            lbMovieName.Size = new Size(65, 25);
            lbMovieName.TabIndex = 0;
            lbMovieName.Text = "label4";
            lbMovieName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnPoster
            // 
            pnPoster.Dock = DockStyle.Left;
            pnPoster.Image = Properties.Resources.nodata;
            pnPoster.Location = new Point(0, 0);
            pnPoster.Name = "pnPoster";
            pnPoster.Size = new Size(185, 274);
            pnPoster.SizeMode = PictureBoxSizeMode.Zoom;
            pnPoster.TabIndex = 1;
            pnPoster.TabStop = false;
            // 
            // WatchListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(panel1);
            Name = "WatchListItem";
            Padding = new Padding(3);
            Size = new Size(736, 280);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tlpSeasons.ResumeLayout(false);
            tlpSeasons.PerformLayout();
            flpSeasons.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            flpGenres.ResumeLayout(false);
            flpGenres.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnPoster).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pnPoster;
        private Panel panel5;
        private TableLayoutPanel tlpSeasons;
        private FlowLayoutPanel flpSeasons;
        private Button btnBaseSeasons;
        private Label lbSeasons;
        private Label lbDescription;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbReleaseDate;
        private Label lbType;
        private Label lbContentRating;
        private Label lbDuration;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label2;
        private FlowLayoutPanel flpGenres;
        private Label lbBaseGenres;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private Label lbIMDbScore;
        private Label lbRatingCount;
        private PictureBox pictureBox2;
        private Panel panel6;
        private Label lbMovieName;
        private Panel panel2;
        private Button btnRemove;
    }
}
