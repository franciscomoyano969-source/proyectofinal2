namespace PROYECTO
{
    partial class ApoyoAInstituciones
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvApoyo = new DataGridView();
            Institucion = new DataGridViewTextBoxColumn();
            Justificacion = new DataGridViewTextBoxColumn();
            FechadeSolicitud = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            cmbInstitucion = new ComboBox();
            cmbEstadoApoyo = new ComboBox();
            txtJustificacion = new TextBox();
            btnEliminar3 = new Button();
            btnEditar3 = new Button();
            btnRegistrar = new Button();
            dtpFechaSolicitud = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvApoyo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvApoyo
            // 
            dgvApoyo.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvApoyo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvApoyo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApoyo.Columns.AddRange(new DataGridViewColumn[] { Institucion, Justificacion, FechadeSolicitud, Estado });
            dgvApoyo.Location = new Point(5, 177);
            dgvApoyo.Name = "dgvApoyo";
            dgvApoyo.Size = new Size(494, 248);
            dgvApoyo.TabIndex = 0;
            dgvApoyo.CellContentClick += dgvApoyo_CellContentClick;
            // 
            // Institucion
            // 
            Institucion.HeaderText = "Institución";
            Institucion.Name = "Institucion";
            Institucion.Width = 130;
            // 
            // Justificacion
            // 
            Justificacion.HeaderText = "Justificación";
            Justificacion.Name = "Justificacion";
            // 
            // FechadeSolicitud
            // 
            FechadeSolicitud.HeaderText = "Fecha de Solicitud";
            FechadeSolicitud.Name = "FechadeSolicitud";
            FechadeSolicitud.Width = 130;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.Width = 90;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(cmbInstitucion);
            panel1.Controls.Add(cmbEstadoApoyo);
            panel1.Controls.Add(txtJustificacion);
            panel1.Controls.Add(btnEliminar3);
            panel1.Controls.Add(btnEditar3);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(dtpFechaSolicitud);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(5, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 136);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // cmbInstitucion
            // 
            cmbInstitucion.Font = new Font("Dubai", 8.999999F);
            cmbInstitucion.FormattingEnabled = true;
            cmbInstitucion.Items.AddRange(new object[] { "Comedor Comunitario", "Comedor La Esperanza", "Banco de Alimentos", "Cocina Comunitaria", "Hogar Infantil", "Guardería", "Centro Educativo", "Escuela Pública", "Centro de Adultos Mayores", "Casa de Acogida", "Orfanato", "Parroquia", "Parroquia San José", "Iglesia", "Fundación Comunitaria", "Centro de Salud", "Hospital", "Cruz Roja", "Defensa Civil", "ONG", "Fundación Social", "Junta Barrial" });
            cmbInstitucion.Location = new Point(84, 42);
            cmbInstitucion.Name = "cmbInstitucion";
            cmbInstitucion.Size = new Size(149, 29);
            cmbInstitucion.TabIndex = 21;
            // 
            // cmbEstadoApoyo
            // 
            cmbEstadoApoyo.Font = new Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEstadoApoyo.FormattingEnabled = true;
            cmbEstadoApoyo.Items.AddRange(new object[] { "Pendiente", "Aprobado", "Rechazado" });
            cmbEstadoApoyo.Location = new Point(346, 41);
            cmbEstadoApoyo.Name = "cmbEstadoApoyo";
            cmbEstadoApoyo.Size = new Size(133, 29);
            cmbEstadoApoyo.TabIndex = 20;
            // 
            // txtJustificacion
            // 
            txtJustificacion.Font = new Font("Dubai", 8.999999F);
            txtJustificacion.Location = new Point(97, 76);
            txtJustificacion.Name = "txtJustificacion";
            txtJustificacion.Size = new Size(265, 28);
            txtJustificacion.TabIndex = 19;
            // 
            // btnEliminar3
            // 
            btnEliminar3.BackColor = Color.Red;
            btnEliminar3.FlatAppearance.BorderSize = 0;
            btnEliminar3.FlatStyle = FlatStyle.Flat;
            btnEliminar3.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            btnEliminar3.Location = new Point(394, 3);
            btnEliminar3.Name = "btnEliminar3";
            btnEliminar3.Size = new Size(72, 35);
            btnEliminar3.TabIndex = 17;
            btnEliminar3.Text = "Eliminar";
            btnEliminar3.UseVisualStyleBackColor = false;
            btnEliminar3.Click += btnEliminar3_Click;
            // 
            // btnEditar3
            // 
            btnEditar3.BackColor = Color.Aquamarine;
            btnEditar3.FlatAppearance.BorderSize = 0;
            btnEditar3.FlatStyle = FlatStyle.Flat;
            btnEditar3.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            btnEditar3.Location = new Point(325, 3);
            btnEditar3.Name = "btnEditar3";
            btnEditar3.Size = new Size(67, 35);
            btnEditar3.TabIndex = 16;
            btnEditar3.Text = "Editar";
            btnEditar3.UseVisualStyleBackColor = false;
            btnEditar3.Click += btnEditar3_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.GreenYellow;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            btnRegistrar.Location = new Point(249, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(73, 35);
            btnRegistrar.TabIndex = 15;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dtpFechaSolicitud
            // 
            dtpFechaSolicitud.Font = new Font("Segoe Print", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaSolicitud.Location = new Point(128, 107);
            dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            dtpFechaSolicitud.Size = new Size(234, 27);
            dtpFechaSolicitud.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(287, 47);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 3;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 109);
            label4.Name = "label4";
            label4.Size = new Size(119, 21);
            label4.TabIndex = 2;
            label4.Text = "Fecha de solicitud:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 44);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 1;
            label3.Text = "Institución:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 78);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 0;
            label2.Text = "Justificación:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(8, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 33);
            label1.TabIndex = 2;
            label1.Text = "Solicitud de Apoyo";
            // 
            // ApoyoAInstituciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(506, 430);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dgvApoyo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ApoyoAInstituciones";
            Text = "ApoyoAInstituciones";
            ((System.ComponentModel.ISupportInitialize)dgvApoyo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvApoyo;
        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpFechaSolicitud;
        private Button btnEliminar3;
        private Button btnEditar3;
        private Button btnRegistrar;
        private TextBox txtJustificacion;
        private ComboBox cmbEstadoApoyo;
        private ComboBox cmbInstitucion;
        private DataGridViewTextBoxColumn Institucion;
        private DataGridViewTextBoxColumn Justificacion;
        private DataGridViewTextBoxColumn FechadeSolicitud;
        private DataGridViewTextBoxColumn Estado;
    }
}