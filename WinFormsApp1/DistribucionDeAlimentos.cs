using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class DistribucionDeAlimentos : Form
    {
        public DistribucionDeAlimentos()
        {
            InitializeComponent();
        }
        int indiceDistribucion;
        private void btnDistribuir_Click(object sender, EventArgs e)
        {
            // 1. Capturar los datos de los nuevos controles
            string alimento = cmbAlimento.Text;
            string destino = cmbDestino.Text;
            string responsable = txtResponsable.Text;
            string cantidad = numCantidadDist.Value.ToString();
            string fecha = dtpFechaDist.Value.ToShortDateString();

            // 2. Validación simple
            if (string.IsNullOrEmpty(alimento) || string.IsNullOrEmpty(responsable))
            {
                MessageBox.Show("Por favor, complete el alimento y el responsable.");
                return;
            }

            // 3. Agregar al DataGridView
            // Asegúrate de que el orden coincida con tus columnas: Fecha, Alimentos, Cantidad, Responsable
            dgvDistribucion.Rows.Add(fecha, alimento, destino, cantidad, responsable);

            // 4. Limpiar campos
            LimpiarCamposDistribucion();
        }

        private void LimpiarCamposDistribucion()
        {
            cmbAlimento.SelectedIndex = -1;
            cmbDestino.SelectedIndex = -1;
            txtResponsable.Clear();
            numCantidadDist.Value = 0;
            dtpFechaDist.Value = DateTime.Now;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (indiceDistribucion != -1)
            {
                // Actualizamos la fila seleccionada con la nueva información
                dgvDistribucion.Rows[indiceDistribucion].Cells[0].Value = dtpFechaDist.Value.ToShortDateString();
                dgvDistribucion.Rows[indiceDistribucion].Cells[1].Value = cmbAlimento.Text;
                dgvDistribucion.Rows[indiceDistribucion].Cells[2].Value = cmbDestino.Text;
                dgvDistribucion.Rows[indiceDistribucion].Cells[3].Value = numCantidadDist.Value.ToString();
                dgvDistribucion.Rows[indiceDistribucion].Cells[4].Value = txtResponsable.Text;

                MessageBox.Show("Distribución actualizada correctamente.");

                LimpiarCamposDistribucion(); // Método para vaciar los cuadros
                indiceDistribucion = -1;    // Reseteamos la selección
            }
            else
            {
                MessageBox.Show("Por favor, selecciona primero una fila de la tabla.");
            }
        }

        private void dgvDistribucion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvDistribucion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceDistribucion = e.RowIndex; // Guardamos la fila seleccionada

            // Evitamos errores si haces clic en el encabezado
            if (indiceDistribucion != -1)
            {
                // El orden de las celdas [0, 1, 2...] debe coincidir con tus columnas
                dtpFechaDist.Value = Convert.ToDateTime(dgvDistribucion.Rows[indiceDistribucion].Cells[0].Value);
                cmbAlimento.Text = dgvDistribucion.Rows[indiceDistribucion].Cells[1].Value.ToString();
                cmbDestino.Text = dgvDistribucion.Rows[indiceDistribucion].Cells[2].Value.ToString();
                numCantidadDist.Value = Convert.ToDecimal(dgvDistribucion.Rows[indiceDistribucion].Cells[3].Value);
                txtResponsable.Text = dgvDistribucion.Rows[indiceDistribucion].Cells[4].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Verificamos que haya una fila seleccionada en el DataGridView
            if (dgvDistribucion.CurrentRow != null && !dgvDistribucion.CurrentRow.IsNewRow)
            {
                // 2. Pedir confirmación (esto evita que borres algo por accidente)
                DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro de distribución?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    // 3. Eliminar la fila de la tabla dgvDistribucion
                    dgvDistribucion.Rows.RemoveAt(dgvDistribucion.CurrentRow.Index);

                    MessageBox.Show("Registro eliminado correctamente.");

                    // 4. Limpiamos los campos (el método que ya creaste)
                    LimpiarCamposDistribucion();

                    // 5. Muy importante: Reseteamos nuestra variable de índice
                    indiceDistribucion = -1;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila en la tabla para eliminar.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // 153 es el 60% de 255 (255 * 0.60 = 153)
            // Color.FromArgb(Alpha, Rojo, Verde, Azul)
            panel1.BackColor = Color.FromArgb(153, 255, 255, 255); // Fondo blanco al 60%
        }
    }
}

    
