namespace NT106_User
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
            imgPoster.Margin = new Padding(4, 5, 4, 5);
            imgPoster.Name = "imgPoster";
            imgPoster.Size = new Size(286, 500);
            imgPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPoster.TabIndex = 0;
            imgPoster.TabStop = false;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(14, 23);
            lbType.Margin = new Padding(4, 0, 4, 0);
            lbType.Name = "lbType";
            lbType.Size = new Size(61, 25);
            lbType.TabIndex = 1;
            lbType.Text = "Movie";
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.Location = new Point(209, 23);
            lbScore.Margin = new Padding(4, 0, 4, 0);
            lbScore.Name = "lbScore";
            lbScore.Size = new Size(63, 25);
            lbScore.TabIndex = 1;
            lbScore.Text = "8.0/10";
            // 
            // lbContentRating
            // 
            lbContentRating.AutoSize = true;
            lbContentRating.Location = new Point(14, 455);
            lbContentRating.Margin = new Padding(4, 0, 4, 0);
            lbContentRating.Name = "lbContentRating";
            lbContentRating.Size = new Size(23, 25);
            lbContentRating.TabIndex = 1;
            lbContentRating.Text = "R";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Dock = DockStyle.Fill;
            lbName.Font = new Font("Segoe UI", 11F);
            lbName.Location = new Point(0, 500);
            lbName.Margin = new Padding(4, 0, 4, 0);
            lbName.Name = "lbName";
            lbName.Size = new Size(135, 30);
            lbName.TabIndex = 2;
            lbName.Text = "Openheimer";
            // 
            // PosterCard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(lbName);
            Controls.Add(lbContentRating);
            Controls.Add(lbScore);
            Controls.Add(lbType);
            Controls.Add(imgPoster);
            Margin = new Padding(4, 5, 4, 5);
            Name = "PosterCard";
            Size = new Size(286, 573);
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
