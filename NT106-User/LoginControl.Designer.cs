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
            llbSignup = new LinkLabel();
            btnGetStarted = new Button();
            llbForgotPassword = new LinkLabel();
            cbRememberme = new CheckBox();
            txtPassword = new TextBox();
            txtUsernameorEmailaddress = new TextBox();
            label3 = new Label();
            lbUsernameorEmailaddress = new Label();
            lbSignIn = new Label();
            SuspendLayout();
            // 
            // lbOrsigninwith
            // 
            lbOrsigninwith.AutoSize = true;
            lbOrsigninwith.Font = new Font("Segoe UI", 11.25F);
            lbOrsigninwith.ForeColor = SystemColors.ControlLightLight;
            lbOrsigninwith.Location = new Point(147, 368);
            lbOrsigninwith.Name = "lbOrsigninwith";
            lbOrsigninwith.Size = new Size(104, 20);
            lbOrsigninwith.TabIndex = 18;
            lbOrsigninwith.Text = "Or sign in with";
            // 
            // llbSignup
            // 
            llbSignup.AutoSize = true;
            llbSignup.Font = new Font("Segoe UI", 11.25F);
            llbSignup.ForeColor = Color.White;
            llbSignup.LinkColor = Color.White;
            llbSignup.Location = new Point(111, 329);
            llbSignup.Name = "llbSignup";
            llbSignup.Size = new Size(217, 20);
            llbSignup.TabIndex = 17;
            llbSignup.TabStop = true;
            llbSignup.Text = "Don't have an account? Sign up";
            llbSignup.LinkClicked += llbSignup_LinkClicked;
            // 
            // btnGetStarted
            // 
            btnGetStarted.BackColor = Color.Gray;
            btnGetStarted.FlatAppearance.BorderColor = Color.Gray;
            btnGetStarted.FlatStyle = FlatStyle.Flat;
            btnGetStarted.Location = new Point(45, 275);
            btnGetStarted.Name = "btnGetStarted";
            btnGetStarted.Size = new Size(320, 28);
            btnGetStarted.TabIndex = 16;
            btnGetStarted.Text = "Get Started";
            btnGetStarted.UseVisualStyleBackColor = false;
            // 
            // llbForgotPassword
            // 
            llbForgotPassword.AutoSize = true;
            llbForgotPassword.Font = new Font("Segoe UI", 11.25F);
            llbForgotPassword.ForeColor = Color.White;
            llbForgotPassword.LinkColor = Color.White;
            llbForgotPassword.Location = new Point(238, 233);
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
            cbRememberme.Location = new Point(48, 229);
            cbRememberme.Name = "cbRememberme";
            cbRememberme.Size = new Size(126, 24);
            cbRememberme.TabIndex = 14;
            cbRememberme.Text = "Remember me";
            cbRememberme.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(64, 64, 64);
            txtPassword.Location = new Point(45, 179);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(320, 28);
            txtPassword.TabIndex = 13;
            // 
            // txtUsernameorEmailaddress
            // 
            txtUsernameorEmailaddress.BackColor = Color.FromArgb(64, 64, 64);
            txtUsernameorEmailaddress.Location = new Point(45, 106);
            txtUsernameorEmailaddress.Multiline = true;
            txtUsernameorEmailaddress.Name = "txtUsernameorEmailaddress";
            txtUsernameorEmailaddress.Size = new Size(320, 28);
            txtUsernameorEmailaddress.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(45, 149);
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
            lbUsernameorEmailaddress.Location = new Point(45, 75);
            lbUsernameorEmailaddress.Name = "lbUsernameorEmailaddress";
            lbUsernameorEmailaddress.Size = new Size(189, 20);
            lbUsernameorEmailaddress.TabIndex = 11;
            lbUsernameorEmailaddress.Text = "Username or Email address";
            // 
            // lbSignIn
            // 
            lbSignIn.AutoSize = true;
            lbSignIn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignIn.ForeColor = SystemColors.ControlLightLight;
            lbSignIn.Location = new Point(45, 28);
            lbSignIn.Name = "lbSignIn";
            lbSignIn.Size = new Size(70, 25);
            lbSignIn.TabIndex = 9;
            lbSignIn.Text = "Sign In";
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(lbOrsigninwith);
            Controls.Add(llbSignup);
            Controls.Add(btnGetStarted);
            Controls.Add(llbForgotPassword);
            Controls.Add(cbRememberme);
            Controls.Add(txtPassword);
            Controls.Add(txtUsernameorEmailaddress);
            Controls.Add(label3);
            Controls.Add(lbUsernameorEmailaddress);
            Controls.Add(lbSignIn);
            Name = "LoginControl";
            Size = new Size(410, 462);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbOrsigninwith;
        private LinkLabel llbSignup;
        private Button btnGetStarted;
        private LinkLabel llbForgotPassword;
        private CheckBox cbRememberme;
        private TextBox txtPassword;
        private TextBox txtUsernameorEmailaddress;
        private Label label3;
        private Label lbUsernameorEmailaddress;
        private Label lbSignIn;
    }
}
