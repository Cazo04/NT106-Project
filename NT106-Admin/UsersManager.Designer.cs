namespace NT106_Admin
{
    partial class UsersManager
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
            dgvUsers = new DataGridView();
            panel2 = new Panel();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnSignin = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnView = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnView);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnSignin);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 50);
            panel1.TabIndex = 0;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvUsers.Location = new Point(-1, 46);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.Size = new Size(833, 657);
            dgvUsers.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(830, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 704);
            panel2.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Username or Email address";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Password";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // btnSignin
            // 
            btnSignin.Location = new Point(0, 0);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(95, 47);
            btnSignin.TabIndex = 0;
            btnSignin.Text = "Sign up ";
            btnSignin.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(101, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(95, 47);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(202, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 47);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            btnView.Location = new Point(303, 0);
            btnView.Name = "btnView";
            btnView.Size = new Size(95, 47);
            btnView.TabIndex = 3;
            btnView.Text = "View ";
            btnView.UseVisualStyleBackColor = true;
            // 
            // UsersManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 702);
            Controls.Add(panel2);
            Controls.Add(dgvUsers);
            Controls.Add(panel1);
            Name = "UsersManager";
            Text = "UsersManager";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvUsers;
        private Panel panel2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnSignin;
        private Button btnView;
    }
}