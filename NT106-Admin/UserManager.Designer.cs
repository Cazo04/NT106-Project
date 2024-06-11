namespace NT106_Admin
{
    partial class UserManager
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
            dgvUsers = new DataGridView();
            UserId = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            SMS = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            ReviewNum = new DataGridViewTextBoxColumn();
            Avatar = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lb1 = new Label();
            label5 = new Label();
            tbSMS = new TextBox();
            label4 = new Label();
            tbEmail = new TextBox();
            label3 = new Label();
            tbFullName = new TextBox();
            label2 = new Label();
            tbUsername = new TextBox();
            label1 = new Label();
            tbUserId = new TextBox();
            tbAvatar = new TextBox();
            label7 = new Label();
            label8 = new Label();
            lbReviewNum = new Label();
            dtpDateOfBirth = new DateTimePicker();
            btnSave = new Button();
            label6 = new Label();
            label9 = new Label();
            tbPassword = new TextBox();
            tbConfirmPassword = new TextBox();
            btnChangePassword = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { UserId, Username, FullName, Email, SMS, DateOfBirth, ReviewNum, Avatar });
            dgvUsers.Dock = DockStyle.Left;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.Size = new Size(889, 635);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellDoubleClick += dgvUsers_CellDoubleClick;
            // 
            // UserId
            // 
            UserId.HeaderText = "Id";
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.HeaderText = "Full name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 61;
            // 
            // SMS
            // 
            SMS.HeaderText = "SMS";
            SMS.Name = "SMS";
            SMS.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            DateOfBirth.HeaderText = "Date of birth";
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.ReadOnly = true;
            // 
            // ReviewNum
            // 
            ReviewNum.HeaderText = "Review Num";
            ReviewNum.Name = "ReviewNum";
            ReviewNum.ReadOnly = true;
            // 
            // Avatar
            // 
            Avatar.HeaderText = "Avatar";
            Avatar.Name = "Avatar";
            Avatar.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(889, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 635);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9462357F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.0537643F));
            tableLayoutPanel1.Controls.Add(lb1, 0, 7);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(tbSMS, 1, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(tbEmail, 1, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(tbFullName, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(tbUsername, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbUserId, 1, 0);
            tableLayoutPanel1.Controls.Add(tbAvatar, 1, 6);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Controls.Add(label8, 0, 6);
            tableLayoutPanel1.Controls.Add(lbReviewNum, 1, 7);
            tableLayoutPanel1.Controls.Add(dtpDateOfBirth, 1, 5);
            tableLayoutPanel1.Controls.Add(btnSave, 1, 8);
            tableLayoutPanel1.Controls.Add(label6, 0, 9);
            tableLayoutPanel1.Controls.Add(label9, 0, 10);
            tableLayoutPanel1.Controls.Add(tbPassword, 1, 9);
            tableLayoutPanel1.Controls.Add(tbConfirmPassword, 1, 10);
            tableLayoutPanel1.Controls.Add(btnChangePassword, 1, 11);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 36);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(465, 599);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Dock = DockStyle.Right;
            lb1.Location = new Point(36, 252);
            lb1.Name = "lb1";
            lb1.Size = new Size(77, 36);
            lb1.TabIndex = 14;
            lb1.Text = "Review Num:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Right;
            label5.Location = new Point(80, 144);
            label5.Name = "label5";
            label5.Size = new Size(33, 36);
            label5.TabIndex = 8;
            label5.Text = "SMS:";
            // 
            // tbSMS
            // 
            tbSMS.Location = new Point(119, 147);
            tbSMS.Name = "tbSMS";
            tbSMS.Size = new Size(199, 23);
            tbSMS.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Right;
            label4.Location = new Point(74, 108);
            label4.Name = "label4";
            label4.Size = new Size(39, 36);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(119, 111);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(199, 23);
            tbEmail.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Location = new Point(49, 72);
            label3.Name = "label3";
            label3.Size = new Size(64, 36);
            label3.TabIndex = 4;
            label3.Text = "Full Name:";
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(119, 75);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(199, 23);
            tbFullName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Right;
            label2.Location = new Point(50, 36);
            label2.Name = "label2";
            label2.Size = new Size(63, 36);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(119, 39);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(199, 23);
            tbUsername.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Right;
            label1.Location = new Point(93, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 36);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // tbUserId
            // 
            tbUserId.Enabled = false;
            tbUserId.Location = new Point(119, 3);
            tbUserId.Name = "tbUserId";
            tbUserId.Size = new Size(199, 23);
            tbUserId.TabIndex = 1;
            // 
            // tbAvatar
            // 
            tbAvatar.Location = new Point(119, 219);
            tbAvatar.Name = "tbAvatar";
            tbAvatar.Size = new Size(199, 23);
            tbAvatar.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Right;
            label7.Location = new Point(37, 180);
            label7.Name = "label7";
            label7.Size = new Size(76, 36);
            label7.TabIndex = 17;
            label7.Text = "Date of birth:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Right;
            label8.Location = new Point(69, 216);
            label8.Name = "label8";
            label8.Size = new Size(44, 36);
            label8.TabIndex = 17;
            label8.Text = "Avatar:";
            // 
            // lbReviewNum
            // 
            lbReviewNum.AutoSize = true;
            lbReviewNum.Location = new Point(119, 252);
            lbReviewNum.Name = "lbReviewNum";
            lbReviewNum.Size = new Size(38, 15);
            lbReviewNum.TabIndex = 18;
            lbReviewNum.Text = "label9";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(119, 183);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(199, 23);
            dtpDateOfBirth.TabIndex = 19;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(119, 291);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Right;
            label6.Location = new Point(26, 447);
            label6.Name = "label6";
            label6.Size = new Size(87, 36);
            label6.TabIndex = 21;
            label6.Text = "New password:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Right;
            label9.Location = new Point(6, 483);
            label9.Name = "label9";
            label9.Size = new Size(107, 36);
            label9.TabIndex = 22;
            label9.Text = "Confirm Password:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(119, 450);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(199, 23);
            tbPassword.TabIndex = 23;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(119, 486);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(199, 23);
            tbConfirmPassword.TabIndex = 24;
            tbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(119, 522);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(75, 23);
            btnChangePassword.TabIndex = 20;
            btnChangePassword.Text = "Change";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(465, 36);
            panel2.TabIndex = 0;
            // 
            // UserManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 635);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(dgvUsers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserManager";
            Text = "UserManager";
            Load += UserManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvUsers;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label lb1;
        private Label label5;
        private TextBox tbSMS;
        private Label label4;
        private TextBox tbEmail;
        private Label label3;
        private TextBox tbFullName;
        private Label label2;
        private TextBox tbUsername;
        private Label label1;
        private TextBox tbUserId;
        private TextBox tbAvatar;
        private Label label7;
        private Label label8;
        private Label lbReviewNum;
        private DateTimePicker dtpDateOfBirth;
        private Button btnSave;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn SMS;
        private DataGridViewTextBoxColumn DateOfBirth;
        private DataGridViewTextBoxColumn ReviewNum;
        private DataGridViewTextBoxColumn Avatar;
        private Label label6;
        private Label label9;
        private TextBox tbPassword;
        private TextBox tbConfirmPassword;
        private Button btnChangePassword;
    }
}