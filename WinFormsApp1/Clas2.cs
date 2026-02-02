using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1;

namespace Clasificación_de_alimentos
{
    public partial class Clas2 : Form
    {
        public Clas2()
        {
            InitializeComponent();

            // Aplicar redondeos iniciales
            RedondearFormulario(25);
            Redondear_butom(button1, 40);
            Redondear_butom(button2, 40);
            Redondear_butom(button3, 40);

            // Colores de botones
            button1.BackColor = ColorTranslator.FromHtml("#98FF98");
            button2.BackColor = ColorTranslator.FromHtml("#98FF98");
            button3.BackColor = ColorTranslator.FromHtml("#98FF98");
        }

        // --- MÉTODOS DE DISEÑO ---

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

        static void Redondearpanel(Panel p, int r)
        {
            GraphicsPath gp = new GraphicsPath();
            int d = r * 2;
            gp.AddArc(0, 0, d, d, 180, 90);
            gp.AddArc(p.Width - d, 0, d, d, 270, 90);
            gp.AddArc(p.Width - d, p.Height - d, d, d, 0, 90);
            gp.AddArc(0, p.Height - d, d, d, 90, 90);
            gp.CloseFigure();
            p.Region = new Region(gp);
        }

        static void Redondear_butom(Button boton, int radius)
        {
            GraphicsPath gp = new GraphicsPath();
            int d = radius * 2;
            gp.AddArc(0, 0, d, d, 180, 90);
            gp.AddArc(boton.Width - d, 0, d, d, 270, 90);
            gp.AddArc(boton.Width - d, boton.Height - d, d, d, 0, 90);
            gp.AddArc(0, boton.Height - d, d, d, 90, 90);
            gp.CloseFigure();
            boton.Region = new Region(gp);
        }

        // --- LÓGICA DE PANELES ANIDADOS ---

        private void CargarSubPanel(Panel panelHijo)
        {
            // 1. Limpiamos el panel principal de lo que tenga antes
            if (panelPrincipal.Controls.Count > 0)
                panelPrincipal.Controls.Clear();

            // 2. Configuramos el panel que va a entrar
            panelHijo.Dock = DockStyle.Fill; // Se ajusta al tamaño de panelPrincipal
            panelHijo.Visible = true;

            // 3. Lo metemos dentro del principal
            panelPrincipal.Controls.Add(panelHijo);

            // 4. (Opcional) Redondear el panel una vez que ya tiene su tamaño final
            Redondearpanel(panelHijo, 25);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Al cargar, escondemos los subpaneles para que no estorben
            panelcereal.Visible = false;
            panellegumbres.Visible = false;
            panelaceites.Visible = false;
            panelPrincipal.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarSubPanel(panelcereal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarSubPanel(panellegumbres);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarSubPanel(panelaceites);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Clas1 formClas1 = new Clas1();
            formClas1.Show();
            this.Hide();
        }
    }
}