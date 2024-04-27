namespace NT106_User
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbOrsigninwith = new Label();
            btnGetStarted = new Button();
            llbForgotPassword = new LinkLabel();
            cbRememberme = new CheckBox();
            txtPassword = new TextBox();
            txtUsernameorEmailaddress = new TextBox();
            label3 = new Label();
            lbUsernameorEmailaddress = new Label();
            lbSignIn = new Label();
            btnGoogle = new Button();
            btnOutlock = new Button();
            SuspendLayout();
            // 
            // lbOrsigninwith
            // 
            lbOrsigninwith.AutoSize = true;
            lbOrsigninwith.Font = new Font("Segoe UI", 11.25F);
            lbOrsigninwith.ForeColor = SystemColors.ControlLightLight;
            lbOrsigninwith.Location = new Point(164, 446);
            lbOrsigninwith.Name = "lbOrsigninwith";
            lbOrsigninwith.Size = new Size(104, 20);
            lbOrsigninwith.TabIndex = 18;
            lbOrsigninwith.Text = "Or sign in with";
            // 
            // btnGetStarted
            // 
            btnGetStarted.BackColor = Color.Gray;
            btnGetStarted.FlatAppearance.BorderColor = Color.Gray;
            btnGetStarted.FlatStyle = FlatStyle.Flat;
            btnGetStarted.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGetStarted.ForeColor = SystemColors.ControlLightLight;
            btnGetStarted.Location = new Point(46, 371);
            btnGetStarted.Name = "btnGetStarted";
            btnGetStarted.Size = new Size(348, 33);
            btnGetStarted.TabIndex = 16;
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
            llbForgotPassword.Location = new Point(267, 314);
            llbForgotPassword.Name = "llbForgotPassword";
            llbForgotPassword.Size = new Size(127, 20);
            llbForgotPassword.TabIndex = 15;
            llbForgotPassword.TabStop = true;
            llbForgotPassword.Text = "Forgot password?";
            // 
            // cbRememberme
            // 
            cbRememberme.AutoSize = true;
            cbRememberme.Font = new Font("Segoe UI", 11.25F);
            cbRememberme.ForeColor = SystemColors.ControlLightLight;
            cbRememberme.Location = new Point(46, 310);
            cbRememberme.Name = "cbRememberme";
            cbRememberme.Size = new Size(126, 24);
            cbRememberme.TabIndex = 14;
            cbRememberme.Text = "Remember me";
            cbRememberme.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(64, 64, 64);
            txtPassword.Location = new Point(46, 244);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(348, 33);
            txtPassword.TabIndex = 13;
            // 
            // txtUsernameorEmailaddress
            // 
            txtUsernameorEmailaddress.BackColor = Color.FromArgb(64, 64, 64);
            txtUsernameorEmailaddress.Location = new Point(46, 141);
            txtUsernameorEmailaddress.Multiline = true;
            txtUsernameorEmailaddress.Name = "txtUsernameorEmailaddress";
            txtUsernameorEmailaddress.Size = new Size(348, 33);
            txtUsernameorEmailaddress.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(46, 207);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // lbUsernameorEmailaddress
            // 
            lbUsernameorEmailaddress.AutoSize = true;
            lbUsernameorEmailaddress.Font = new Font("Segoe UI", 11.25F);
            lbUsernameorEmailaddress.ForeColor = SystemColors.ControlLightLight;
            lbUsernameorEmailaddress.Location = new Point(46, 105);
            lbUsernameorEmailaddress.Name = "lbUsernameorEmailaddress";
            lbUsernameorEmailaddress.Size = new Size(189, 20);
            lbUsernameorEmailaddress.TabIndex = 11;
            lbUsernameorEmailaddress.Text = "Username or Email address";
            // 
            // lbSignIn
            // 
            lbSignIn.AutoSize = true;
            lbSignIn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignIn.ForeColor = SystemColors.ControlLightLight;
            lbSignIn.Location = new Point(50, 33);
            lbSignIn.Name = "lbSignIn";
            lbSignIn.Size = new Size(77, 30);
            lbSignIn.TabIndex = 9;
            lbSignIn.Text = "Sign In";
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
            btnGoogle.Location = new Point(46, 503);
            btnGoogle.Name = "btnGoogle";
            btnGoogle.Size = new Size(134, 39);
            btnGoogle.TabIndex = 19;
            btnGoogle.Text = "Google";
            btnGoogle.UseVisualStyleBackColor = true;
            // 
            // btnOutlock
            // 
            btnOutlock.FlatStyle = FlatStyle.Flat;
            btnOutlock.Font = new Font("Segoe UI", 12F);
            btnOutlock.ForeColor = Color.Cyan;
            btnOutlock.Image = Properties.Resources.icons8_outlook_24;
            btnOutlock.ImageAlign = ContentAlignment.MiddleLeft;
            btnOutlock.Location = new Point(260, 503);
            btnOutlock.Name = "btnOutlock";
            btnOutlock.Size = new Size(134, 39);
            btnOutlock.TabIndex = 20;
            btnOutlock.Text = "Outlock";
            btnOutlock.UseVisualStyleBackColor = true;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnOutlock);
            Controls.Add(btnGoogle);
            Controls.Add(lbOrsigninwith);
            Controls.Add(btnGetStarted);
            Controls.Add(llbForgotPassword);
            Controls.Add(cbRememberme);
            Controls.Add(txtPassword);
            Controls.Add(txtUsernameorEmailaddress);
            Controls.Add(label3);
            Controls.Add(lbUsernameorEmailaddress);
            Controls.Add(lbSignIn);
            Name = "LoginControl";
            Padding = new Padding(5);
            Size = new Size(449, 589);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbOrsigninwith;
        private Button btnGetStarted;
        private LinkLabel llbForgotPassword;
        private CheckBox cbRememberme;
        private TextBox txtPassword;
        private TextBox txtUsernameorEmailaddress;
        private Label label3;
        private Label lbUsernameorEmailaddress;
        private Label lbSignIn;
        private Button btnGoogle;
        private Button btnOutlock;
    }
}
