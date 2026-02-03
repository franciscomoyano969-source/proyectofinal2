using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D; // Necesario para formas avanzadas

namespace WindowsFormsApp5.NewFolder1
{
    public partial class ucPasoProtocolo : UserControl
    {
        public ucPasoProtocolo()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public void configurarPaso(string numero, string texto)
        {
            label1.Text = numero + ".";
            label2.Text = texto;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            int borderRadius = 20; // Ajusta este valor para más o menos redondeo
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            
            using (GraphicsPath path = GetRoundedPath(rect, borderRadius))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                
                // 1. Recortar el control para que las esquinas sean transparentes
                this.Region = new Region(path);

                // 2. Dibujar el fondo (usa el color verde de tu diseño)
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
        }
        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void ucPasoProtocolo_Load(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
