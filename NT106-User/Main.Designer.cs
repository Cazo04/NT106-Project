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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            tVShowsToolStripMenuItem = new ToolStripMenuItem();
            newPopularToolStripMenuItem = new ToolStripMenuItem();
            myListToolStripMenuItem = new ToolStripMenuItem();
            miLogin = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, tVShowsToolStripMenuItem, newPopularToolStripMenuItem, myListToolStripMenuItem, miLogin });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(689, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(74, 29);
            homeToolStripMenuItem.Text = "Home";
            // 
            // tVShowsToolStripMenuItem
            // 
            tVShowsToolStripMenuItem.Name = "tVShowsToolStripMenuItem";
            tVShowsToolStripMenuItem.Size = new Size(105, 29);
            tVShowsToolStripMenuItem.Text = "TV Shows";
            // 
            // newPopularToolStripMenuItem
            // 
            newPopularToolStripMenuItem.Name = "newPopularToolStripMenuItem";
            newPopularToolStripMenuItem.Size = new Size(152, 29);
            newPopularToolStripMenuItem.Text = "New && Popular";
            // 
            // myListToolStripMenuItem
            // 
            myListToolStripMenuItem.Name = "myListToolStripMenuItem";
            myListToolStripMenuItem.Size = new Size(83, 29);
            myListToolStripMenuItem.Text = "My List";
            // 
            // miLogin
            // 
            miLogin.Alignment = ToolStripItemAlignment.Right;
            miLogin.Name = "miLogin";
            miLogin.Size = new Size(82, 29);
            miLogin.Text = "Sign In";
            miLogin.Click += miLogin_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 543);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Main";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem tVShowsToolStripMenuItem;
        private ToolStripMenuItem newPopularToolStripMenuItem;
        private ToolStripMenuItem myListToolStripMenuItem;
        private ToolStripMenuItem miLogin;
    }
}
