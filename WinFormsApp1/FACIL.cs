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
    public partial class FACIL : Form
    {
        // VARIABLES GLOBALES
        int intentos = 0;
        int segundos = 30;
        System.Windows.Forms.Timer timerReloj;
        Label lblCronometro;

        string pMango = "MANGO";
        string pArroz = "ARROZ";
        string pPan = "PAN";
        string pPera = "PERA";
        string pLeche = "LECHE";
        string pUva = "UVA";

        public FACIL()
        {
            InitializeComponent();
            InicializarCronometroDinamico();
            RedondearFormulario(25);
            ConfigurarTodosLosTextBox(this.Controls);
            ConfigurarCasilla(textBox1, "1");
            ConfigurarCasilla(textBox2, "2");
            ConfigurarCasilla(textBox10, "3");
            ConfigurarCasilla(textBox15, "4");
            ConfigurarCasilla(textBox19, "5");

            this.FormClosing += (s, e) =>
            {
                if (timerReloj != null) { timerReloj.Stop(); timerReloj.Dispose(); }
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
            lblCronometro.Text = "Tiempo: 30s";
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
                    MessageBox.Show("¡Tiempo agotado! Reiniciando...");
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
                Label lbl = new Label
                {
                    Text = numeroPista,
                    Font = new Font("Arial", 5),
                    Location = new Point(1, 1),
                    AutoSize = true,
                    BackColor = Color.Transparent,
                    ForeColor = Color.Gray
                };
                txt.Controls.Add(lbl);
            }
        }

        private void SoloUnaLetra(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
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

        // MÉTODOS DE AUTOCOMPLETAR
        private void AutoCompletarMANGO() { textBox1.Text = "M"; textBox2.Text = "A"; textBox3.Text = "N"; textBox4.Text = "G"; textBox5.Text = "O"; }
        private void AutoCompletarARROZ() { textBox2.Text = "A"; textBox6.Text = "R"; textBox7.Text = "R"; textBox8.Text = "O"; textBox9.Text = "Z"; }
        private void AutoCompletarPAN() { textBox10.Text = "P"; textBox11.Text = "A"; textBox13.Text = "N"; }
        private void AutoCompletarPERA() { textBox10.Text = "P"; textBox12.Text = "E"; textBox13.Text = "R"; textBox14.Text = "A"; }
        private void AutoCompletarLECHE() { textBox15.Text = "L"; textBox16.Text = "E"; textBox17.Text = "C"; textBox18.Text = "H"; textBox12.Text = "E"; }
        private void AutoCompletarUVA() { textBox19.Text = "U"; textBox20.Text = "V"; textBox14.Text = "A"; }

        private void VerificarLetraIndividual(string palabra, params TextBox[] cajas)
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

            VerificarLetraIndividual(pMango, textBox1, textBox2, textBox3, textBox4, textBox5);
            VerificarLetraIndividual(pArroz, textBox2, textBox6, textBox7, textBox8, textBox9);
            VerificarLetraIndividual(pPan, textBox10, textBox11, textBox13);
            VerificarLetraIndividual(pPera, textBox10, textBox12, textBox13, textBox14);
            VerificarLetraIndividual(pLeche, textBox15, textBox16, textBox17, textBox18, textBox12);
            VerificarLetraIndividual(pUva, textBox19, textBox20, textBox14);

            // Verificación lógica de victoria
            int correctas = 0;
            if ((textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text) == pMango) correctas++;
            if ((textBox2.Text + textBox6.Text + textBox7.Text + textBox8.Text + textBox9.Text) == pArroz) correctas++;
            if ((textBox10.Text + textBox11.Text + textBox13.Text) == pPan) correctas++;
            if ((textBox10.Text + textBox12.Text + textBox13.Text + textBox14.Text) == pPera) correctas++;
            if ((textBox15.Text + textBox16.Text + textBox17.Text + textBox18.Text + textBox12.Text) == pLeche) correctas++;
            if ((textBox19.Text + textBox20.Text + textBox14.Text) == pUva) correctas++;

            if (correctas >= 5)
            {
                timerReloj.Stop();
                // --- LÓGICA DE DESBLOQUEO ---
                if (CRUCIGRAMA.NivelDesbloqueado < 2) CRUCIGRAMA.NivelDesbloqueado = 2;
                // ----------------------------
                MessageBox.Show("¡Victoria! Nivel MEDIO desbloqueado.", "¡Felicidades!");
                pictureBox1_Click(null, null);
            }
            else
            {
                intentos++;
                if (intentos >= 5)
                {
                    MessageBox.Show("Se muestran las respuestas.");
                    AutoCompletarMANGO();
                    AutoCompletarARROZ();
                    AutoCompletarPAN();
                    AutoCompletarPERA();
                    AutoCompletarLECHE();
                    AutoCompletarUVA();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            segundos = 30;
            intentos = 0;
            timerReloj.Start();
            LimpiarTodo(this.Controls);
        }

        private void LimpiarTodo(Control.ControlCollection controles)
        {
            foreach (Control c in controles)
            {
                if (c is TextBox tb) { tb.Text = ""; tb.BackColor = Color.White; }
                if (c.HasChildren) LimpiarTodo(c.Controls);
            }
        }

        private void FACIL_Load(object sender, EventArgs e)
        {
            Font fuenteSegoe = new Font("Segoe Print", 9, FontStyle.Bold);
            listHorizontales.Font = fuenteSegoe;
            listVerticales.Font = fuenteSegoe;

            listHorizontales.Items.Clear();
            listVerticales.Items.Clear();

            listHorizontales.Items.Add("HORIZONTAL");
            listHorizontales.Items.Add("2: Grano blanco que se cocina con agua.");
            listHorizontales.Items.Add("3: Alimento hecho con harina y horneado.");
            listHorizontales.Items.Add("4: Bebida blanca rica en calcio.");
            listHorizontales.Items.Add("5: Fruta pequeña que crece en racimos.");

            listVerticales.Items.Add("VERTICAL");
            listVerticales.Items.Add("1: Fruta tropical amarilla o anaranjada.");
            listVerticales.Items.Add("3: Fruta verde o amarilla con forma alargada.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (timerReloj != null) timerReloj.Stop();
            CRUCIGRAMA c = new CRUCIGRAMA();
            c.Show();
            this.Hide();
        }

        // Eventos vacíos para no romper el diseñador
        private void listHorizontales_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listVerticales_SelectedIndexChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

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