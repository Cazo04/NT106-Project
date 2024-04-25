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
            imgUser = new PictureBox();
            lbName = new Label();
            lbEmail = new Label();
            lbSMS = new Label();
            lbDateofBirth = new Label();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtSMS = new TextBox();
            txtDateofBirth = new TextBox();
            btnSave = new Button();
            lbChangePassword = new Label();
            lbOldpassword = new Label();
            lbNewpassword = new Label();
            lbConfirmnewpassword = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            btnChangepassword = new Button();
            panel1 = new Panel();
            btnlogout = new Button();
            btnProfile = new Button();
            lbUsername = new Label();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imgUser
            // 
            imgUser.Image = Properties.Resources.avatar_fb;
            imgUser.Location = new Point(183, 12);
            imgUser.Name = "imgUser";
            imgUser.Size = new Size(185, 121);
            imgUser.SizeMode = PictureBoxSizeMode.Zoom;
            imgUser.TabIndex = 0;
            imgUser.TabStop = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 11.25F);
            lbName.ForeColor = Color.White;
            lbName.Location = new Point(181, 215);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 1;
            lbName.Text = "Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI", 11.25F);
            lbEmail.ForeColor = Color.White;
            lbEmail.Location = new Point(181, 301);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbSMS
            // 
            lbSMS.AutoSize = true;
            lbSMS.Font = new Font("Segoe UI", 11.25F);
            lbSMS.ForeColor = Color.White;
            lbSMS.Location = new Point(181, 378);
            lbSMS.Name = "lbSMS";
            lbSMS.Size = new Size(38, 20);
            lbSMS.TabIndex = 3;
            lbSMS.Text = "SMS";
            // 
            // lbDateofBirth
            // 
            lbDateofBirth.AutoSize = true;
            lbDateofBirth.Font = new Font("Segoe UI", 11.25F);
            lbDateofBirth.ForeColor = Color.White;
            lbDateofBirth.Location = new Point(181, 460);
            lbDateofBirth.Name = "lbDateofBirth";
            lbDateofBirth.Size = new Size(89, 20);
            lbDateofBirth.TabIndex = 4;
            lbDateofBirth.Text = "Date of Birh";
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(64, 64, 64);
            txtName.Location = new Point(181, 247);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(362, 36);
            txtName.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(181, 330);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(362, 36);
            txtEmail.TabIndex = 6;
            // 
            // txtSMS
            // 
            txtSMS.BackColor = Color.FromArgb(64, 64, 64);
            txtSMS.Location = new Point(181, 407);
            txtSMS.Multiline = true;
            txtSMS.Name = "txtSMS";
            txtSMS.Size = new Size(362, 36);
            txtSMS.TabIndex = 7;
            // 
            // txtDateofBirth
            // 
            txtDateofBirth.BackColor = Color.FromArgb(64, 64, 64);
            txtDateofBirth.Location = new Point(181, 489);
            txtDateofBirth.Multiline = true;
            txtDateofBirth.Name = "txtDateofBirth";
            txtDateofBirth.Size = new Size(362, 36);
            txtDateofBirth.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 11.25F);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(181, 547);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(81, 34);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // lbChangePassword
            // 
            lbChangePassword.AutoSize = true;
            lbChangePassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbChangePassword.ForeColor = Color.White;
            lbChangePassword.Location = new Point(181, 603);
            lbChangePassword.Name = "lbChangePassword";
            lbChangePassword.Size = new Size(161, 25);
            lbChangePassword.TabIndex = 10;
            lbChangePassword.Text = "Change Password";
            // 
            // lbOldpassword
            // 
            lbOldpassword.AutoSize = true;
            lbOldpassword.Font = new Font("Segoe UI", 11.25F);
            lbOldpassword.ForeColor = Color.White;
            lbOldpassword.Location = new Point(183, 642);
            lbOldpassword.Name = "lbOldpassword";
            lbOldpassword.Size = new Size(98, 20);
            lbOldpassword.TabIndex = 11;
            lbOldpassword.Text = "Old Password";
            // 
            // lbNewpassword
            // 
            lbNewpassword.AutoSize = true;
            lbNewpassword.Font = new Font("Segoe UI", 11.25F);
            lbNewpassword.ForeColor = Color.White;
            lbNewpassword.Location = new Point(183, 722);
            lbNewpassword.Name = "lbNewpassword";
            lbNewpassword.Size = new Size(104, 20);
            lbNewpassword.TabIndex = 12;
            lbNewpassword.Text = "New Password";
            // 
            // lbConfirmnewpassword
            // 
            lbConfirmnewpassword.AutoSize = true;
            lbConfirmnewpassword.Font = new Font("Segoe UI", 11.25F);
            lbConfirmnewpassword.ForeColor = Color.White;
            lbConfirmnewpassword.Location = new Point(183, 806);
            lbConfirmnewpassword.Name = "lbConfirmnewpassword";
            lbConfirmnewpassword.Size = new Size(161, 20);
            lbConfirmnewpassword.TabIndex = 13;
            lbConfirmnewpassword.Text = "Confirm New Password";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(64, 64, 64);
            textBox5.Location = new Point(183, 669);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(362, 36);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(64, 64, 64);
            textBox6.Location = new Point(183, 751);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(362, 36);
            textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(64, 64, 64);
            textBox7.Location = new Point(183, 837);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(362, 36);
            textBox7.TabIndex = 16;
            // 
            // btnChangepassword
            // 
            btnChangepassword.BackColor = SystemColors.ActiveCaption;
            btnChangepassword.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnChangepassword.FlatStyle = FlatStyle.Flat;
            btnChangepassword.Font = new Font("Segoe UI", 11.25F);
            btnChangepassword.ForeColor = SystemColors.ControlLightLight;
            btnChangepassword.Location = new Point(183, 892);
            btnChangepassword.Name = "btnChangepassword";
            btnChangepassword.Size = new Size(159, 34);
            btnChangepassword.TabIndex = 17;
            btnChangepassword.Text = "Change Password";
            btnChangepassword.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btnProfile);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 977);
            panel1.TabIndex = 18;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.FromArgb(192, 192, 0);
            btnlogout.FlatAppearance.BorderColor = Color.FromArgb(192, 192, 0);
            btnlogout.FlatAppearance.MouseDownBackColor = Color.White;
            btnlogout.FlatAppearance.MouseOverBackColor = Color.White;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI", 11.25F);
            btnlogout.ForeColor = SystemColors.ControlLightLight;
            btnlogout.Location = new Point(0, 924);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(138, 53);
            btnlogout.TabIndex = 1;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.FromArgb(64, 64, 64);
            btnProfile.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnProfile.FlatAppearance.MouseDownBackColor = Color.White;
            btnProfile.FlatAppearance.MouseOverBackColor = Color.White;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 11.25F);
            btnProfile.ForeColor = SystemColors.ControlLightLight;
            btnProfile.Location = new Point(0, 0);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(138, 53);
            btnProfile.TabIndex = 0;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.ForeColor = Color.White;
            lbUsername.Location = new Point(181, 151);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(71, 15);
            lbUsername.TabIndex = 19;
            lbUsername.Text = "@Username";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Black;
            btnEdit.FlatAppearance.BorderColor = Color.Black;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.Location = new Point(334, 120);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(46, 23);
            btnEdit.TabIndex = 20;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(696, 979);
            Controls.Add(btnEdit);
            Controls.Add(lbUsername);
            Controls.Add(panel1);
            Controls.Add(btnChangepassword);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(lbConfirmnewpassword);
            Controls.Add(lbNewpassword);
            Controls.Add(lbOldpassword);
            Controls.Add(lbChangePassword);
            Controls.Add(btnSave);
            Controls.Add(txtDateofBirth);
            Controls.Add(txtSMS);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(lbDateofBirth);
            Controls.Add(lbSMS);
            Controls.Add(lbEmail);
            Controls.Add(lbName);
            Controls.Add(imgUser);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Profile";
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgUser;
        private Label lbName;
        private Label lbEmail;
        private Label lbSMS;
        private Label lbDateofBirth;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtSMS;
        private TextBox txtDateofBirth;
        private Button btnSave;
        private Label lbChangePassword;
        private Label lbOldpassword;
        private Label lbNewpassword;
        private Label lbConfirmnewpassword;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button btnChangepassword;
        private Panel panel1;
        private Button btnlogout;
        private Button btnProfile;
        private Label lbUsername;
        private Button btnEdit;
    }
}