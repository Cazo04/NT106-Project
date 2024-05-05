﻿namespace NT106_User
{
    partial class PesonView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesonView));
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            lbMore = new Label();
            lbCharacterName = new Label();
            lbName = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.3186817F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.68132F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(364, 112);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lbMore, 0, 2);
            tableLayoutPanel2.Controls.Add(lbCharacterName, 0, 1);
            tableLayoutPanel2.Controls.Add(lbName, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(117, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(3);
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.Size = new Size(244, 106);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // lbMore
            // 
            lbMore.AutoSize = true;
            lbMore.Dock = DockStyle.Fill;
            lbMore.ForeColor = SystemColors.ControlLightLight;
            lbMore.Location = new Point(6, 73);
            lbMore.Name = "lbMore";
            lbMore.Size = new Size(232, 30);
            lbMore.TabIndex = 2;
            lbMore.Text = "More";
            lbMore.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbCharacterName
            // 
            lbCharacterName.AutoSize = true;
            lbCharacterName.Dock = DockStyle.Fill;
            lbCharacterName.ForeColor = SystemColors.ControlLightLight;
            lbCharacterName.Location = new Point(6, 38);
            lbCharacterName.Name = "lbCharacterName";
            lbCharacterName.Size = new Size(232, 35);
            lbCharacterName.TabIndex = 1;
            lbCharacterName.Text = "CharacterName";
            lbCharacterName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Dock = DockStyle.Fill;
            lbName.ForeColor = SystemColors.ControlLightLight;
            lbName.Location = new Point(6, 3);
            lbName.Name = "lbName";
            lbName.Size = new Size(232, 35);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            lbName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PesonView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 27, 29);
            Controls.Add(tableLayoutPanel1);
            Name = "PesonView";
            Size = new Size(364, 112);
            Resize += PesonView_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lbName;
        private Label lbMore;
        private Label lbCharacterName;
    }
}
