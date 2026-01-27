using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Clasificación_de_alimentos
{
    public partial class Clas4 : Form
    {
        private void RedondearFormulario(int radio)
        {
            // Crea una nueva ruta de gráficos para definir la forma
            GraphicsPath path = new GraphicsPath();
            int d = radio * 2;

            // Añade los arcos para las cuatro esquinas
            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(this.Width - d, 0, d, d, 270, 90);
            path.AddArc(this.Width - d, this.Height - d, d, d, 0, 90);
            path.AddArc(0, this.Height - d, d, d, 90, 90);

            // Cierra la figura y aplica la nueva región al formulario
            path.CloseFigure();
            this.Region = new Region(path);
        }
        public Clas4()
        {
            InitializeComponent();
            RedondearFormulario(25);
        }
        private void OcultarPaneles()
        {
            panelPrincipal.Visible = false;
            panelEnlatados.Visible = false;
            panelConservas.Visible = false;
            panelCongelados.Visible = false;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            OcultarPaneles();
            panelPrincipal.Visible = true;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Clas1 clas1 = new Clas1();
            clas1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            panelEnlatados.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            panelConservas.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            panelCongelados.Visible = true;
        }
    }
}
