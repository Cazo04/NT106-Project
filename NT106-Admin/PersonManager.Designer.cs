namespace NT106_Admin
{
    partial class PersonManager
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
            dgvUsers = new DataGridView();
            panel1 = new Panel();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnCreateperson = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Location = new Point(832, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 704);
            panel2.TabIndex = 5;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvUsers.Location = new Point(1, 48);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.Size = new Size(833, 657);
            dgvUsers.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnView);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnCreateperson);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 50);
            panel1.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Full Name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Email";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "SMS";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Date of Birth";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // btnCreateperson
            // 
            btnCreateperson.Location = new Point(0, 0);
            btnCreateperson.Name = "btnCreateperson";
            btnCreateperson.Size = new Size(95, 47);
            btnCreateperson.TabIndex = 0;
            btnCreateperson.Text = "Add Person";
            btnCreateperson.UseVisualStyleBackColor = true;
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
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            // 
            // PersonManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 702);
            Controls.Add(panel2);
            Controls.Add(dgvUsers);
            Controls.Add(panel1);
            Name = "PersonManager";
            Text = "PersonManager";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dgvUsers;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnView;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnCreateperson;
    }
}