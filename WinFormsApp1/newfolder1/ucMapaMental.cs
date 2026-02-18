using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp5.NewFolder1
{
    public partial class ucMapaMental : UserControl
    {
        private List<string> accionesRecepcion = new()
        {
            "Verificar la integridad del paquete recibido.",
            "Registrar la recepción en el sistema.",
            "Notificar al remitente sobre la recepción.",
            "Sanitizar empaques externos antes de su ingreso."
        };

        private bool[] completado = new bool[4];
        private RoundedPanel pnlCentral, pnlReto;
        private Label lblCentral, lblProgreso;
        private RoundedButton btnRecepcion, btnAlmacenamiento, btnEntrega, btnNormas;
        private ProgressBar pbProgreso;

        Color crema = Color.FromArgb(255, 248, 240);
        Color verdeMenta = Color.FromArgb(184, 242, 230);
        Color azulCielo = Color.FromArgb(198, 226, 255);
        Color rosa = Color.FromArgb(255, 205, 210);
        Color amarillo = Color.FromArgb(255, 236, 179);

        public ucMapaMental()
        {
            InitializeComponent();
            this.Size = new Size(687, 442);
            ConstruirUI();
        }

        private void ConstruirUI()
        {
            this.BackColor = crema;

            pnlCentral = new RoundedPanel() { BackColor = Color.FromArgb(198, 242, 235), Size = new Size(350, 40) };
            pnlCentral.Location = new Point((687 - 350) / 2, 15);
            lblCentral = new Label() { Text = "Gestión Segura de Donaciones", Font = new Font("Segoe UI", 10, FontStyle.Bold), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter };
            pnlCentral.Controls.Add(lblCentral);

            int wBtn = 158;
            int hBtn = 55;
            int gap = 10;
            int startX = (687 - (wBtn * 4 + gap * 3)) / 2;

            btnRecepcion = CrearBoton("1. Recepción", azulCielo, new Point(startX, 65), wBtn, hBtn);
            btnAlmacenamiento = CrearBoton("2. Almacenamiento", amarillo, new Point(startX + wBtn + gap, 65), wBtn, hBtn);
            btnEntrega = CrearBoton("3. Entrega", rosa, new Point(startX + (wBtn + gap) * 2, 65), wBtn, hBtn);
            btnNormas = CrearBoton("4. Normas", verdeMenta, new Point(startX + (wBtn + gap) * 3, 65), wBtn, hBtn);

            pbProgreso = new ProgressBar() { Maximum = 4, Width = 450, Height = 15, Location = new Point((687 - 450) / 2, 135) };
            lblProgreso = new Label() { Text = "Progreso 0/4", AutoSize = true, Location = new Point((687 - 70) / 2, 155), Font = new Font("Segoe UI", 8, FontStyle.Bold) };

            pnlReto = new RoundedPanel()
            {
                BackColor = Color.White,
                Size = new Size(650, 250),
                Location = new Point((687 - 650) / 2, 180),
                Visible = false,
                BorderStyle = BorderStyle.FixedSingle // LÍNEAS DERECHA Y ABAJO ACTIVADAS
            };

            this.Controls.AddRange(new Control[] { pnlCentral, btnRecepcion, btnAlmacenamiento, btnEntrega, btnNormas, pbProgreso, lblProgreso, pnlReto });

            btnRecepcion.Click += (s, e) => MostrarJuegoRecepcion();
            btnAlmacenamiento.Click += (s, e) => MostrarJuegoAlmacenamiento();
            btnEntrega.Click += (s, e) => MostrarJuegoEntrega();
            btnNormas.Click += (s, e) => MostrarJuegoNormas();
        }

        private void MostrarJuegoRecepcion()
        {
            if (completado[0]) { MessageBox.Show("Ya has completado este protocolo correctamente.", "Sección Finalizada"); return; }
            pnlReto.Controls.Clear(); pnlReto.Visible = true;
            Label t = new Label() { Text = "Ordena el protocolo de recepción (Arrastra para ordenar):", AutoSize = true, Location = new Point(20, 15), Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            FlowLayoutPanel lista = new FlowLayoutPanel() { Location = new Point(20, 45), Size = new Size(610, 160), FlowDirection = FlowDirection.TopDown, WrapContents = false, AllowDrop = true };
            foreach (var acc in accionesRecepcion.OrderBy(x => Guid.NewGuid()))
            {
                Panel p = new Panel() { Size = new Size(590, 32), BackColor = Color.LightBlue, BorderStyle = BorderStyle.FixedSingle, Margin = new Padding(0, 0, 0, 5) };
                Label l = new Label() { Text = acc, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(10, 0, 0, 0) };
                p.Controls.Add(l);
                p.MouseDown += (s, e) => p.DoDragDrop(p, DragDropEffects.Move);
                l.MouseDown += (s, e) => p.DoDragDrop(p, DragDropEffects.Move);
                lista.Controls.Add(p);
            }
            lista.DragEnter += (s, e) => e.Effect = DragDropEffects.Move;
            lista.DragDrop += (s, e) => {
                Panel data = (Panel)e.Data.GetData(typeof(Panel));
                Control dest = lista.GetChildAtPoint(lista.PointToClient(new Point(e.X, e.Y)));
                int idx = lista.Controls.GetChildIndex(dest);
                if (idx >= 0) lista.Controls.SetChildIndex(data, idx);
            };
            Button v = new Button() { Text = "Validar Orden", Location = new Point(20, 210), Size = new Size(110, 30) };
            v.Click += (s, e) => {
                bool ok = true;
                for (int i = 0; i < lista.Controls.Count; i++)
                    if (lista.Controls[i].Controls[0].Text != accionesRecepcion[i]) ok = false;
                if (ok) { MessageBox.Show("¡Correcto!"); completado[0] = true; pnlReto.Visible = false; ActualizarProgreso(); }
                else MessageBox.Show("Orden incorrecto.");
            };
            pnlReto.Controls.AddRange(new Control[] { t, lista, v });
        }

        private void MostrarJuegoAlmacenamiento()
        {
            if (completado[1]) { MessageBox.Show("Esta actividad ya fue completada exitosamente.", "Aviso"); return; }
            pnlReto.Controls.Clear(); pnlReto.Visible = true;
            Label q = new Label() { Text = "¿Qué acción garantiza la seguridad alimentaria a largo plazo?", AutoSize = true, Location = new Point(20, 20), Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            RadioButton r1 = new RadioButton() { Text = "Rotar stock colocando lo nuevo detrás (FIFO).", Location = new Point(25, 55), AutoSize = true };
            RadioButton r2 = new RadioButton() { Text = "Almacenar sin registrar para agilizar.", Location = new Point(25, 85), AutoSize = true };
            RadioButton r3 = new RadioButton() { Text = "Mezclar productos antiguos y nuevos.", Location = new Point(25, 115), AutoSize = true };
            Button v = new Button() { Text = "Validar", Location = new Point(20, 160), Size = new Size(100, 30) };
            v.Click += (s, e) => { if (r1.Checked) { completado[1] = true; pnlReto.Visible = false; ActualizarProgreso(); } else MessageBox.Show("Incorrecto."); };
            pnlReto.Controls.AddRange(new Control[] { q, r1, r2, r3, v });
        }

        private void MostrarJuegoEntrega()
        {
            if (completado[2]) { MessageBox.Show("El registro de entrega ya está listo.", "Información"); return; }
            pnlReto.Controls.Clear(); pnlReto.Visible = true;
            Label q = new Label() { Text = "¿Es obligatorio registrar la salida de productos?", AutoSize = true, Location = new Point(20, 20), Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            RadioButton r1 = new RadioButton() { Text = "Sí, siempre se debe registrar.", Location = new Point(25, 55), AutoSize = true };
            RadioButton r2 = new RadioButton() { Text = "No, si es un beneficiario frecuente.", Location = new Point(25, 85), AutoSize = true };
            Button v = new Button() { Text = "Validar", Location = new Point(20, 130), Size = new Size(100, 30) };
            v.Click += (s, e) => { if (r1.Checked) { completado[2] = true; pnlReto.Visible = false; ActualizarProgreso(); } else MessageBox.Show("Incorrecto."); };
            pnlReto.Controls.AddRange(new Control[] { q, r1, r2, v });
        }

        private void MostrarJuegoNormas()
        {
            if (completado[3]) { MessageBox.Show("Ya terminaste la validación de normas sanitarias.", "Completado"); return; }
            pnlReto.Controls.Clear(); pnlReto.Visible = true;
            Label q = new Label() { Text = "¿Qué donación debe rechazarse por seguridad?", AutoSize = true, Location = new Point(20, 20), Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            CheckBox c1 = new CheckBox() { Text = "Conservas selladas correctamente.", Location = new Point(25, 55), AutoSize = true };
            CheckBox c2 = new CheckBox() { Text = "Producto casero sin etiqueta.", Location = new Point(25, 85), AutoSize = true };
            CheckBox c3 = new CheckBox() { Text = "Granos en empaque original íntegro.", Location = new Point(25, 115), AutoSize = true };
            Button v = new Button() { Text = "Validar", Location = new Point(20, 160), Size = new Size(100, 30) };
            v.Click += (s, e) => { if (c2.Checked && !c1.Checked && !c3.Checked) { completado[3] = true; pnlReto.Visible = false; ActualizarProgreso(); } else MessageBox.Show("Incorrecto."); };
            pnlReto.Controls.AddRange(new Control[] { q, c1, c2, c3, v });
        }

        private void ActualizarProgreso()
        {
            int c = completado.Count(x => x);
            pbProgreso.Value = c;
            lblProgreso.Text = $"Progreso {c}/4";
        }

        private RoundedButton CrearBoton(string txt, Color clr, Point loc, int w, int h) =>
            new RoundedButton() { Text = txt, Size = new Size(w, h), BackColor = clr, Location = loc, Font = new Font("Segoe UI", 8, FontStyle.Bold) };
    }

    public class RoundedPanel : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, 15, 15, 180, 90); gp.AddArc(Width - 16, 0, 15, 15, 270, 90);
            gp.AddArc(Width - 16, Height - 16, 15, 15, 0, 90); gp.AddArc(0, Height - 16, 15, 15, 90, 90);
            Region = new Region(gp);
        }
    }

    public class RoundedButton : Button
    {
        public RoundedButton() { FlatStyle = FlatStyle.Flat; FlatAppearance.BorderSize = 0; }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, 12, 12, 180, 90); gp.AddArc(Width - 1, 0, 12, 12, 270, 90);
            gp.AddArc(Width - 1, Height - 1, 12, 12, 0, 90); gp.AddArc(0, Height - 1, 12, 12, 90, 90);
            Region = new Region(gp);
        }
    }
}