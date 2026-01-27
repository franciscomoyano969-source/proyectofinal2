using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace Cuidado_nutricional
{
    public partial class Cuidado2 : Form
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
        public Cuidado2()
        {
            InitializeComponent();
            RedondearFormulario(25);
        }
        private void OcultarPaneles()
        {
            panelPrincipal.Visible = false;
            panelEnergeticos.Visible = false;
            panelConstructores.Visible = false;
            panelReguladores.Visible = false;
            panelGrasas.Visible = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            OcultarPaneles();
            panelPrincipal.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            panelEnergeticos.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Cuidado1 formCuidado = new Cuidado1();
            formCuidado.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            panelConstructores.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            panelReguladores.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OcultarPaneles();
            panelGrasas.Visible = true;
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelEnergeticos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
