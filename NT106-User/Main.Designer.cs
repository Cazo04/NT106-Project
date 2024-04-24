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
            miHome = new ToolStripMenuItem();
            tVShowsToolStripMenuItem = new ToolStripMenuItem();
            newPopularToolStripMenuItem = new ToolStripMenuItem();
            myListToolStripMenuItem = new ToolStripMenuItem();
            miLogin = new ToolStripMenuItem();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(854, 33);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 687);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.Location = new Point(0, 138);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(184, 36);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(0, 102);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(184, 36);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 66);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(184, 36);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
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
            label2.Location = new Point(85, 39);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 44);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label1;
    }
}
