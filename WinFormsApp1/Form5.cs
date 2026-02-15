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

    public partial class Form5 : Form
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

        int puntaje = 0;
        int indice = 0;
        int tiempoTotal = 0;
        int tiempoMaximo = 0;
        int tiempoFinal = 0;
        int puntosPorRespuesta = 10;
        string[] oracionesJuego;
        string[] respuestasJuego;
        void IniciarJuego()
        {
            if (tiempoMaximo <= 0)
            {
                MessageBox.Show("Seleccione una dificultad primero");
                return;
            }

            tiempoTotal = tiempoMaximo;
            MostrarTiempo();
            timer1.Start();
        }
        void ReiniciarJuego()
        {
            timer1.Stop();
            puntaje = 0;
            indice = 0;
            tiempoTotal = 0;

            lblPuntaje.Text = "Puntaje: 0";
            label16.Text = "00:00";


            btnVerificar.Enabled = true;
            btnSiguiente.Enabled = false;

            btnComenzar.Enabled = true;

            lblResultado.Visible = false;
            panel5.Visible = true;
            btnComenzar.Enabled = true;
            txtRespuesta.Enabled = false;
        }


        void MostrarTiempo()
        {
            int minutos = tiempoTotal / 60;
            int segundos = tiempoTotal % 60;

            label16.Text = minutos.ToString("D2") + ":" + segundos.ToString("D2");
        }

        string[] oraciones = new string[]
        {
            "Un banco de alimentos comunitario ayuda a reducir el __________ " +
            "alimentario.",
            "Los alimentos donados deben estar en buen __________.",
            "Las donaciones de alimentos benefician a muchas __________.",
            "El banco de alimentos recibe, almacena y ___________ productos " +
            "alimenticios.",
            "Los alimentos deben ser clasificados según su tipo y __________.",
            "La correcta higiene evita la __________ de los alimentos.",
            "El banco de alimentos apoya a personas en situación de __________.",
            "Los alimentos perecederos requieren adecuada __________.",
            "La donación responsable contribuye a la __________ alimentaria.",
            "Una buena alimentación mejora la __________ de las personas."
        };
        string[] oracionesDificil = new string[]
{
    "Un banco de alimentos comunitario ayuda a reducir el __________ alimentario.",
    "Los alimentos donados deben estar en buen __________.",
    "Las donaciones de alimentos benefician a muchas __________.",
    "El banco de alimentos recibe, almacena y ___________ productos alimenticios.",
    "Los alimentos deben ser clasificados según su tipo y __________.",
    "La correcta higiene evita la __________ de los alimentos.",
    "El banco de alimentos apoya a personas en situación de __________.",
    "Los alimentos perecederos requieren adecuada __________.",
    "La donación responsable contribuye a la __________ alimentaria.",
    "Una buena alimentación mejora la __________ de las personas.",

    "El almacenamiento adecuado previene la __________ de los alimentos.",
    "La fecha de __________ indica hasta cuándo consumir el producto.",
    "Los voluntarios ayudan en la __________ de alimentos.",
    "Una dieta balanceada incluye vitaminas y __________.",
    "El desperdicio de alimentos afecta al __________.",
    "Los alimentos deben mantenerse en un lugar __________.",
    "La manipulación incorrecta puede causar __________.",
    "El banco promueve la __________ social.",
    "Las frutas deben lavarse antes de su __________.",
    "La nutrición adecuada fortalece el __________."
};


        string[] respuestas = new string[]
        {
            "desperdicio",
            "estado",
            "familias",
            "distribuye",
            "categoría",
            "contaminación",
            "vulnerabilidad",
            "refrigeración",
            "seguridad",
            "salud"
        };
        string[] respuestasDificil = new string[]
{
    "desperdicio",
    "estado",
    "familias",
    "distribuye",
    "categoría",
    "contaminación",
    "vulnerabilidad",
    "refrigeración",
    "seguridad",
    "salud",

    "descomposición",
    "caducidad",
    "clasificación",
    "minerales",
    "ambiente",
    "fresco",
    "enfermedades",
    "solidaridad",
    "consumo",
    "sistema"
};

        bool respuestaCorrecta = false;

        public Form5()
        {
            InitializeComponent();

            RedondearFormulario(25);
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }
        void CargarOracion()
        {
            string oracion = oracionesJuego[indice];

            lblOracion.Text = oracion;
            lblOracion.AutoSize = true;
            lblOracion.MaximumSize = new Size(600, 0);

            btnVerificar.Enabled = true;

            int posicion = oracion.IndexOf("________");

            if (posicion != -1)
            {
                string textoAntes = oracion.Substring(0, posicion);

                Size tamañoTexto = TextRenderer.MeasureText(
                    textoAntes,
                    lblOracion.Font
                );

                txtRespuesta.Location = new Point(
                    lblOracion.Left + tamañoTexto.Width,
                    lblOracion.Top
                );
            }

            txtRespuesta.Width = 70;
            txtRespuesta.Text = "";

            lblResultado.Text = "";
            lblResultado.Visible = false;

            btnSiguiente.Enabled = false;
            respuestaCorrecta = false;

            lblPuntaje.Text = "Puntaje: " + puntaje;
        }

        private void btnVerificar_Click_1(object sender, EventArgs e)
        {
            if (respuestaCorrecta) return;

            string respuesta = txtRespuesta.Text.Trim().ToLower();

            if (respuesta == respuestasJuego[indice])

            {
                lblResultado.ForeColor = Color.Green;
                lblResultado.Text = "✔ ¡Correcto!";
                lblResultado.Visible = true;

                puntaje += puntosPorRespuesta;


                if (puntaje > 100)
                {
                    puntaje = 100;
                }


                lblPuntaje.Text = "Puntaje: " + puntaje;

                respuestaCorrecta = true;

                btnSiguiente.Enabled = true;
                btnVerificar.Enabled = false;
            }
            else
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "✘ Inténtalo de nuevo";
                lblResultado.Visible = true;
            }
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {

            if (!respuestaCorrecta)
                return;


            if (indice == oracionesJuego.Length - 1)
            {
                timer1.Stop();

                tiempoFinal = tiempoMaximo - tiempoTotal;

                int minutos = tiempoFinal / 60;
                int segundos = tiempoFinal % 60;

                MessageBox.Show(
                "¡Juego terminado!\nPuntaje final: " + puntaje +
                "\nTiempo: " + minutos.ToString("D2") + ":" + segundos.ToString("D2")
                );

                btnSiguiente.Enabled = false;
                txtRespuesta.Enabled = false;
                btnVerificar.Enabled = false;

                return;
            }


            indice++;
            CargarOracion();
        }

        private void txtRespuesta_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ReiniciarJuego();

            panel4.Visible = false;
            panel3.Visible = true;

        }

        private void lblPuntaje_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cuidado1 cui1 = new Cuidado1();
            cui1.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ReiniciarJuego();
            tiempoMaximo = 120;

            oracionesJuego = oraciones;
            respuestasJuego = respuestas;
            puntosPorRespuesta = 10;

            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = true;
            panel2.Visible = true;
            panel6.Visible = false;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ReiniciarJuego();
            tiempoMaximo = 60;

            oracionesJuego = oraciones;
            respuestasJuego = respuestas;
            puntosPorRespuesta = 10;

            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = true;
            panel2.Visible = true;
            panel6.Visible = false;


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ReiniciarJuego();
            tiempoMaximo = 60;

            oracionesJuego = oracionesDificil;
            respuestasJuego = respuestasDificil;
            puntosPorRespuesta = 5;

            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = true;
            panel2.Visible = false;
            panel6.Visible = true;


        }

        private void label16_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (tiempoTotal <= 0)
            {
                timer1.Stop();

                lblResultado.Text = "⏱ Tiempo agotado";
                lblResultado.ForeColor = Color.Red;
                lblResultado.Visible = true;

                btnVerificar.Enabled = false;
                btnSiguiente.Enabled = true;
                return;
            }

            tiempoTotal--;
            MostrarTiempo();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            IniciarJuego();
            CargarOracion();
            txtRespuesta.Enabled = true;
            btnVerificar.Enabled = true;
            btnSiguiente.Enabled = false;

            btnComenzar.Enabled = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

