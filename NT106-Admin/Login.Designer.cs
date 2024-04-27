namespace NT106_Admin
{
    partial class Login
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tbUsername = new TextBox();
            label2 = new Label();
            tbPassword = new TextBox();
            panel1 = new Panel();
            btnLogin = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tbPassword, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbUsername, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.1219521F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.8780479F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            tableLayoutPanel1.Size = new Size(278, 232);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 24);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbUsername
            // 
            tbUsername.Dock = DockStyle.Top;
            tbUsername.Location = new Point(3, 27);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(272, 23);
            tbUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(3, 53);
            label2.Name = "label2";
            label2.Size = new Size(60, 31);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            label2.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tbPassword
            // 
            tbPassword.Dock = DockStyle.Top;
            tbPassword.Location = new Point(3, 87);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(272, 23);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 38);
            panel1.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(97, 12);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 232);
            Controls.Add(tableLayoutPanel1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox tbPassword;
        private Label label2;
        private Label label1;
        private TextBox tbUsername;
        private Panel panel1;
        private Button btnLogin;
    }
}