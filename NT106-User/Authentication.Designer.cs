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
            loginControl = new LoginControl();
            SuspendLayout();
            // 
            // loginControl
            // 
            loginControl.BackColor = Color.FromArgb(64, 64, 64);
            loginControl.BorderStyle = BorderStyle.FixedSingle;
            loginControl.Location = new Point(48, 81);
            loginControl.Name = "loginControl";
            loginControl.Padding = new Padding(5);
            loginControl.Size = new Size(408, 467);
            loginControl.TabIndex = 0;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(508, 633);
            Controls.Add(loginControl);
            Name = "Authentication";
            ResumeLayout(false);
        }

        #endregion

        private LoginControl loginControl;
    }
}