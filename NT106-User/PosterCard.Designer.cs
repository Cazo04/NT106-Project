﻿namespace NT106_User
{
    partial class PosterCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosterCard));
            imgPoster = new PictureBox();
            lbType = new Label();
            lbScore = new Label();
            lbContentRating = new Label();
            lbName = new Label();
            ((System.ComponentModel.ISupportInitialize)imgPoster).BeginInit();
            SuspendLayout();
            // 
            // imgPoster
            // 
            imgPoster.Dock = DockStyle.Top;
            imgPoster.Image = (Image)resources.GetObject("imgPoster.Image");
            imgPoster.Location = new Point(0, 0);
            imgPoster.Name = "imgPoster";
            imgPoster.Size = new Size(200, 300);
            imgPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPoster.TabIndex = 0;
            imgPoster.TabStop = false;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.BackColor = Color.FromArgb(16, 24, 39);
            lbType.ForeColor = SystemColors.Control;
            lbType.Location = new Point(10, 14);
            lbType.Name = "lbType";
            lbType.Size = new Size(40, 15);
            lbType.TabIndex = 1;
            lbType.Text = "Movie";
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.BackColor = Color.FromArgb(16, 24, 39);
            lbScore.ForeColor = SystemColors.Control;
            lbScore.Location = new Point(146, 14);
            lbScore.Name = "lbScore";
            lbScore.Padding = new Padding(3);
            lbScore.Size = new Size(45, 21);
            lbScore.TabIndex = 1;
            lbScore.Text = "8.0/10";
            // 
            // lbContentRating
            // 
            lbContentRating.AutoSize = true;
            lbContentRating.BackColor = Color.FromArgb(16, 24, 39);
            lbContentRating.ForeColor = SystemColors.Control;
            lbContentRating.Location = new Point(10, 273);
            lbContentRating.Name = "lbContentRating";
            lbContentRating.Padding = new Padding(3);
            lbContentRating.Size = new Size(20, 21);
            lbContentRating.TabIndex = 1;
            lbContentRating.Text = "R";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Dock = DockStyle.Fill;
            lbName.Font = new Font("Segoe UI", 11F);
            lbName.ForeColor = SystemColors.Control;
            lbName.Location = new Point(0, 300);
            lbName.Name = "lbName";
            lbName.Size = new Size(91, 20);
            lbName.TabIndex = 2;
            lbName.Text = "Openheimer";
            // 
            // PosterCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 24, 39);
            Controls.Add(lbName);
            Controls.Add(lbContentRating);
            Controls.Add(lbScore);
            Controls.Add(lbType);
            Controls.Add(imgPoster);
            Name = "PosterCard";
            Size = new Size(200, 344);
            Click += PosterCard_Click;
            MouseEnter += PosterCard_MouseEnter;
            MouseLeave += PosterCard_MouseLeave;
            Resize += PosterCard_Resize;
            ((System.ComponentModel.ISupportInitialize)imgPoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgPoster;
        private Label lbType;
        private Label lbScore;
        private Label lbContentRating;
        private Label lbName;
    }
}
