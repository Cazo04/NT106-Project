using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace NT106_User
{
    public static class LabelExtensions
    {
        public static void MakeRounded(this Label label, int borderRadius)
        {
            label.Paint += (sender, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                    path.AddArc(label.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                    path.AddArc(label.Width - borderRadius, label.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                    path.AddArc(0, label.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                    path.CloseAllFigures();

                    label.Region = new Region(path);

                    using (SolidBrush brush = new SolidBrush(label.BackColor))
                    {
                        e.Graphics.FillPath(brush, path);
                    }

                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;

                        using (Brush brush = new SolidBrush(label.ForeColor))
                        {
                            e.Graphics.DrawString(label.Text, label.Font, brush, label.ClientRectangle, sf);
                        }
                    }
                }
            };

            label.Resize += (sender, e) =>
            {
                label.Invalidate();
            };
        }
    }
}
