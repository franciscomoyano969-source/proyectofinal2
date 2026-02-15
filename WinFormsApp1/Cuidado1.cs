using Clasificación_de_alimentos;
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
    public partial class Cuidado1 : Form
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
        public Cuidado1()
        {
            InitializeComponent();
            RedondearFormulario(25);
            referenciaa.BackColor = ColorTranslator.FromHtml("#e5ff7d");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            referenciaa.Visible = false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Cuidado2 formNuevo = new Cuidado2();
            formNuevo.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Cuidado3 formNuevo = new Cuidado3();
            formNuevo.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            referenciaa.Visible = true;
            referenciaa.BringToFront();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            referenciaa.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Clas1 formClas1 = new Clas1();
            formClas1.Show();
            this.Hide();
        }

        private void picsalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas cerrar la aplicación?", "Cerrar Aplicación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
