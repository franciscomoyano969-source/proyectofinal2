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
    public partial class ucTarjetaGuia : UserControl
    {
        // 1. Lista para guardar las imágenes (diapositivas)
        private List<Image> misDiapositivas = new List<Image>();
        private int indiceActual = 0;

        public ucTarjetaGuia()
        {
            InitializeComponent();
        }
        /////////////////
        // 2. Método para cargar las imágenes desde el Form1
        public void ConfigurarDiapositivas(List<Image> listaImagenes)
        {
            if (listaImagenes != null && listaImagenes.Count > 0)
            {
                misDiapositivas = listaImagenes;
                indiceActual = 0;
                ActualizarFondo();
            }
        }

        // 3. Método para cambiar el fondo visualmente
        private void ActualizarFondo()
        {
            this.BackgroundImage = misDiapositivas[indiceActual];
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        // 4. Evento del botón "Siguiente"
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (misDiapositivas.Count > 0)
            {
                // Aumenta el índice y vuelve a 0 si llega al final
                indiceActual = (indiceActual + 1) % misDiapositivas.Count;
                ActualizarFondo();
            }
        }

        private void ucTarjetaGuia_Load(object sender, EventArgs e)
        {
        }

        
    }
}
