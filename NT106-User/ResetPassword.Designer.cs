namespace NT106_User
{
    partial class ResetPassword
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
            label1 = new Label();
            tbEmail = new TextBox();
            label2 = new Label();
            tbCode = new TextBox();
            btnSendCode = new Button();
            label3 = new Label();
            tbPassword = new TextBox();
            label4 = new Label();
            tbConfirmPassword = new TextBox();
            btnApply = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 36);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(81, 33);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(238, 23);
            tbEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 86);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "Reset code:";
            // 
            // tbCode
            // 
            tbCode.Location = new Point(153, 83);
            tbCode.Name = "tbCode";
            tbCode.Size = new Size(120, 23);
            tbCode.TabIndex = 1;
            // 
            // btnSendCode
            // 
            btnSendCode.Location = new Point(325, 32);
            btnSendCode.Name = "btnSendCode";
            btnSendCode.Size = new Size(75, 23);
            btnSendCode.TabIndex = 2;
            btnSendCode.Text = "Send code";
            btnSendCode.UseVisualStyleBackColor = true;
            btnSendCode.Click += btnSendCode_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 115);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 0;
            label3.Text = "New password:";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(153, 112);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(162, 23);
            tbPassword.TabIndex = 1;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 146);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 0;
            label4.Text = "Confirm password:";
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(153, 143);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(162, 23);
            tbConfirmPassword.TabIndex = 1;
            tbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(153, 181);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 3;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 230);
            Controls.Add(btnApply);
            Controls.Add(btnSendCode);
            Controls.Add(tbConfirmPassword);
            Controls.Add(tbPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbCode);
            Controls.Add(label2);
            Controls.Add(tbEmail);
            Controls.Add(label1);
            Name = "ResetPassword";
            Text = "ResetPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbEmail;
        private Label label2;
        private TextBox tbCode;
        private Button btnSendCode;
        private Label label3;
        private TextBox tbPassword;
        private Label label4;
        private TextBox tbConfirmPassword;
        private Button btnApply;
    }
}