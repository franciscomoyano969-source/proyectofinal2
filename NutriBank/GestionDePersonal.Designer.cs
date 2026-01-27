namespace PROYECTO
{
    partial class GestionDePersonal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvPersonal = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Área = new DataGridViewTextBoxColumn();
            Turno = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnEliminar2 = new Button();
            btnEditar2 = new Button();
            btnRegistro = new Button();
            cmbTurno = new ComboBox();
            cmbCargo = new ComboBox();
            cmbEstadoPers = new ComboBox();
            cmbArea = new ComboBox();
            txtNombrePers = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPersonal).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPersonal
            // 
            dgvPersonal.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPersonal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonal.Columns.AddRange(new DataGridViewColumn[] { Nombre, Cargo, Área, Turno, Estado });
            dgvPersonal.Location = new Point(3, 183);
            dgvPersonal.Name = "dgvPersonal";
            dgvPersonal.Size = new Size(543, 229);
            dgvPersonal.TabIndex = 0;
            dgvPersonal.CellContentClick += dgvPersonal_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Cargo
            // 
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
            // 
            // Área
            // 
            Área.HeaderText = "Área";
            Área.Name = "Área";
            // 
            // Turno
            // 
            Turno.HeaderText = "Turno";
            Turno.Name = "Turno";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEliminar2);
            panel1.Controls.Add(btnEditar2);
            panel1.Controls.Add(btnRegistro);
            panel1.Controls.Add(cmbTurno);
            panel1.Controls.Add(cmbCargo);
            panel1.Controls.Add(cmbEstadoPers);
            panel1.Controls.Add(cmbArea);
            panel1.Controls.Add(txtNombrePers);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F);
            panel1.Location = new Point(3, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(543, 142);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnEliminar2
            // 
            btnEliminar2.BackColor = Color.Red;
            btnEliminar2.FlatAppearance.BorderSize = 0;
            btnEliminar2.FlatStyle = FlatStyle.Flat;
            btnEliminar2.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            btnEliminar2.Location = new Point(448, 3);
            btnEliminar2.Name = "btnEliminar2";
            btnEliminar2.Size = new Size(82, 33);
            btnEliminar2.TabIndex = 15;
            btnEliminar2.Text = "Eliminar";
            btnEliminar2.UseVisualStyleBackColor = false;
            btnEliminar2.Click += btnEliminar2_Click;
            // 
            // btnEditar2
            // 
            btnEditar2.BackColor = Color.Aquamarine;
            btnEditar2.FlatAppearance.BorderSize = 0;
            btnEditar2.FlatStyle = FlatStyle.Flat;
            btnEditar2.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            btnEditar2.Location = new Point(360, 3);
            btnEditar2.Name = "btnEditar2";
            btnEditar2.Size = new Size(82, 33);
            btnEditar2.TabIndex = 14;
            btnEditar2.Text = "Editar";
            btnEditar2.UseVisualStyleBackColor = false;
            btnEditar2.Click += btnEditar2_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.GreenYellow;
            btnRegistro.FlatAppearance.BorderSize = 0;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.Location = new Point(272, 3);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(82, 33);
            btnRegistro.TabIndex = 13;
            btnRegistro.Text = "Registro";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // cmbTurno
            // 
            cmbTurno.Font = new Font("Dubai", 8.249999F);
            cmbTurno.FormattingEnabled = true;
            cmbTurno.Items.AddRange(new object[] { "Mañana → 08:00 – 12:00", "Tarde → 13:00 – 17:00", "Noche → 18:00 – 22:00" });
            cmbTurno.Location = new Point(281, 72);
            cmbTurno.Name = "cmbTurno";
            cmbTurno.Size = new Size(180, 26);
            cmbTurno.TabIndex = 11;
            // 
            // cmbCargo
            // 
            cmbCargo.Font = new Font("Dubai", 8.249999F);
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Almacenero", "Despachador", "Auxiliar de Almacén", "Repartidor", "Coordinador de Distribución", "Supervisor de Logística", "Recepcionista", "Control de Inventario", "Administrador", "Coordinador Administrativo", "Asistente Administrativo", "Digitador", "Voluntario", "Trabajador Social", "Gestor Comunitario", "Guardia", "Responsable de Seguridad" });
            cmbCargo.Location = new Point(281, 40);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(180, 26);
            cmbCargo.TabIndex = 10;
            // 
            // cmbEstadoPers
            // 
            cmbEstadoPers.Font = new Font("Dubai", 8.249999F);
            cmbEstadoPers.FormattingEnabled = true;
            cmbEstadoPers.Items.AddRange(new object[] { "Activo", "Inactivo", "Suspendido", "Vacaciones", "Licencia", "Retirado" });
            cmbEstadoPers.Location = new Point(61, 103);
            cmbEstadoPers.Name = "cmbEstadoPers";
            cmbEstadoPers.Size = new Size(166, 26);
            cmbEstadoPers.TabIndex = 9;
            // 
            // cmbArea
            // 
            cmbArea.Font = new Font("Dubai", 8.249999F);
            cmbArea.FormattingEnabled = true;
            cmbArea.Items.AddRange(new object[] { "Almacén", "Logística", "Distribución", "Producción", "Administración", "Finanzas", "Recursos Humanos", "Planificación", "Apoyo Comunitario", "Trabajo Social", "Voluntariado", "Seguridad", "Control de Calidad" });
            cmbArea.Location = new Point(50, 72);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(177, 26);
            cmbArea.TabIndex = 8;
            // 
            // txtNombrePers
            // 
            txtNombrePers.Font = new Font("Dubai", 8.249999F);
            txtNombrePers.Location = new Point(70, 40);
            txtNombrePers.Name = "txtNombrePers";
            txtNombrePers.Size = new Size(157, 26);
            txtNombrePers.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label6.Location = new Point(233, 75);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 5;
            label6.Text = "Turno:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label5.Location = new Point(233, 43);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 4;
            label5.Text = "Cargo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label4.Location = new Point(10, 106);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 3;
            label4.Text = "Estado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label3.Location = new Point(10, 75);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 2;
            label3.Text = "Area:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 43);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, -1);
            label1.Name = "label1";
            label1.Size = new Size(214, 33);
            label1.TabIndex = 0;
            label1.Text = "Registro de Personal";
            // 
            // GestionDePersonal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(550, 416);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dgvPersonal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionDePersonal";
            Text = "GestionDePersonal";
            ((System.ComponentModel.ISupportInitialize)dgvPersonal).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPersonal;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Área;
        private DataGridViewTextBoxColumn Turno;
        private DataGridViewTextBoxColumn Estado;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNombrePers;
        private Button btnEliminar2;
        private Button btnEditar2;
        private Button btnRegistro;
        private ComboBox cmbTurno;
        private ComboBox cmbCargo;
        private ComboBox cmbEstadoPers;
        private ComboBox cmbArea;
    }
}