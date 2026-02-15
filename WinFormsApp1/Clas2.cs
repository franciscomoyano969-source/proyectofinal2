using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1;

namespace Clasificación_de_alimentos
{
    public partial class Clas2 : Form
    {
        public Clas2()
        {
            InitializeComponent();

            // Aplicar redondeos iniciales
            RedondearFormulario(25);
            Redondear_butom(button1, 40);
            Redondear_butom(button2, 40);
            Redondear_butom(button3, 40);
            Redondearpanel(panelPrincipal, 50);
            // Colores de botones
            button1.BackColor = ColorTranslator.FromHtml("#98FF98");
            button2.BackColor = ColorTranslator.FromHtml("#98FF98");
            button3.BackColor = ColorTranslator.FromHtml("#98FF98");
        }

        // --- MÉTODOS DE DISEÑO ---

        private void RedondearFormulario(int radio)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radio * 2;
            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(this.Width - d, 0, d, d, 270, 90);
            path.AddArc(this.Width - d, this.Height - d, d, d, 0, 90);
            path.AddArc(0, this.Height - d, d, d, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
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
        public void AbrirFormEnPanel(Form fh)
        {
            if (this.panelPrincipal.Controls.Count > 0)
            {
                Form anterior = this.panelPrincipal.Controls[0] as Form;
                if (anterior != null)
                {
                    anterior.Close();
                    anterior.Dispose();
                }
                this.panelPrincipal.Controls.Clear();
            }

            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();
        }
        static void Redondear_butom(Button boton, int radius)
        {
            GraphicsPath gp = new GraphicsPath();
            int d = radius * 2;
            gp.AddArc(0, 0, d, d, 180, 90);
            gp.AddArc(boton.Width - d, 0, d, d, 270, 90);
            gp.AddArc(boton.Width - d, boton.Height - d, d, d, 0, 90);
            gp.AddArc(0, boton.Height - d, d, d, 90, 90);
            gp.CloseFigure();
            boton.Region = new Region(gp);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Cereales());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new legumbres());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new aceites());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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