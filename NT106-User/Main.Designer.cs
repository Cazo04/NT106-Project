namespace NT106_User
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pnUser = new Panel();
            btnLogout = new Button();
            btnProfile = new Button();
            btnWatctlist = new Button();
            panel3 = new Panel();
            label2 = new Label();
            lbUser = new Label();
            imgUser = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            tlpnMiniUser = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnMylist = new Button();
            btnNewandpopular = new Button();
            btnMovies = new Button();
            btnTvshows = new Button();
            btnHome = new Button();
            btnLogo = new Button();
            btnSignin = new Button();
            pnUser.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            panel1.SuspendLayout();
            tlpnMiniUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnUser
            // 
            pnUser.BackColor = Color.FromArgb(64, 64, 64);
            pnUser.Controls.Add(btnLogout);
            pnUser.Controls.Add(btnProfile);
            pnUser.Controls.Add(btnWatctlist);
            pnUser.Controls.Add(panel3);
            pnUser.Dock = DockStyle.Right;
            pnUser.Location = new Point(854, 0);
            pnUser.Margin = new Padding(2);
            pnUser.Name = "pnUser";
            pnUser.Size = new Size(184, 720);
            pnUser.TabIndex = 1;
            pnUser.Visible = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(64, 64, 64);
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F);
            btnLogout.ForeColor = SystemColors.ControlLightLight;
            btnLogout.Location = new Point(0, 138);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(184, 36);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(64, 64, 64);
            btnProfile.Dock = DockStyle.Top;
            btnProfile.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 12F);
            btnProfile.ForeColor = SystemColors.ControlLightLight;
            btnProfile.Location = new Point(0, 102);
            btnProfile.Margin = new Padding(2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(184, 36);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnWatctlist
            // 
            btnWatctlist.BackColor = Color.FromArgb(64, 64, 64);
            btnWatctlist.Dock = DockStyle.Top;
            btnWatctlist.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnWatctlist.FlatStyle = FlatStyle.Flat;
            btnWatctlist.Font = new Font("Segoe UI", 12F);
            btnWatctlist.ForeColor = SystemColors.ControlLightLight;
            btnWatctlist.Location = new Point(0, 66);
            btnWatctlist.Margin = new Padding(2);
            btnWatctlist.Name = "btnWatctlist";
            btnWatctlist.Size = new Size(184, 36);
            btnWatctlist.TabIndex = 1;
            btnWatctlist.Text = "Watchlist";
            btnWatctlist.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lbUser);
            panel3.Controls.Add(imgUser);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(184, 66);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(85, 39);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(33, 17);
            label2.TabIndex = 2;
            label2.Text = "Free";
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Font = new Font("Segoe UI", 9.75F);
            lbUser.ForeColor = SystemColors.ControlLightLight;
            lbUser.Location = new Point(85, 11);
            lbUser.Margin = new Padding(2, 0, 2, 0);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(35, 17);
            lbUser.TabIndex = 1;
            lbUser.Text = "User";
            // 
            // imgUser
            // 
            imgUser.Image = (Image)resources.GetObject("imgUser.Image");
            imgUser.Location = new Point(12, 11);
            imgUser.Margin = new Padding(2);
            imgUser.Name = "imgUser";
            imgUser.Size = new Size(54, 44);
            imgUser.SizeMode = PictureBoxSizeMode.Zoom;
            imgUser.TabIndex = 0;
            imgUser.TabStop = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 35);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 685);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(tlpnMiniUser);
            panel1.Controls.Add(btnMylist);
            panel1.Controls.Add(btnNewandpopular);
            panel1.Controls.Add(btnMovies);
            panel1.Controls.Add(btnTvshows);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnLogo);
            panel1.Controls.Add(btnSignin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(854, 39);
            panel1.TabIndex = 3;
            // 
            // tlpnMiniUser
            // 
            tlpnMiniUser.ColumnCount = 2;
            tlpnMiniUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.5783119F));
            tlpnMiniUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.4216881F));
            tlpnMiniUser.Controls.Add(pictureBox1, 0, 0);
            tlpnMiniUser.Controls.Add(label1, 1, 0);
            tlpnMiniUser.Dock = DockStyle.Right;
            tlpnMiniUser.Location = new Point(691, 0);
            tlpnMiniUser.Name = "tlpnMiniUser";
            tlpnMiniUser.Padding = new Padding(2);
            tlpnMiniUser.RowCount = 1;
            tlpnMiniUser.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpnMiniUser.Size = new Size(77, 39);
            tlpnMiniUser.TabIndex = 6;
            tlpnMiniUser.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(36, 2);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 35);
            label1.TabIndex = 2;
            label1.Text = "User";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnMylist
            // 
            btnMylist.BackColor = Color.Black;
            btnMylist.Dock = DockStyle.Left;
            btnMylist.FlatAppearance.BorderColor = Color.Black;
            btnMylist.FlatStyle = FlatStyle.Flat;
            btnMylist.Font = new Font("Segoe UI", 12F);
            btnMylist.ForeColor = SystemColors.ControlLightLight;
            btnMylist.Location = new Point(493, 0);
            btnMylist.Name = "btnMylist";
            btnMylist.Size = new Size(86, 39);
            btnMylist.TabIndex = 4;
            btnMylist.Text = "My List";
            btnMylist.UseVisualStyleBackColor = false;
            // 
            // btnNewandpopular
            // 
            btnNewandpopular.BackColor = Color.Black;
            btnNewandpopular.Dock = DockStyle.Left;
            btnNewandpopular.FlatAppearance.BorderColor = Color.Black;
            btnNewandpopular.FlatStyle = FlatStyle.Flat;
            btnNewandpopular.Font = new Font("Segoe UI", 12F);
            btnNewandpopular.ForeColor = SystemColors.ControlLightLight;
            btnNewandpopular.Location = new Point(356, 0);
            btnNewandpopular.Name = "btnNewandpopular";
            btnNewandpopular.Size = new Size(137, 39);
            btnNewandpopular.TabIndex = 3;
            btnNewandpopular.Text = "New && Popular";
            btnNewandpopular.UseVisualStyleBackColor = false;
            // 
            // btnMovies
            // 
            btnMovies.BackColor = Color.Black;
            btnMovies.Dock = DockStyle.Left;
            btnMovies.FlatAppearance.BorderColor = Color.Black;
            btnMovies.FlatStyle = FlatStyle.Flat;
            btnMovies.Font = new Font("Segoe UI", 12F);
            btnMovies.ForeColor = SystemColors.ControlLightLight;
            btnMovies.Location = new Point(270, 0);
            btnMovies.Name = "btnMovies";
            btnMovies.Size = new Size(86, 39);
            btnMovies.TabIndex = 2;
            btnMovies.Text = "Movies";
            btnMovies.UseVisualStyleBackColor = false;
            // 
            // btnTvshows
            // 
            btnTvshows.BackColor = Color.Black;
            btnTvshows.Dock = DockStyle.Left;
            btnTvshows.FlatAppearance.BorderColor = Color.Black;
            btnTvshows.FlatStyle = FlatStyle.Flat;
            btnTvshows.Font = new Font("Segoe UI", 12F);
            btnTvshows.ForeColor = SystemColors.ControlLightLight;
            btnTvshows.Location = new Point(172, 0);
            btnTvshows.Name = "btnTvshows";
            btnTvshows.Size = new Size(98, 39);
            btnTvshows.TabIndex = 1;
            btnTvshows.Text = "TV Shows";
            btnTvshows.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Black;
            btnHome.Dock = DockStyle.Left;
            btnHome.FlatAppearance.BorderColor = Color.Black;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 12F);
            btnHome.ForeColor = SystemColors.ControlLightLight;
            btnHome.Location = new Point(86, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(86, 39);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnLogo
            // 
            btnLogo.BackColor = Color.Black;
            btnLogo.Dock = DockStyle.Left;
            btnLogo.FlatAppearance.BorderColor = Color.Black;
            btnLogo.FlatStyle = FlatStyle.Flat;
            btnLogo.Font = new Font("Segoe UI", 12F);
            btnLogo.ForeColor = SystemColors.ControlLightLight;
            btnLogo.Location = new Point(0, 0);
            btnLogo.Name = "btnLogo";
            btnLogo.Size = new Size(86, 39);
            btnLogo.TabIndex = 1;
            btnLogo.Text = "Logo";
            btnLogo.UseVisualStyleBackColor = false;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.Black;
            btnSignin.Dock = DockStyle.Right;
            btnSignin.FlatAppearance.BorderColor = Color.Black;
            btnSignin.FlatStyle = FlatStyle.Flat;
            btnSignin.Font = new Font("Segoe UI", 12F);
            btnSignin.ForeColor = SystemColors.ControlLightLight;
            btnSignin.Location = new Point(768, 0);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(86, 39);
            btnSignin.TabIndex = 5;
            btnSignin.Text = "Sign in";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1038, 720);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pnUser);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Main";
            Text = "Form1";
            pnUser.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
            panel1.ResumeLayout(false);
            tlpnMiniUser.ResumeLayout(false);
            tlpnMiniUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnUser;
        private Panel panel2;
        private Panel panel3;
        private PictureBox imgUser;
        private Button btnLogout;
        private Button btnProfile;
        private Button btnWatctlist;
        private Label label2;
        private Label lbUser;
        private Panel panel1;
        private Button btnNewandpopular;
        private Button btnMovies;
        private Button btnTvshows;
        private Button btnHome;
        private Button btnSignin;
        private Button btnMylist;
        private Button btnLogo;
        private TableLayoutPanel tlpnMiniUser;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
