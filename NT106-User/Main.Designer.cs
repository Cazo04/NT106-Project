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
            menuStrip1 = new MenuStrip();
            miHome = new ToolStripMenuItem();
            tVShowsToolStripMenuItem = new ToolStripMenuItem();
            newPopularToolStripMenuItem = new ToolStripMenuItem();
            myListToolStripMenuItem = new ToolStripMenuItem();
            miLogin = new ToolStripMenuItem();
            pnUser = new Panel();
            btnLogout = new Button();
            btnProfile = new Button();
            btnWatctlist = new Button();
            panel3 = new Panel();
            label2 = new Label();
            lbUser = new Label();
            imgUser = new PictureBox();
            panel2 = new Panel();
            menuStrip1.SuspendLayout();
            pnUser.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { miHome, tVShowsToolStripMenuItem, newPopularToolStripMenuItem, myListToolStripMenuItem, miLogin });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1038, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // miHome
            // 
            miHome.ForeColor = SystemColors.ControlLightLight;
            miHome.Name = "miHome";
            miHome.Size = new Size(74, 29);
            miHome.Text = "Home";
            miHome.Click += miHome_Click;
            // 
            // tVShowsToolStripMenuItem
            // 
            tVShowsToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            tVShowsToolStripMenuItem.Name = "tVShowsToolStripMenuItem";
            tVShowsToolStripMenuItem.Size = new Size(105, 29);
            tVShowsToolStripMenuItem.Text = "TV Shows";
            // 
            // newPopularToolStripMenuItem
            // 
            newPopularToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            newPopularToolStripMenuItem.Name = "newPopularToolStripMenuItem";
            newPopularToolStripMenuItem.Size = new Size(152, 29);
            newPopularToolStripMenuItem.Text = "New && Popular";
            // 
            // myListToolStripMenuItem
            // 
            myListToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            myListToolStripMenuItem.Name = "myListToolStripMenuItem";
            myListToolStripMenuItem.Size = new Size(83, 29);
            myListToolStripMenuItem.Text = "My List";
            // 
            // miLogin
            // 
            miLogin.Alignment = ToolStripItemAlignment.Right;
            miLogin.ForeColor = SystemColors.ControlLightLight;
            miLogin.Name = "miLogin";
            miLogin.Size = new Size(82, 29);
            miLogin.Text = "Sign In";
            miLogin.Click += miLogin_Click;
            // 
            // pnUser
            // 
            pnUser.BackColor = Color.FromArgb(64, 64, 64);
            pnUser.Controls.Add(btnLogout);
            pnUser.Controls.Add(btnProfile);
            pnUser.Controls.Add(btnWatctlist);
            pnUser.Controls.Add(panel3);
            pnUser.Dock = DockStyle.Right;
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
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 33);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(854, 687);
            panel2.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1038, 720);
            Controls.Add(panel2);
            Controls.Add(pnUser);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnUser.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem miHome;
        private ToolStripMenuItem tVShowsToolStripMenuItem;
        private ToolStripMenuItem newPopularToolStripMenuItem;
        private ToolStripMenuItem myListToolStripMenuItem;
        private ToolStripMenuItem miLogin;
        private Panel pnUser;
        private Panel panel2;
        private Panel panel3;
        private PictureBox imgUser;
        private Button btnLogout;
        private Button btnProfile;
        private Button btnWatctlist;
        private Label label2;
        private Label lbUser;
    }
}
