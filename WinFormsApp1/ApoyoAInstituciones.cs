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
    public partial class ApoyoAInstituciones : Form
    {
        public ApoyoAInstituciones()
        {
            InitializeComponent();
        }
        int indiceApoyo = -1; // Variable para almacenar el índice de la fila seleccionada
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // 153 es el 60% de 255 (255 * 0.60 = 153)
            // Color.FromArgb(Alpha, Rojo, Verde, Azul)
            panel1.BackColor = Color.FromArgb(153, 255, 255, 255); // Fondo blanco al 60%
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Capturamos los datos de los controles
            string institucion = cmbInstitucion.Text;
            string estado = cmbEstadoApoyo.Text;
            string justificacion = txtJustificacion.Text;
            string fecha = dtpFechaSolicitud.Value.ToShortDateString();

            // 2. Validación: Que los campos principales no estén vacíos
            if (string.IsNullOrEmpty(institucion) || string.IsNullOrEmpty(justificacion))
            {
                MessageBox.Show("Por favor, seleccione una institución e ingrese la justificación.");
                return;
            }

            // 3. Agregar al DataGridView
            // El orden debe coincidir con tus columnas: Institución, Justificación, Fecha de Solicitud, Estado
            dgvApoyo.Rows.Add(institucion, justificacion, fecha, estado);

            // 4. Limpiamos los campos para una nueva entrada
            LimpiarApoyo();
        }

        private void LimpiarApoyo()
        {
            cmbInstitucion.SelectedIndex = -1; // Recuerda: NO usar .Value
            cmbEstadoApoyo.SelectedIndex = -1;
            txtJustificacion.Clear();
            dtpFechaSolicitud.Value = DateTime.Now;
        }

        private void dgvApoyo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indiceApoyo = e.RowIndex; // Guardamos el índice de la fila seleccionada

            if (indiceApoyo != -1)
            {
                // Pasamos los datos de las celdas a los ComboBox y TextBox
                cmbInstitucion.Text = dgvApoyo.Rows[indiceApoyo].Cells[0].Value.ToString();
                txtJustificacion.Text = dgvApoyo.Rows[indiceApoyo].Cells[1].Value.ToString();
                dtpFechaSolicitud.Value = Convert.ToDateTime(dgvApoyo.Rows[indiceApoyo].Cells[2].Value);
                cmbEstadoApoyo.Text = dgvApoyo.Rows[indiceApoyo].Cells[3].Value.ToString();
            }
        }

        private void btnEditar3_Click(object sender, EventArgs e)
        {
            if (indiceApoyo != -1)
            {
                // Actualizamos la fila en el DataGridView dgvApoyo
                dgvApoyo.Rows[indiceApoyo].Cells[0].Value = cmbInstitucion.Text;
                dgvApoyo.Rows[indiceApoyo].Cells[1].Value = txtJustificacion.Text;
                dgvApoyo.Rows[indiceApoyo].Cells[2].Value = dtpFechaSolicitud.Value.ToShortDateString();
                dgvApoyo.Rows[indiceApoyo].Cells[3].Value = cmbEstadoApoyo.Text;

                MessageBox.Show("Solicitud de apoyo actualizada con éxito.");

                LimpiarApoyo(); // Vaciamos los campos
                indiceApoyo = -1; // Reseteamos la selección
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila de la tabla primero.");
            }
        }

        private void btnEliminar3_Click(object sender, EventArgs e)
        {
            // 1. Verificamos que haya una fila seleccionada y que no sea la fila vacía del final
            if (dgvApoyo.CurrentRow != null && !dgvApoyo.CurrentRow.IsNewRow)
            {
                // 2. Pedimos confirmación al usuario para evitar borrados accidentales
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta solicitud de apoyo?",
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // 3. Obtenemos el índice y eliminamos la fila del DataGridView
                    int indiceABorrar = dgvApoyo.CurrentRow.Index;
                    dgvApoyo.Rows.RemoveAt(indiceABorrar);

                    MessageBox.Show("Solicitud eliminada correctamente.");

                    // 4. Limpiamos los cuadros de texto y combos para refrescar la vista
                    LimpiarApoyo();

                    // 5. Reseteamos la variable de índice para que el botón Editar no falle
                    indiceApoyo = -1;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila en la tabla para eliminar.");
            }
        }
    }
}
