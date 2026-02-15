using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Intrucciones_sopa : Form
    {
        public static bool NivelFacilCompletado = false;
        public static bool NivelMedioCompletado = false;

        public Intrucciones_sopa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            info1 fp = (info1)Application.OpenForms["info1"];
            if (fp != null)
            {
                // Pasamos 'fp' como argumento para que el juego sepa a quién regresar
                juego2 nFacil = new juego2(fp);
                nFacil.NivelCompletado = () => { NivelFacilCompletado = true; };
                fp.AbrirFormEnPanel(nFacil);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (NivelFacilCompletado)
            {
                info1 fp = (info1)Application.OpenForms["info1"];
                if (fp != null)
                {
                    // Pasamos 'fp' como argumento para que el juego sepa a quién regresar
                    juego nmedio = new juego(fp);
                    nmedio.NivelCompletado = () => { NivelMedioCompletado = true; };
                    fp.AbrirFormEnPanel(nmedio);
                }
            }
            else { MessageBox.Show("Debes completar el Nivel Fácil primero."); }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (NivelFacilCompletado && NivelMedioCompletado)
            {
                info1 fp = (info1)Application.OpenForms["info1"];
                if (fp != null)
                {
                    // Debes asegurarte que la clase 'juego3' acepte un argumento Form en su constructor
                    juego3 nDificil = new juego3(fp);
                    fp.AbrirFormEnPanel(nDificil);
                }
            }
            else { MessageBox.Show("Debes completar el Nivel Medio primero."); }
        }
    }
}