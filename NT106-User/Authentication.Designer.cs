namespace NT106_User
{
    partial class Authentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            pnAuthentication = new Panel();
            lbOr = new Label();
            btnSignup = new Button();
            btnSignin = new Button();
            pnAuthentication.SuspendLayout();
            SuspendLayout();
            // 
            // pnAuthentication
            // 
            pnAuthentication.AutoScroll = true;
            pnAuthentication.Controls.Add(lbOr);
            pnAuthentication.Controls.Add(btnSignup);
            pnAuthentication.Controls.Add(btnSignin);
            pnAuthentication.Dock = DockStyle.Fill;
            pnAuthentication.Location = new Point(0, 0);
            pnAuthentication.Name = "pnAuthentication";
            pnAuthentication.Size = new Size(472, 593);
            pnAuthentication.TabIndex = 0;
            // 
            // lbOr
            // 
            lbOr.AutoSize = true;
            lbOr.Font = new Font("Segoe UI", 15.75F);
            lbOr.ForeColor = SystemColors.ControlLightLight;
            lbOr.Location = new Point(212, 254);
            lbOr.Name = "lbOr";
            lbOr.Size = new Size(36, 30);
            lbOr.TabIndex = 11;
            lbOr.Text = "Or";
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(64, 64, 64);
            btnSignup.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 128);
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI", 15.75F);
            btnSignup.ForeColor = Color.FromArgb(255, 255, 128);
            btnSignup.Image = Properties.Resources.icons8_sign_up_50;
            btnSignup.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignup.Location = new Point(120, 327);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(223, 80);
            btnSignup.TabIndex = 10;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.FromArgb(64, 64, 64);
            btnSignin.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            btnSignin.FlatStyle = FlatStyle.Flat;
            btnSignin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignin.ForeColor = Color.FromArgb(128, 255, 255);
            btnSignin.Image = (Image)resources.GetObject("btnSignin.Image");
            btnSignin.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignin.Location = new Point(120, 132);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(223, 80);
            btnSignin.TabIndex = 9;
            btnSignin.Text = "Sign In";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(472, 593);
            Controls.Add(pnAuthentication);
            Name = "Authentication";
            pnAuthentication.ResumeLayout(false);
            pnAuthentication.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnAuthentication;
        private Label lbOr;
        private Button btnSignup;
        private Button btnSignin;
    }
}