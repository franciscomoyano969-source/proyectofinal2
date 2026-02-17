using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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