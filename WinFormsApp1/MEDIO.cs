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

namespace ParteInteractivaPY
{
    public partial class MEDIO : Form
    {
        // VARIABLES GLOBALES
        int intentos = 0;
        int segundos = 120; // TIEMPO CONFIGURADO A 2 MINUTOS
        System.Windows.Forms.Timer timerReloj;
        Label lblCronometro;

        string pDONACION = "DONACION";
        string pBENDICHO = "BENEFICIO";
        string pALMACEN = "ALMACEN";
        string pINVENTARIO = "INVENTARIO";
        string pSOLIDARIO = "SOLIDARIO";
        string pRACIONES = "RACIONES";
        string pDESPENSA = "DESPENSA";
        string pDISTRIBUIR = "DISTRIBUIR";

        public MEDIO()
        {
            InitializeComponent();
            InicializarCronometroDinamico();
            ConfigurarTodosLosTextBox(this.Controls);
            RedondearFormulario(25);
            // Configuración de pistas con números pequeños
            ConfigurarCasilla(textBox1, "1");  // DONACION
            ConfigurarCasilla(textBox9, "2");  // BENEFICIO
            ConfigurarCasilla(textBox13, "3"); // INVENTARIO
            ConfigurarCasilla(textBox24, "4"); // DESPENSA
            ConfigurarCasilla(textBox41, "5"); // SOLIDARIO
            ConfigurarCasilla(textBox17, "6"); // RACIONES
            ConfigurarCasilla(textBox18, "7"); // ALMACEN
            ConfigurarCasilla(textBox45, "8"); // DESPENSA (Horizontal)
            ConfigurarCasilla(textBox32, "9"); // DISTRIBUIR

            // Matar el proceso al cerrar la ventana
            this.FormClosing += (s, e) =>
            {
                if (timerReloj != null)
                {
                    timerReloj.Stop();
                    timerReloj.Dispose();
                }
            };
        }
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
        private void InicializarCronometroDinamico()
        {
            lblCronometro = new Label();
            lblCronometro.Text = "Tiempo: 120s";
            lblCronometro.Location = new Point(15, this.ClientSize.Height - 45);
            lblCronometro.AutoSize = true;
            lblCronometro.Font = new Font("Arial", 14, FontStyle.Bold);
            lblCronometro.ForeColor = Color.Red;
            lblCronometro.BackColor = Color.Transparent;
            lblCronometro.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.Controls.Add(lblCronometro);
            lblCronometro.BringToFront();

            timerReloj = new System.Windows.Forms.Timer();
            timerReloj.Interval = 1000;
            timerReloj.Tick += (s, e) =>
            {
                segundos--;
                lblCronometro.Text = "Tiempo: " + segundos + "s";

                if (segundos <= 0)
                {
                    timerReloj.Stop();
                    MessageBox.Show("¡Tiempo agotado! El nivel medio requiere rapidez.", "Fin del tiempo");
                    btnLimpiar_Click(null, null);
                }
            };
            timerReloj.Start();
        }

        private void ConfigurarCasilla(TextBox txt, string numeroPista)
        {
            txt.MaxLength = 1;
            txt.CharacterCasing = CharacterCasing.Upper;
            txt.TextAlign = HorizontalAlignment.Center;
            txt.KeyPress += SoloUnaLetra;

            if (!string.IsNullOrEmpty(numeroPista))
            {
                Label lblNumero = new Label();
                lblNumero.Text = numeroPista;
                lblNumero.Font = new Font("Arial", 5); // TAMAÑO 5
                lblNumero.ForeColor = Color.DimGray;
                lblNumero.BackColor = Color.Transparent;
                lblNumero.Location = new Point(0, 0);
                lblNumero.AutoSize = true;
                txt.Controls.Add(lblNumero);
            }
        }

        private void ConfigurarTodosLosTextBox(Control.ControlCollection controles)
        {
            foreach (Control c in controles)
            {
                if (c is TextBox tb)
                {
                    tb.MaxLength = 1;
                    tb.CharacterCasing = CharacterCasing.Upper;
                    tb.TextAlign = HorizontalAlignment.Center;
                    tb.KeyPress += SoloUnaLetra;
                }
                if (c.HasChildren) ConfigurarTodosLosTextBox(c.Controls);
            }
        }

        private void SoloUnaLetra(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        // Lógica de validación individual para que los cruces no den error visual
        private void ValidarLetrasCorrectas(string palabra, params TextBox[] cajas)
        {
            for (int i = 0; i < cajas.Length; i++)
            {
                if (cajas[i].Text.ToUpper() == palabra[i].ToString())
                    cajas[i].BackColor = Color.LightGreen;
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls) if (c is TextBox) c.BackColor = Color.White;
            foreach (Control c in this.Controls) if (c is TextBox tb && !string.IsNullOrWhiteSpace(tb.Text)) tb.BackColor = Color.LightCoral;

            // El verde manda sobre el rojo en los cruces
            ValidarLetrasCorrectas(pDONACION, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8);
            ValidarLetrasCorrectas(pBENDICHO, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15, textBox16);
            ValidarLetrasCorrectas(pALMACEN, textBox18, textBox56, textBox57, textBox58, textBox59, textBox60, textBox61);
            ValidarLetrasCorrectas(pINVENTARIO, textBox13, textBox24, textBox25, textBox26, textBox27, textBox28, textBox29, textBox30, textBox31, textBox32);
            ValidarLetrasCorrectas(pSOLIDARIO, textBox41, textBox42, textBox43, textBox44, textBox45, textBox46, textBox47, textBox48, textBox49);
            ValidarLetrasCorrectas(pRACIONES, textBox17, textBox18, textBox19, textBox20, textBox21, textBox22, textBox23, textBox24);
            ValidarLetrasCorrectas(pDESPENSA, textBox45, textBox49, textBox50, textBox51, textBox52, textBox53, textBox54, textBox55);
            ValidarLetrasCorrectas(pDISTRIBUIR, textBox32, textBox30, textBox33, textBox34, textBox35, textBox36, textBox37, textBox38, textBox39, textBox40);

            intentos++;
            if (intentos >= 5)
            {
                timerReloj.Stop();
                MessageBox.Show("Se muestran las respuestas automáticas.");
                AutoCompletarTodo();
            }
        }

        private void AutoCompletarTodo()
        {
            AutoCompletarDONACION(); AutoCompletarBENEFICIO(); AutoCompletarALMACEN();
            AutoCompletarINVENTARIO(); AutoCompletarSOLIDARIO(); AutoCompletarRACIONES();
            AutoCompletarDESPENSA(); AutoCompletarDISTRIBUIR();
        }

        // Métodos AutoCompletar (Lógica original)
        private void AutoCompletarDONACION() { textBox1.Text = "D"; textBox2.Text = "O"; textBox3.Text = "N"; textBox4.Text = "A"; textBox5.Text = "C"; textBox6.Text = "I"; textBox7.Text = "O"; textBox8.Text = "N"; }
        private void AutoCompletarBENEFICIO() { textBox9.Text = "B"; textBox10.Text = "E"; textBox3.Text = "N"; textBox11.Text = "E"; textBox12.Text = "F"; textBox13.Text = "I"; textBox14.Text = "C"; textBox15.Text = "I"; textBox16.Text = "O"; }
        private void AutoCompletarALMACEN() { textBox18.Text = "A"; textBox56.Text = "L"; textBox57.Text = "M"; textBox58.Text = "A"; textBox59.Text = "C"; textBox60.Text = "E"; textBox61.Text = "N"; }
        private void AutoCompletarINVENTARIO() { textBox13.Text = "I"; textBox24.Text = "N"; textBox25.Text = "V"; textBox22.Text = "E"; textBox26.Text = "N"; textBox27.Text = "T"; textBox28.Text = "A"; textBox29.Text = "R"; textBox30.Text = "I"; textBox31.Text = "O"; }
        private void AutoCompletarSOLIDARIO() { textBox41.Text = "S"; textBox42.Text = "O"; textBox43.Text = "L"; textBox44.Text = "I"; textBox45.Text = "D"; textBox46.Text = "A"; textBox35.Text = "R"; textBox47.Text = "I"; textBox48.Text = "O"; }
        private void AutoCompletarRACIONES() { textBox17.Text = "R"; textBox18.Text = "A"; textBox19.Text = "C"; textBox6.Text = "I"; textBox20.Text = "O"; textBox21.Text = "N"; textBox22.Text = "E"; textBox23.Text = "S"; }
        private void AutoCompletarDESPENSA() { textBox45.Text = "D"; textBox49.Text = "E"; textBox50.Text = "S"; textBox51.Text = "P"; textBox52.Text = "E"; textBox53.Text = "N"; textBox54.Text = "S"; textBox55.Text = "A"; }
        private void AutoCompletarDISTRIBUIR() { textBox32.Text = "D"; textBox30.Text = "I"; textBox33.Text = "S"; textBox34.Text = "T"; textBox35.Text = "R"; textBox36.Text = "I"; textBox37.Text = "B"; textBox38.Text = "U"; textBox39.Text = "I"; textBox40.Text = "R"; }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            intentos = 0;
            segundos = 120;
            if (lblCronometro != null) lblCronometro.Text = "Tiempo: 120s";
            timerReloj.Start();
            LimpiarTextBoxes(this.Controls);
        }

        private void LimpiarTextBoxes(Control.ControlCollection controles)
        {
            foreach (Control c in controles)
            {
                if (c is TextBox tb) { tb.Text = ""; tb.BackColor = Color.White; }
                else if (c.HasChildren) LimpiarTextBoxes(c.Controls);
            }
        }

        private void MEDIO_Load(object sender, EventArgs e)
        {
            Font fSegoe = new Font("Segoe Print", 9, FontStyle.Bold);
            listHorizontales.Font = fSegoe;
            listVerticales.Font = fSegoe;

            listHorizontales.Items.Clear();
            listVerticales.Items.Clear();

            listHorizontales.Items.Add("HORIZONTAL");
            listHorizontales.Items.Add("2: Ayuda que recibe una persona.");
            listHorizontales.Items.Add("6: Porciones de comida para repartir.");
            listHorizontales.Items.Add("8: Espacio donde se guardan alimentos.");
            listHorizontales.Items.Add("9: Acción de entregar los alimentos.");

            listVerticales.Items.Add("VERTICAL");
            listVerticales.Items.Add("1: Aporte voluntario para ayudar a otros.");
            listVerticales.Items.Add("3: Registro de productos disponibles.");
            listVerticales.Items.Add("4: Conjunto de productos básicos.");
            listVerticales.Items.Add("5: Persona que apoya en momentos difíciles.");
            listVerticales.Items.Add("7: Lugar donde se guardan los alimentos.");
        }

        private void ptbRegreso_Click(object sender, EventArgs e)
        {
            if (timerReloj != null) timerReloj.Stop();
            CRUCIGRAMA c = new CRUCIGRAMA();
            c.Show();
            this.Hide();
        }

        // Eventos vacíos para compatibilidad
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void listHorizontales_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listVerticales_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox9_TextChanged(object sender, EventArgs e) { }

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