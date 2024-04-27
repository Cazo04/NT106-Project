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
            panel1 = new Panel();
            btnlogout = new Button();
            btnProfile = new Button();
            panel2 = new Panel();
            btnEdit = new Button();
            lbUsername = new Label();
            btnChangepassword = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            lbConfirmnewpassword = new Label();
            lbNewpassword = new Label();
            lbOldpassword = new Label();
            lbChangePassword = new Label();
            btnSave = new Button();
            txtDateofBirth = new TextBox();
            txtSMS = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            lbDateofBirth = new Label();
            lbSMS = new Label();
            lbEmail = new Label();
            lbName = new Label();
            imgUser = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnlogout);
            panel1.Controls.Add(btnProfile);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 979);
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
            btnlogout.TabIndex = 14;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
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
            // panel2
            // 
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(lbUsername);
            panel2.Controls.Add(btnChangepassword);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(lbConfirmnewpassword);
            panel2.Controls.Add(lbNewpassword);
            panel2.Controls.Add(lbOldpassword);
            panel2.Controls.Add(lbChangePassword);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(txtDateofBirth);
            panel2.Controls.Add(txtSMS);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(lbDateofBirth);
            panel2.Controls.Add(lbSMS);
            panel2.Controls.Add(lbEmail);
            panel2.Controls.Add(lbName);
            panel2.Controls.Add(imgUser);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(144, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(552, 979);
            panel2.TabIndex = 19;
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
            lbUsername.ForeColor = Color.White;
            lbUsername.Location = new Point(75, 151);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(71, 15);
            lbUsername.TabIndex = 39;
            lbUsername.Text = "@Username";
            // 
            // btnChangepassword
            // 
            btnChangepassword.BackColor = SystemColors.ActiveCaption;
            btnChangepassword.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnChangepassword.FlatStyle = FlatStyle.Flat;
            btnChangepassword.Font = new Font("Segoe UI", 11.25F);
            btnChangepassword.ForeColor = SystemColors.ControlLightLight;
            btnChangepassword.Location = new Point(77, 892);
            btnChangepassword.Name = "btnChangepassword";
            btnChangepassword.Size = new Size(159, 34);
            btnChangepassword.TabIndex = 38;
            btnChangepassword.Text = "Change Password";
            btnChangepassword.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(64, 64, 64);
            textBox7.Location = new Point(77, 837);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(362, 36);
            textBox7.TabIndex = 36;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(64, 64, 64);
            textBox6.Location = new Point(77, 751);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(362, 36);
            textBox6.TabIndex = 33;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(64, 64, 64);
            textBox5.Location = new Point(77, 669);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(362, 36);
            textBox5.TabIndex = 32;
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
            // txtDateofBirth
            // 
            txtDateofBirth.BackColor = Color.FromArgb(64, 64, 64);
            txtDateofBirth.Location = new Point(75, 489);
            txtDateofBirth.Multiline = true;
            txtDateofBirth.Name = "txtDateofBirth";
            txtDateofBirth.Size = new Size(362, 36);
            txtDateofBirth.TabIndex = 29;
            // 
            // txtSMS
            // 
            txtSMS.BackColor = Color.FromArgb(64, 64, 64);
            txtSMS.Location = new Point(75, 407);
            txtSMS.Multiline = true;
            txtSMS.Name = "txtSMS";
            txtSMS.Size = new Size(362, 36);
            txtSMS.TabIndex = 28;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(75, 330);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(362, 36);
            txtEmail.TabIndex = 27;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(64, 64, 64);
            txtName.Location = new Point(75, 247);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(362, 36);
            txtName.TabIndex = 26;
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
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI", 11.25F);
            lbName.ForeColor = Color.White;
            lbName.Location = new Point(75, 215);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 22;
            lbName.Text = "Name";
            // 
            // imgUser
            // 
            imgUser.Image = Properties.Resources.avatar_fb;
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
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(696, 979);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            Name = "Profile";
            Text = "Profile";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnlogout;
        private Button btnProfile;
        private Panel panel2;
        private Button btnEdit;
        private Label lbUsername;
        private Button btnChangepassword;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label lbConfirmnewpassword;
        private Label lbNewpassword;
        private Label lbOldpassword;
        private Label lbChangePassword;
        private Button btnSave;
        private TextBox txtDateofBirth;
        private TextBox txtSMS;
        private TextBox txtEmail;
        private TextBox txtName;
        private Label lbDateofBirth;
        private Label lbSMS;
        private Label lbEmail;
        private Label lbName;
        private PictureBox imgUser;
    }
}