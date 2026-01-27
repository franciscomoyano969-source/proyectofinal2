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
    public partial class GestionDePersonal : Form
    {
        public GestionDePersonal()
        {
            InitializeComponent();
        }
        int indicePersonal; // Variable para saber qué fila estamos editando
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            // 1. Capturamos los datos de los controles
            string nombre = txtNombrePers.Text;
            string cargo = cmbCargo.Text;
            string area = cmbArea.Text;
            string turno = cmbTurno.Text;
            string estado = cmbEstadoPers.Text;

            // 2. Validación: Que el nombre no esté vacío
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor, ingrese el nombre del personal.");
                return;
            }

            // 3. Agregar al DataGridView
            // El orden debe ser: Nombre, Cargo, Área, Turno, Estado
            dgvPersonal.Rows.Add(nombre, cargo, area, turno, estado);

            // 4. Limpiamos los campos
            LimpiarPersonal();
        }

        private void LimpiarPersonal()
        {
            txtNombrePers.Clear();
            cmbCargo.SelectedIndex = -1; // Recuerda: NO uses .Value = 0
            cmbArea.SelectedIndex = -1;
            cmbTurno.SelectedIndex = -1;
            cmbEstadoPers.SelectedIndex = -1;
        }

        private void dgvPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indicePersonal = e.RowIndex; // Guardamos la fila seleccionada

            if (indicePersonal != -1)
            {
                // Pasamos los datos de la tabla a los cuadros de texto y combos
                txtNombrePers.Text = dgvPersonal.Rows[indicePersonal].Cells[0].Value.ToString();
                cmbCargo.Text = dgvPersonal.Rows[indicePersonal].Cells[1].Value.ToString();
                cmbArea.Text = dgvPersonal.Rows[indicePersonal].Cells[2].Value.ToString();
                cmbTurno.Text = dgvPersonal.Rows[indicePersonal].Cells[3].Value.ToString();
                cmbEstadoPers.Text = dgvPersonal.Rows[indicePersonal].Cells[4].Value.ToString();
            }
        }

        private void btnEditar2_Click(object sender, EventArgs e)
        {
            if (indicePersonal != -1)
            {
                // Actualizamos la fila en el DataGridView
                dgvPersonal.Rows[indicePersonal].Cells[0].Value = txtNombrePers.Text;
                dgvPersonal.Rows[indicePersonal].Cells[1].Value = cmbCargo.Text;
                dgvPersonal.Rows[indicePersonal].Cells[2].Value = cmbArea.Text;
                dgvPersonal.Rows[indicePersonal].Cells[3].Value = cmbTurno.Text;
                dgvPersonal.Rows[indicePersonal].Cells[4].Value = cmbEstadoPers.Text;

                MessageBox.Show("Datos del personal actualizados con éxito.");

                LimpiarPersonal(); // Método que vacía los campos
                indicePersonal = -1; // Reseteamos la selección
            }
            else
            {
                MessageBox.Show("Por favor, selecciona primero a una persona de la tabla.");
            }
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            // 1. Verificamos que haya una fila seleccionada y que no sea la fila vacía del final
            if (dgvPersonal.CurrentRow != null && !dgvPersonal.CurrentRow.IsNewRow)
            {
                // 2. Pedimos confirmación al usuario por seguridad
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar a este empleado del registro?",
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // 3. Obtenemos el índice de la fila y la borramos
                    int indiceABorrar = dgvPersonal.CurrentRow.Index;
                    dgvPersonal.Rows.RemoveAt(indiceABorrar);

                    MessageBox.Show("Personal eliminado correctamente.");

                    // 4. Limpiamos los cuadros de texto y combos
                    LimpiarPersonal();

                    // 5. Reseteamos la variable de índice para evitar errores en editar
                    indicePersonal = -1;
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
