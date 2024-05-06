namespace NT106_User
{
    partial class Signup
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
            dtpDateOfBirth = new DateTimePicker();
            btnSignup = new Button();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            tbCofirmpassword = new TextBox();
            tbUsername = new TextBox();
            tbFullName = new TextBox();
            lbConfirmpassword = new Label();
            lbPassword = new Label();
            lbEmailaddress = new Label();
            lbUsername = new Label();
            lbDateofbirth = new Label();
            lbFullname = new Label();
            lbSignup = new Label();
            SuspendLayout();
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(12, 169);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(364, 23);
            dtpDateOfBirth.TabIndex = 9;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.Gray;
            btnSignup.FlatAppearance.BorderColor = Color.Gray;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = SystemColors.ControlLightLight;
            btnSignup.Location = new Point(12, 532);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(364, 29);
            btnSignup.TabIndex = 19;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(64, 64, 64);
            tbPassword.ForeColor = SystemColors.Window;
            tbPassword.Location = new Point(12, 382);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(364, 29);
            tbPassword.TabIndex = 15;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.FromArgb(64, 64, 64);
            tbEmail.ForeColor = SystemColors.Window;
            tbEmail.Location = new Point(12, 314);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(364, 29);
            tbEmail.TabIndex = 13;
            // 
            // tbCofirmpassword
            // 
            tbCofirmpassword.BackColor = Color.FromArgb(64, 64, 64);
            tbCofirmpassword.ForeColor = SystemColors.Window;
            tbCofirmpassword.Location = new Point(12, 459);
            tbCofirmpassword.Multiline = true;
            tbCofirmpassword.Name = "tbCofirmpassword";
            tbCofirmpassword.PasswordChar = '*';
            tbCofirmpassword.Size = new Size(364, 29);
            tbCofirmpassword.TabIndex = 17;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.FromArgb(64, 64, 64);
            tbUsername.ForeColor = SystemColors.Window;
            tbUsername.Location = new Point(12, 240);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(364, 29);
            tbUsername.TabIndex = 11;
            // 
            // tbFullName
            // 
            tbFullName.BackColor = Color.FromArgb(64, 64, 64);
            tbFullName.ForeColor = SystemColors.Window;
            tbFullName.Location = new Point(12, 85);
            tbFullName.Multiline = true;
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(364, 29);
            tbFullName.TabIndex = 7;
            // 
            // lbConfirmpassword
            // 
            lbConfirmpassword.Font = new Font("Segoe UI", 11.25F);
            lbConfirmpassword.ForeColor = SystemColors.ControlLightLight;
            lbConfirmpassword.Location = new Point(12, 426);
            lbConfirmpassword.Name = "lbConfirmpassword";
            lbConfirmpassword.Size = new Size(119, 20);
            lbConfirmpassword.TabIndex = 20;
            lbConfirmpassword.Text = "Cofirm Password";
            // 
            // lbPassword
            // 
            lbPassword.Font = new Font("Segoe UI", 11.25F);
            lbPassword.ForeColor = SystemColors.ControlLightLight;
            lbPassword.Location = new Point(12, 346);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 18;
            lbPassword.Text = "Password";
            // 
            // lbEmailaddress
            // 
            lbEmailaddress.Font = new Font("Segoe UI", 11.25F);
            lbEmailaddress.ForeColor = SystemColors.ControlLightLight;
            lbEmailaddress.Location = new Point(12, 282);
            lbEmailaddress.Name = "lbEmailaddress";
            lbEmailaddress.Size = new Size(101, 20);
            lbEmailaddress.TabIndex = 16;
            lbEmailaddress.Text = "Email address";
            // 
            // lbUsername
            // 
            lbUsername.Font = new Font("Segoe UI", 11.25F);
            lbUsername.ForeColor = SystemColors.ControlLightLight;
            lbUsername.Location = new Point(12, 207);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 20);
            lbUsername.TabIndex = 14;
            lbUsername.Text = "Username";
            // 
            // lbDateofbirth
            // 
            lbDateofbirth.Font = new Font("Segoe UI", 11.25F);
            lbDateofbirth.ForeColor = SystemColors.ControlLightLight;
            lbDateofbirth.Location = new Point(12, 131);
            lbDateofbirth.Name = "lbDateofbirth";
            lbDateofbirth.Size = new Size(94, 20);
            lbDateofbirth.TabIndex = 12;
            lbDateofbirth.Text = "Date of Birth";
            // 
            // lbFullname
            // 
            lbFullname.Font = new Font("Segoe UI", 11.25F);
            lbFullname.ForeColor = SystemColors.ControlLightLight;
            lbFullname.Location = new Point(12, 56);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new Size(76, 20);
            lbFullname.TabIndex = 10;
            lbFullname.Text = "Full Name";
            // 
            // lbSignup
            // 
            lbSignup.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignup.ForeColor = SystemColors.ControlLightLight;
            lbSignup.Location = new Point(12, 12);
            lbSignup.Name = "lbSignup";
            lbSignup.Size = new Size(85, 30);
            lbSignup.TabIndex = 8;
            lbSignup.Text = "Sign Up";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(394, 575);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(btnSignup);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(tbCofirmpassword);
            Controls.Add(tbUsername);
            Controls.Add(tbFullName);
            Controls.Add(lbConfirmpassword);
            Controls.Add(lbPassword);
            Controls.Add(lbEmailaddress);
            Controls.Add(lbUsername);
            Controls.Add(lbDateofbirth);
            Controls.Add(lbFullname);
            Controls.Add(lbSignup);
            Name = "Signup";
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDateOfBirth;
        private Button btnSignup;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private TextBox tbCofirmpassword;
        private TextBox tbUsername;
        private TextBox tbFullName;
        private Label lbConfirmpassword;
        private Label lbPassword;
        private Label lbEmailaddress;
        private Label lbUsername;
        private Label lbDateofbirth;
        private Label lbFullname;
        private Label lbSignup;
    }
}