using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Intrucciones_sopa : Form
    {
        // VARIABLES DE PROGRESO (Estáticas para que no se reinicien al cambiar de panel)
        public static bool NivelFacilCompletado = false;
        public static bool NivelMedioCompletado = false;

        public Intrucciones_sopa()
        {
            InitializeComponent();
        }

        // --- BOTÓN NIVEL FÁCIL (Juego 2) ---
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            juego2 nFacil = new juego2();

            // Cuando gane el fácil, desbloquea el medio
            nFacil.NivelCompletado = () => {
                NivelFacilCompletado = true;
            };

            info1 fp2 = (info1)Application.OpenForms["info1"];
            fp2.AbrirFormEnPanel(nFacil);
        }

        // --- BOTÓN NIVEL MEDIO (Juego) ---
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (NivelFacilCompletado)
            {
                juego nMedio = new juego();

                // Cuando gane el medio, desbloquea el difícil
                nMedio.NivelCompletado = () => {
                    NivelMedioCompletado = true;
                };

                info1 fp = (info1)Application.OpenForms["info1"];
                fp.AbrirFormEnPanel(nMedio);
            }
            else
            {
                MessageBox.Show("Debes completar el Nivel Fácil primero.", "Nivel Bloqueado");
            }
        }

        // --- BOTÓN NIVEL DIFÍCIL (Juego 3) ---
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (NivelFacilCompletado && NivelMedioCompletado)
            {
                info1 fp = (info1)Application.OpenForms["info1"];
                fp.AbrirFormEnPanel(new juego3());
            }
            else
            {
                MessageBox.Show("Debes completar el Nivel Medio primero.", "Nivel Bloqueado");
            }
        }
    }
}