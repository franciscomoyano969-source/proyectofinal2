/*using Clasificación_de_alimentos;
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

            GraphicsPath path = new GraphicsPath();
            int d = radio * 2;


            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(this.Width - d, 0, d, d, 270, 90);
            path.AddArc(this.Width - d, this.Height - d, d, d, 0, 90);
            path.AddArc(0, this.Height - d, d, d, 90, 90);


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
            lblPuntaje.Text = "Puntaje: 0";
            tiempoTotal = 0;
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
            Cuidado1 inicio = Application.OpenForms["cuidado1"] as Cuidado1;

            if (inicio != null)
            {
                inicio.Show();
                this.Close();
            }
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
            tiempoTotal--;
            MostrarTiempo();

            if (tiempoTotal <= 0)
            {
                timer1.Stop();

                DialogResult resultado = MessageBox.Show(
                    "⏱ Se acabó el tiempo\n¿Desea volver a intentarlo?",
                    "Tiempo agotado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                // --- SOLUCIÓN ---
                if (resultado == DialogResult.Yes)
                {
                    // Llamamos a reiniciar para limpiar puntaje e índice antes de volver a empezar
                    ReiniciarJuego();

                    // Preparamos la interfaz para que el usuario elija dificultad o pulse comenzar
                    lblResultado.Text = "Puntaje reiniciado. ¡Elige dificultad o pulsa comenzar!";
                    lblResultado.ForeColor = Color.Blue;
                    lblResultado.Visible = true;

                    panel5.Visible = true; // Mostramos el panel de inicio
                    btnComenzar.Enabled = true;
                }
                else
                {
                    ReiniciarJuego();
                    panel6.Visible = false;
                    panel3.Visible = true; // Regresa al menú principal
                }
            }
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas cerrar el juego y salir de la aplicación?","Cerrar Aplicación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
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
}*/

using Clasificación_de_alimentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cuidado_nutricional
{
    public partial class Form5 : Form
    {
        bool nivelFacilCompletado = false;
        bool nivelMedioCompletado = false;

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

        int puntaje = 0;
        int indice = 0;
        int tiempoTotal = 0;
        int tiempoMaximo = 0;
        int puntosPorRespuesta = 10;
        int fallosConsecutivos = 0; // Para activar la pista
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
            fallosConsecutivos = 0;
            lblPuntaje.Text = "Puntaje: 0";
            tiempoTotal = 0;
            btnVerificar.Enabled = true;
            btnSiguiente.Enabled = false;
            btnComenzar.Enabled = true;
            lblResultado.Visible = false;
            panel5.Visible = true;
            txtRespuesta.Enabled = false;
        }

        void MostrarTiempo()
        {
            int minutos = tiempoTotal / 60;
            int segundos = tiempoTotal % 60;
            label16.Text = minutos.ToString("D2") + ":" + segundos.ToString("D2");
        }

        // --- BANCOS DE DATOS ---
        string[] oraciones = new string[] {
            "Un banco de alimentos comunitario ayuda a reducir el __________ alimentario.",
            "Los alimentos donados deben estar en buen __________.",
            "Las donaciones de alimentos benefician a muchas __________.",
            "El banco de alimentos recibe, almacena y ___________ productos alimenticios.",
            "Los alimentos deben ser clasificados según su tipo y __________.",
            "La correcta higiene evita la __________ de los alimentos.",
            "El banco de alimentos apoya a personas en situación de __________.",
            "Los alimentos perecederos requieren adecuada __________.",
            "La donación responsable contribuye a la __________ alimentaria.",
            "Una buena alimentación mejora la __________ de las personas."
        };
        string[] respuestas = new string[] { "desperdicio", "estado", "familias", "distribuye", "categoría", "contaminación", "vulnerabilidad", "refrigeración", "seguridad", "salud" };

        string[] oracionesMedio = new string[] {
            "Es vital revisar la fecha de __________ en cada producto.",
            "Los granos y legumbres son alimentos no __________.",
            "El __________ es el motor principal de la ayuda humanitaria.",
            "Una dieta equilibrada ayuda a combatir la __________.",
            "Los alimentos deben almacenarse en un lugar fresco y __________.",
            "La __________ equitativa de comida es un derecho humano.",
            "Debemos evitar el exceso de __________ en nuestra dieta diaria.",
            "La __________ social permite que nadie se quede sin comer.",
            "El transporte seguro mantiene la cadena de __________.",
            "Los bancos de alimentos imparten charlas de nutrición __________."
        };
        string[] respuestasMedio = new string[] { "vencimiento", "perecederos", "voluntariado", "anemia", "seco", "distribución", "azúcar", "solidaridad", "frío", "comunitaria" };

        string[] oracionesDificil = new string[] {
            "La logística inversa ayuda a recuperar el excedente __________.",
            "La __________ de riesgos asegura que la comida sea apta.",
            "Las proteínas son esenciales para la regeneración __________.",
            "El almacenamiento vertical optimiza el __________ del almacén.",
            "La trazabilidad permite rastrear el __________ de la donación.",
            "La desnutrición afecta gravemente el desarrollo __________.",
            "Los micronutrientes incluyen __________ y minerales básicos.",
            "El etiquetado debe ser claro sobre los posibles __________.",
            "La inseguridad __________ ocurre cuando falta comida nutritiva.",
            "El compostaje es una alternativa para residuos __________."
        };
        string[] respuestasDificil = new string[] { "agrícola", "prevención", "celular", "espacio", "origen", "cognitivo", "vitaminas", "alérgenos", "alimentaria", "orgánicos" };

        bool respuestaCorrecta = false;

        public Form5()
        {
            InitializeComponent();
            RedondearFormulario(25);
            label2.BackColor = System.Drawing.Color.Transparent;
        }

        void CargarOracion()
        {
            if (oracionesJuego == null || indice >= oracionesJuego.Length) return;

            string oracion = oracionesJuego[indice];
            lblOracion.Text = oracion;
            lblOracion.AutoSize = true;
            lblOracion.MaximumSize = new Size(600, 0);
            fallosConsecutivos = 0;

            int posicion = oracion.IndexOf("__________");
            if (posicion != -1)
            {
                string textoAntes = oracion.Substring(0, posicion);
                Size tamañoTexto = TextRenderer.MeasureText(textoAntes, lblOracion.Font);
                txtRespuesta.Location = new Point(lblOracion.Left + tamañoTexto.Width - 10, lblOracion.Top + 1);
            }

            txtRespuesta.Width = 85;
            txtRespuesta.Enabled = true;
            txtRespuesta.Text = "";
            txtRespuesta.Focus();

            btnVerificar.Enabled = true;
            btnSiguiente.Enabled = false;
            lblResultado.Visible = false;
            respuestaCorrecta = false;
        }

        private void btnVerificar_Click_1(object sender, EventArgs e)
        {
            if (respuestaCorrecta) return;

            string respuestaUsuario = txtRespuesta.Text.Trim().ToLower();

            // Obtenemos la respuesta correcta actual del arreglo que se esté usando en ese momento
            string correcta = respuestasJuego[indice].ToLower();

            if (respuestaUsuario == correcta)
            {
                lblResultado.ForeColor = Color.Green;
                lblResultado.Text = "✔ ¡Correcto!";
                lblResultado.Visible = true;
                puntaje += puntosPorRespuesta;
                lblPuntaje.Text = "Puntaje: " + puntaje;
                respuestaCorrecta = true;
                btnSiguiente.Enabled = true;
                btnVerificar.Enabled = false;
                txtRespuesta.Enabled = false;
            }
            else
            {
                fallosConsecutivos++;
                lblResultado.ForeColor = Color.Red;

                // --- SISTEMA DE PISTAS SEGÚN EL NIVEL ---
                if (fallosConsecutivos >= 2)
                {
                    // Muestra la primera letra y la cantidad de letras de la respuesta del nivel actual
                    string inicial = correcta.Substring(0, 1).ToUpper();
                    int longitud = correcta.Length;

                    lblResultado.Text = string.Format("✘ Pista: Empieza con {0}... ({1} letras)", inicial, longitud);
                }
                else
                {
                    lblResultado.Text = "✘ Inténtalo de nuevo";
                }
                lblResultado.Visible = true;
            }
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            if (!respuestaCorrecta) return;
            if (indice == oracionesJuego.Length - 1)
            {
                timer1.Stop();
                MessageBox.Show("¡Felicidades! Nivel completado.");
                if (tiempoMaximo == 120) nivelFacilCompletado = true;
                if (tiempoMaximo == 60 && oracionesJuego == oracionesMedio) nivelMedioCompletado = true;
                ReiniciarJuego();
                panel4.Visible = false;
                panel3.Visible = true;
                return;
            }
            indice++;
            CargarOracion();
        }
        void ActualizarPistasVisuales(string nivel)
        {
            // Usamos el nombre lblListaPistas en todo el método
            if (nivel == "Facil")
            {
                // Mezcla nueva para Nivel Fácil
                lblListaPistas.Text = "vulnerabilidad\n" + "distribuye\n" + "estado\n" + "salud\n" + "categoría\n" + "refrigeración\n" + "desperdicio\n" + "seguridad\n" + "familias\n" + "contaminación";
            }
            else if (nivel == "Medio")
            {
                // Mezcla nueva para Nivel Medio
                lblListaPistas.Text = "seco\n" + "voluntariado\n" + "vencimiento\n" + "frío\n" + "comunitaria\n" + "azúcar\n" + "anemia\n" + "distribución\n" + "perecederos\n" + "solidaridad";
            }
            else if (nivel == "Dificil")
            {
                // Mezcla nueva para Nivel Difícil
                lblListaPistas.Text = "vitaminas\n" + "alérgenos\n" + "agrícola\n" + "espacio\n" + "alimentaria\n" + "origen\n" + "cognitivo\n" + "prevención\n" + "orgánicos\n" + "celular";
            }

            lblListaPistas.Visible = true;
            lblListaPistas.BringToFront();
        }
        private void pictureBox3_Click(object sender, EventArgs e) { ReiniciarJuego(); panel4.Visible = false; panel3.Visible = true; }
        private void pictureBox6_Click(object sender, EventArgs e) // NIVEL FÁCIL
        {
            ReiniciarJuego();
            tiempoMaximo = 120;
            oracionesJuego = oraciones;
            respuestasJuego = respuestas;
            puntosPorRespuesta = 10;

            ActualizarPistasVisuales("Facil"); // <--- Cambia las pistas a las de Fácil

            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e) // NIVEL MEDIO
        {
            if (!nivelFacilCompletado) { MessageBox.Show("Debes completar el Nivel Fácil primero."); return; }
            ReiniciarJuego();
            tiempoMaximo = 60;
            oracionesJuego = oracionesMedio;
            respuestasJuego = respuestasMedio;
            puntosPorRespuesta = 10;

            ActualizarPistasVisuales("Medio"); // <--- Cambia las pistas a las de Medio

            panel3.Visible = false;
            panel4.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e) // NIVEL DIFÍCIL
        {
            if (!nivelMedioCompletado) { MessageBox.Show("Debes completar el Nivel Medio primero."); return; }
            ReiniciarJuego();
            tiempoMaximo = 60;
            oracionesJuego = oracionesDificil;
            respuestasJuego = respuestasDificil;
            puntosPorRespuesta = 5;

            ActualizarPistasVisuales("Dificil"); // <--- Cambia las pistas a las de Difícil

            panel3.Visible = false;
            panel4.Visible = true;
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (tiempoTotal > 0) { tiempoTotal--; MostrarTiempo(); }
            else { timer1.Stop(); MessageBox.Show("Tiempo agotado."); ReiniciarJuego(); panel4.Visible = false; panel3.Visible = true; }
        }

        private void btnComenzar_Click(object sender, EventArgs e) 
        { 
            panel5.Visible = false; IniciarJuego(); CargarOracion(); 
        }
        private void pictureBox9_Click(object sender, EventArgs e) 
        {
            DialogResult resultado = MessageBox.Show("¿Deseas cerrar la aplicación?", "Cerrar Aplicación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas cerrar la aplicación?", "Cerrar Aplicación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cuidado1 cui1 = new Cuidado1();
            cui1.Show();
            this.Hide();
        }
    }
}