namespace NT106_User
{
    partial class UserRecentComment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRecentComment));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pnImgBackground = new Panel();
            imgStatus = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lbContent = new Label();
            lbDate = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel7 = new TableLayoutPanel();
            btnNo = new Button();
            btnYes = new Button();
            label7 = new Label();
            lbUserName = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnImgBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgStatus).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(34, 49, 69);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.Size = new Size(352, 234);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(23, 33, 46);
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.092485F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.90752F));
            tableLayoutPanel2.Controls.Add(lbUserName, 0, 0);
            tableLayoutPanel2.Controls.Add(pnImgBackground, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(346, 29);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pnImgBackground
            // 
            pnImgBackground.BackColor = Color.FromArgb(25, 65, 93);
            pnImgBackground.Controls.Add(imgStatus);
            pnImgBackground.Dock = DockStyle.Fill;
            pnImgBackground.Location = new Point(3, 3);
            pnImgBackground.Name = "pnImgBackground";
            pnImgBackground.Padding = new Padding(4);
            pnImgBackground.Size = new Size(22, 23);
            pnImgBackground.TabIndex = 2;
            // 
            // imgStatus
            // 
            imgStatus.Dock = DockStyle.Fill;
            imgStatus.Image = Properties.Resources.dislike;
            imgStatus.Location = new Point(4, 4);
            imgStatus.Name = "imgStatus";
            imgStatus.Size = new Size(14, 15);
            imgStatus.SizeMode = PictureBoxSizeMode.Zoom;
            imgStatus.TabIndex = 0;
            imgStatus.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lbDate);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 38);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(346, 130);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(lbContent);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 18);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 5, 0, 0);
            panel2.Size = new Size(340, 109);
            panel2.TabIndex = 1;
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Dock = DockStyle.Top;
            lbContent.ForeColor = Color.FromArgb(238, 238, 238);
            lbContent.Location = new Point(0, 5);
            lbContent.MaximumSize = new Size(400, 0);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(398, 120);
            lbContent.TabIndex = 0;
            lbContent.Text = resources.GetString("lbContent.Text");
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Dock = DockStyle.Top;
            lbDate.ForeColor = Color.FromArgb(128, 145, 162);
            lbDate.Location = new Point(3, 3);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(156, 15);
            lbDate.TabIndex = 0;
            lbDate.Text = "POSTED: 5 NOVEMBER, 2023";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 174);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(3);
            panel3.Size = new Size(346, 57);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel7);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 18);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(4);
            panel4.Size = new Size(340, 36);
            panel4.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(btnNo, 1, 0);
            tableLayoutPanel7.Controls.Add(btnYes, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Left;
            tableLayoutPanel7.Location = new Point(4, 4);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(84, 28);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.FromArgb(79, 30, 35);
            btnNo.Dock = DockStyle.Fill;
            btnNo.ForeColor = SystemColors.ControlLightLight;
            btnNo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNo.Location = new Point(45, 3);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(36, 22);
            btnNo.TabIndex = 1;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = false;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.FromArgb(25, 65, 93);
            btnYes.Dock = DockStyle.Fill;
            btnYes.ForeColor = SystemColors.ControlLightLight;
            btnYes.ImageAlign = ContentAlignment.MiddleLeft;
            btnYes.Location = new Point(3, 3);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(36, 22);
            btnYes.TabIndex = 0;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Top;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.FromArgb(128, 145, 162);
            label7.Location = new Point(3, 3);
            label7.Name = "label7";
            label7.Size = new Size(133, 15);
            label7.TabIndex = 1;
            label7.Text = "Was this review helpful?";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Dock = DockStyle.Left;
            lbUserName.ForeColor = SystemColors.ControlLightLight;
            lbUserName.Location = new Point(31, 0);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(38, 29);
            lbUserName.TabIndex = 3;
            lbUserName.Text = "label1";
            lbUserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserRecentComment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UserRecentComment";
            Size = new Size(352, 234);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            pnImgBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgStatus).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel pnImgBackground;
        private PictureBox imgStatus;
        private Panel panel1;
        private Panel panel2;
        private Label lbContent;
        private Label lbDate;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel7;
        private Button btnNo;
        private Button btnYes;
        private Label label7;
        private Label lbUserName;
    }
}
