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
            btnSetting = new Button();
            btnWatctlist = new Button();
            panel3 = new Panel();
            label2 = new Label();
            lbUsername = new Label();
            imgUser = new PictureBox();
            pnMain = new Panel();
            panel1 = new Panel();
            tlpnMiniUser = new TableLayoutPanel();
            imgMiniAvatar = new PictureBox();
            lbMiniUsername = new Label();
            btnMylist = new Button();
            btnInfo = new Button();
            btnMovies = new Button();
            btnTvshows = new Button();
            btnHome = new Button();
            btnSignin = new Button();
            pnUser.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            panel1.SuspendLayout();
            tlpnMiniUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgMiniAvatar).BeginInit();
            SuspendLayout();
            // 
            // pnUser
            // 
            pnUser.BackColor = Color.FromArgb(25, 27, 29);
            pnUser.Controls.Add(btnLogout);
            pnUser.Controls.Add(btnSetting);
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
            btnLogout.BackColor = Color.FromArgb(42, 44, 49);
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F);
            btnLogout.ForeColor = SystemColors.ControlLightLight;
            btnLogout.Location = new Point(0, 684);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(184, 36);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackColor = Color.FromArgb(42, 44, 49);
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Segoe UI", 12F);
            btnSetting.ForeColor = SystemColors.ControlLightLight;
            btnSetting.Location = new Point(0, 108);
            btnSetting.Margin = new Padding(2);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(184, 42);
            btnSetting.TabIndex = 2;
            btnSetting.Text = "Setting";
            btnSetting.UseVisualStyleBackColor = false;
            btnSetting.Click += btnProfile_Click;
            // 
            // btnWatctlist
            // 
            btnWatctlist.BackColor = Color.FromArgb(42, 44, 49);
            btnWatctlist.Dock = DockStyle.Top;
            btnWatctlist.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnWatctlist.FlatStyle = FlatStyle.Flat;
            btnWatctlist.Font = new Font("Segoe UI", 12F);
            btnWatctlist.ForeColor = SystemColors.ControlLightLight;
            btnWatctlist.Location = new Point(0, 66);
            btnWatctlist.Margin = new Padding(2);
            btnWatctlist.Name = "btnWatctlist";
            btnWatctlist.Size = new Size(184, 42);
            btnWatctlist.TabIndex = 1;
            btnWatctlist.Text = "Watchlist";
            btnWatctlist.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(42, 44, 49);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lbUsername);
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
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 9.75F);
            lbUsername.ForeColor = SystemColors.ControlLightLight;
            lbUsername.Location = new Point(85, 11);
            lbUsername.Margin = new Padding(2, 0, 2, 0);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(35, 17);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "User";
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
            // pnMain
            // 
            pnMain.AutoScroll = true;
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 39);
            pnMain.Margin = new Padding(2);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(854, 681);
            pnMain.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(tlpnMiniUser);
            panel1.Controls.Add(btnMylist);
            panel1.Controls.Add(btnInfo);
            panel1.Controls.Add(btnMovies);
            panel1.Controls.Add(btnTvshows);
            panel1.Controls.Add(btnHome);
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
            tlpnMiniUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.4482765F));
            tlpnMiniUser.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.55173F));
            tlpnMiniUser.Controls.Add(imgMiniAvatar, 0, 0);
            tlpnMiniUser.Controls.Add(lbMiniUsername, 1, 0);
            tlpnMiniUser.Dock = DockStyle.Right;
            tlpnMiniUser.Location = new Point(610, 0);
            tlpnMiniUser.Name = "tlpnMiniUser";
            tlpnMiniUser.Padding = new Padding(2);
            tlpnMiniUser.RowCount = 1;
            tlpnMiniUser.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpnMiniUser.Size = new Size(158, 39);
            tlpnMiniUser.TabIndex = 6;
            tlpnMiniUser.Visible = false;
            tlpnMiniUser.Click += tlpnMiniUser_Click;
            // 
            // imgMiniAvatar
            // 
            imgMiniAvatar.Dock = DockStyle.Left;
            imgMiniAvatar.Image = (Image)resources.GetObject("imgMiniAvatar.Image");
            imgMiniAvatar.Location = new Point(4, 4);
            imgMiniAvatar.Margin = new Padding(2);
            imgMiniAvatar.Name = "imgMiniAvatar";
            imgMiniAvatar.Size = new Size(28, 31);
            imgMiniAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            imgMiniAvatar.TabIndex = 1;
            imgMiniAvatar.TabStop = false;
            imgMiniAvatar.Click += imgMiniAvatar_Click;
            // 
            // lbMiniUsername
            // 
            lbMiniUsername.Dock = DockStyle.Left;
            lbMiniUsername.Font = new Font("Segoe UI", 9.75F);
            lbMiniUsername.ForeColor = SystemColors.ControlLightLight;
            lbMiniUsername.Location = new Point(47, 2);
            lbMiniUsername.Margin = new Padding(2, 0, 2, 0);
            lbMiniUsername.Name = "lbMiniUsername";
            lbMiniUsername.Size = new Size(107, 35);
            lbMiniUsername.TabIndex = 2;
            lbMiniUsername.Text = "User";
            lbMiniUsername.TextAlign = ContentAlignment.MiddleLeft;
            lbMiniUsername.Click += lbMiniUsername_Click;
            // 
            // btnMylist
            // 
            btnMylist.BackColor = Color.Black;
            btnMylist.Dock = DockStyle.Left;
            btnMylist.FlatAppearance.BorderColor = Color.Black;
            btnMylist.FlatStyle = FlatStyle.Flat;
            btnMylist.Font = new Font("Segoe UI", 12F);
            btnMylist.ForeColor = SystemColors.ControlLightLight;
            btnMylist.Location = new Point(385, 0);
            btnMylist.Name = "btnMylist";
            btnMylist.Size = new Size(86, 39);
            btnMylist.TabIndex = 4;
            btnMylist.Text = "My List";
            btnMylist.UseVisualStyleBackColor = false;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Black;
            btnInfo.Dock = DockStyle.Left;
            btnInfo.FlatAppearance.BorderColor = Color.Black;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Segoe UI", 12F);
            btnInfo.ForeColor = SystemColors.ControlLightLight;
            btnInfo.Location = new Point(294, 0);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(91, 39);
            btnInfo.TabIndex = 3;
            btnInfo.Text = "Search";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnMovies
            // 
            btnMovies.BackColor = Color.Black;
            btnMovies.Dock = DockStyle.Left;
            btnMovies.FlatAppearance.BorderColor = Color.Black;
            btnMovies.FlatStyle = FlatStyle.Flat;
            btnMovies.Font = new Font("Segoe UI", 12F);
            btnMovies.ForeColor = SystemColors.ControlLightLight;
            btnMovies.Location = new Point(208, 0);
            btnMovies.Name = "btnMovies";
            btnMovies.Size = new Size(86, 39);
            btnMovies.TabIndex = 2;
            btnMovies.Text = "Movies";
            btnMovies.UseVisualStyleBackColor = false;
            btnMovies.Click += btnMovies_Click;
            // 
            // btnTvshows
            // 
            btnTvshows.BackColor = Color.Black;
            btnTvshows.Dock = DockStyle.Left;
            btnTvshows.FlatAppearance.BorderColor = Color.Black;
            btnTvshows.FlatStyle = FlatStyle.Flat;
            btnTvshows.Font = new Font("Segoe UI", 12F);
            btnTvshows.ForeColor = SystemColors.ControlLightLight;
            btnTvshows.Location = new Point(86, 0);
            btnTvshows.Name = "btnTvshows";
            btnTvshows.Size = new Size(122, 39);
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
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(86, 39);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
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
            Controls.Add(pnMain);
            Controls.Add(panel1);
            Controls.Add(pnUser);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Main";
            Text = "Form1";
            Load += Main_Load;
            pnUser.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
            panel1.ResumeLayout(false);
            tlpnMiniUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgMiniAvatar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnUser;
        private Panel pnMain;
        private Panel panel3;
        private PictureBox imgUser;
        private Button btnLogout;
        private Button btnSetting;
        private Button btnWatctlist;
        private Label label2;
        private Label lbUsername;
        private Panel panel1;
        private Button btnInfo;
        private Button btnMovies;
        private Button btnTvshows;
        private Button btnHome;
        private Button btnSignin;
        private Button btnMylist;
        private TableLayoutPanel tlpnMiniUser;
        private PictureBox imgMiniAvatar;
        private Label lbMiniUsername;
    }
}
