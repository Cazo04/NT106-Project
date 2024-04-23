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
            linkLabel1 = new LinkLabel();
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
            lbOrsigninwith.Location = new Point(147, 368);
            lbOrsigninwith.Name = "lbOrsigninwith";
            lbOrsigninwith.Size = new Size(84, 15);
            lbOrsigninwith.TabIndex = 18;
            lbOrsigninwith.Text = "Or sign in with";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(97, 324);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(174, 15);
            linkLabel1.TabIndex = 17;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don't have an account? Sign up";
            // 
            // btnGetStarted
            // 
            btnGetStarted.Location = new Point(45, 275);
            btnGetStarted.Name = "btnGetStarted";
            btnGetStarted.Size = new Size(287, 29);
            btnGetStarted.TabIndex = 16;
            btnGetStarted.Text = "Get Started";
            btnGetStarted.UseVisualStyleBackColor = true;
            // 
            // llbForgotPassword
            // 
            llbForgotPassword.AutoSize = true;
            llbForgotPassword.Location = new Point(242, 232);
            llbForgotPassword.Name = "llbForgotPassword";
            llbForgotPassword.Size = new Size(100, 15);
            llbForgotPassword.TabIndex = 15;
            llbForgotPassword.TabStop = true;
            llbForgotPassword.Text = "Forgot password?";
            // 
            // cbRememberme
            // 
            cbRememberme.AutoSize = true;
            cbRememberme.Location = new Point(48, 229);
            cbRememberme.Name = "cbRememberme";
            cbRememberme.Size = new Size(104, 19);
            cbRememberme.TabIndex = 14;
            cbRememberme.Text = "Remember me";
            cbRememberme.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(45, 179);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(287, 23);
            txtPassword.TabIndex = 13;
            // 
            // txtUsernameorEmailaddress
            // 
            txtUsernameorEmailaddress.Location = new Point(45, 106);
            txtUsernameorEmailaddress.Name = "txtUsernameorEmailaddress";
            txtUsernameorEmailaddress.Size = new Size(287, 23);
            txtUsernameorEmailaddress.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 149);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // lbUsernameorEmailaddress
            // 
            lbUsernameorEmailaddress.AutoSize = true;
            lbUsernameorEmailaddress.Location = new Point(45, 75);
            lbUsernameorEmailaddress.Name = "lbUsernameorEmailaddress";
            lbUsernameorEmailaddress.Size = new Size(149, 15);
            lbUsernameorEmailaddress.TabIndex = 11;
            lbUsernameorEmailaddress.Text = "Username or Email address";
            // 
            // lbSignIn
            // 
            lbSignIn.AutoSize = true;
            lbSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignIn.Location = new Point(45, 28);
            lbSignIn.Name = "lbSignIn";
            lbSignIn.Size = new Size(58, 21);
            lbSignIn.TabIndex = 9;
            lbSignIn.Text = "Sign In";
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbOrsigninwith);
            Controls.Add(linkLabel1);
            Controls.Add(btnGetStarted);
            Controls.Add(llbForgotPassword);
            Controls.Add(cbRememberme);
            Controls.Add(txtPassword);
            Controls.Add(txtUsernameorEmailaddress);
            Controls.Add(label3);
            Controls.Add(lbUsernameorEmailaddress);
            Controls.Add(lbSignIn);
            Name = "LoginControl";
            Size = new Size(386, 444);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbOrsigninwith;
        private LinkLabel linkLabel1;
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
