/*using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class juego2 : Form
    {
        public Action NivelCompletado;

        int filas = 10;
        int columnas = 10;
        int tamañoCelda = 27;
        char[,] tablero;
        Label[,] labels;
        string[] palabras = { "FUNDACION", "COLABORA", "ENTREGA", "BOLSA", "LEGUMBRE", "ARROZ", "PAN", "LECHE", "FRUTA", "GALLETAS" };
        Color[] paletaColores = {
            Color.LightGreen, Color.LightSalmon, Color.LightSkyBlue, Color.Thistle,
            Color.Khaki, Color.LightCoral, Color.Aquamarine, Color.SandyBrown,
            Color.Plum, Color.YellowGreen
        };
        int indiceColor = 0;
        HashSet<string> encontradas = new HashSet<string>();
        List<Label> seleccionActual = new List<Label>();
        Point inicioSeleccion = new Point(-1, -1);
        bool estaArrastrando = false;
        Panel panelSopa;
        Panel panelLista;
        Dictionary<string, Label> etiquetasListaUI = new Dictionary<string, Label>();
        Random rnd = new Random();

        private System.Windows.Forms.Timer timerJuego;
        int tiempoRestante;
        Label lblTiempo;

        public juego2()
        {
            ConfigurarInterfaz();
            IniciarJuego();
            // ESTO ASEGURA QUE EL TIMER SE DETENGA AL SALIR
            this.FormClosing += Juego2_FormClosing;
        }

        private void Juego2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timerJuego != null)
            {
                timerJuego.Stop(); // Detiene el reloj
                timerJuego.Tick -= TimerJuego_Tick; // Desconecta el evento
                timerJuego.Dispose(); // Libera la memoria
                timerJuego = null;
            }
        }

        private void ConfigurarInterfaz()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor = Color.White;
            this.Size = new Size((columnas * tamañoCelda) + 250, (filas * tamañoCelda) + 80);
            this.StartPosition = FormStartPosition.CenterScreen;

            panelSopa = new Panel
            {
                Location = new Point(30, 30),
                Size = new Size(columnas * tamañoCelda, filas * tamañoCelda),
                BackColor = Color.FromArgb(160, Color.White),
                BorderStyle = BorderStyle.None
            };
            panelSopa.MouseMove += PanelSopa_MouseMove;

            panelLista = new Panel
            {
                Location = new Point(panelSopa.Right + 50, 30),
                Size = new Size(180, 250),
                BackColor = Color.FromArgb(200, Color.WhiteSmoke),
                BorderStyle = BorderStyle.FixedSingle,
            };

            lblTiempo = new Label
            {
                Text = "Tiempo: 01:00",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DarkRed,
                AutoSize = true,
                Location = new Point(panelLista.Left, panelLista.Bottom + 10)
            };

            this.Controls.Add(panelSopa);
            this.Controls.Add(panelLista);
            this.Controls.Add(lblTiempo);

            timerJuego = new System.Windows.Forms.Timer();
            timerJuego.Interval = 1000;
            timerJuego.Tick += TimerJuego_Tick;

            tiempoRestante = 60;
            lblTiempo.Text = "Tiempo: 01:00";
            timerJuego.Start();
        }

        private void IniciarJuego()
        {
            tablero = new char[filas, columnas];
            labels = new Label[filas, columnas];
            panelSopa.Controls.Clear();
            etiquetasListaUI.Clear();
            encontradas.Clear();
            indiceColor = 0;
            seleccionActual.Clear();

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Label lbl = new Label
                    {
                        Size = new Size(tamañoCelda, tamañoCelda),
                        Location = new Point(c * tamañoCelda, f * tamañoCelda),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        BorderStyle = BorderStyle.FixedSingle,
                        Tag = new Point(f, c),
                        BackColor = Color.Transparent
                    };
                    lbl.MouseDown += Lbl_MouseDown;
                    lbl.MouseEnter += Lbl_MouseEnter;
                    lbl.MouseUp += Lbl_MouseUp;
                    labels[f, c] = lbl;
                    panelSopa.Controls.Add(lbl);
                }
            }

            ColocarPalabras();
            RellenarConLetrasAzar();
            DibujarListaPalabras();
        }

        private void TimerJuego_Tick(object sender, EventArgs e)
        {
            // Evita que el tick corra si el form se está cerrando
            if (this.IsDisposed) return;

            tiempoRestante--;
            int min = tiempoRestante / 60;
            int seg = tiempoRestante % 60;
            lblTiempo.Text = $"Tiempo: {min:D2}:{seg:D2}";

            if (tiempoRestante <= 0)
            {
                timerJuego.Stop();
                DialogResult r = MessageBox.Show("Se acabó el tiempo. ¿Deseas reiniciar el nivel?", "Fin del juego", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                    ReiniciarJuego();
                else
                    this.Close();
            }
        }

        private void ReiniciarJuego()
        {
            tiempoRestante = 60;
            lblTiempo.Text = "Tiempo: 01:00";
            timerJuego.Start();
            IniciarJuego();
        }

        private void PanelSopa_MouseMove(object sender, MouseEventArgs e)
        {
            if (estaArrastrando)
            {
                Control hijo = panelSopa.GetChildAtPoint(e.Location);
                if (hijo is Label lbl && lbl.Tag is Point puntoActual)
                {
                    ActualizarSeleccion(puntoActual);
                }
            }
        }

        private void Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            estaArrastrando = true;
            inicioSeleccion = (Point)((Label)sender).Tag;
            LimpiarSeleccionVisual();
            ActualizarSeleccion(inicioSeleccion);
            ((Label)sender).Capture = false;
        }

        private void Lbl_MouseEnter(object sender, EventArgs e)
        {
            if (estaArrastrando) ActualizarSeleccion((Point)((Label)sender).Tag);
        }

        private void Lbl_MouseUp(object sender, MouseEventArgs e)
        {
            if (!estaArrastrando) return;
            estaArrastrando = false;
            string formada = string.Concat(seleccionActual.Select(l => l.Text));
            string invertida = new string(formada.Reverse().ToArray());

            if (palabras.Contains(formada) || palabras.Contains(invertida))
            {
                string correcta = palabras.Contains(formada) ? formada : invertida;
                if (!encontradas.Contains(correcta)) MarcarComoEncontrada(correcta);
            }
            else LimpiarSeleccionVisual();
        }

        private void ActualizarSeleccion(Point fin)
        {
            LimpiarSeleccionVisual();
            seleccionActual.Clear();
            int df = fin.X - inicioSeleccion.X;
            int dc = fin.Y - inicioSeleccion.Y;
            if (df == 0 || dc == 0 || Math.Abs(df) == Math.Abs(dc))
            {
                int pasoF = (df == 0) ? 0 : df / Math.Abs(df);
                int pasoC = (dc == 0) ? 0 : dc / Math.Abs(dc);
                int f = inicioSeleccion.X, c = inicioSeleccion.Y;
                while (true)
                {
                    Label lbl = labels[f, c];
                    seleccionActual.Add(lbl);

                    if (lbl.BorderStyle != BorderStyle.None)
                        lbl.BackColor = Color.SkyBlue;

                    if (f == fin.X && c == fin.Y) break;
                    f += pasoF; c += pasoC;
                }
            }
        }

        private void MarcarComoEncontrada(string p)
        {
            Color col = paletaColores[indiceColor % paletaColores.Length];
            indiceColor++;
            foreach (var lbl in seleccionActual)
            {
                lbl.BackColor = col;
                lbl.BorderStyle = BorderStyle.None;
            }
            encontradas.Add(p);
            etiquetasListaUI[p].BackColor = col;
            etiquetasListaUI[p].Font = new Font("Segoe UI", 9, FontStyle.Strikeout | FontStyle.Bold);

            if (encontradas.Count == palabras.Length)
            {
                timerJuego.Stop(); // Detener el timer antes del mensaje
                MessageBox.Show("¡Felicidades! Completaste la sopa de donaciones.");
                NivelCompletado?.Invoke();
                this.Hide();
            }
        }
        private void LimpiarSeleccionVisual()
        {
            foreach (Label lbl in labels)
                if (lbl.BackColor == Color.SkyBlue) lbl.BackColor = Color.Transparent;
        }

        private void ColocarPalabras()
        {
            int[,] dirs = { { 0, 1 }, { 1, 0 }, { 1, 1 }, { -1, 1 } };
            foreach (string p in palabras)
            {
                bool colocado = false;
                while (!colocado)
                {
                    int f = rnd.Next(filas), c = rnd.Next(columnas), d = rnd.Next(4);
                    int df = dirs[d, 0], dc = dirs[d, 1];
                    if (ValidarEspacio(p, f, c, df, dc))
                    {
                        for (int i = 0; i < p.Length; i++)
                        {
                            tablero[f, c] = p[i];
                            labels[f, c].Text = p[i].ToString();
                            f += df; c += dc;
                        }
                        colocado = true;
                    }
                }
            }
        }

        private bool ValidarEspacio(string p, int f, int c, int df, int dc)
        {
            for (int i = 0; i < p.Length; i++)
            {
                if (f < 0 || f >= filas || c < 0 || c >= columnas) return false;
                if (tablero[f, c] != '\0' && tablero[f, c] != p[i]) return false;
                f += df; c += dc;
            }
            return true;
        }

        private void RellenarConLetrasAzar()
        {
            for (int f = 0; f < filas; f++)
                for (int c = 0; c < columnas; c++)
                    if (tablero[f, c] == '\0') labels[f, c].Text = ((char)('A' + rnd.Next(26))).ToString();
        }

        private void InitializeComponent()
        {

        }

        private void DibujarListaPalabras()
        {
            panelLista.Controls.Clear();
            etiquetasListaUI.Clear();
            Label t = new Label { Text = "LISTA", Font = new Font("Segoe UI", 10, FontStyle.Bold), Location = new Point(5, 5), AutoSize = true };
            panelLista.Controls.Add(t);
            int y = 30;
            foreach (string p in palabras)
            {
                Label lbl = new Label { Text = p, Font = new Font("Segoe UI", 9), Location = new Point(10, y), AutoSize = true };
                panelLista.Controls.Add(lbl);
                etiquetasListaUI.Add(p, lbl);
                y += 25;
            }
        }
    }
}*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class juego2 : Form
    {
        public Action NivelCompletado;
        // Referencia para volver al formulario anterior
        private Form formularioPadre;

        int filas = 10;
        int columnas = 10;
        int tamañoCelda = 27;
        char[,] tablero;
        Label[,] labels;
        string[] palabras = { "FUNDACION", "COLABORA", "ENTREGA", "BOLSA", "LEGUMBRE", "ARROZ", "PAN", "LECHE", "FRUTA", "GALLETAS" };
        Color[] paletaColores = {
            Color.LightGreen, Color.LightSalmon, Color.LightSkyBlue, Color.Thistle,
            Color.Khaki, Color.LightCoral, Color.Aquamarine, Color.SandyBrown,
            Color.Plum, Color.YellowGreen
        };
        int indiceColor = 0;
        HashSet<string> encontradas = new HashSet<string>();
        List<Label> seleccionActual = new List<Label>();
        Point inicioSeleccion = new Point(-1, -1);
        bool estaArrastrando = false;
        Panel panelSopa;
        Panel panelLista;
        Dictionary<string, Label> etiquetasListaUI = new Dictionary<string, Label>();
        Random rnd = new Random();

        private System.Windows.Forms.Timer timerJuego;
        int tiempoRestante;
        Label lblTiempo;

        // Constructor modificado para recibir al padre (opcional)
        public juego2(Form padre = null)
        {
            this.formularioPadre = padre;
            ConfigurarInterfaz();
            IniciarJuego();
            this.FormClosing += Juego2_FormClosing;
        }

        private void Juego2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timerJuego != null)
            {
                timerJuego.Stop();
                timerJuego.Tick -= TimerJuego_Tick;
                timerJuego.Dispose();
                timerJuego = null;
            }
            // Si se cierra manualmente, mostramos el menú anterior
            if (formularioPadre != null) formularioPadre.Show();
        }

        private void ConfigurarInterfaz()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor = Color.White;
            this.Size = new Size((columnas * tamañoCelda) + 250, (filas * tamañoCelda) + 80);
            this.StartPosition = FormStartPosition.CenterScreen;

            panelSopa = new Panel
            {
                Location = new Point(30, 30),
                Size = new Size(columnas * tamañoCelda, filas * tamañoCelda),
                BackColor = Color.FromArgb(160, Color.White),
                BorderStyle = BorderStyle.None
            };
            panelSopa.MouseMove += PanelSopa_MouseMove;

            panelLista = new Panel
            {
                Location = new Point(panelSopa.Right + 50, 30),
                Size = new Size(180, 250),
                BackColor = Color.FromArgb(200, Color.WhiteSmoke),
                BorderStyle = BorderStyle.FixedSingle,
            };

            lblTiempo = new Label
            {
                Text = "Tiempo: 01:00",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DarkRed,
                AutoSize = true,
                Location = new Point(panelLista.Left, panelLista.Bottom + 10)
            };

            this.Controls.Add(panelSopa);
            this.Controls.Add(panelLista);
            this.Controls.Add(lblTiempo);

            timerJuego = new System.Windows.Forms.Timer();
            timerJuego.Interval = 1000;
            timerJuego.Tick += TimerJuego_Tick;

            tiempoRestante = 60;
            lblTiempo.Text = "Tiempo: 01:00";
            timerJuego.Start();
        }

        private void IniciarJuego()
        {
            tablero = new char[filas, columnas];
            labels = new Label[filas, columnas];
            panelSopa.Controls.Clear();
            etiquetasListaUI.Clear();
            encontradas.Clear();
            indiceColor = 0;
            seleccionActual.Clear();

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Label lbl = new Label
                    {
                        Size = new Size(tamañoCelda, tamañoCelda),
                        Location = new Point(c * tamañoCelda, f * tamañoCelda),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        BorderStyle = BorderStyle.FixedSingle,
                        Tag = new Point(f, c),
                        BackColor = Color.Transparent
                    };
                    lbl.MouseDown += Lbl_MouseDown;
                    lbl.MouseEnter += Lbl_MouseEnter;
                    lbl.MouseUp += Lbl_MouseUp;
                    labels[f, c] = lbl;
                    panelSopa.Controls.Add(lbl);
                }
            }

            ColocarPalabras();
            RellenarConLetrasAzar();
            DibujarListaPalabras();
        }

        private void TimerJuego_Tick(object sender, EventArgs e)
        {
            if (this.IsDisposed) return;
            tiempoRestante--;
            int min = tiempoRestante / 60;
            int seg = tiempoRestante % 60;
            lblTiempo.Text = $"Tiempo: {min:D2}:{seg:D2}";

            if (tiempoRestante <= 0)
            {
                timerJuego.Stop();
                DialogResult r = MessageBox.Show("Se acabó el tiempo. ¿Deseas reiniciar el nivel?", "Fin del juego", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes) ReiniciarJuego();
                else this.Close();
            }
        }

        private void ReiniciarJuego()
        {
            tiempoRestante = 60;
            lblTiempo.Text = "Tiempo: 01:00";
            timerJuego.Start();
            IniciarJuego();
        }

        private void PanelSopa_MouseMove(object sender, MouseEventArgs e)
        {
            if (estaArrastrando)
            {
                Control hijo = panelSopa.GetChildAtPoint(e.Location);
                if (hijo is Label lbl && lbl.Tag is Point puntoActual) ActualizarSeleccion(puntoActual);
            }
        }

        private void Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            estaArrastrando = true;
            inicioSeleccion = (Point)((Label)sender).Tag;
            LimpiarSeleccionVisual();
            ActualizarSeleccion(inicioSeleccion);
            ((Label)sender).Capture = false;
        }

        private void Lbl_MouseEnter(object sender, EventArgs e)
        {
            if (estaArrastrando) ActualizarSeleccion((Point)((Label)sender).Tag);
        }

        private void Lbl_MouseUp(object sender, MouseEventArgs e)
        {
            if (!estaArrastrando) return;
            estaArrastrando = false;
            string formada = string.Concat(seleccionActual.Select(l => l.Text));
            string invertida = new string(formada.Reverse().ToArray());

            if (palabras.Contains(formada) || palabras.Contains(invertida))
            {
                string correcta = palabras.Contains(formada) ? formada : invertida;
                if (!encontradas.Contains(correcta)) MarcarComoEncontrada(correcta);
            }
            else LimpiarSeleccionVisual();
        }

        private void ActualizarSeleccion(Point fin)
        {
            LimpiarSeleccionVisual();
            seleccionActual.Clear();
            int df = fin.X - inicioSeleccion.X;
            int dc = fin.Y - inicioSeleccion.Y;
            if (df == 0 || dc == 0 || Math.Abs(df) == Math.Abs(dc))
            {
                int pasoF = (df == 0) ? 0 : df / Math.Abs(df);
                int pasoC = (dc == 0) ? 0 : dc / Math.Abs(dc);
                int f = inicioSeleccion.X, c = inicioSeleccion.Y;
                while (true)
                {
                    Label lbl = labels[f, c];
                    seleccionActual.Add(lbl);
                    if (lbl.BorderStyle != BorderStyle.None) lbl.BackColor = Color.SkyBlue;
                    if (f == fin.X && c == fin.Y) break;
                    f += pasoF; c += pasoC;
                }
            }
        }

        private void MarcarComoEncontrada(string p)
        {
            // ... (Mantén tu lógica de colores igual)
            Color col = paletaColores[indiceColor % paletaColores.Length];
            indiceColor++;
            foreach (var lbl in seleccionActual) { lbl.BackColor = col; lbl.BorderStyle = BorderStyle.None; }
            encontradas.Add(p);
            etiquetasListaUI[p].BackColor = col;
            etiquetasListaUI[p].Font = new Font("Segoe UI", 9, FontStyle.Strikeout | FontStyle.Bold);

            if (encontradas.Count == palabras.Length)
            {
                timerJuego.Stop();
                MessageBox.Show("¡Felicidades! Completaste la sopa de donaciones.");

                // Ejecutamos la acción de desbloqueo de nivel
                NivelCompletado?.Invoke();

                // IMPORTANTE: Volver a las instrucciones dentro del panel
                if (this.formularioPadre is info1 fp)
                {
                    // Le pedimos a info1 que cargue de nuevo las instrucciones en su panel
                    fp.AbrirFormEnPanel(new Intrucciones_sopa());
                }

                this.Close(); // Cerramos el juego
            }
        }
        private void LimpiarSeleccionVisual()
        {
            foreach (Label lbl in labels)
                if (lbl.BackColor == Color.SkyBlue) lbl.BackColor = Color.Transparent;
        }
        private void ColocarPalabras()
        {
            int[,] dirs = { { 0, 1 }, { 1, 0 }, { 1, 1 }, { -1, 1 } };
            foreach (string p in palabras)
            {
                bool colocado = false;
                while (!colocado)
                {
                    int f = rnd.Next(filas), c = rnd.Next(columnas), d = rnd.Next(4);
                    int df = dirs[d, 0], dc = dirs[d, 1];
                    if (ValidarEspacio(p, f, c, df, dc))
                    {
                        for (int i = 0; i < p.Length; i++)
                        {
                            tablero[f, c] = p[i];
                            labels[f, c].Text = p[i].ToString();
                            f += df; c += dc;
                        }
                        colocado = true;
                    }
                }
            }
        }
        private bool ValidarEspacio(string p, int f, int c, int df, int dc)
        {
            for (int i = 0; i < p.Length; i++)
            {
                if (f < 0 || f >= filas || c < 0 || c >= columnas) return false;
                if (tablero[f, c] != '\0' && tablero[f, c] != p[i]) return false;
                f += df; c += dc;
            }
            return true;
        }

        private void RellenarConLetrasAzar()
        {
            for (int f = 0; f < filas; f++)
                for (int c = 0; c < columnas; c++)
                    if (tablero[f, c] == '\0') labels[f, c].Text = ((char)('A' + rnd.Next(26))).ToString();
        }

        private void DibujarListaPalabras()
        {
            panelLista.Controls.Clear();
            etiquetasListaUI.Clear();
            Label t = new Label { Text = "LISTA", Font = new Font("Segoe UI", 10, FontStyle.Bold), Location = new Point(5, 5), AutoSize = true };
            panelLista.Controls.Add(t);
            int y = 30;
            foreach (string p in palabras)
            {
                Label lbl = new Label { Text = p, Font = new Font("Segoe UI", 9), Location = new Point(10, y), AutoSize = true };
                panelLista.Controls.Add(lbl);
                etiquetasListaUI.Add(p, lbl);
                y += 25;
            }
        }
    }
}