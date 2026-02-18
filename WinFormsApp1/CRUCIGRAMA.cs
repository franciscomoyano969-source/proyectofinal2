using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace ParteInteractivaPY
{
    public partial class CRUCIGRAMA : Form
    {
        // Variable estática para mantener el progreso
        // 1 = Fácil, 2 = Medio, 3 = Difícil
        public static int NivelDesbloqueado = 1;

        public CRUCIGRAMA()
        {
            InitializeComponent();
            ActualizarEstadoBotones();
            RedondearFormulario(25);
            Redondear_butom(btnFacil, 20);
            Redondear_butom(button2, 20);
            Redondear_butom(button3, 20);
            Redondearpanel(panel1, 30);
            Redondearpanel(panel2, 30);
            Redondearpanel(panel3, 30);
            Redondearpanel(panel4, 30);
            // Colores de botones y paneles
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
        // Método para habilitar botones y aplicar tus colores específicos
        private void ActualizarEstadoBotones()
        {
            // BOTÓN FÁCIL (button1) - Siempre activo
            btnFacil.Enabled = true;
            btnFacil.BackColor = Color.Lime;

            // BOTÓN MEDIO (button2)
            button2.Enabled = (NivelDesbloqueado >= 2);
            if (button2.Enabled)
            {
                button2.BackColor = Color.Yellow; // Color AMARILLO al desbloquear
            }
            else
            {
                button2.BackColor = Color.LightGray; // GRIS si está bloqueado
            }

            // BOTÓN DIFICIL (button3)
            button3.Enabled = (NivelDesbloqueado >= 3);
            if (button3.Enabled)
            {
                button3.BackColor = Color.Red; // Color ROJO al desbloquear
                button3.ForeColor = Color.White; // Texto blanco para que resalte en el rojo
            }
            else
            {
                button3.BackColor = Color.LightGray; // GRIS si está bloqueado
                button3.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FACIL fACIL = new FACIL();
            fACIL.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MEDIO mEDIO = new MEDIO();
            mEDIO.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DIFICIL dIFICIL = new DIFICIL();
            dIFICIL.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Menuprincipal menuprincipal = new Menuprincipal();
            menuprincipal.Show();
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