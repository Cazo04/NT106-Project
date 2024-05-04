namespace NT106_User
{
    partial class CustomLable1
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
            lbText = new Label();
            SuspendLayout();
            // 
            // lbText
            // 
            lbText.Dock = DockStyle.Fill;
            lbText.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbText.Location = new Point(0, 0);
            lbText.Name = "lbText";
            lbText.Padding = new Padding(2);
            lbText.Size = new Size(222, 37);
            lbText.TabIndex = 0;
            lbText.Text = "label1";
            lbText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CustomLable1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 24, 39);
            Controls.Add(lbText);
            ForeColor = SystemColors.ControlLightLight;
            Name = "CustomLable1";
            Size = new Size(222, 37);
            Resize += CustomLable1_Resize;
            ResumeLayout(false);
        }

        #endregion

        private Label lbText;
    }
}
