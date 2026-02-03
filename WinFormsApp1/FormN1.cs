using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WindowsFormsApp5.NewFolder1;
using WinFormsApp1.Properties;
namespace WinFormsApp1
{
    public partial class FormN1 : Form
    {
        public FormN1()
        {
            InitializeComponent();
            RedondearFormulario(20);
            this.DoubleBuffered = true;
            Redondear_butom(GuiaButon, 40);
            Redondear_butom(DonacionButon, 40);
            Redondear_butom(button1, 40);
            Redondear_butom(button2, 40);
            Redondear_butom(button3, 40);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static void Redondear_butom(Button boton, int radius)
        {
            if (boton == null) return;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, radius, radius, 180, 90);
            gp.AddArc(boton.Width - radius, 0, radius, radius, 270, 90);
            gp.AddArc(boton.Width - radius, boton.Height - radius, radius, radius, 0, 90);
            gp.AddArc(0, boton.Height - radius, radius, radius, 90, 90);
            gp.CloseFigure();
            boton.Region = new Region(gp);
        }
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
        // Métodos de eventos existentes
        private void button1_Click_1(object sender, EventArgs e) => MostrarPasosRecepcion();
        private void button2_Click(object sender, EventArgs e) => MostrarPasosAlmacenamiento();
        private void button3_Click_1(object sender, EventArgs e) => MostrarPasosDistribucion();

        private void button4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            // Asegúrate que ucMapaMental esté en el namespace WinFormsApp1
            ucMapaMental mapa = new ucMapaMental();
            mapa.Dock = DockStyle.Fill;
            flowLayoutPanel1.Controls.Add(mapa);
        }

        private void MostrarPasosRecepcion()
        {
            flowLayoutPanel1.Controls.Clear();
            string[] pasos = { "Verificar la integridad del paquete recibido.", "Registrar la recepción en el sistema.", "Notificar al remitente sobre la recepción.", "Sanitizar empaques externos antes de su ingreso." };
            CargarPasos(pasos);
        }

        private void MostrarPasosAlmacenamiento()
        {
            flowLayoutPanel1.Controls.Clear();
            string[] pasos = { "Cotejar la cantidad recibida contra la nota de entraga.", "Actualizar el inventario fisico/digital del comedor.", "Comunicar la renovacion de insumos al equipo de cocina.", "Rotar el stock colocando lo nuevo detrás de lo antiguo." };
            CargarPasos(pasos);
        }

        private void MostrarPasosDistribucion()
        {
            flowLayoutPanel1.Controls.Clear();
            string[] pasos = { "Validar la identidad del beneficiario.", "Registrar entrega para el cierre de cuenta diario.", "Confirmar con el responsable el destino final.", "Trasladar el alimento al usuario final." };
            CargarPasos(pasos);
        }

        private void CargarPasos(string[] pasos)
        {
            for (int i = 0; i < pasos.Length; ++i)
            {
                ucPasoProtocolo pasoControl = new ucPasoProtocolo();
                pasoControl.configurarPaso((i + 1).ToString(), pasos[i]);
                pasoControl.Margin = new Padding(0, 0, 0, 10);
                flowLayoutPanel1.Controls.Add(pasoControl);
            }
        }

        private void GuiaButon_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ucTarjetaGuia tarjetaComida = new ucTarjetaGuia();

            // Usamos Resources de WinFormsApp1
            List<Image> fotosComida = new List<Image>()
            {
                Resources.HigSan2,
                Resources.ContSand,
                Resources.DonPermi,
                Resources.DonNoPermi
            };

            tarjetaComida.ConfigurarDiapositivas(fotosComida);
            flowLayoutPanel1.Controls.Add(tarjetaComida);
        }

        private void DonacionButon_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ucRegistroDonacion formRegistro = new ucRegistroDonacion();
            flowLayoutPanel1.Controls.Add(formRegistro);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menuprincipal menu = new Menuprincipal();
            menu.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            // Ocultar contenido anterior si es necesario
            flowLayoutPanel1.Controls.Clear();

            // Instanciar y mostrar el mini-juego
            ucMapaMental mapa = new ucMapaMental();
            mapa.Dock = DockStyle.Fill;
            flowLayoutPanel1.Controls.Add(mapa);
        }
    }
}