using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                    TextRenderer.DrawText(e.Graphics, label.Text, label.Font, label.ClientRectangle, label.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
            };
        }
    }
}
