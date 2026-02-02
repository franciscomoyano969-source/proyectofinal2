using Clasificación_de_alimentos;
using PROYECTO;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection.Emit;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Menuprincipal : Form
    {
        // CONSTRUCTOR ÚNICO
        public Menuprincipal()
        {
            // Fíjate en las mayúsculas: es InitializeComponent
            InitializeComponent();
            RedondearFormulario(30);
            if (!string.IsNullOrEmpty(usuario.nombreUsuario))
            {
                lblnombre.Text = "Bienvenido, " + usuario.nombreUsuario;
            }
            else
            {
                lblnombre.Text = "Bienvenido, Invitado";
            }
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
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormN1 formN1 = new FormN1();
            formN1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Clas1 formClas1 = new Clas1();
            formClas1.Show();
            this.Hide();
        }
    }
}