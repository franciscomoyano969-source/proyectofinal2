using Cuidado_nutricional;
using System.Drawing.Drawing2D;
using WinFormsApp1;

namespace Clasificación_de_alimentos
{
    public partial class Clas1 : Form
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
        public Clas1()
        {
            InitializeComponent();
            RedondearFormulario(25);
            referenciaa.BackColor = ColorTranslator.FromHtml("#e5ff7d");

        }
        private void CLa_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clas2 formNuevo = new Clas2();
            formNuevo.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clas3 formNuevo = new clas3();
            formNuevo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clas4 formNuevo = new Clas4();
            formNuevo.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Menuprincipal formMenu = new Menuprincipal();
            formMenu.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            referenciaa.Visible = true;
            referenciaa.BringToFront();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cuidado1 formCuidado = new Cuidado1();
            formCuidado.Show();
            this.Hide();
        }

        private void picsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            referenciaa.Visible = false;
        }
    }
}
