using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace HydraApp.Class
{

public class CircularProgressBar : Control
    {
        private int percentage = 0;

        public int Percentage
        {
            get => percentage;
            set
            {
                percentage = Math.Max(0, Math.Min(100, value));
                Invalidate();
            }
        }

        public Color ProgressColor { get; set; } = Color.DeepSkyBlue;
        public Color TrackColor { get; set; } = Color.FromArgb(50, 60, 75);
        public int Thickness { get; set; } = 12;

        public CircularProgressBar()
        {
            Size = new Size(150, 150);
            BackColor = Color.FromArgb(20, 27, 40);
            ForeColor = Color.White;
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            float margem = Thickness / 2f + 3;
            float diametro = Math.Min(
                ClientSize.Width,
                ClientSize.Height
            ) - 2 * margem;

            if (diametro <= 0) return;

            RectangleF area = new RectangleF(
                (ClientSize.Width - diametro) / 2f,
                (ClientSize.Height - diametro) / 2f,
                diametro,
                diametro
            );

            using (Pen fundo = new Pen(TrackColor, Thickness))
            using (Pen progresso = new Pen(ProgressColor, Thickness))
            {
                fundo.StartCap = LineCap.Round;
                fundo.EndCap = LineCap.Round;

                progresso.StartCap = LineCap.Round;
                progresso.EndCap = LineCap.Round;

                g.DrawArc(fundo, area, -90, 359.9f);

                if (Percentage > 0)
                {
                    g.DrawArc(
                        progresso,
                        area,
                        -90,
                        360f * Percentage / 100f
                    );
                }
            }

            string texto = $"{Percentage}%";

            using (Font fonte = new Font(
                "Segoe UI", 22, FontStyle.Bold))
            using (Brush pincel = new SolidBrush(ForeColor))
            {
                SizeF tamanho = g.MeasureString(texto, fonte);

                g.DrawString(
                    texto,
                    fonte,
                    pincel,
                    (ClientSize.Width - tamanho.Width) / 2f,
                    (ClientSize.Height - tamanho.Height) / 2f
                );
            }
        }
    
}
}
