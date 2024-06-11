
namespace NT106_Admin
{
    partial class Dashboard
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
            panel1 = new Panel();
            pnMain = new Panel();
            panel2 = new Panel();
            btnCheckConnection = new Button();
            btnLogout = new Button();
            btnPersons = new Button();
            btnMovies = new Button();
            btnUsers = new Button();
            btnHome = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnMain);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 553);
            panel1.TabIndex = 0;
            // 
            // pnMain
            // 
            pnMain.AutoScroll = true;
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 40);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1000, 513);
            pnMain.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(btnCheckConnection);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnPersons);
            panel2.Controls.Add(btnMovies);
            panel2.Controls.Add(btnUsers);
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 40);
            panel2.TabIndex = 0;
            // 
            // btnCheckConnection
            // 
            btnCheckConnection.Dock = DockStyle.Left;
            btnCheckConnection.Location = new Point(397, 0);
            btnCheckConnection.Name = "btnCheckConnection";
            btnCheckConnection.Size = new Size(103, 40);
            btnCheckConnection.TabIndex = 5;
            btnCheckConnection.Text = "Check Connection";
            btnCheckConnection.UseVisualStyleBackColor = true;
            btnCheckConnection.Click += btnCheckConnection_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Right;
            btnLogout.Location = new Point(913, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(87, 40);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnPersons
            // 
            btnPersons.Dock = DockStyle.Left;
            btnPersons.Location = new Point(294, 0);
            btnPersons.Name = "btnPersons";
            btnPersons.Size = new Size(103, 40);
            btnPersons.TabIndex = 3;
            btnPersons.Text = "Persons";
            btnPersons.UseVisualStyleBackColor = true;
            // 
            // btnMovies
            // 
            btnMovies.Dock = DockStyle.Left;
            btnMovies.Location = new Point(202, 0);
            btnMovies.Name = "btnMovies";
            btnMovies.Size = new Size(92, 40);
            btnMovies.TabIndex = 2;
            btnMovies.Text = "Movies";
            btnMovies.UseVisualStyleBackColor = true;
            btnMovies.Click += btnMovies_Click;
            // 
            // btnUsers
            // 
            btnUsers.Dock = DockStyle.Left;
            btnUsers.Location = new Point(96, 0);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(106, 40);
            btnUsers.TabIndex = 1;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Left;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(96, 40);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 553);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Form1";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnLogout;
        private Button btnPersons;
        private Button btnMovies;
        private Button btnUsers;
        private Button btnHome;
        private Panel pnMain;
        private Button btnCheckConnection;
    }
}
