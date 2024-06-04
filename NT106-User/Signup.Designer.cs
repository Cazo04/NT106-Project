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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            dtpDateOfBirth = new DateTimePicker();
            btnSignup = new Button();
            lbConfirmpassword = new Label();
            lbPassword = new Label();
            lbEmailaddress = new Label();
            lbUsername = new Label();
            lbDateofbirth = new Label();
            lbFullname = new Label();
            lbSignup = new Label();
            tbFullName = new RoundTextBox();
            tbUsername = new RoundTextBox();
            tbEmail = new RoundTextBox();
            tbPassword = new RoundTextBox();
            tbConfirmpassword = new RoundTextBox();
            pbHide = new PictureBox();
            pbShow = new PictureBox();
            pbHide1 = new PictureBox();
            pbShow1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHide1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbShow1).BeginInit();
            SuspendLayout();
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(12, 171);
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
            btnSignup.TabIndex = 14;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // lbConfirmpassword
            // 
            lbConfirmpassword.Font = new Font("Segoe UI", 11.25F);
            lbConfirmpassword.ForeColor = SystemColors.ControlLightLight;
            lbConfirmpassword.Location = new Point(12, 442);
            lbConfirmpassword.Name = "lbConfirmpassword";
            lbConfirmpassword.Size = new Size(119, 20);
            lbConfirmpassword.TabIndex = 20;
            lbConfirmpassword.Text = "Cofirm Password";
            // 
            // lbPassword
            // 
            lbPassword.Font = new Font("Segoe UI", 11.25F);
            lbPassword.ForeColor = SystemColors.ControlLightLight;
            lbPassword.Location = new Point(12, 366);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 18;
            lbPassword.Text = "Password";
            // 
            // lbEmailaddress
            // 
            lbEmailaddress.Font = new Font("Segoe UI", 11.25F);
            lbEmailaddress.ForeColor = SystemColors.ControlLightLight;
            lbEmailaddress.Location = new Point(12, 295);
            lbEmailaddress.Name = "lbEmailaddress";
            lbEmailaddress.Size = new Size(101, 20);
            lbEmailaddress.TabIndex = 16;
            lbEmailaddress.Text = "Email address";
            // 
            // lbUsername
            // 
            lbUsername.Font = new Font("Segoe UI", 11.25F);
            lbUsername.ForeColor = SystemColors.ControlLightLight;
            lbUsername.Location = new Point(13, 223);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 20);
            lbUsername.TabIndex = 14;
            lbUsername.Text = "Username";
            // 
            // lbDateofbirth
            // 
            lbDateofbirth.Font = new Font("Segoe UI", 11.25F);
            lbDateofbirth.ForeColor = SystemColors.ControlLightLight;
            lbDateofbirth.Location = new Point(12, 148);
            lbDateofbirth.Name = "lbDateofbirth";
            lbDateofbirth.Size = new Size(94, 20);
            lbDateofbirth.TabIndex = 12;
            lbDateofbirth.Text = "Date of Birth";
            // 
            // lbFullname
            // 
            lbFullname.Font = new Font("Segoe UI", 11.25F);
            lbFullname.ForeColor = SystemColors.ControlLightLight;
            lbFullname.Location = new Point(12, 72);
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
            // tbFullName
            // 
            tbFullName.BackColor = Color.FromArgb(64, 64, 64);
            tbFullName.BorderColor = Color.White;
            tbFullName.BorderFocusColor = Color.White;
            tbFullName.BorderRadius = 10;
            tbFullName.BorderSize = 2;
            tbFullName.Font = new Font("Segoe UI", 9.75F);
            tbFullName.ForeColor = Color.White;
            tbFullName.Location = new Point(13, 96);
            tbFullName.Margin = new Padding(4);
            tbFullName.Multiline = false;
            tbFullName.Name = "tbFullName";
            tbFullName.Padding = new Padding(10, 7, 10, 7);
            tbFullName.PasswordChar = false;
            tbFullName.PlaceholderColor = Color.DarkGray;
            tbFullName.PlaceholderText = "";
            tbFullName.Size = new Size(364, 32);
            tbFullName.TabIndex = 8;
            tbFullName.UnderlinedStyle = false;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.FromArgb(64, 64, 64);
            tbUsername.BorderColor = Color.White;
            tbUsername.BorderFocusColor = Color.White;
            tbUsername.BorderRadius = 10;
            tbUsername.BorderSize = 2;
            tbUsername.Font = new Font("Segoe UI", 9.75F);
            tbUsername.ForeColor = Color.White;
            tbUsername.Location = new Point(12, 247);
            tbUsername.Margin = new Padding(4);
            tbUsername.Multiline = false;
            tbUsername.Name = "tbUsername";
            tbUsername.Padding = new Padding(10, 7, 10, 7);
            tbUsername.PasswordChar = false;
            tbUsername.PlaceholderColor = Color.DarkGray;
            tbUsername.PlaceholderText = "";
            tbUsername.Size = new Size(364, 32);
            tbUsername.TabIndex = 10;
            tbUsername.UnderlinedStyle = false;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.FromArgb(64, 64, 64);
            tbEmail.BorderColor = Color.White;
            tbEmail.BorderFocusColor = Color.White;
            tbEmail.BorderRadius = 10;
            tbEmail.BorderSize = 2;
            tbEmail.Font = new Font("Segoe UI", 9.75F);
            tbEmail.ForeColor = Color.White;
            tbEmail.Location = new Point(12, 319);
            tbEmail.Margin = new Padding(4);
            tbEmail.Multiline = false;
            tbEmail.Name = "tbEmail";
            tbEmail.Padding = new Padding(10, 7, 10, 7);
            tbEmail.PasswordChar = false;
            tbEmail.PlaceholderColor = Color.DarkGray;
            tbEmail.PlaceholderText = "";
            tbEmail.Size = new Size(364, 32);
            tbEmail.TabIndex = 11;
            tbEmail.UnderlinedStyle = false;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(64, 64, 64);
            tbPassword.BorderColor = Color.White;
            tbPassword.BorderFocusColor = Color.White;
            tbPassword.BorderRadius = 10;
            tbPassword.BorderSize = 2;
            tbPassword.Font = new Font("Segoe UI", 9.75F);
            tbPassword.ForeColor = Color.White;
            tbPassword.Location = new Point(12, 390);
            tbPassword.Margin = new Padding(4);
            tbPassword.Multiline = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Padding = new Padding(10, 7, 10, 7);
            tbPassword.PasswordChar = true;
            tbPassword.PlaceholderColor = Color.DarkGray;
            tbPassword.PlaceholderText = "";
            tbPassword.Size = new Size(364, 32);
            tbPassword.TabIndex = 12;
            tbPassword.UnderlinedStyle = false;
            // 
            // tbConfirmpassword
            // 
            tbConfirmpassword.BackColor = Color.FromArgb(64, 64, 64);
            tbConfirmpassword.BorderColor = Color.White;
            tbConfirmpassword.BorderFocusColor = Color.White;
            tbConfirmpassword.BorderRadius = 10;
            tbConfirmpassword.BorderSize = 2;
            tbConfirmpassword.Font = new Font("Segoe UI", 9.75F);
            tbConfirmpassword.ForeColor = Color.White;
            tbConfirmpassword.Location = new Point(12, 466);
            tbConfirmpassword.Margin = new Padding(4);
            tbConfirmpassword.Multiline = false;
            tbConfirmpassword.Name = "tbConfirmpassword";
            tbConfirmpassword.Padding = new Padding(10, 7, 10, 7);
            tbConfirmpassword.PasswordChar = true;
            tbConfirmpassword.PlaceholderColor = Color.DarkGray;
            tbConfirmpassword.PlaceholderText = "";
            tbConfirmpassword.Size = new Size(364, 32);
            tbConfirmpassword.TabIndex = 13;
            tbConfirmpassword.UnderlinedStyle = false;
            // 
            // pbHide
            // 
            pbHide.Image = (Image)resources.GetObject("pbHide.Image");
            pbHide.Location = new Point(382, 393);
            pbHide.Name = "pbHide";
            pbHide.Size = new Size(29, 29);
            pbHide.TabIndex = 33;
            pbHide.TabStop = false;
            pbHide.Click += pbHide_Click;
            // 
            // pbShow
            // 
            pbShow.Image = (Image)resources.GetObject("pbShow.Image");
            pbShow.Location = new Point(382, 393);
            pbShow.Name = "pbShow";
            pbShow.Size = new Size(29, 29);
            pbShow.TabIndex = 32;
            pbShow.TabStop = false;
            pbShow.Click += pbShow_Click;
            // 
            // pbHide1
            // 
            pbHide1.Image = (Image)resources.GetObject("pbHide1.Image");
            pbHide1.Location = new Point(382, 469);
            pbHide1.Name = "pbHide1";
            pbHide1.Size = new Size(29, 29);
            pbHide1.TabIndex = 35;
            pbHide1.TabStop = false;
            pbHide1.Click += pbHide2_Click;
            // 
            // pbShow1
            // 
            pbShow1.Image = (Image)resources.GetObject("pbShow1.Image");
            pbShow1.Location = new Point(383, 469);
            pbShow1.Name = "pbShow1";
            pbShow1.Size = new Size(29, 29);
            pbShow1.TabIndex = 34;
            pbShow1.TabStop = false;
            pbShow1.Click += pbShow1_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(410, 575);
            Controls.Add(pbHide1);
            Controls.Add(pbShow1);
            Controls.Add(pbHide);
            Controls.Add(pbShow);
            Controls.Add(tbConfirmpassword);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(tbUsername);
            Controls.Add(tbFullName);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(btnSignup);
            Controls.Add(lbConfirmpassword);
            Controls.Add(lbPassword);
            Controls.Add(lbEmailaddress);
            Controls.Add(lbUsername);
            Controls.Add(lbDateofbirth);
            Controls.Add(lbFullname);
            Controls.Add(lbSignup);
            Name = "Signup";
            Text = "Signup";
            ((System.ComponentModel.ISupportInitialize)pbHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHide1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbShow1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpDateOfBirth;
        private Button btnSignup;
        private Label lbConfirmpassword;
        private Label lbPassword;
        private Label lbEmailaddress;
        private Label lbUsername;
        private Label lbDateofbirth;
        private Label lbFullname;
        private Label lbSignup;
        private RoundTextBox tbFullName;
        private RoundTextBox tbUsername;
        private RoundTextBox tbEmail;
        private RoundTextBox tbPassword;
        private RoundTextBox tbConfirmpassword;
        private PictureBox pbHide;
        private PictureBox pbShow;
        private PictureBox pbHide1;
        private PictureBox pbShow1;
    }
}