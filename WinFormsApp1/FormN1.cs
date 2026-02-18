using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
            Redondear_butom(button1, 40);
            Redondear_butom(button2, 40);
            Redondear_butom(button3, 40);
            button1.BackColor = ColorTranslator.FromHtml("#98FF98");
            button2.BackColor = ColorTranslator.FromHtml("#98FF98");
            button3.BackColor = ColorTranslator.FromHtml("#98FF98");
        }

        private void Form1_Load(object sender, EventArgs e) { }

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

        private void button1_Click_1(object sender, EventArgs e) => MostrarPasosRecepcion();
        private void button2_Click(object sender, EventArgs e) => MostrarPasosAlmacenamiento();
        private void button3_Click_1(object sender, EventArgs e) => MostrarPasosDistribucion();

        private void button4_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ucMapaMental mapa = new ucMapaMental();
            mapa.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(mapa);
        }

        private void MostrarPasosRecepcion()
        {
            panelContenedor.Controls.Clear();
            string[] pasos = { "Protocolo de Recepción",
                "Verificar la integridad del paquete recibido.",
                "Registrar la recepción en el sistema.",
                "Notificar al remitente sobre la recepción.",
                "Sanitizar empaques externos antes de su ingreso." };
            CargarPasos(pasos, Resources.rece1, Resources.rece2_0);
        }

        private void MostrarPasosAlmacenamiento()
        {
            panelContenedor.Controls.Clear();
            string[] pasos = { "Protocolo de Almacenamiento",
                "Cotejar la cantidad recibida contra la nota de entrega.",
                "Actualizar el inventario físico/digital del comedor.",
                "Comunicar la renovación de insumos al equipo de cocina.",
                "Rotar el stock colocando lo nuevo detrás de lo antiguo." };
            CargarPasos(pasos, Resources.alma1, Resources.alma2);
        }

        private void MostrarPasosDistribucion()
        {
            panelContenedor.Controls.Clear();
            string[] pasos = { "Protocolo de Distribución",
                "Validar la identidad del beneficiario.",
                "Registrar entrega para el cierre de cuenta diario.",
                "Confirmar con el responsable el destino final.",
                "Trasladar el alimento al usuario final." };
            CargarPasos(pasos, Resources.dis1, Resources.dis2);
        }

        private void CargarPasos(string[] pasos, Image img1, Image img2)
        {
            panelContenedor.Controls.Clear();

            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Dock = DockStyle.Fill;
            flow.FlowDirection = FlowDirection.TopDown;
            flow.AutoScroll = true;
            flow.WrapContents = false;
            flow.Padding = new Padding(10, 15, 10, 15);

            for (int i = 0; i < pasos.Length; ++i)
            {
                if (i == 0) // Centrado del Título
                {
                    Label lblTitulo = new Label();
                    lblTitulo.Text = pasos[i];
                    lblTitulo.Font = new Font("Segoe Print", 18, FontStyle.Bold);
                    lblTitulo.TextAlign = ContentAlignment.MiddleCenter; // Centrado
                    lblTitulo.AutoSize = false;
                    lblTitulo.Width = panelContenedor.Width - 50;
                    lblTitulo.Height = 35;
                    lblTitulo.Margin = new Padding(0, 0, 0, 15);
                    flow.Controls.Add(lblTitulo);
                }
                else // Pasos del protocolo (4 líneas visibles)
                {
                    ucPasoProtocolo pasoControl = new ucPasoProtocolo();
                    pasoControl.configurarPaso(i.ToString(), pasos[i]);
                    pasoControl.Width = panelContenedor.Width - 60;
                    pasoControl.Margin = new Padding(5, 0, 0, 10);
                    flow.Controls.Add(pasoControl);
                }
            }

            // Contenedor de imágenes centrado
            FlowLayoutPanel pnlImgContainer = new FlowLayoutPanel();
            pnlImgContainer.Width = panelContenedor.Width - 50;
            pnlImgContainer.Height = 160;
            pnlImgContainer.FlowDirection = FlowDirection.LeftToRight;
            pnlImgContainer.WrapContents = false;

            // Cálculo dinámico para centrar las imágenes
            int anchoTotalImg = 420;
            int margenCentrado = (pnlImgContainer.Width - anchoTotalImg) / 2;
            if (margenCentrado < 0) margenCentrado = 0;

            PictureBox pb1 = new PictureBox() { Image = img1, Size = new Size(200, 140), SizeMode = PictureBoxSizeMode.Zoom, Margin = new Padding(margenCentrado, 0, 10, 0) };
            PictureBox pb2 = new PictureBox() { Image = img2, Size = new Size(200, 140), SizeMode = PictureBoxSizeMode.Zoom, Margin = new Padding(10, 0, 0, 0) };

            pnlImgContainer.Controls.Add(pb1);
            pnlImgContainer.Controls.Add(pb2);
            flow.Controls.Add(pnlImgContainer);

            panelContenedor.BorderStyle = BorderStyle.FixedSingle; // Línea de límite
            panelContenedor.Controls.Add(flow);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Menuprincipal menu = new Menuprincipal();
            menu.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ucMapaMental mapa = new ucMapaMental();
            mapa.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(mapa);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ucRegistroDonacion formRegistro = new ucRegistroDonacion();
            panelContenedor.Controls.Add(formRegistro);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ucTarjetaGuia tarjetaComida = new ucTarjetaGuia();
            List<Image> fotosComida = new List<Image>() { Resources.HigSan2, Resources.ContSand, Resources.DonPermi, Resources.DonNoPermi };
            tarjetaComida.ConfigurarDiapositivas(fotosComida);
            panelContenedor.Controls.Add(tarjetaComida);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas cerrar la aplicación?", "Cerrar Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes) Application.Exit();
        }
    }
}