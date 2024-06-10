namespace NT106_User
{
    partial class ResetPassword
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
            label1 = new Label();
            label2 = new Label();
            btnSendCode = new Button();
            label3 = new Label();
            label4 = new Label();
            btnApply = new Button();
            pbHide = new PictureBox();
            pbShow = new PictureBox();
            pbHide1 = new PictureBox();
            pbShow1 = new PictureBox();
            tbEmail = new RoundTextBox();
            tbCode = new RoundTextBox();
            tbPassword = new RoundTextBox();
            tbConfirmPassword = new RoundTextBox();
            ((System.ComponentModel.ISupportInitialize)pbHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHide1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbShow1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(46, 48);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(46, 108);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 0;
            label2.Text = "Reset code:";
            // 
            // btnSendCode
            // 
            btnSendCode.BackColor = Color.Gray;
            btnSendCode.FlatAppearance.BorderColor = Color.Gray;
            btnSendCode.FlatStyle = FlatStyle.Flat;
            btnSendCode.ForeColor = Color.White;
            btnSendCode.Location = new Point(382, 47);
            btnSendCode.Margin = new Padding(3, 4, 3, 4);
            btnSendCode.Name = "btnSendCode";
            btnSendCode.Size = new Size(94, 31);
            btnSendCode.TabIndex = 2;
            btnSendCode.Text = "Send code";
            btnSendCode.UseVisualStyleBackColor = false;
            btnSendCode.Click += btnSendCode_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(46, 163);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 0;
            label3.Text = "New password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(46, 206);
            label4.Name = "label4";
            label4.Size = new Size(132, 20);
            label4.TabIndex = 0;
            label4.Text = "Confirm password:";
            // 
            // btnApply
            // 
            btnApply.BackColor = Color.Gray;
            btnApply.FlatAppearance.BorderColor = Color.Gray;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.ForeColor = SystemColors.ControlLightLight;
            btnApply.Location = new Point(222, 252);
            btnApply.Margin = new Padding(3, 4, 3, 4);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(86, 31);
            btnApply.TabIndex = 3;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // pbHide
            // 
            pbHide.Image = Properties.Resources.icons8_visibility_off_25;
            pbHide.Location = new Point(383, 159);
            pbHide.Margin = new Padding(3, 4, 3, 4);
            pbHide.Name = "pbHide";
            pbHide.Size = new Size(33, 39);
            pbHide.TabIndex = 35;
            pbHide.TabStop = false;
            pbHide.Click += pbHide_Click;
            // 
            // pbShow
            // 
            pbShow.Image = Properties.Resources.icons8_visibility_25;
            pbShow.Location = new Point(382, 160);
            pbShow.Margin = new Padding(3, 4, 3, 4);
            pbShow.Name = "pbShow";
            pbShow.Size = new Size(33, 39);
            pbShow.TabIndex = 34;
            pbShow.TabStop = false;
            pbShow.Click += pbShow_Click;
            // 
            // pbHide1
            // 
            pbHide1.Image = Properties.Resources.icons8_visibility_off_25;
            pbHide1.Location = new Point(383, 206);
            pbHide1.Margin = new Padding(3, 4, 3, 4);
            pbHide1.Name = "pbHide1";
            pbHide1.Size = new Size(33, 39);
            pbHide1.TabIndex = 37;
            pbHide1.TabStop = false;
            pbHide1.Click += pbHide1_Click;
            // 
            // pbShow1
            // 
            pbShow1.Image = Properties.Resources.icons8_visibility_25;
            pbShow1.Location = new Point(383, 206);
            pbShow1.Margin = new Padding(3, 4, 3, 4);
            pbShow1.Name = "pbShow1";
            pbShow1.Size = new Size(33, 39);
            pbShow1.TabIndex = 36;
            pbShow1.TabStop = false;
            pbShow1.Click += pbShow1_Click;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.FromArgb(64, 64, 64);
            tbEmail.BorderColor = Color.White;
            tbEmail.BorderFocusColor = Color.White;
            tbEmail.BorderRadius = 10;
            tbEmail.BorderSize = 2;
            tbEmail.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.ForeColor = Color.White;
            tbEmail.Location = new Point(102, 43);
            tbEmail.Margin = new Padding(4);
            tbEmail.Multiline = false;
            tbEmail.Name = "tbEmail";
            tbEmail.Padding = new Padding(10, 7, 10, 7);
            tbEmail.PasswordChar = false;
            tbEmail.PlaceholderColor = Color.DarkGray;
            tbEmail.PlaceholderText = "";
            tbEmail.Size = new Size(258, 35);
            tbEmail.TabIndex = 38;
            tbEmail.UnderlinedStyle = false;
            // 
            // tbCode
            // 
            tbCode.BackColor = Color.FromArgb(64, 64, 64);
            tbCode.BorderColor = Color.White;
            tbCode.BorderFocusColor = Color.White;
            tbCode.BorderRadius = 10;
            tbCode.BorderSize = 2;
            tbCode.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCode.ForeColor = Color.White;
            tbCode.Location = new Point(176, 105);
            tbCode.Margin = new Padding(4);
            tbCode.Multiline = false;
            tbCode.Name = "tbCode";
            tbCode.Padding = new Padding(10, 7, 10, 7);
            tbCode.PasswordChar = false;
            tbCode.PlaceholderColor = Color.DarkGray;
            tbCode.PlaceholderText = "";
            tbCode.Size = new Size(184, 35);
            tbCode.TabIndex = 39;
            tbCode.UnderlinedStyle = false;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(64, 64, 64);
            tbPassword.BorderColor = Color.White;
            tbPassword.BorderFocusColor = Color.White;
            tbPassword.BorderRadius = 10;
            tbPassword.BorderSize = 2;
            tbPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.ForeColor = Color.White;
            tbPassword.Location = new Point(175, 153);
            tbPassword.Margin = new Padding(4);
            tbPassword.Multiline = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Padding = new Padding(10, 7, 10, 7);
            tbPassword.PasswordChar = true;
            tbPassword.PlaceholderColor = Color.DarkGray;
            tbPassword.PlaceholderText = "";
            tbPassword.Size = new Size(185, 35);
            tbPassword.TabIndex = 40;
            tbPassword.UnderlinedStyle = false;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.BackColor = Color.FromArgb(64, 64, 64);
            tbConfirmPassword.BorderColor = Color.White;
            tbConfirmPassword.BorderFocusColor = Color.White;
            tbConfirmPassword.BorderRadius = 10;
            tbConfirmPassword.BorderSize = 2;
            tbConfirmPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbConfirmPassword.ForeColor = Color.White;
            tbConfirmPassword.Location = new Point(176, 199);
            tbConfirmPassword.Margin = new Padding(4);
            tbConfirmPassword.Multiline = false;
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Padding = new Padding(10, 7, 10, 7);
            tbConfirmPassword.PasswordChar = true;
            tbConfirmPassword.PlaceholderColor = Color.DarkGray;
            tbConfirmPassword.PlaceholderText = "";
            tbConfirmPassword.Size = new Size(184, 35);
            tbConfirmPassword.TabIndex = 41;
            tbConfirmPassword.UnderlinedStyle = false;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(499, 307);
            Controls.Add(tbConfirmPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbCode);
            Controls.Add(tbEmail);
            Controls.Add(pbHide1);
            Controls.Add(pbShow1);
            Controls.Add(pbHide);
            Controls.Add(pbShow);
            Controls.Add(btnApply);
            Controls.Add(btnSendCode);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ResetPassword";
            Text = "ResetPassword";
            ((System.ComponentModel.ISupportInitialize)pbHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHide1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbShow1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnSendCode;
        private Label label3;
        private Label label4;
        private Button btnApply;
        private PictureBox pbHide;
        private PictureBox pbShow;
        private PictureBox pbHide1;
        private PictureBox pbShow1;
        private RoundTextBox tbEmail;
        private RoundTextBox tbCode;
        private RoundTextBox tbPassword;
        private RoundTextBox tbConfirmPassword;
    }
}