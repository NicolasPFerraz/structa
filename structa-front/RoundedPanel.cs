using System;
using System.Drawing;
using System.Windows.Forms;

namespace structa_front
{
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 2;
        public int ShadowOffset { get; set; } = 16;
        public Color ShadowColor { get; set; } = Color.FromArgb(60, 0, 0, 0);

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            var rect = new Rectangle(ShadowOffset, ShadowOffset, Width - ShadowOffset * 2, Height - ShadowOffset * 2);
            using (var path = RoundedRectPath(rect, CornerRadius))
            {
                // desenhar sombra
                for (int i = 0; i < 8; i++)
                {
                    int alpha = (int)(ShadowColor.A * (1.0 - i / 8.0));
                    using (var brush = new SolidBrush(Color.FromArgb(alpha, ShadowColor)))
                    {
                        var srect = new Rectangle(rect.X - i, rect.Y - i, rect.Width + i * 2, rect.Height + i * 2);
                        using (var sp = RoundedRectPath(srect, CornerRadius + i))
                            g.FillPath(brush, sp);
                    }
                }

                // fundo do painel
                using (var brush = new SolidBrush(this.BackColor))
                    g.FillPath(brush, path);

                // borda
                using (var pen = new Pen(Color.FromArgb(100, Color.Black)))
                    g.DrawPath(pen, path);

                // define a região para recorte/click
                this.Region = new Region(path);
            }
        }

        private System.Drawing.Drawing2D.GraphicsPath RoundedRectPath(Rectangle r, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            int d = radius * 2;
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
