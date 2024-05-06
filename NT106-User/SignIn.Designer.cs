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
            btnOutlock = new Button();
            btnGoogle = new Button();
            lbOrsigninwith = new Label();
            btnGetStarted = new Button();
            llbForgotPassword = new LinkLabel();
            cbRememberme = new CheckBox();
            tbUsernameOrEmail = new TextBox();
            label3 = new Label();
            lbUsernameorEmailaddress = new Label();
            lbSignIn = new Label();
            llbSignup = new LinkLabel();
            tbPassword = new TextBox();
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
            // tbUsernameOrEmail
            // 
            tbUsernameOrEmail.BackColor = Color.FromArgb(64, 64, 64);
            tbUsernameOrEmail.ForeColor = SystemColors.Window;
            tbUsernameOrEmail.Location = new Point(12, 121);
            tbUsernameOrEmail.Multiline = true;
            tbUsernameOrEmail.Name = "tbUsernameOrEmail";
            tbUsernameOrEmail.Size = new Size(348, 33);
            tbUsernameOrEmail.TabIndex = 0;
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
            // tbPassword
            // 
            tbPassword.Location = new Point(12, 226);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(348, 23);
            tbPassword.TabIndex = 1;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(382, 548);
            Controls.Add(tbPassword);
            Controls.Add(btnOutlock);
            Controls.Add(btnGoogle);
            Controls.Add(lbOrsigninwith);
            Controls.Add(btnGetStarted);
            Controls.Add(llbSignup);
            Controls.Add(llbForgotPassword);
            Controls.Add(cbRememberme);
            Controls.Add(tbUsernameOrEmail);
            Controls.Add(label3);
            Controls.Add(lbUsernameorEmailaddress);
            Controls.Add(lbSignIn);
            Name = "SignIn";
            Text = "SignIn";
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
        private TextBox tbUsernameOrEmail;
        private Label label3;
        private Label lbUsernameorEmailaddress;
        private Label lbSignIn;
        private LinkLabel llbSignup;
        private TextBox tbPassword;
    }
}