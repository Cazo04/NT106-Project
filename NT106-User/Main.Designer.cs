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
            btnMylist = new Button();
            btnNewandpopular = new Button();
            btnSignin = new Button();
            btnMovies = new Button();
            btnTvshows = new Button();
            btnHome = new Button();
            pnUser.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnUser
            // 
            pnUser.BackColor = Color.FromArgb(64, 64, 64);
            pnUser.Controls.Add(btnLogout);
            pnUser.Controls.Add(btnProfile);
            pnUser.Controls.Add(btnWatctlist);
            pnUser.Controls.Add(panel3);
            pnUser.Location = new Point(854, 33);
            pnUser.Margin = new Padding(2);
            pnUser.Name = "pnUser";
            pnUser.Size = new Size(184, 687);
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
            panel2.Location = new Point(0, 35);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 685);
            panel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnMylist);
            panel1.Controls.Add(btnNewandpopular);
            panel1.Controls.Add(btnSignin);
            panel1.Controls.Add(btnMovies);
            panel1.Controls.Add(btnTvshows);
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 39);
            panel1.TabIndex = 3;
            // 
            // btnMylist
            // 
            btnMylist.BackColor = Color.Black;
            btnMylist.FlatAppearance.BorderColor = Color.Black;
            btnMylist.FlatStyle = FlatStyle.Flat;
            btnMylist.Font = new Font("Segoe UI", 12F);
            btnMylist.ForeColor = SystemColors.ControlLightLight;
            btnMylist.Location = new Point(431, 3);
            btnMylist.Name = "btnMylist";
            btnMylist.Size = new Size(86, 36);
            btnMylist.TabIndex = 4;
            btnMylist.Text = "My List";
            btnMylist.UseVisualStyleBackColor = false;
            // 
            // btnNewandpopular
            // 
            btnNewandpopular.BackColor = Color.Black;
            btnNewandpopular.FlatAppearance.BorderColor = Color.Black;
            btnNewandpopular.FlatStyle = FlatStyle.Flat;
            btnNewandpopular.Font = new Font("Segoe UI", 12F);
            btnNewandpopular.ForeColor = SystemColors.ControlLightLight;
            btnNewandpopular.Location = new Point(288, 3);
            btnNewandpopular.Name = "btnNewandpopular";
            btnNewandpopular.Size = new Size(137, 36);
            btnNewandpopular.TabIndex = 3;
            btnNewandpopular.Text = "New && Popular";
            btnNewandpopular.UseVisualStyleBackColor = false;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.Black;
            btnSignin.FlatAppearance.BorderColor = Color.Black;
            btnSignin.FlatStyle = FlatStyle.Flat;
            btnSignin.Font = new Font("Segoe UI", 12F);
            btnSignin.ForeColor = SystemColors.ControlLightLight;
            btnSignin.Location = new Point(859, 0);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(86, 39);
            btnSignin.TabIndex = 5;
            btnSignin.Text = "Sign in";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // btnMovies
            // 
            btnMovies.BackColor = Color.Black;
            btnMovies.FlatAppearance.BorderColor = Color.Black;
            btnMovies.FlatStyle = FlatStyle.Flat;
            btnMovies.Font = new Font("Segoe UI", 12F);
            btnMovies.ForeColor = SystemColors.ControlLightLight;
            btnMovies.Location = new Point(196, 3);
            btnMovies.Name = "btnMovies";
            btnMovies.Size = new Size(86, 33);
            btnMovies.TabIndex = 2;
            btnMovies.Text = "Movies";
            btnMovies.UseVisualStyleBackColor = false;
            // 
            // btnTvshows
            // 
            btnTvshows.BackColor = Color.Black;
            btnTvshows.FlatAppearance.BorderColor = Color.Black;
            btnTvshows.FlatStyle = FlatStyle.Flat;
            btnTvshows.Font = new Font("Segoe UI", 12F);
            btnTvshows.ForeColor = SystemColors.ControlLightLight;
            btnTvshows.Location = new Point(92, 3);
            btnTvshows.Name = "btnTvshows";
            btnTvshows.Size = new Size(98, 34);
            btnTvshows.TabIndex = 1;
            btnTvshows.Text = "TV Shows";
            btnTvshows.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Black;
            btnHome.FlatAppearance.BorderColor = Color.Black;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 12F);
            btnHome.ForeColor = SystemColors.ControlLightLight;
            btnHome.Location = new Point(0, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(86, 34);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
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
    }
}
