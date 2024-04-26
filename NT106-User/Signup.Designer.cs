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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbSignup = new Label();
            lbFullname = new Label();
            lbDateofbirth = new Label();
            lbUsername = new Label();
            lbEmailaddress = new Label();
            lbPassword = new Label();
            lbConfirmpassword = new Label();
            txtFullname = new TextBox();
            txtUsername = new TextBox();
            txtCofirmpassword = new TextBox();
            txtEmailaddress = new TextBox();
            txtPassword = new TextBox();
            btnSignup = new Button();
            dtpDateOfBirth = new DateTimePicker();
            SuspendLayout();
            // 
            // lbSignup
            // 
            lbSignup.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSignup.ForeColor = SystemColors.ControlLightLight;
            lbSignup.Location = new Point(38, 19);
            lbSignup.Name = "lbSignup";
            lbSignup.Size = new Size(85, 30);
            lbSignup.TabIndex = 0;
            lbSignup.Text = "Sign Up";
            // 
            // lbFullname
            // 
            lbFullname.Font = new Font("Segoe UI", 11.25F);
            lbFullname.ForeColor = SystemColors.ControlLightLight;
            lbFullname.Location = new Point(38, 63);
            lbFullname.Name = "lbFullname";
            lbFullname.Size = new Size(76, 20);
            lbFullname.TabIndex = 1;
            lbFullname.Text = "Full Name";
            // 
            // lbDateofbirth
            // 
            lbDateofbirth.Font = new Font("Segoe UI", 11.25F);
            lbDateofbirth.ForeColor = SystemColors.ControlLightLight;
            lbDateofbirth.Location = new Point(38, 138);
            lbDateofbirth.Name = "lbDateofbirth";
            lbDateofbirth.Size = new Size(94, 20);
            lbDateofbirth.TabIndex = 2;
            lbDateofbirth.Text = "Date of Birth";
            // 
            // lbUsername
            // 
            lbUsername.Font = new Font("Segoe UI", 11.25F);
            lbUsername.ForeColor = SystemColors.ControlLightLight;
            lbUsername.Location = new Point(38, 214);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(75, 20);
            lbUsername.TabIndex = 3;
            lbUsername.Text = "Username";
            // 
            // lbEmailaddress
            // 
            lbEmailaddress.Font = new Font("Segoe UI", 11.25F);
            lbEmailaddress.ForeColor = SystemColors.ControlLightLight;
            lbEmailaddress.Location = new Point(38, 289);
            lbEmailaddress.Name = "lbEmailaddress";
            lbEmailaddress.Size = new Size(101, 20);
            lbEmailaddress.TabIndex = 4;
            lbEmailaddress.Text = "Email address";
            // 
            // lbPassword
            // 
            lbPassword.Font = new Font("Segoe UI", 11.25F);
            lbPassword.ForeColor = SystemColors.ControlLightLight;
            lbPassword.Location = new Point(38, 353);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 5;
            lbPassword.Text = "Password";
            // 
            // lbConfirmpassword
            // 
            lbConfirmpassword.Font = new Font("Segoe UI", 11.25F);
            lbConfirmpassword.ForeColor = SystemColors.ControlLightLight;
            lbConfirmpassword.Location = new Point(38, 433);
            lbConfirmpassword.Name = "lbConfirmpassword";
            lbConfirmpassword.Size = new Size(119, 20);
            lbConfirmpassword.TabIndex = 6;
            lbConfirmpassword.Text = "Cofirm Password";
            // 
            // txtFullname
            // 
            txtFullname.BackColor = Color.FromArgb(64, 64, 64);
            txtFullname.Location = new Point(38, 92);
            txtFullname.Multiline = true;
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(364, 29);
            txtFullname.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(64, 64, 64);
            txtUsername.Location = new Point(38, 247);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(364, 29);
            txtUsername.TabIndex = 2;
            // 
            // txtCofirmpassword
            // 
            txtCofirmpassword.BackColor = Color.FromArgb(64, 64, 64);
            txtCofirmpassword.Location = new Point(38, 466);
            txtCofirmpassword.Multiline = true;
            txtCofirmpassword.Name = "txtCofirmpassword";
            txtCofirmpassword.Size = new Size(364, 29);
            txtCofirmpassword.TabIndex = 5;
            // 
            // txtEmailaddress
            // 
            txtEmailaddress.BackColor = Color.FromArgb(64, 64, 64);
            txtEmailaddress.Location = new Point(38, 321);
            txtEmailaddress.Multiline = true;
            txtEmailaddress.Name = "txtEmailaddress";
            txtEmailaddress.Size = new Size(364, 29);
            txtEmailaddress.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(64, 64, 64);
            txtPassword.Location = new Point(38, 389);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(364, 29);
            txtPassword.TabIndex = 4;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.Gray;
            btnSignup.FlatAppearance.BorderColor = Color.Gray;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = SystemColors.ControlLightLight;
            btnSignup.Location = new Point(38, 539);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(364, 29);
            btnSignup.TabIndex = 6;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(38, 176);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(364, 23);
            dtpDateOfBirth.TabIndex = 1;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(dtpDateOfBirth);
            Controls.Add(btnSignup);
            Controls.Add(txtPassword);
            Controls.Add(txtEmailaddress);
            Controls.Add(txtCofirmpassword);
            Controls.Add(txtUsername);
            Controls.Add(txtFullname);
            Controls.Add(lbConfirmpassword);
            Controls.Add(lbPassword);
            Controls.Add(lbEmailaddress);
            Controls.Add(lbUsername);
            Controls.Add(lbDateofbirth);
            Controls.Add(lbFullname);
            Controls.Add(lbSignup);
            Name = "Signup";
            Padding = new Padding(5);
            Size = new Size(449, 589);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSignup;
        private Label lbFullname;
        private Label lbDateofbirth;
        private Label lbUsername;
        private Label lbEmailaddress;
        private Label lbPassword;
        private Label lbConfirmpassword;
        private TextBox txtFullname;
        private TextBox txtUsername;
        private TextBox txtCofirmpassword;
        private TextBox txtEmailaddress;
        private TextBox txtPassword;
        private Button btnSignup;
        private DateTimePicker dtpDateOfBirth;
    }
}
