namespace NT106_User
{
    partial class Watchlist
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
            pnWatchlist = new Panel();
            watchListItem1 = new WatchListItem();
            pnWatchlist.SuspendLayout();
            SuspendLayout();
            // 
            // pnWatchlist
            // 
            pnWatchlist.Controls.Add(watchListItem1);
            pnWatchlist.Dock = DockStyle.Fill;
            pnWatchlist.Location = new Point(0, 0);
            pnWatchlist.Name = "pnWatchlist";
            pnWatchlist.Size = new Size(618, 757);
            pnWatchlist.TabIndex = 0;
            // 
            // watchListItem1
            // 
            watchListItem1.BackColor = SystemColors.ControlDarkDark;
            watchListItem1.Dock = DockStyle.Top;
            watchListItem1.Location = new Point(0, 0);
            watchListItem1.Name = "watchListItem1";
            watchListItem1.Padding = new Padding(3);
            watchListItem1.Size = new Size(618, 280);
            watchListItem1.TabIndex = 0;
            // 
            // Watchlist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(618, 757);
            ControlBox = false;
            Controls.Add(pnWatchlist);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Watchlist";
            Text = "Watchlist";
            Load += Watchlist_Load;
            pnWatchlist.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnWatchlist;
        private WatchListItem watchListItem1;
    }
}