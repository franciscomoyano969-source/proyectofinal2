using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5.NewFolder1
{
    public partial class ucMapaMental : UserControl
    {
        //variables priv mapa
        private Panel pnlCentral;
        private Label lblCentral;
        private Button btnRecepcion, btnAlmacenamiento, btnEntrega, btnNormas;
        private ProgressBar pbProgreso;
        private Label lblProgreso;
        private Panel pnlReto; // Panel para mostrar retos
        private List<string> accionesRecepcion = new List<string> { "Verificar la integridad del paquete recibido.", "Registrar la recepción en el sistema.", "Notificar al remitente sobre la recepción.", "Sanitizar empaques externos antes de su ingreso." };
        private List<string> accionesAlmacenamiento = new List<string> { "Cotejar la cantidad recibida contra la nota de entrega.", "Actualizar el inventario físico/digital del comedor.", "Comunicar la renovación de insumos al equipo de cocina.", "Rotar el stock colocando lo nuevo detrás de lo antiguo." };
        private List<string> accionesEntrega = new List<string> { "Validar la identidad del beneficiario.", "Registrar entrega para el cierre de cuenta diario.", "Confirmar con el responsable el destino final.", "Trasladar el alimento al usuario final." };
        private bool[] completado = new bool[4]; // Progreso: 0=Recepcion, 1=Almacenamiento, 2=Entrega, 3=Normas

        public ucMapaMental()
        {
            InitializeComponent();
            InicializarMapa();
        }

        private void ucMapaMental_Load(object sender, EventArgs e)
        {
        }

        private void InicializarMapa()
        {
            // Nodo central
            pnlCentral = new Panel { AutoSize = true, Location = new Point(135, 50), BackColor = Color.LightGreen, BorderStyle = BorderStyle.FixedSingle };
            lblCentral = new Label { Text = "Gestión Segura de Donaciones", Font = new Font("segoe print", 12, FontStyle.Bold), AutoSize = true, Location = new Point(20, 30) };
            pnlCentral.Controls.Add(lblCentral);
            this.Controls.Add(pnlCentral);

            // Ramas (tarjetas grandes)
            btnRecepcion = new Button { Text = "1. Recepción", Font = new Font("segoe print", 8, FontStyle.Bold), Size = new Size(150, 50), Location = new Point(90, 160), BackColor = Color.LightBlue };
            btnRecepcion.Click += BtnRecepcion_Click;
            this.Controls.Add(btnRecepcion);

            btnAlmacenamiento = new Button { Text = "2. Almacenamiento", Font = new Font("segoe print", 8, FontStyle.Bold), Size = new Size(150, 50), Location = new Point(300, 160), BackColor = Color.LightYellow };
            btnAlmacenamiento.Click += BtnAlmacenamiento_Click;
            this.Controls.Add(btnAlmacenamiento);

            btnEntrega = new Button { Text = "3. Entrega/Distribución", Font = new Font("segoe print", 8, FontStyle.Bold), Size = new Size(150, 50), Location = new Point(90, 210), BackColor = Color.LightCoral };
            btnEntrega.Click += BtnEntrega_Click;
            this.Controls.Add(btnEntrega);

            btnNormas = new Button { Text = "4. Normas Sanitarias", Font = new Font("segoe print", 8, FontStyle.Bold), Size = new Size(150, 50), Location = new Point(300, 210), BackColor = Color.LightPink };
            btnNormas.Click += BtnNormas_Click;
            this.Controls.Add(btnNormas);

            // Barra de progreso
            pbProgreso = new ProgressBar { Size = new Size(400, 20), Location = new Point(75, 270), Maximum = 4 };
            lblProgreso = new Label { Text = "Progreso: 0/4", Location = new Point(100, 290), BackColor = Color.White, Font = new Font("segoe print", 8, FontStyle.Bold) };
            this.Controls.Add(pbProgreso);
            this.Controls.Add(lblProgreso);

            // Panel para retos
            pnlReto = new Panel { AutoSize = true, Location = new Point(95, 320), BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle, Visible = false };
            this.Controls.Add(pnlReto);
        }

        private void ActualizarProgreso()
        {
            int completadas = completado.Count(b => b);
            pbProgreso.Value = completadas;
            lblProgreso.Text = $"Progreso: {completadas}/4";
            if (completadas == 4)
            {
                MessageBox.Show("¡Has completado el mapa mental correctamente! Has reforzado los protocolos de bioseguridad.", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnRecepcion_Click(object sender, EventArgs e)
        {
            if (completado[0]) return;
            pnlReto.Controls.Clear();
            pnlReto.Visible = true;
            Label lblInstruccion = new Label { Text = "Ordena correctamente el protocolo de recepción (arrastra las tarjetas):", Location = new Point(10, 10), AutoSize = true };
            pnlReto.Controls.Add(lblInstruccion);

            // Crear tarjetas movibles (usando Panels para drag-and-drop)
            List<Panel> tarjetas = new List<Panel>();
            int yPos = 60; // Posición Y inicial
            foreach (var accion in accionesRecepcion.OrderBy(x => Guid.NewGuid())) // Desordenar
            {
                Panel pnlTarjeta = new Panel { Size = new Size(400, 30), Location = new Point(10, yPos), BackColor = Color.LightBlue, BorderStyle = BorderStyle.FixedSingle };
                Label lblTexto = new Label { Text = accion, AutoSize = true, Location = new Point(5, 5) };
                pnlTarjeta.Controls.Add(lblTexto);
                pnlTarjeta.MouseDown += (s, ev) => { pnlTarjeta.DoDragDrop(pnlTarjeta, DragDropEffects.Move); }; // Iniciar drag
                pnlReto.AllowDrop = true;
                pnlReto.DragOver += (s, ev) => { ev.Effect = DragDropEffects.Move; }; // Permitir drop
                pnlReto.DragDrop += (s, ev) =>
                {
                    Panel dragged = (Panel)ev.Data.GetData(typeof(Panel));
                    dragged.Location = pnlReto.PointToClient(new Point(ev.X, ev.Y)); // Mover a nueva posición
                };
                tarjetas.Add(pnlTarjeta);
                pnlReto.Controls.Add(pnlTarjeta);
                yPos += 35; // Espacio entre tarjetas
            }

            Button btnValidar = new Button { Text = "Validar Orden", Location = new Point(10, yPos + 10) };
            btnValidar.Click += (s, ev) =>
            {
                // Validar basado en posiciones Y (orden vertical)
                tarjetas = tarjetas.OrderBy(t => t.Location.Y).ToList();// Ordenar por y
                bool correcto = true;
                for (int i = 0; i < tarjetas.Count; i++)
                {
                    if (tarjetas[i].Controls[0].Text != accionesRecepcion[i]) correcto = false;
                }
                if (correcto)
                {
                    MessageBox.Show("¡Correcto! Orden validado.", "Feedback");
                    completado[0] = true;
                    ActualizarProgreso();
                    pnlReto.Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorrecto. Revisa el orden: Verificar integridad primero, luego registrar, notificar y sanitizar.", "Feedback");
                }
            };
            pnlReto.Controls.Add(btnValidar);
        }
        //juego almecenamiento
        private void BtnAlmacenamiento_Click(object sender, EventArgs e)
        {
            if (completado[1]) return;
            pnlReto.Controls.Clear();
            pnlReto.Visible = true;
            Label lblPregunta = new Label { Text = "¿Cuál acción garantiza la seguridad alimentaria a largo plazo?", Location = new Point(10, 10), AutoSize = true };
            pnlReto.Controls.Add(lblPregunta);

            RadioButton rb1 = new RadioButton { Text = "Rotar stock colocando lo nuevo detrás de lo antiguo.", Location = new Point(10, 40), AutoSize = true };
            RadioButton rb2 = new RadioButton { Text = "Almacenar sin registrar.", Location = new Point(10, 70), AutoSize = true };
            RadioButton rb3 = new RadioButton { Text = "Mezclar productos antiguos y nuevos.", Location = new Point(10, 100), AutoSize = true };
            pnlReto.Controls.Add(rb1);
            pnlReto.Controls.Add(rb2);
            pnlReto.Controls.Add(rb3);

            Button btnValidar = new Button { Text = "Validar", Location = new Point(10, 150) };
            btnValidar.Click += (s, ev) =>
            {
                if (rb1.Checked)
                {
                    MessageBox.Show("¡Correcto! La rotación FIFO asegura frescura.", "Feedback");
                    completado[1] = true;
                    ActualizarProgreso();
                    pnlReto.Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorrecto. La rotación es clave para evitar caducidad.", "Feedback");
                }
            };
            pnlReto.Controls.Add(btnValidar);
        }

        private void BtnEntrega_Click(object sender, EventArgs e)
        {
            if (completado[2]) return;
            pnlReto.Controls.Clear();
            pnlReto.Visible = true;
            Label lblVF = new Label { Text = "\"Registrar la entrega no es necesario si el beneficiario es frecuente.\"", Location = new Point(10, 10), AutoSize = true };
            pnlReto.Controls.Add(lblVF);

            RadioButton rbVerdadero = new RadioButton { Text = "Verdadero", Location = new Point(10, 40) };
            RadioButton rbFalso = new RadioButton { Text = "Falso", Location = new Point(10, 70) };
            pnlReto.Controls.Add(rbVerdadero);
            pnlReto.Controls.Add(rbFalso);

            Button btnValidar = new Button { Text = "Validar", Location = new Point(10, 150) };
            btnValidar.Click += (s, ev) =>
            {
                if (rbFalso.Checked)
                {
                    MessageBox.Show("¡Correcto! El registro es obligatorio para el cierre de cuenta diario.", "Feedback");
                    completado[2] = true;
                    ActualizarProgreso();
                    pnlReto.Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorrecto. Siempre se debe registrar.", "Feedback");
                }
            };
            pnlReto.Controls.Add(btnValidar);
        }

        private void BtnNormas_Click(object sender, EventArgs e)
        {
            if (completado[3]) return;
            pnlReto.Controls.Clear();
            pnlReto.Visible = true;
            Label lblRiesgo = new Label { Text = "¿Cuál donación debe rechazarse? (Selecciona la incorrecta)", Location = new Point(10, 10), AutoSize = true };
            pnlReto.Controls.Add(lblRiesgo);

            CheckBox cb1 = new CheckBox { Text = "Conservas selladas (seguras).", Location = new Point(10, 40) };
            CheckBox cb2 = new CheckBox { Text = "Producto casero sin etiqueta (riesgo sanitario).", Location = new Point(10, 70) };
            CheckBox cb3 = new CheckBox { Text = "Granos secos (seguros).", Location = new Point(10, 100) };
            pnlReto.Controls.Add(cb1);
            pnlReto.Controls.Add(cb2);
            pnlReto.Controls.Add(cb3);

            Button btnValidar = new Button { Text = "Validar", Location = new Point(10, 150) };
            btnValidar.Click += (s, ev) =>
            {
                if (cb2.Checked && !cb1.Checked && !cb3.Checked)
                {
                    MessageBox.Show("¡Correcto! Productos caseros sin etiqueta violan normas sanitarias (OMS/FAO).", "Feedback");
                    completado[3] = true;
                    ActualizarProgreso();
                    pnlReto.Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorrecto. Rechaza lo que no cumple higiene.", "Feedback");
                }
            };
            pnlReto.Controls.Add(btnValidar);

        }
    }
}