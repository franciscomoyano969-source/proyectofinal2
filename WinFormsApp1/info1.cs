using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class info1 : Form
    {
        public info1()
        {
            InitializeComponent();

            RedondearFormulario(25);
            Redondearpanel(pangenmenu, 50);
            Redondearpanel(paninfo, 30);

            // Redondeo de botones
            Redondear_butom(button1, 40);
            Redondear_butom(button2, 40);
            Redondear_butom(button3, 40);
            Redondear_butom(button4, 40);
            Redondear_butom(button5, 40);

            // Colores de botones y paneles
            button1.BackColor = ColorTranslator.FromHtml("#98FF98");
            button2.BackColor = ColorTranslator.FromHtml("#98FF98");
            button3.BackColor = ColorTranslator.FromHtml("#98FF98");
            button4.BackColor = ColorTranslator.FromHtml("#98FF98");
            button5.BackColor = ColorTranslator.FromHtml("#98FF98");
            paninfo.BackColor = ColorTranslator.FromHtml("#e5ff7d");
        }
        public void CambiarContenido(Form nuevoHijo)
        {
            this.pangenmenu.Controls.Clear(); // Limpiamos lo que haya (la sopa)

            nuevoHijo.TopLevel = false;
            nuevoHijo.FormBorderStyle = FormBorderStyle.None;
            nuevoHijo.Dock = DockStyle.Fill;

            this.pangenmenu.Controls.Add(nuevoHijo);
            nuevoHijo.Show();
        }
        public void AbrirFormEnPanel(Form fh)
        {
            if (this.pangenmenu.Controls.Count > 0)
            {
                Form anterior = this.pangenmenu.Controls[0] as Form;
                if (anterior != null)
                {
                    anterior.Close();    
                    anterior.Dispose();
                }
                this.pangenmenu.Controls.Clear();
            }

            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.pangenmenu.Controls.Add(fh);
            this.pangenmenu.Tag = fh;
            fh.Show();
        }

        private void picjuego_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Intrucciones_sopa());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Quees());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new objetivos());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Quehacen());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new impactosocial());
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Consejos());
        }

        private void picregresar_Click(object sender, EventArgs e)
        {
            if (this.pangenmenu.Controls.Count > 0)
            {
                Form fh = this.pangenmenu.Controls[0] as Form;
                fh?.Close();
            }

            Form1 menuInicio = new Form1();
            menuInicio.Show();
            this.Hide();
        }
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            paninfo.Visible = true;
            paninfo.BringToFront();
        }

        private void picsalref_Click(object sender, EventArgs e)
        {
            paninfo.Visible = false;
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