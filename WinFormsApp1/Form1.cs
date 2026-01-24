using Microsoft.VisualBasic.Devices;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp1
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            RedondearFormulario(25);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            usuario.nombreUsuario = textBox1.Text;
            Menuprincipal principal = new Menuprincipal();
            principal.Show();
            this.Hide();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            info1 info = new info1();
            info.Show();
            Hide();
        }
        private void picsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
