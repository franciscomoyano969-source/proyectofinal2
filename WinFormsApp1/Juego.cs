using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public class juego : Form
    {
        int filas = 15;
        int columnas = 15;
        int tamañoCelda = 27; // Reducido para que quepa mejor
        char[,] tablero;
        Label[,] labels;
        string[] palabras = { "ALIMENTOS", "DONACION", "ARROZ", "LECHE", "VOLUNTARIO", "SOLIDARIDAD", "BANCO", "AYUDA", "FRUTAS", "HARINA" };
        Color[] paletaColores = { Color.LightGreen, Color.LightSalmon, Color.LightSkyBlue, Color.Thistle, Color.Khaki, Color.LightCoral, Color.Aquamarine, Color.SandyBrown, Color.Plum, Color.YellowGreen };
        int indiceColor = 0;
        HashSet<string> encontradas = new HashSet<string>();
        List<Label> seleccionActual = new List<Label>();
        Point inicioSeleccion = new Point(-1, -1);
        bool estaArrastrando = false;
        Panel panelSopa;
        Panel panelLista;
        Dictionary<string, Label> etiquetasListaUI = new Dictionary<string, Label>();
        Random rnd = new Random();
        public juego()
        {
            ConfigurarInterfaz();
            IniciarJuego();
        }
        private void ConfigurarInterfaz()
        {
            // IMPORTANTE: Quitamos bordes y tamaño fijo para el panel
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.White;
            this.DoubleBuffered = true;
            // Panel de la Sopa (Izquierda)
            panelSopa = new Panel
            {
                Location = new Point(10, 10),
                Size = new Size(columnas * tamañoCelda, filas * tamañoCelda),
                BackColor = Color.FromArgb(160, Color.White),
                BorderStyle = BorderStyle.None
            };
            // Panel de la Lista (Derecha)
            panelLista = new Panel
            {
                Location = new Point(panelSopa.Right + 10, 10),
                Size = new Size(180, panelSopa.Height),
                BackColor = Color.FromArgb(200, Color.WhiteSmoke),
                BorderStyle = BorderStyle.FixedSingle,
                AutoScroll = true
            };
            this.Controls.Add(panelSopa);
            this.Controls.Add(panelLista);
        }
        private void IniciarJuego()
        {
            tablero = new char[filas, columnas];
            labels = new Label[filas, columnas];
            panelSopa.Controls.Clear();
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
                        Tag = new Point(f, c)
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
        // --- LÓGICA DE SELECCIÓN ---
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
                    if (lbl.BackColor == Color.Transparent || lbl.BackColor == Color.White)
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
                MessageBox.Show("¡Felicidades! Completaste la sopa de donaciones.");
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