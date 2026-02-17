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
    public partial class DIFICIL : Form
    {
        // VARIABLES GLOBALES
        int intentos = 0;
        int segundos = 180; // TIEMPO CONFIGURADO A 3 MINUTOS
        System.Windows.Forms.Timer timerReloj;
        Label lblCronometro;

        // Palabras del crucigrama
        string pBANANA = "BANANA";
        string pSANDIA = "SANDIA";
        string pPINA = "PIÑA";
        string pPAPAYA = "PAPAYA";
        string pCANASTA = "CANASTA";
        string pBROCOLI = "BROCOLI";
        string pRACIONES = "RACIONES";
        string pMANZANA = "MANZANA";
        string pDURAZNO = "DURAZNO";
        string pTOMATE = "TOMATE";
        string pCEBOLLA = "CEBOLLA";
        string pALMACEN = "ALMACEN";
        string pDONACION = "DONACION";
        string pNARANJA = "NARANJA";
        string pLECHUGA = "LECHUGA";

        public DIFICIL()
        {
            InitializeComponent();
            InicializarCronometroDinamico();
            ConfigurarTodosLosTextBox(this.Controls);
            RedondearFormulario(25);
            // Horizontales
            ConfigurarCasilla(textBox25, "3"); // PAPAYA / PIÑA
            ConfigurarCasilla(textBox7, "6");  // CANASTA
            ConfigurarCasilla(textBox44, "10"); // DONACION
            ConfigurarCasilla(textBox40, "12"); // ALMACEN
            ConfigurarCasilla(textBox69, "13"); // NARANJA
            ConfigurarCasilla(textBox57, "14"); // LECHUGA

            // Verticales
            ConfigurarCasilla(textBox1, "1");   // BANANA
            ConfigurarCasilla(textBox13, "2");  // SANDIA
            ConfigurarCasilla(textBox18, "4");  // RACIONES
            ConfigurarCasilla(textBox33, "5");  // BROCOLI
            ConfigurarCasilla(textBox63, "7");  // MANZANA
            ConfigurarCasilla(textBox75, "8");  // DURAZNO
            ConfigurarCasilla(textBox81, "9");  // TOMATE
            ConfigurarCasilla(textBox47, "11"); // CEBOLLA

            // Seguridad para cerrar el proceso
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
            lblCronometro.Text = "Tiempo: 180s";
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
                    MessageBox.Show("¡Tiempo agotado en el nivel Difícil!", "Fin del tiempo");
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
                lblNumero.Font = new Font("Arial", 5, FontStyle.Regular); // TAMAÑO 5
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

        // Lógica de validación individual para cruces
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
            // Resetear colores
            foreach (Control c in this.Controls)
                if (c is TextBox) c.BackColor = Color.White;

            // Marcar errores base (Rojo) si hay texto
            foreach (Control c in this.Controls)
                if (c is TextBox tb && !string.IsNullOrWhiteSpace(tb.Text)) tb.BackColor = Color.LightCoral;

            // Validar cada palabra (El verde sobreescribe al rojo si es correcto)
            ValidarLetrasCorrectas(pBANANA, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6);
            ValidarLetrasCorrectas(pSANDIA, textBox13, textBox14, textBox15, textBox16, textBox17, textBox12);
            ValidarLetrasCorrectas(pPINA, textBox25, textBox30, textBox31, textBox32);
            ValidarLetrasCorrectas(pPAPAYA, textBox25, textBox26, textBox27, textBox28, textBox29, textBox2);
            ValidarLetrasCorrectas(pCANASTA, textBox7, textBox8, textBox9, textBox6, textBox10, textBox11, textBox12);
            ValidarLetrasCorrectas(pBROCOLI, textBox33, textBox34, textBox35, textBox36, textBox37, textBox38, textBox39);
            ValidarLetrasCorrectas(pRACIONES, textBox18, textBox8, textBox19, textBox20, textBox21, textBox22, textBox23, textBox24);
            ValidarLetrasCorrectas(pMANZANA, textBox63, textBox64, textBox50, textBox65, textBox66, textBox67, textBox68);
            ValidarLetrasCorrectas(pDURAZNO, textBox75, textBox76, textBox77, textBox71, textBox78, textBox79, textBox80);
            ValidarLetrasCorrectas(pTOMATE, textBox81, textBox82, textBox83, textBox74, textBox84, textBox85);
            ValidarLetrasCorrectas(pCEBOLLA, textBox47, textBox51, textBox52, textBox53, textBox54, textBox55, textBox56);
            ValidarLetrasCorrectas(pALMACEN, textBox40, textBox38, textBox41, textBox42, textBox43, textBox23, textBox86);
            ValidarLetrasCorrectas(pDONACION, textBox44, textBox21, textBox45, textBox46, textBox47, textBox48, textBox49, textBox50);
            ValidarLetrasCorrectas(pNARANJA, textBox69, textBox66, textBox70, textBox71, textBox72, textBox73, textBox74);
            ValidarLetrasCorrectas(pLECHUGA, textBox57, textBox58, textBox59, textBox60, textBox61, textBox62, textBox56);

            intentos++;
            if (intentos >= 5)
            {
                timerReloj.Stop();
                MessageBox.Show("Se muestran las respuestas.");
                AutoCompletarTodo();
            }
        }

        private void AutoCompletarTodo()
        {
            AutoCompletarBANANA(); AutoCompletarSANDIA(); AutoCompletarPINA();
            AutoCompletarPAPAYA(); AutoCompletarCANASTA(); AutoCompletarBROCOLI();
            AutoCompletarRACIONES(); AutoCompletarMANZANA(); AutoCompletarDURAZNO();
            AutoCompletarTOMATE(); AutoCompletarCEBOLLA(); AutoCompletarALMACEN();
            AutoCompletarDONACION(); AutoCompletarNARANJA(); AutoCompletarLECHUGA();
        }

        // Métodos AutoCompletar (Mantenidos igual)
        private void AutoCompletarBANANA() { textBox1.Text = "B"; textBox2.Text = "A"; textBox3.Text = "N"; textBox4.Text = "A"; textBox5.Text = "N"; textBox6.Text = "A"; }
        private void AutoCompletarSANDIA() { textBox13.Text = "S"; textBox14.Text = "A"; textBox15.Text = "N"; textBox16.Text = "D"; textBox17.Text = "I"; textBox12.Text = "A"; }
        private void AutoCompletarPINA() { textBox25.Text = "P"; textBox30.Text = "I"; textBox31.Text = "Ñ"; textBox32.Text = "A"; }
        private void AutoCompletarPAPAYA() { textBox25.Text = "P"; textBox26.Text = "A"; textBox27.Text = "P"; textBox28.Text = "A"; textBox29.Text = "Y"; textBox2.Text = "A"; }
        private void AutoCompletarCANASTA() { textBox7.Text = "C"; textBox8.Text = "A"; textBox9.Text = "N"; textBox6.Text = "A"; textBox10.Text = "S"; textBox11.Text = "T"; textBox12.Text = "A"; }
        private void AutoCompletarBROCOLI() { textBox33.Text = "B"; textBox34.Text = "R"; textBox35.Text = "O"; textBox36.Text = "C"; textBox37.Text = "O"; textBox38.Text = "L"; textBox39.Text = "I"; }
        private void AutoCompletarRACIONES() { textBox18.Text = "R"; textBox8.Text = "A"; textBox19.Text = "C"; textBox20.Text = "I"; textBox21.Text = "O"; textBox22.Text = "N"; textBox23.Text = "E"; textBox24.Text = "S"; }
        private void AutoCompletarMANZANA() { textBox63.Text = "M"; textBox64.Text = "A"; textBox50.Text = "N"; textBox65.Text = "Z"; textBox66.Text = "A"; textBox67.Text = "N"; textBox68.Text = "A"; }
        private void AutoCompletarDURAZNO() { textBox75.Text = "D"; textBox76.Text = "U"; textBox77.Text = "R"; textBox71.Text = "A"; textBox78.Text = "Z"; textBox79.Text = "N"; textBox80.Text = "O"; }
        private void AutoCompletarTOMATE() { textBox81.Text = "T"; textBox82.Text = "O"; textBox83.Text = "M"; textBox74.Text = "A"; textBox84.Text = "T"; textBox85.Text = "E"; }
        private void AutoCompletarCEBOLLA() { textBox47.Text = "C"; textBox51.Text = "E"; textBox52.Text = "B"; textBox53.Text = "O"; textBox54.Text = "L"; textBox55.Text = "L"; textBox56.Text = "A"; }
        private void AutoCompletarALMACEN() { textBox40.Text = "A"; textBox38.Text = "L"; textBox41.Text = "M"; textBox42.Text = "A"; textBox43.Text = "C"; textBox23.Text = "E"; textBox86.Text = "N"; }
        private void AutoCompletarDONACION() { textBox44.Text = "D"; textBox21.Text = "O"; textBox45.Text = "N"; textBox46.Text = "A"; textBox47.Text = "C"; textBox48.Text = "I"; textBox49.Text = "O"; textBox50.Text = "N"; }
        private void AutoCompletarNARANJA() { textBox69.Text = "N"; textBox66.Text = "A"; textBox70.Text = "R"; textBox71.Text = "A"; textBox72.Text = "N"; textBox73.Text = "J"; textBox74.Text = "A"; }
        private void AutoCompletarLECHUGA() { textBox57.Text = "L"; textBox58.Text = "E"; textBox59.Text = "C"; textBox60.Text = "H"; textBox61.Text = "U"; textBox62.Text = "G"; textBox56.Text = "A"; }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            intentos = 0;
            segundos = 180;
            if (lblCronometro != null) lblCronometro.Text = "Tiempo: 180s";
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

        private void DIFICIL_Load(object sender, EventArgs e)
        {
            Font fSegoe = new Font("Segoe Print", 9, FontStyle.Bold);
            listHorizontales.Font = fSegoe;
            listVerticales.Font = fSegoe;

            listHorizontales.Items.Clear();
            listVerticales.Items.Clear();

            listHorizontales.Items.Add("HORIZONTAL");
            listHorizontales.Items.Add("3: Fruta tropical anaranjada por");
            listHorizontales.Items.Add("dentro.");
            listHorizontales.Items.Add("6: Conjunto de alimentos entregados");
            listHorizontales.Items.Add("a familias.");
            listHorizontales.Items.Add("10: Aporte voluntario para ayudar.");
            listHorizontales.Items.Add("12: Lugar donde se guardan los");
            listHorizontales.Items.Add("productos.");
            listHorizontales.Items.Add("13: Fruta cítrica rica en vitamina C.");
            listHorizontales.Items.Add("14: Verdura verde usada en ensaladas.");

            listVerticales.Items.Add("VERTICAL");
            listVerticales.Items.Add("1: Fruta amarilla y alargada.");
            listVerticales.Items.Add("2: Fruta grande, verde por fuera y roja");
            listVerticales.Items.Add("por dentro.");
            listVerticales.Items.Add("3: Fruta tropical con corona y escamas.");
            listVerticales.Items.Add("4: Porciones de comida para repartir.");
            listVerticales.Items.Add("5: Verdura verde con forma de arbolito.");
            listVerticales.Items.Add("7: Fruta roja o verde muy común.");
            listVerticales.Items.Add("8: Fruta dulce con hueso en el centro.");
            listVerticales.Items.Add("9: Puede usarse en ensaladas o salsas.");
            listVerticales.Items.Add("11: Verdura que hace llorar al cortarla.");
        }

        private void ptbRegreso_Click(object sender, EventArgs e)
        {
            if (timerReloj != null) timerReloj.Stop();
            CRUCIGRAMA c = new CRUCIGRAMA();
            c.Show();
            this.Hide();
        }

        // Eventos vacíos para no romper el diseñador
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void listHorizontales_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listVerticales_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox10_TextChanged(object sender, EventArgs e) { }

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