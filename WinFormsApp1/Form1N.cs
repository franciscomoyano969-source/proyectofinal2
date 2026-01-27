using System.Drawing.Drawing2D;
using WinFormsApp1;

namespace PROYECTO
{
    public partial class FormN1 : Form
    {
        // Declaramos las instancias una sola vez
        Form frmMateriaPrima = new GestionDeMate();
        DistribucionDeAlimentos frmDistribucion = new DistribucionDeAlimentos();
        GestionDePersonal frmPersonal = new GestionDePersonal();
        ApoyoAInstituciones frmApoyo = new ApoyoAInstituciones();

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

        public FormN1()
        {
            InitializeComponent();
            // Llamada al método con un radio de 25 píxeles
            RedondearFormulario(25);
            Redondear_butom(btnMatPrima, 40);
            Redondear_butom(btnDistriAlimento, 40);
            Redondear_butom(btnGestPersonal, 40);
            Redondear_butom(btnApoyInstituciones, 40);
            btnMatPrima.BackColor = ColorTranslator.FromHtml("#98FF98");
            btnDistriAlimento.BackColor = ColorTranslator.FromHtml("#98FF98");
            btnGestPersonal.BackColor = ColorTranslator.FromHtml("#98FF98");
            btnApoyInstituciones.BackColor = ColorTranslator.FromHtml("#98FF98");
            Redondearpanel(pnlReferencias, 30);
            Redondearpanel(pnlMostrarInfo, 30);

        }
        static void Redondearpanel(Panel p, int r)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, r, r, 180, 90);
            gp.AddArc(p.Width - r, 0, r, r, 270, 90);
            gp.AddArc(p.Width - r, p.Height - r, r, r, 0, 90);
            gp.AddArc(0, p.Height - r, r, r, 90, 90);
            gp.CloseFigure();
            p.Region = new Region(gp);
        }
        static void Redondear_butom(Button boton, int radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, radius, radius, 180, 90);
            gp.AddArc(boton.Width - radius, 0, radius, radius, 270, 90);
            gp.AddArc(boton.Width - radius, boton.Height - radius, radius, radius, 0, 90);
            gp.AddArc(0, boton.Height - radius, radius, radius, 90, 90);
            gp.CloseFigure();
            boton.Region = new Region(gp);
        }

        private void AbrirFormEnPanel(Form formularioHijo)
        {
            // 1. Limpiamos el panel de cualquier control previo sin destruir los datos
            if (this.pnlMostrarInfo.Controls.Count > 0)
            {
                this.pnlMostrarInfo.Controls.Clear();
            }

            // 2. Configuramos el formulario hijo como un control interno
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            // 3. Lo agregamos al panel pnlMostrarInfo y lo mostramos
            this.pnlMostrarInfo.Controls.Add(formularioHijo);
            this.pnlMostrarInfo.Tag = formularioHijo;
            formularioHijo.Show();
        }
        private void btnMatPrima_Click(object sender, EventArgs e) => AbrirFormEnPanel(frmMateriaPrima);

        private void ShowFormInPanel(Form frm, string panelName)
        {
            if (frm == null) return;

            var pnl = this.Controls.Find(panelName, true).FirstOrDefault() as Panel;
            if (pnl == null)
            {
                MessageBox.Show($"Panel '{panelName}' no encontrado. Verifica el nombre en el diseñador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                frm.Dispose();
                return;
            }

            // Limpiar y disponer contenido previo del panel
            foreach (Control c in pnl.Controls.OfType<Control>().ToArray())
            {
                if (c is Form f)
                {
                    try { f.Close(); } catch { }
                    f.Dispose();
                }
                else
                {
                    c.Dispose();
                }
            }
            pnl.Controls.Clear();

            // Preparar y añadir el formulario
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnl.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }
        private void btnDistriAlimento_Click(object sender, EventArgs e) => AbrirFormEnPanel(frmDistribucion);


        private void btnGestPersonal_Click(object sender, EventArgs e) => AbrirFormEnPanel(frmPersonal);


        private void btnApoyInstituciones_Click(object sender, EventArgs e) => AbrirFormEnPanel(frmApoyo);

        private void btnPractPrendido_Click(object sender, EventArgs e)
        {
            Form frmPractica = new PacticaLoAprendido();
            frmPractica.Show();
            this.Hide();
        }
        private void ptbReferencias_Click(object sender, EventArgs e)
        {
            ocultartodoslopaneles();
            pnlReferencias.Visible = true;
        }
        private void ocultartodoslopaneles()
        {
            pnlReferencias.Visible = false;
        }
        private void ptbCerrar_Click(object sender, EventArgs e)
        {
            // Oculta el panel de referencias
            pnlReferencias.Visible = false;
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            Menuprincipal menu = new Menuprincipal();
            menu.Show();
            this.Hide();
        }

        private void picjuego_Click(object sender, EventArgs e)
        {
            PacticaLoAprendido juego = new PacticaLoAprendido();
            juego.Show();
            this.Hide();
        }
    }
}
