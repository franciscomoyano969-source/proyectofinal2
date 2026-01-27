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
    public partial class GestionDeMate : Form
    {
        public GestionDeMate()
        {
            InitializeComponent();
        }
        int posicionFila; // Variable para saber qué fila estamos editando
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Capturar los datos de los controles
            string nombre = txtNombre.Text;
            string tipo = cmbTipo.SelectedItem?.ToString();
            string fechaIngreso = dtpIngreso.Value.ToShortDateString();
            string fechaCaducidad = dtpCaducidad.Value.ToShortDateString();
            string cantidad = numCantidad.Value.ToString();
            string estado = cmbEstado.SelectedItem?.ToString();

            // 2. Validar que el nombre no esté vacío (Opcional pero recomendado)
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingrese el nombre del alimento.");
                return;
            }

            // 3. Agregar una nueva fila al DataGridView
            // El orden debe coincidir exactamente con las columnas de tu tabla
            dataGridView1.Rows.Add(nombre, tipo, fechaIngreso, fechaCaducidad, cantidad, estado);

            // 4. Limpiar los campos para un nuevo registro
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            cmbTipo.SelectedIndex = -1;
            numCantidad.Value = 0;
            cmbEstado.SelectedIndex = -1;
            dtpIngreso.Value = DateTime.Now;
            dtpCaducidad.Value = DateTime.Now;
        }

        private void GestionDeMate_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            posicionFila = e.RowIndex; // Guardamos el número de fila

            if (posicionFila != -1) // Si la fila es válida
            {
                // Pasamos los datos de la tabla a los controles
                txtNombre.Text = dataGridView1.Rows[posicionFila].Cells[0].Value.ToString();
                cmbTipo.Text = dataGridView1.Rows[posicionFila].Cells[1].Value.ToString();
                dtpIngreso.Text = dataGridView1.Rows[posicionFila].Cells[2].Value.ToString();
                dtpCaducidad.Text = dataGridView1.Rows[posicionFila].Cells[3].Value.ToString();
                numCantidad.Value = Convert.ToDecimal(dataGridView1.Rows[posicionFila].Cells[4].Value);
                cmbEstado.Text = dataGridView1.Rows[posicionFila].Cells[5].Value.ToString();
            }
        }

        private void btnEditar1_Click(object sender, EventArgs e)
        {
            // Verificamos que se haya seleccionado una fila antes
            if (posicionFila != -1)
            {
                // Actualizamos las celdas de la fila guardada en 'posicionFila'
                dataGridView1.Rows[posicionFila].Cells[0].Value = txtNombre.Text;
                dataGridView1.Rows[posicionFila].Cells[1].Value = cmbTipo.Text;
                dataGridView1.Rows[posicionFila].Cells[2].Value = dtpIngreso.Value.ToShortDateString();
                dataGridView1.Rows[posicionFila].Cells[3].Value = dtpCaducidad.Value.ToShortDateString();

                // CORRECCIÓN: Usamos el control de cantidad (NumericUpDown)
                dataGridView1.Rows[posicionFila].Cells[4].Value = numCantidad.Value.ToString();

                dataGridView1.Rows[posicionFila].Cells[5].Value = cmbEstado.Text;

                MessageBox.Show("Registro actualizado correctamente.");
                LimpiarCampos(); // Método que ya tienes para vaciar los cuadros
            }
            else
            {
                MessageBox.Show("Por favor, selecciona primero una fila de la tabla.");
            }
        }

        private void btnEliminar1_Click(object sender, EventArgs e)

        {
            // 1. Verificamos si hay al menos una fila seleccionada
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                // 2. Preguntar al usuario si está seguro (esto evita borrar por error)
                DialogResult confirmacion = MessageBox.Show("¿Seguro que deseas eliminar el alimento seleccionado?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    // 3. Obtenemos el índice de la fila actual y la eliminamos
                    int indice = dataGridView1.CurrentRow.Index;
                    dataGridView1.Rows.RemoveAt(indice);

                    MessageBox.Show("Alimento eliminado con éxito.");

                    // 4. Limpiamos los campos de texto
                    LimpiarCampos();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
