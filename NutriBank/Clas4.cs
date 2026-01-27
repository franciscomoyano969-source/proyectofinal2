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
            Redondear_butom(button1, 40);
            Redondear_butom(button2, 40);
            Redondear_butom(button3, 40);
            Redondearpanel(panelPrincipal, 30);
            Redondearpanel(panelEnlatados, 30);
            Redondearpanel(panelConservas, 30);
            Redondearpanel(panelCongelados, 30);
            button1.BackColor = ColorTranslator.FromHtml("#98FF98");
            button2.BackColor = ColorTranslator.FromHtml("#98FF98");
            button3.BackColor = ColorTranslator.FromHtml("#98FF98");
        }
        static void Redondear_butom(Button boton, int radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, radius, radius, 180, 90);
            gp.AddArc(boton.Width - radius, 0, radius, radius, 270, 90);
            gp.AddArc(boton.Width - radius, boton.Height - radius, radius, radius, 0, 90);
            gp.AddArc(0, boton.Height - radius, radius, radius, 90, 90);
            gp.CloseFigure();
            boton.Region = new Region(gp);
        }
        static void Redondearpanel(Panel p, int r)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, r, r, 180, 90);
            gp.AddArc(p.Width - r, 0, r, r, 270, 90);
            gp.AddArc(p.Width - r, p.Height - r, r, r, 0, 90);
            gp.AddArc(0, p.Height - r, r, r, 90, 90);
            gp.CloseFigure();
            p.Region = new Region(gp);
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
