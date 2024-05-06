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
            panel2.AutoScroll = true;
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
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(749, 1106);
            panel2.TabIndex = 20;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(107, 833);
            dtpDateOfBirth.Margin = new Padding(4, 5, 4, 5);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(515, 31);
            dtpDateOfBirth.TabIndex = 41;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Black;
            btnEdit.FlatAppearance.BorderColor = Color.Black;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.Location = new Point(326, 200);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(66, 38);
            btnEdit.TabIndex = 40;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.ForeColor = Color.White;
            lbUsername.Location = new Point(107, 252);
            lbUsername.Margin = new Padding(4, 0, 4, 0);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(144, 32);
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
            btnChangePassword.Location = new Point(110, 1487);
            btnChangePassword.Margin = new Padding(4, 5, 4, 5);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(227, 57);
            btnChangePassword.TabIndex = 38;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // tbConfirmNewPassword
            // 
            tbConfirmNewPassword.BackColor = Color.FromArgb(64, 64, 64);
            tbConfirmNewPassword.Font = new Font("Segoe UI", 14.25F);
            tbConfirmNewPassword.ForeColor = SystemColors.Window;
            tbConfirmNewPassword.Location = new Point(110, 1395);
            tbConfirmNewPassword.Margin = new Padding(4, 5, 4, 5);
            tbConfirmNewPassword.Multiline = true;
            tbConfirmNewPassword.Name = "tbConfirmNewPassword";
            tbConfirmNewPassword.PasswordChar = '*';
            tbConfirmNewPassword.Size = new Size(515, 57);
            tbConfirmNewPassword.TabIndex = 36;
            // 
            // tbNewPassword
            // 
            tbNewPassword.BackColor = Color.FromArgb(64, 64, 64);
            tbNewPassword.Font = new Font("Segoe UI", 14.25F);
            tbNewPassword.ForeColor = SystemColors.Window;
            tbNewPassword.Location = new Point(110, 1252);
            tbNewPassword.Margin = new Padding(4, 5, 4, 5);
            tbNewPassword.Multiline = true;
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.PasswordChar = '*';
            tbNewPassword.Size = new Size(515, 57);
            tbNewPassword.TabIndex = 33;
            // 
            // tbOldPassword
            // 
            tbOldPassword.BackColor = Color.FromArgb(64, 64, 64);
            tbOldPassword.Font = new Font("Segoe UI", 14.25F);
            tbOldPassword.ForeColor = SystemColors.Window;
            tbOldPassword.Location = new Point(110, 1115);
            tbOldPassword.Margin = new Padding(4, 5, 4, 5);
            tbOldPassword.Multiline = true;
            tbOldPassword.Name = "tbOldPassword";
            tbOldPassword.PasswordChar = '*';
            tbOldPassword.Size = new Size(515, 57);
            tbOldPassword.TabIndex = 32;
            // 
            // lbConfirmnewpassword
            // 
            lbConfirmnewpassword.AutoSize = true;
            lbConfirmnewpassword.Font = new Font("Segoe UI", 11.25F);
            lbConfirmnewpassword.ForeColor = Color.White;
            lbConfirmnewpassword.Location = new Point(110, 1343);
            lbConfirmnewpassword.Margin = new Padding(4, 0, 4, 0);
            lbConfirmnewpassword.Name = "lbConfirmnewpassword";
            lbConfirmnewpassword.Size = new Size(249, 31);
            lbConfirmnewpassword.TabIndex = 37;
            lbConfirmnewpassword.Text = "Confirm New Password";
            // 
            // lbNewpassword
            // 
            lbNewpassword.AutoSize = true;
            lbNewpassword.Font = new Font("Segoe UI", 11.25F);
            lbNewpassword.ForeColor = Color.White;
            lbNewpassword.Location = new Point(110, 1203);
            lbNewpassword.Margin = new Padding(4, 0, 4, 0);
            lbNewpassword.Name = "lbNewpassword";
            lbNewpassword.Size = new Size(162, 31);
            lbNewpassword.TabIndex = 35;
            lbNewpassword.Text = "New Password";
            // 
            // lbOldpassword
            // 
            lbOldpassword.AutoSize = true;
            lbOldpassword.Font = new Font("Segoe UI", 11.25F);
            lbOldpassword.ForeColor = Color.White;
            lbOldpassword.Location = new Point(110, 1070);
            lbOldpassword.Margin = new Padding(4, 0, 4, 0);
            lbOldpassword.Name = "lbOldpassword";
            lbOldpassword.Size = new Size(153, 31);
            lbOldpassword.TabIndex = 34;
            lbOldpassword.Text = "Old Password";
            // 
            // lbChangePassword
            // 
            lbChangePassword.AutoSize = true;
            lbChangePassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbChangePassword.ForeColor = Color.White;
            lbChangePassword.Location = new Point(107, 1005);
            lbChangePassword.Margin = new Padding(4, 0, 4, 0);
            lbChangePassword.Name = "lbChangePassword";
            lbChangePassword.Size = new Size(241, 40);
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
            btnSave.Location = new Point(107, 912);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 57);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // tbSMS
            // 
            tbSMS.BackColor = Color.FromArgb(64, 64, 64);
            tbSMS.Font = new Font("Segoe UI", 11.25F);
            tbSMS.ForeColor = SystemColors.Window;
            tbSMS.Location = new Point(107, 678);
            tbSMS.Margin = new Padding(4, 5, 4, 5);
            tbSMS.Multiline = true;
            tbSMS.Name = "tbSMS";
            tbSMS.Size = new Size(515, 57);
            tbSMS.TabIndex = 28;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.FromArgb(64, 64, 64);
            tbEmail.Font = new Font("Segoe UI", 11.25F);
            tbEmail.ForeColor = SystemColors.Window;
            tbEmail.Location = new Point(107, 550);
            tbEmail.Margin = new Padding(4, 5, 4, 5);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(515, 57);
            tbEmail.TabIndex = 27;
            // 
            // tbFullName
            // 
            tbFullName.BackColor = Color.FromArgb(64, 64, 64);
            tbFullName.Font = new Font("Segoe UI", 11.25F);
            tbFullName.ForeColor = SystemColors.Window;
            tbFullName.Location = new Point(107, 412);
            tbFullName.Margin = new Padding(4, 5, 4, 5);
            tbFullName.Multiline = true;
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(515, 57);
            tbFullName.TabIndex = 26;
            // 
            // lbDateofBirth
            // 
            lbDateofBirth.AutoSize = true;
            lbDateofBirth.Font = new Font("Segoe UI", 11.25F);
            lbDateofBirth.ForeColor = Color.White;
            lbDateofBirth.Location = new Point(107, 767);
            lbDateofBirth.Margin = new Padding(4, 0, 4, 0);
            lbDateofBirth.Name = "lbDateofBirth";
            lbDateofBirth.Size = new Size(134, 31);
            lbDateofBirth.TabIndex = 25;
            lbDateofBirth.Text = "Date of Birh";
            // 
            // lbSMS
            // 
            lbSMS.AutoSize = true;
            lbSMS.Font = new Font("Segoe UI", 11.25F);
            lbSMS.ForeColor = Color.White;
            lbSMS.Location = new Point(107, 630);
            lbSMS.Margin = new Padding(4, 0, 4, 0);
            lbSMS.Name = "lbSMS";
            lbSMS.Size = new Size(59, 31);
            lbSMS.TabIndex = 24;
            lbSMS.Text = "SMS";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 11.25F);
            lbEmail.ForeColor = Color.White;
            lbEmail.Location = new Point(107, 502);
            lbEmail.Margin = new Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(70, 31);
            lbEmail.TabIndex = 23;
            lbEmail.Text = "Email";
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Font = new Font("Segoe UI", 11.25F);
            lbFullName.ForeColor = Color.White;
            lbFullName.Location = new Point(107, 358);
            lbFullName.Margin = new Padding(4, 0, 4, 0);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(113, 31);
            lbFullName.TabIndex = 22;
            lbFullName.Text = "Full name";
            // 
            // imgUser
            // 
            imgUser.Image = Properties.Resources.user_pic;
            imgUser.Location = new Point(110, 20);
            imgUser.Margin = new Padding(4, 5, 4, 5);
            imgUser.Name = "imgUser";
            imgUser.Size = new Size(264, 202);
            imgUser.SizeMode = PictureBoxSizeMode.Zoom;
            imgUser.TabIndex = 21;
            imgUser.TabStop = false;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 1106);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
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