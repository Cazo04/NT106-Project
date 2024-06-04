namespace NT106_User
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            btnOutlock = new Button();
            btnGoogle = new Button();
            lbOrsigninwith = new Label();
            btnGetStarted = new Button();
            llbForgotPassword = new LinkLabel();
            cbRememberme = new CheckBox();
            label3 = new Label();
            lbUsernameorEmailaddress = new Label();
            lbSignIn = new Label();
            llbSignup = new LinkLabel();
            tbUsernameOrEmail = new RoundTextBox();
            tbPassword = new RoundTextBox();
            pbShow = new PictureBox();
            pbHide = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHide).BeginInit();
            SuspendLayout();
            // 
            // btnOutlock
            // 
            btnOutlock.FlatStyle = FlatStyle.Flat;
            btnOutlock.Font = new Font("Segoe UI", 12F);
            btnOutlock.ForeColor = Color.Cyan;
            btnOutlock.Image = Properties.Resources.icons8_outlook_24;
            btnOutlock.ImageAlign = ContentAlignment.MiddleLeft;
            btnOutlock.Location = new Point(226, 483);
            btnOutlock.Name = "btnOutlock";
            btnOutlock.Size = new Size(134, 39);
            btnOutlock.TabIndex = 7;
            btnOutlock.Text = "Outlock";
            btnOutlock.UseVisualStyleBackColor = true;
            // 
            // btnGoogle
            // 
            btnGoogle.BackgroundImageLayout = ImageLayout.Zoom;
            btnGoogle.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnGoogle.FlatStyle = FlatStyle.Flat;
            btnGoogle.Font = new Font("Segoe UI", 12F);
            btnGoogle.ForeColor = Color.FromArgb(255, 128, 128);
            btnGoogle.Image = Properties.Resources.icons8_google_24;
            btnGoogle.ImageAlign = ContentAlignment.MiddleLeft;
            btnGoogle.Location = new Point(12, 483);
            btnGoogle.Name = "btnGoogle";
            btnGoogle.Size = new Size(134, 39);
            btnGoogle.TabIndex = 6;
            btnGoogle.Text = "Google";
            btnGoogle.UseVisualStyleBackColor = true;
            // 
            // lbOrsigninwith
            // 
            lbOrsigninwith.AutoSize = true;
            lbOrsigninwith.Font = new Font("Segoe UI", 11.25F);
            lbOrsigninwith.ForeColor = SystemColors.ControlLightLight;
            lbOrsigninwith.Location = new Point(130, 426);
            lbOrsigninwith.Name = "lbOrsigninwith";
            lbOrsigninwith.Size = new Size(104, 20);
            lbOrsigninwith.TabIndex = 29;
            lbOrsigninwith.Text = "Or sign in with";
            // 
            // btnGetStarted
            // 
            btnGetStarted.BackColor = Color.Gray;
            btnGetStarted.FlatAppearance.BorderColor = Color.Gray;
            btnGetStarted.FlatStyle = FlatStyle.Flat;
            btnGetStarted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGetStarted.ForeColor = SystemColors.ControlLightLight;
            btnGetStarted.Location = new Point(12, 351);
            btnGetStarted.Name = "btnGetStarted";
            btnGetStarted.Size = new Size(348, 33);
            btnGetStarted.TabIndex = 4;
            btnGetStarted.Text = "Get Started";
            btnGetStarted.UseVisualStyleBackColor = false;
            btnGetStarted.Click += btnGetStarted_Click;
            // 
            // llbForgotPassword
            // 
            llbForgotPassword.AutoSize = true;
            llbForgotPassword.Font = new Font("Segoe UI", 11.25F);
            llbForgotPassword.ForeColor = Color.White;
            llbForgotPassword.LinkColor = Color.White;
            llbForgotPassword.Location = new Point(233, 294);
            llbForgotPassword.Name = "llbForgotPassword";
            llbForgotPassword.Size = new Size(127, 20);
            llbForgotPassword.TabIndex = 3;
            llbForgotPassword.TabStop = true;
            llbForgotPassword.Text = "Forgot password?";
            // 
            // cbRememberme
            // 
            cbRememberme.AutoSize = true;
            cbRememberme.Font = new Font("Segoe UI", 11.25F);
            cbRememberme.ForeColor = SystemColors.ControlLightLight;
            cbRememberme.Location = new Point(12, 290);
            cbRememberme.Name = "cbRememberme";
            cbRememberme.Size = new Size(126, 24);
            cbRememberme.TabIndex = 2;
            cbRememberme.Text = "Remember me";
            cbRememberme.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 187);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 22;
            label3.Text = "Password";
            // 
            // lbUsernameorEmailaddress
            // 
            lbUsernameorEmailaddress.AutoSize = true;
            lbUsernameorEmailaddress.Font = new Font("Segoe UI", 11.25F);
            lbUsernameorEmailaddress.ForeColor = SystemColors.ControlLightLight;
            lbUsernameorEmailaddress.Location = new Point(12, 85);
            lbUsernameorEmailaddress.Name = "lbUsernameorEmailaddress";
            lbUsernameorEmailaddress.Size = new Size(189, 20);
            lbUsernameorEmailaddress.TabIndex = 23;
            lbUsernameorEmailaddress.Text = "Username or Email address";
            // 
            // lbSignIn
            // 
            lbSignIn.AutoSize = true;
            lbSignIn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignIn.ForeColor = SystemColors.ControlLightLight;
            lbSignIn.Location = new Point(16, 13);
            lbSignIn.Name = "lbSignIn";
            lbSignIn.Size = new Size(77, 30);
            lbSignIn.TabIndex = 21;
            lbSignIn.Text = "Sign In";
            // 
            // llbSignup
            // 
            llbSignup.AutoSize = true;
            llbSignup.Font = new Font("Segoe UI", 11.25F);
            llbSignup.ForeColor = Color.White;
            llbSignup.LinkColor = Color.White;
            llbSignup.Location = new Point(78, 397);
            llbSignup.Name = "llbSignup";
            llbSignup.Size = new Size(217, 20);
            llbSignup.TabIndex = 5;
            llbSignup.TabStop = true;
            llbSignup.Text = "Don't have an account? Sign up";
            llbSignup.LinkClicked += llbSignup_LinkClicked;
            // 
            // tbUsernameOrEmail
            // 
            tbUsernameOrEmail.BackColor = Color.FromArgb(64, 64, 64);
            tbUsernameOrEmail.BorderColor = Color.White;
            tbUsernameOrEmail.BorderFocusColor = Color.White;
            tbUsernameOrEmail.BorderRadius = 10;
            tbUsernameOrEmail.BorderSize = 2;
            tbUsernameOrEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsernameOrEmail.ForeColor = Color.White;
            tbUsernameOrEmail.Location = new Point(12, 129);
            tbUsernameOrEmail.Margin = new Padding(4);
            tbUsernameOrEmail.Multiline = false;
            tbUsernameOrEmail.Name = "tbUsernameOrEmail";
            tbUsernameOrEmail.Padding = new Padding(10, 7, 10, 7);
            tbUsernameOrEmail.PasswordChar = false;
            tbUsernameOrEmail.PlaceholderColor = Color.DarkGray;
            tbUsernameOrEmail.PlaceholderText = "";
            tbUsernameOrEmail.Size = new Size(348, 32);
            tbUsernameOrEmail.TabIndex = 0;
            tbUsernameOrEmail.UnderlinedStyle = false;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.FromArgb(64, 64, 64);
            tbPassword.BorderColor = Color.White;
            tbPassword.BorderFocusColor = Color.White;
            tbPassword.BorderRadius = 10;
            tbPassword.BorderSize = 2;
            tbPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.ForeColor = Color.White;
            tbPassword.Location = new Point(12, 234);
            tbPassword.Margin = new Padding(4);
            tbPassword.Multiline = false;
            tbPassword.Name = "tbPassword";
            tbPassword.Padding = new Padding(10, 7, 10, 7);
            tbPassword.PasswordChar = true;
            tbPassword.PlaceholderColor = Color.DarkGray;
            tbPassword.PlaceholderText = "";
            tbPassword.Size = new Size(348, 32);
            tbPassword.TabIndex = 1;
            tbPassword.UnderlinedStyle = false;
            // 
            // pbShow
            // 
            pbShow.Image = (Image)resources.GetObject("pbShow.Image");
            pbShow.Location = new Point(368, 237);
            pbShow.Name = "pbShow";
            pbShow.Size = new Size(29, 29);
            pbShow.TabIndex = 30;
            pbShow.TabStop = false;
            pbShow.Click += pbShow_Click;
            // 
            // pbHide
            // 
            pbHide.Image = (Image)resources.GetObject("pbHide.Image");
            pbHide.Location = new Point(367, 237);
            pbHide.Name = "pbHide";
            pbHide.Size = new Size(29, 29);
            pbHide.TabIndex = 31;
            pbHide.TabStop = false;
            pbHide.Click += pbHide_Click;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(396, 548);
            Controls.Add(pbHide);
            Controls.Add(pbShow);
            Controls.Add(tbPassword);
            Controls.Add(tbUsernameOrEmail);
            Controls.Add(btnOutlock);
            Controls.Add(btnGoogle);
            Controls.Add(lbOrsigninwith);
            Controls.Add(btnGetStarted);
            Controls.Add(llbSignup);
            Controls.Add(llbForgotPassword);
            Controls.Add(cbRememberme);
            Controls.Add(label3);
            Controls.Add(lbUsernameorEmailaddress);
            Controls.Add(lbSignIn);
            Name = "SignIn";
            Text = "SignIn";
            ((System.ComponentModel.ISupportInitialize)pbShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHide).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOutlock;
        private Button btnGoogle;
        private Label lbOrsigninwith;
        private Button btnGetStarted;
        private LinkLabel llbForgotPassword;
        private CheckBox cbRememberme;
        private Label label3;
        private Label lbUsernameorEmailaddress;
        private Label lbSignIn;
        private LinkLabel llbSignup;
        private RoundTextBox tbUsernameOrEmail;
        private RoundTextBox tbPassword;
        private PictureBox pbShow;
        private PictureBox pbHide;
    }
}