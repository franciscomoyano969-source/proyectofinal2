using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp5.NewFolder1
{
    public partial class ucRegistroDonacion : UserControl
    {
        public ucRegistroDonacion()
        {
            InitializeComponent();
        }
////////////////////////////
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }
////////////////////////////
        private void label1_Click(object sender, EventArgs e)
        {
        }
////////////////////////////
        private void ControlBio_Click(object sender, EventArgs e)
        {
        }
///////////////////////////
        private void ValidarCheckboxes(object sender, EventArgs e)
        {
            //check inicio sin check
            bool todosListos = checkBox1.Checked && checkBox2.Checked && checkBox3.Checked;
            ConfirmarRegistro.Enabled = todosListos;
            //Mod Visual
            ConfirmarRegistro.BackColor = todosListos ? Color.FromArgb(85, 139, 47) : Color.Gray;
             
        }
///////////////////////////
        private void TipoAlimento_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
        }
        private void CantidadAlimento_Click(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void DonanteAlimento_Click(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
///////////////////////////
        private void ConfirmarRegistro_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos de texto no estén vacíos
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Por favor, complete los datos del alimento.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Procesar la información (aquí es donde le das "utilidad")
            RegistrarDonacion();
        }

        private void RegistrarDonacion()
        {
            try
            {
                string rutaArchivo = "Registro_Donaciones.txt";
                string linea = $"{DateTime.Now} | Alimento: {textBox1.Text} | Cant: {textBox2.Text} | Donante: {textBox3.Text}";

                // Añade la línea al archivo sin borrar lo anterior
                File.AppendAllLines(rutaArchivo, new[] { linea });

                MessageBox.Show("¡Donación registrada y asegurada bajo protocolo!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Error al guardar: " + ex.Message);

            }
        }
        private void LimpiarFormulario()
        {
            // Limpia los textos
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            // Desmarca los protocolos de bioseguridad
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            // El botón se desactivará solo gracias a la función ValidarCheckboxes que hicimos antes
            textBox1.Focus(); // Pone el cursor listo para el siguiente alimento
        }


        private void ucRegistroDonacion_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ruta = "Registro_Donaciones.txt";

            // Verificamos si el archivo existe antes de leerlo
            if (File.Exists(ruta))
            {
                // Limpiamos la lista para no duplicar datos
                listBox1.Items.Clear();

                // Leemos todas las líneas y las agregamos al ListBox
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    listBox1.Items.Add(linea);
                }
            }
            else
            {
                MessageBox.Show("Aún no hay registros guardados.");
            }
        }
        ///////////////////////////
    }
}
