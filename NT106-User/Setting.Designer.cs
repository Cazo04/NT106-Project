namespace NT106_User
{
    partial class Setting
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
            panel1 = new Panel();
            btnWatchlist = new Button();
            btnlogout = new Button();
            btnProfile = new Button();
            pnMain = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(42, 44, 49);
            panel1.Controls.Add(btnWatchlist);
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btnProfile);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 979);
            panel1.TabIndex = 18;
            // 
            // btnWatchlist
            // 
            btnWatchlist.BackColor = Color.DimGray;
            btnWatchlist.Dock = DockStyle.Top;
            btnWatchlist.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnWatchlist.FlatAppearance.MouseDownBackColor = Color.White;
            btnWatchlist.FlatAppearance.MouseOverBackColor = Color.White;
            btnWatchlist.FlatStyle = FlatStyle.Flat;
            btnWatchlist.Font = new Font("Segoe UI", 11.25F);
            btnWatchlist.ForeColor = SystemColors.ControlLightLight;
            btnWatchlist.Location = new Point(0, 40);
            btnWatchlist.Name = "btnWatchlist";
            btnWatchlist.Size = new Size(143, 40);
            btnWatchlist.TabIndex = 15;
            btnWatchlist.Text = "Watchlist";
            btnWatchlist.UseVisualStyleBackColor = false;
            btnWatchlist.Click += btnWatchlist_Click;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.LightCoral;
            btnlogout.Dock = DockStyle.Bottom;
            btnlogout.FlatAppearance.MouseDownBackColor = Color.White;
            btnlogout.FlatAppearance.MouseOverBackColor = Color.White;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI", 11.25F);
            btnlogout.ForeColor = SystemColors.Desktop;
            btnlogout.Location = new Point(0, 944);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(143, 35);
            btnlogout.TabIndex = 14;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.DimGray;
            btnProfile.Dock = DockStyle.Top;
            btnProfile.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnProfile.FlatAppearance.MouseDownBackColor = Color.White;
            btnProfile.FlatAppearance.MouseOverBackColor = Color.White;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 11.25F);
            btnProfile.ForeColor = SystemColors.ControlLightLight;
            btnProfile.Location = new Point(0, 0);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(143, 40);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // pnMain
            // 
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(143, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(553, 979);
            pnMain.TabIndex = 19;
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(696, 979);
            Controls.Add(pnMain);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Setting";
            Text = "Profile";
            Load += Setting_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnlogout;
        private Button btnProfile;
        private Panel pnMain;
        private Button btnWatchlist;
    }
}