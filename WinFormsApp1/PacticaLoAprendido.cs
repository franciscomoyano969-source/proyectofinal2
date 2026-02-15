using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class PacticaLoAprendido : Form
    {
        /// Matriz de 15 filas (0-14) y 12 columnas (0-11)
        private const int filas = 15;
        private const int columnas = 12;
        private TextBox[,] matrizCells = new TextBox[filas, columnas];

        private void RedondearFormulario(int radio)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radio * 2;

            // Crear los arcos para las 4 esquinas
            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(this.Width - d, 0, d, d, 270, 90);
            path.AddArc(this.Width - d, this.Height - d, d, d, 0, 90);
            path.AddArc(0, this.Height - d, d, d, 90, 90);

            path.CloseFigure();

            // Aplicar la región redondeada al formulario
            this.Region = new Region(path);
        }
        private void RedondearControl(Control control, int radio)
        {
            GraphicsPath ruta = new GraphicsPath();
            // Creamos un rectángulo con las dimensiones del control
            ruta.AddArc(0, 0, radio, radio, 180, 90);
            ruta.AddArc(control.Width - radio, 0, radio, radio, 270, 90);
            ruta.AddArc(control.Width - radio, control.Height - radio, radio, radio, 0, 90);
            ruta.AddArc(0, control.Height - radio, radio, radio, 90, 90);
            ruta.CloseAllFigures();

            control.Region = new Region(ruta);
        }
        public PacticaLoAprendido()
        {
            InitializeComponent();
            GenerarTablero();
            CargarPistas();
            // Llamada al método con un radio de 25 píxeles
            RedondearFormulario(25);
            RedondearControl(listHorizontales, 25);
            RedondearControl(listVerticales, 25);
            listHorizontales.Font = new Font("Segoe Print", 9, FontStyle.Regular);
            listVerticales.Font = new Font("Segoe Print", 9, FontStyle.Regular);
        }

        private void GenerarTablero()
        {
            panelCrucigrama.Controls.Clear();
            int tamañoCelda = 30;

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    TextBox txt = new TextBox();
                    txt.Size = new Size(tamañoCelda, tamañoCelda);
                    txt.Location = new Point(c * tamañoCelda, f * tamañoCelda);
                    txt.TextAlign = HorizontalAlignment.Center;
                    txt.MaxLength = 1;
                    txt.CharacterCasing = CharacterCasing.Upper;
                    txt.Font = new Font("segoe print", 11, FontStyle.Bold);

                    // Fondo negro para celdas inactivas
                    txt.ReadOnly = true;
                    txt.Enabled = false;
                    txt.BackColor = Color.Black;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.TabStop = false;

                    matrizCells[f, c] = txt;
                    panelCrucigrama.Controls.Add(txt);
                }
            }
            ConfigurarPalabras();
        }

        // Se agrega 'string numeroPista = ""' para que el método acepte 4 argumentos
        private void HabilitarCelda(int f, int c, char letraCorrecta, string numeroPista = "")
        {
            // Seguro de rango para evitar cierres inesperados (15 filas, 12 columnas)
            if (f >= 0 && f < filas && c >= 0 && c < columnas)
            {
                TextBox txt = matrizCells[f, c];
                txt.ReadOnly = false;
                txt.Enabled = true;
                txt.BackColor = Color.White;
                txt.ForeColor = Color.Black;
                txt.Tag = letraCorrecta;
                txt.TabStop = true;

                // Si se proporciona un número, creamos un Label pequeño dentro del TextBox
                if (!string.IsNullOrEmpty(numeroPista))
                {
                    Label lblNumero = new Label();
                    lblNumero.Text = numeroPista;
                    lblNumero.Font = new Font("segoe print", 6); // Tamaño pequeño para que no estorbe
                    lblNumero.ForeColor = Color.Black;
                    lblNumero.BackColor = Color.Transparent;
                    lblNumero.Location = new Point(1, 1); // Posición en la esquina superior izquierda
                    lblNumero.AutoSize = true;

                    txt.Controls.Add(lblNumero); // Se agrega el label al control del TextBox
                }
            }
        }
        private void ConfigurarPalabras()
        {
            // 1 VERTICAL: UNIDAD (Número 1 en la 'U')
            HabilitarCelda(0, 9, 'U', "1");
            HabilitarPalabra("NIDAD", 1, 9, true);

            // 2 HORIZONTAL: COMEDOR (Número 2 en la 'C')
            HabilitarCelda(5, 5, 'C', "2");
            HabilitarPalabra("OMEDOR", 5, 6, false);

            // 2 VERTICAL: CANTIDAD (Comparte la 'C' del 2 horizontal)
            HabilitarPalabra("ANTIDAD", 6, 5, true);

            // 3 HORIZONTAL: LENTEJAS (Número 3 en la 'L')
            HabilitarCelda(7, 3, 'L', "3");
            HabilitarPalabra("ENTEJAS", 7, 4, false);

            // 4 VERTICAL: NARANJA (Número 4 en la 'N')
            HabilitarCelda(8, 2, 'N', "4");
            HabilitarPalabra("ARANJA", 9, 2, true);

            // 5 HORIZONTAL: INGRESO (Número 5 en la 'I')
            HabilitarCelda(9, 5, 'I', "5");
            HabilitarPalabra("NGRESO", 9, 6, false);

            // 6 HORIZONTAL: MANZANAS (Número 6 en la 'M')
            HabilitarCelda(11, 0, 'M', "6");
            HabilitarPalabra("ANZANAS", 11, 1, false);

            // 7 HORIZONTAL: LACTEO (Número 7 en la 'L')
            // Usamos la fila 14 para no salir del rango
            HabilitarCelda(14, 0, 'L', "7");
            HabilitarPalabra("ACTEO", 14, 1, false);

        }
        private void HabilitarPalabra(string palabra, int fInicio, int cInicio, bool esVertical)
        {
            for (int i = 0; i < palabra.Length; i++)
            {
                if (esVertical) HabilitarCelda(fInicio + i, cInicio, palabra[i]);
                else HabilitarCelda(fInicio, cInicio + i, palabra[i]);
            }
        }
        private void CargarPistas()
        {
            // 1. Limpia los elementos actuales para evitar que se dupliquen al reiniciar
            listHorizontales.Items.Clear();
            listVerticales.Items.Clear();

            // 2. Agregar pistas Horizontales reducidas
            listHorizontales.Items.Add(" ");
            listHorizontales.Items.Add("2. Lugar de entrega de raciones.");
            listHorizontales.Items.Add("3. Legumbre con hierro (catálogo).");
            listHorizontales.Items.Add("5. Registro de materia prima.");
            listHorizontales.Items.Add("6. Fruta fresca en historial.");
            listHorizontales.Items.Add("7. Categoría de la leche.");

            // 3. Agregar pistas Verticales reducidas
            listVerticales.Items.Add(" ");
            listVerticales.Items.Add("1. Medida para contar paquetes.");
            listVerticales.Items.Add("2. Valor total a distribuir.");
            listVerticales.Items.Add("4. Cítrico para hacer jugos.");
            listVerticales.Items.Add("1. Medida para contar paquetes.");
        }
        private void PacticaLoAprendido_Load(object sender, EventArgs e)
        {

        }

        private void panelCrucigrama_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listVerticales_Enter(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click_1(object sender, EventArgs e)
        {
            foreach (var txt in matrizCells)
            {
                if (txt.Enabled && !string.IsNullOrWhiteSpace(txt.Text))
                {
                    if (txt.Text.ToUpper() == txt.Tag.ToString().ToUpper())
                        txt.BackColor = Color.LightGreen;
                    else
                        txt.BackColor = Color.LightCoral;
                }
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            foreach (var txt in matrizCells)
            {
                if (txt.Enabled)
                {
                    txt.Clear();
                    txt.BackColor = Color.White;
                }
            }
        }

        private void listHorizontales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ptbRegresar_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
            this.Hide();
        }


        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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