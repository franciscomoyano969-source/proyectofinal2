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

    public partial class Cuidado4 : Form
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
        bool respuestaCorrecta = false;

        public Cuidado4()
        {
            InitializeComponent();
            CargarOracion();
            RedondearFormulario(25);
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }
        void CargarOracion()
        {
            string oracion = oraciones[indice];
            lblOracion.Text = oracion;
            lblOracion.AutoSize = true;
            lblOracion.AutoSize = false;
            lblOracion.MaximumSize = new Size(600, 0); // ancho fijo
            lblOracion.Size = new Size(600, 0);
            lblOracion.Text = oraciones[indice];
            btnVerificar.Enabled = true;
            // Buscar la posición del espacio en blanco
            int posicion = oracion.IndexOf("________");

            if (posicion != -1)
            {
                // Texto antes del espacio
                string textoAntes = oracion.Substring(0, posicion);

                // Medir el tamaño del texto antes del espacio
                Size tamañoTexto = TextRenderer.MeasureText(
                    textoAntes,
                    lblOracion.Font
                );

                // Mover el TextBox exactamente al espacio
                txtRespuesta.Location = new Point(
                    lblOracion.Left + tamañoTexto.Width,
                    lblOracion.Top
                );
            }

            txtRespuesta.Width = 70;
            txtRespuesta.Text = "";

            lblResultado.Text = "";
            lblResultado.ForeColor = Color.Black;
            lblResultado.Visible = false;

            btnSiguiente.Enabled = false;
            respuestaCorrecta = false;

            lblPuntaje.Text = "Puntaje: " + puntaje; oracion = oraciones[indice];
            lblOracion.Text = oracion;
            lblOracion.AutoSize = true;

            // Buscar la posición del espacio en blanco
            posicion = oracion.IndexOf("________");

            if (posicion != -1)
            {
                // Texto antes del espacio
                string textoAntes = oracion.Substring(0, posicion);

                // Medir el tamaño del texto antes del espacio
                Size tamañoTexto = TextRenderer.MeasureText(
                    textoAntes,
                    lblOracion.Font
                );

                // Mover el TextBox exactamente al espacio
                txtRespuesta.Location = new Point(
                    lblOracion.Left + tamañoTexto.Width,
                    lblOracion.Top
                );
            }

            txtRespuesta.Width = 70;
            txtRespuesta.Text = "";

            lblResultado.Text = "";
            lblResultado.ForeColor = Color.Black;
            lblResultado.Visible = false;

            btnSiguiente.Enabled = false;
            respuestaCorrecta = false;

            lblPuntaje.Text = "Puntaje: " + puntaje;
        }
        private void btnVerificar_Click_1(object sender, EventArgs e)
        {
            if (respuestaCorrecta) return; // 👈 evita doble suma

            string respuesta = txtRespuesta.Text.Trim().ToLower();

            if (respuesta == respuestas[indice])
            {
                lblResultado.ForeColor = Color.Green;
                lblResultado.Text = "✔ ¡Correcto!";
                lblResultado.Visible = true;

                puntaje += 10;
                respuestaCorrecta = true;

                btnSiguiente.Enabled = true;
                btnVerificar.Enabled = false; // 👈 BLOQUEO CLAVE
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

            indice++;

            if (indice < oraciones.Length)
            {
                CargarOracion();
            }
            else
            {
                lblPuntaje.Text = "Puntaje: " + puntaje;
                MessageBox.Show("¡Juego terminado!\nPuntaje final: " + puntaje);
                btnSiguiente.Enabled = false;
                txtRespuesta.Enabled = false;
            }
        }

        private void txtRespuesta_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Cuidado1 formCuidado = new Cuidado1();
            formCuidado.Show();
            this.Hide();
        }

        private void lblPuntaje_Click(object sender, EventArgs e)
        {

        }
    }
}

