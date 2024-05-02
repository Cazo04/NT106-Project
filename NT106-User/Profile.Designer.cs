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
            dtpDateOfBirth = new DateTimePicker();
            btnEdit = new Button();
            lbUsername = new Label();
            btnChangePassword = new Button();
            tbConfirmNewPassword = new TextBox();
            tbNewPassword = new TextBox();
            tbOldPassword = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(dtpDateOfBirth);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(lbUsername);
            panel2.Controls.Add(btnChangePassword);
            panel2.Controls.Add(tbConfirmNewPassword);
            panel2.Controls.Add(tbNewPassword);
            panel2.Controls.Add(tbOldPassword);
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
            panel2.Name = "panel2";
            panel2.Size = new Size(524, 959);
            panel2.TabIndex = 20;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(75, 500);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(362, 23);
            dtpDateOfBirth.TabIndex = 41;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Black;
            btnEdit.FlatAppearance.BorderColor = Color.Black;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.Location = new Point(228, 120);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(46, 23);
            btnEdit.TabIndex = 40;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.ForeColor = Color.White;
            lbUsername.Location = new Point(75, 151);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(96, 21);
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
            btnChangePassword.Location = new Point(77, 892);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(159, 34);
            btnChangePassword.TabIndex = 38;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // tbConfirmNewPassword
            // 
            tbConfirmNewPassword.BackColor = Color.FromArgb(64, 64, 64);
            tbConfirmNewPassword.Location = new Point(77, 837);
            tbConfirmNewPassword.Multiline = true;
            tbConfirmNewPassword.Name = "tbConfirmNewPassword";
            tbConfirmNewPassword.Size = new Size(362, 36);
            tbConfirmNewPassword.TabIndex = 36;
            // 
            // tbNewPassword
            // 
            tbNewPassword.BackColor = Color.FromArgb(64, 64, 64);
            tbNewPassword.Location = new Point(77, 751);
            tbNewPassword.Multiline = true;
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Size = new Size(362, 36);
            tbNewPassword.TabIndex = 33;
            // 
            // tbOldPassword
            // 
            tbOldPassword.BackColor = Color.FromArgb(64, 64, 64);
            tbOldPassword.Location = new Point(77, 669);
            tbOldPassword.Multiline = true;
            tbOldPassword.Name = "tbOldPassword";
            tbOldPassword.Size = new Size(362, 36);
            tbOldPassword.TabIndex = 32;
            // 
            // lbConfirmnewpassword
            // 
            lbConfirmnewpassword.AutoSize = true;
            lbConfirmnewpassword.Font = new Font("Segoe UI", 11.25F);
            lbConfirmnewpassword.ForeColor = Color.White;
            lbConfirmnewpassword.Location = new Point(77, 806);
            lbConfirmnewpassword.Name = "lbConfirmnewpassword";
            lbConfirmnewpassword.Size = new Size(161, 20);
            lbConfirmnewpassword.TabIndex = 37;
            lbConfirmnewpassword.Text = "Confirm New Password";
            // 
            // lbNewpassword
            // 
            lbNewpassword.AutoSize = true;
            lbNewpassword.Font = new Font("Segoe UI", 11.25F);
            lbNewpassword.ForeColor = Color.White;
            lbNewpassword.Location = new Point(77, 722);
            lbNewpassword.Name = "lbNewpassword";
            lbNewpassword.Size = new Size(104, 20);
            lbNewpassword.TabIndex = 35;
            lbNewpassword.Text = "New Password";
            // 
            // lbOldpassword
            // 
            lbOldpassword.AutoSize = true;
            lbOldpassword.Font = new Font("Segoe UI", 11.25F);
            lbOldpassword.ForeColor = Color.White;
            lbOldpassword.Location = new Point(77, 642);
            lbOldpassword.Name = "lbOldpassword";
            lbOldpassword.Size = new Size(98, 20);
            lbOldpassword.TabIndex = 34;
            lbOldpassword.Text = "Old Password";
            // 
            // lbChangePassword
            // 
            lbChangePassword.AutoSize = true;
            lbChangePassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbChangePassword.ForeColor = Color.White;
            lbChangePassword.Location = new Point(75, 603);
            lbChangePassword.Name = "lbChangePassword";
            lbChangePassword.Size = new Size(161, 25);
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
            btnSave.Location = new Point(75, 547);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(81, 34);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // tbSMS
            // 
            tbSMS.BackColor = Color.FromArgb(64, 64, 64);
            tbSMS.Font = new Font("Segoe UI", 11.25F);
            tbSMS.ForeColor = SystemColors.Window;
            tbSMS.Location = new Point(75, 407);
            tbSMS.Multiline = true;
            tbSMS.Name = "tbSMS";
            tbSMS.Size = new Size(362, 36);
            tbSMS.TabIndex = 28;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.FromArgb(64, 64, 64);
            tbEmail.Font = new Font("Segoe UI", 11.25F);
            tbEmail.ForeColor = SystemColors.Window;
            tbEmail.Location = new Point(75, 330);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(362, 36);
            tbEmail.TabIndex = 27;
            // 
            // tbFullName
            // 
            tbFullName.BackColor = Color.FromArgb(64, 64, 64);
            tbFullName.Font = new Font("Segoe UI", 11.25F);
            tbFullName.ForeColor = SystemColors.Window;
            tbFullName.Location = new Point(75, 247);
            tbFullName.Multiline = true;
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(362, 36);
            tbFullName.TabIndex = 26;
            // 
            // lbDateofBirth
            // 
            lbDateofBirth.AutoSize = true;
            lbDateofBirth.Font = new Font("Segoe UI", 11.25F);
            lbDateofBirth.ForeColor = Color.White;
            lbDateofBirth.Location = new Point(75, 460);
            lbDateofBirth.Name = "lbDateofBirth";
            lbDateofBirth.Size = new Size(89, 20);
            lbDateofBirth.TabIndex = 25;
            lbDateofBirth.Text = "Date of Birh";
            // 
            // lbSMS
            // 
            lbSMS.AutoSize = true;
            lbSMS.Font = new Font("Segoe UI", 11.25F);
            lbSMS.ForeColor = Color.White;
            lbSMS.Location = new Point(75, 378);
            lbSMS.Name = "lbSMS";
            lbSMS.Size = new Size(38, 20);
            lbSMS.TabIndex = 24;
            lbSMS.Text = "SMS";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 11.25F);
            lbEmail.ForeColor = Color.White;
            lbEmail.Location = new Point(75, 301);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 23;
            lbEmail.Text = "Email";
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Font = new Font("Segoe UI", 11.25F);
            lbFullName.ForeColor = Color.White;
            lbFullName.Location = new Point(75, 215);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(73, 20);
            lbFullName.TabIndex = 22;
            lbFullName.Text = "Full name";
            // 
            // imgUser
            // 
            imgUser.Image = Properties.Resources.user_pic;
            imgUser.Location = new Point(77, 12);
            imgUser.Name = "imgUser";
            imgUser.Size = new Size(185, 121);
            imgUser.SizeMode = PictureBoxSizeMode.Zoom;
            imgUser.TabIndex = 21;
            imgUser.TabStop = false;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 959);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnEdit;
        private Label lbUsername;
        private Button btnChangePassword;
        private TextBox tbConfirmNewPassword;
        private TextBox tbNewPassword;
        private TextBox tbOldPassword;
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
    }
}