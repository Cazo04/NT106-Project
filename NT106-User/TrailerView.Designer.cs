namespace NT106_User
{
    partial class TrailerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrailerView));
            wmpPreviewTrailer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)wmpPreviewTrailer).BeginInit();
            SuspendLayout();
            // 
            // wmpPreviewTrailer
            // 
            wmpPreviewTrailer.Dock = DockStyle.Fill;
            wmpPreviewTrailer.Enabled = true;
            wmpPreviewTrailer.Location = new Point(0, 0);
            wmpPreviewTrailer.Name = "wmpPreviewTrailer";
            wmpPreviewTrailer.OcxState = (AxHost.State)resources.GetObject("wmpPreviewTrailer.OcxState");
            wmpPreviewTrailer.Size = new Size(590, 348);
            wmpPreviewTrailer.TabIndex = 6;
            // 
            // TrailerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 348);
            Controls.Add(wmpPreviewTrailer);
            Name = "TrailerView";
            Text = "TrailerView";
            FormClosing += TrailerView_FormClosing;
            ((System.ComponentModel.ISupportInitialize)wmpPreviewTrailer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpPreviewTrailer;
    }
}