namespace NT106_User
{
    partial class Profile
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
            panel2 = new Panel();
            pbHide1 = new PictureBox();
            pbShow1 = new PictureBox();
            tbConfirmNewPassword = new RoundTextBox();
            tbNewPassword = new RoundTextBox();
            tbOldPassword = new RoundTextBox();
            dtpDateOfBirth = new DateTimePicker();
            btnEdit = new Button();
            lbUsername = new Label();
            btnChangePassword = new Button();
            lbConfirmnewpassword = new Label();
            lbNewpassword = new Label();
            lbOldpassword = new Label();
            lbChangePassword = new Label();
            btnSave = new Button();
            tbSMS = new TextBox();
            tbEmail = new TextBox();
            tbFullName = new TextBox();
            lbDateofBirth = new Label();
            lbSMS = new Label();
            lbEmail = new Label();
            lbFullName = new Label();
            imgUser = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHide1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbShow1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(pbHide1);
            panel2.Controls.Add(pbShow1);
            panel2.Controls.Add(tbConfirmNewPassword);
            panel2.Controls.Add(tbNewPassword);
            panel2.Controls.Add(tbOldPassword);
            panel2.Controls.Add(dtpDateOfBirth);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(lbUsername);
            panel2.Controls.Add(btnChangePassword);
            panel2.Controls.Add(lbConfirmnewpassword);
            panel2.Controls.Add(lbNewpassword);
            panel2.Controls.Add(lbOldpassword);
            panel2.Controls.Add(lbChangePassword);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(tbSMS);
            panel2.Controls.Add(tbEmail);
            panel2.Controls.Add(tbFullName);
            panel2.Controls.Add(lbDateofBirth);
            panel2.Controls.Add(lbSMS);
            panel2.Controls.Add(lbEmail);
            panel2.Controls.Add(lbFullName);
            panel2.Controls.Add(imgUser);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 880);
            panel2.TabIndex = 20;
            // 
            // pbHide1
            // 
            pbHide1.Image = Properties.Resources.icons8_visibility_off_25;
            pbHide1.Location = new Point(522, 1023);
            pbHide1.Margin = new Padding(3, 4, 3, 4);
            pbHide1.Name = "pbHide1";
            pbHide1.Size = new Size(33, 39);
            pbHide1.TabIndex = 44;
            pbHide1.TabStop = false;
            pbHide1.Click += pbHide1_Click;
            // 
            // pbShow1
            // 
            pbShow1.Image = Properties.Resources.icons8_visibility_25;
            pbShow1.Location = new Point(522, 1023);
            pbShow1.Margin = new Padding(3, 4, 3, 4);
            pbShow1.Name = "pbShow1";
            pbShow1.Size = new Size(33, 39);
            pbShow1.TabIndex = 43;
            pbShow1.TabStop = false;
            pbShow1.Click += pbShow1_Click;
            // 
            // tbConfirmNewPassword
            // 
            tbConfirmNewPassword.BackColor = Color.FromArgb(64, 64, 64);
            tbConfirmNewPassword.BorderColor = Color.White;
            tbConfirmNewPassword.BorderFocusColor = Color.White;
            tbConfirmNewPassword.BorderRadius = 10;
            tbConfirmNewPassword.BorderSize = 2;
            tbConfirmNewPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbConfirmNewPassword.ForeColor = SystemColors.ControlLightLight;
            tbConfirmNewPassword.Location = new Point(88, 1124);
            tbConfirmNewPassword.Margin = new Padding(5);
            tbConfirmNewPassword.Multiline = false;
            tbConfirmNewPassword.Name = "tbConfirmNewPassword";
            tbConfirmNewPassword.Padding = new Padding(11, 9, 11, 9);
            tbConfirmNewPassword.PasswordChar = true;
            tbConfirmNewPassword.PlaceholderColor = Color.DarkGray;
            tbConfirmNewPassword.PlaceholderText = "";
            tbConfirmNewPassword.Size = new Size(414, 39);
            tbConfirmNewPassword.TabIndex = 33;
            tbConfirmNewPassword.UnderlinedStyle = false;
            // 
            // tbNewPassword
            // 
            tbNewPassword.BackColor = Color.FromArgb(64, 64, 64);
            tbNewPassword.BorderColor = Color.White;
            tbNewPassword.BorderFocusColor = Color.White;
            tbNewPassword.BorderRadius = 10;
            tbNewPassword.BorderSize = 2;
            tbNewPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNewPassword.ForeColor = SystemColors.ControlLightLight;
            tbNewPassword.Location = new Point(88, 1012);
            tbNewPassword.Margin = new Padding(5);
            tbNewPassword.Multiline = false;
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Padding = new Padding(11, 9, 11, 9);
            tbNewPassword.PasswordChar = true;
            tbNewPassword.PlaceholderColor = Color.DarkGray;
            tbNewPassword.PlaceholderText = "";
            tbNewPassword.Size = new Size(414, 39);
            tbNewPassword.TabIndex = 32;
            tbNewPassword.UnderlinedStyle = false;
            // 
            // tbOldPassword
            // 
            tbOldPassword.BackColor = Color.FromArgb(64, 64, 64);
            tbOldPassword.BorderColor = Color.White;
            tbOldPassword.BorderFocusColor = Color.White;
            tbOldPassword.BorderRadius = 10;
            tbOldPassword.BorderSize = 2;
            tbOldPassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbOldPassword.ForeColor = SystemColors.ControlLightLight;
            tbOldPassword.Location = new Point(88, 904);
            tbOldPassword.Margin = new Padding(5);
            tbOldPassword.Multiline = false;
            tbOldPassword.Name = "tbOldPassword";
            tbOldPassword.Padding = new Padding(11, 9, 11, 9);
            tbOldPassword.PasswordChar = true;
            tbOldPassword.PlaceholderColor = Color.DarkGray;
            tbOldPassword.PlaceholderText = "";
            tbOldPassword.Size = new Size(414, 39);
            tbOldPassword.TabIndex = 31;
            tbOldPassword.UnderlinedStyle = false;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(86, 667);
            dtpDateOfBirth.Margin = new Padding(3, 4, 3, 4);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(413, 27);
            dtpDateOfBirth.TabIndex = 29;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Black;
            btnEdit.FlatAppearance.BorderColor = Color.Black;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.Location = new Point(261, 160);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(53, 31);
            btnEdit.TabIndex = 40;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.ForeColor = Color.White;
            lbUsername.Location = new Point(86, 201);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(118, 28);
            lbUsername.TabIndex = 39;
            lbUsername.Text = "@Username";
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = SystemColors.ActiveCaption;
            btnChangePassword.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI", 11.25F);
            btnChangePassword.ForeColor = SystemColors.ControlLightLight;
            btnChangePassword.Location = new Point(88, 1189);
            btnChangePassword.Margin = new Padding(3, 4, 3, 4);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(182, 45);
            btnChangePassword.TabIndex = 34;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // lbConfirmnewpassword
            // 
            lbConfirmnewpassword.AutoSize = true;
            lbConfirmnewpassword.Font = new Font("Segoe UI", 11.25F);
            lbConfirmnewpassword.ForeColor = Color.White;
            lbConfirmnewpassword.Location = new Point(86, 1092);
            lbConfirmnewpassword.Name = "lbConfirmnewpassword";
            lbConfirmnewpassword.Size = new Size(207, 25);
            lbConfirmnewpassword.TabIndex = 37;
            lbConfirmnewpassword.Text = "Confirm New Password";
            // 
            // lbNewpassword
            // 
            lbNewpassword.AutoSize = true;
            lbNewpassword.Font = new Font("Segoe UI", 11.25F);
            lbNewpassword.ForeColor = Color.White;
            lbNewpassword.Location = new Point(88, 980);
            lbNewpassword.Name = "lbNewpassword";
            lbNewpassword.Size = new Size(134, 25);
            lbNewpassword.TabIndex = 35;
            lbNewpassword.Text = "New Password";
            // 
            // lbOldpassword
            // 
            lbOldpassword.AutoSize = true;
            lbOldpassword.Font = new Font("Segoe UI", 11.25F);
            lbOldpassword.ForeColor = Color.White;
            lbOldpassword.Location = new Point(88, 872);
            lbOldpassword.Name = "lbOldpassword";
            lbOldpassword.Size = new Size(126, 25);
            lbOldpassword.TabIndex = 34;
            lbOldpassword.Text = "Old Password";
            // 
            // lbChangePassword
            // 
            lbChangePassword.AutoSize = true;
            lbChangePassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbChangePassword.ForeColor = Color.White;
            lbChangePassword.Location = new Point(86, 804);
            lbChangePassword.Name = "lbChangePassword";
            lbChangePassword.Size = new Size(200, 32);
            lbChangePassword.TabIndex = 31;
            lbChangePassword.Text = "Change Password";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11.25F);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(86, 729);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(93, 45);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // tbSMS
            // 
            tbSMS.BackColor = Color.FromArgb(64, 64, 64);
            tbSMS.Font = new Font("Segoe UI", 11.25F);
            tbSMS.ForeColor = SystemColors.Window;
            tbSMS.Location = new Point(86, 543);
            tbSMS.Margin = new Padding(3, 4, 3, 4);
            tbSMS.Multiline = true;
            tbSMS.Name = "tbSMS";
            tbSMS.Size = new Size(413, 47);
            tbSMS.TabIndex = 28;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.FromArgb(64, 64, 64);
            tbEmail.Font = new Font("Segoe UI", 11.25F);
            tbEmail.ForeColor = SystemColors.Window;
            tbEmail.Location = new Point(86, 440);
            tbEmail.Margin = new Padding(3, 4, 3, 4);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(413, 47);
            tbEmail.TabIndex = 27;
            // 
            // tbFullName
            // 
            tbFullName.BackColor = Color.FromArgb(64, 64, 64);
            tbFullName.Font = new Font("Segoe UI", 11.25F);
            tbFullName.ForeColor = SystemColors.Window;
            tbFullName.Location = new Point(86, 329);
            tbFullName.Margin = new Padding(3, 4, 3, 4);
            tbFullName.Multiline = true;
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(413, 47);
            tbFullName.TabIndex = 26;
            // 
            // lbDateofBirth
            // 
            lbDateofBirth.AutoSize = true;
            lbDateofBirth.Font = new Font("Segoe UI", 11.25F);
            lbDateofBirth.ForeColor = Color.White;
            lbDateofBirth.Location = new Point(86, 613);
            lbDateofBirth.Name = "lbDateofBirth";
            lbDateofBirth.Size = new Size(112, 25);
            lbDateofBirth.TabIndex = 25;
            lbDateofBirth.Text = "Date of Birh";
            // 
            // lbSMS
            // 
            lbSMS.AutoSize = true;
            lbSMS.Font = new Font("Segoe UI", 11.25F);
            lbSMS.ForeColor = Color.White;
            lbSMS.Location = new Point(86, 504);
            lbSMS.Name = "lbSMS";
            lbSMS.Size = new Size(49, 25);
            lbSMS.TabIndex = 24;
            lbSMS.Text = "SMS";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 11.25F);
            lbEmail.ForeColor = Color.White;
            lbEmail.Location = new Point(86, 401);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(58, 25);
            lbEmail.TabIndex = 23;
            lbEmail.Text = "Email";
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Font = new Font("Segoe UI", 11.25F);
            lbFullName.ForeColor = Color.White;
            lbFullName.Location = new Point(86, 287);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(94, 25);
            lbFullName.TabIndex = 22;
            lbFullName.Text = "Full name";
            // 
            // imgUser
            // 
            imgUser.Image = Properties.Resources.user_pic;
            imgUser.Location = new Point(88, 16);
            imgUser.Margin = new Padding(3, 4, 3, 4);
            imgUser.Name = "imgUser";
            imgUser.Size = new Size(211, 161);
            imgUser.SizeMode = PictureBoxSizeMode.Zoom;
            imgUser.TabIndex = 21;
            imgUser.TabStop = false;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 880);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHide1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbShow1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnEdit;
        private Label lbUsername;
        private Button btnChangePassword;
        private Label lbConfirmnewpassword;
        private Label lbNewpassword;
        private Label lbOldpassword;
        private Label lbChangePassword;
        private Button btnSave;
        private TextBox tbSMS;
        private TextBox tbEmail;
        private TextBox tbFullName;
        private Label lbDateofBirth;
        private Label lbSMS;
        private Label lbEmail;
        private Label lbFullName;
        private PictureBox imgUser;
        private DateTimePicker dtpDateOfBirth;
        private RoundTextBox tbConfirmNewPassword;
        private RoundTextBox tbNewPassword;
        private RoundTextBox tbOldPassword;
        private PictureBox pbHide1;
        private PictureBox pbShow1;
    }
}