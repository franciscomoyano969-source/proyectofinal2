namespace PROYECTO
{
    partial class DistribucionDeAlimentos
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvDistribucion = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Alimetos = new DataGridViewTextBoxColumn();
            Destino = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Responsable = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1 = new Panel();
            numCantidadDist = new NumericUpDown();
            txtResponsable = new TextBox();
            cmbDestino = new ComboBox();
            cmbAlimento = new ComboBox();
            btnEliminar = new Button();
            btnEditar2 = new Button();
            btnDistribui = new Button();
            dtpFechaDist = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)dgvDistribucion).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidadDist).BeginInit();
            SuspendLayout();
            // 
            // dgvDistribucion
            // 
            dgvDistribucion.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe Print", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDistribucion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDistribucion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDistribucion.Columns.AddRange(new DataGridViewColumn[] { Fecha, Alimetos, Destino, Cantidad, Responsable });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Dubai Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvDistribucion.DefaultCellStyle = dataGridViewCellStyle5;
            dgvDistribucion.Location = new Point(9, 189);
            dgvDistribucion.Name = "dgvDistribucion";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvDistribucion.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvDistribucion.Size = new Size(519, 241);
            dgvDistribucion.TabIndex = 0;
            dgvDistribucion.CellClick += dgvDistribucion_CellClick;
            dgvDistribucion.CellContentClick += dgvDistribucion_CellContentClick;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Alimetos
            // 
            Alimetos.HeaderText = "Alimetos";
            Alimetos.Name = "Alimetos";
            // 
            // Destino
            // 
            Destino.HeaderText = "Destino";
            Destino.Name = "Destino";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 80;
            // 
            // Responsable
            // 
            Responsable.HeaderText = "Responsable";
            Responsable.Name = "Responsable";
            Responsable.Width = 95;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 1);
            label1.Name = "label1";
            label1.Size = new Size(246, 33);
            label1.TabIndex = 1;
            label1.Text = "Registro de Distribución";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(numCantidadDist);
            panel1.Controls.Add(txtResponsable);
            panel1.Controls.Add(cmbDestino);
            panel1.Controls.Add(cmbAlimento);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar2);
            panel1.Controls.Add(btnDistribui);
            panel1.Controls.Add(dtpFechaDist);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(9, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(519, 147);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // numCantidadDist
            // 
            numCantidadDist.Font = new Font("Dubai", 8.999999F);
            numCantidadDist.Location = new Point(298, 62);
            numCantidadDist.Name = "numCantidadDist";
            numCantidadDist.Size = new Size(120, 28);
            numCantidadDist.TabIndex = 18;
            // 
            // txtResponsable
            // 
            txtResponsable.Font = new Font("Dubai", 8.999999F);
            txtResponsable.Location = new Point(98, 103);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(123, 28);
            txtResponsable.TabIndex = 17;
            // 
            // cmbDestino
            // 
            cmbDestino.Font = new Font("Dubai", 8.999999F);
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Items.AddRange(new object[] { "Comedor Comunitario", "Hogar Infantil", "Centro de Adultos Mayores", "Orfanato", "Casa de Acogida", "Parroquia", "Iglesia", "Fundación Social", "ONG", "Junta Barrial", "Centro de Salud", "Hospital", "Cruz Roja", "Defensa Civil", "Centro Comunitario", "Centro Barrial", "Casa Comunal", "Centro Local", "Familias Beneficiarias", "Personas Vulnerables", "Entrega Domiciliaria", "Brigada de Ayuda", "Escuela Pública", "Colegio Fiscal", "Guardería", "Centro Educativo" });
            cmbDestino.Location = new Point(73, 63);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(148, 29);
            cmbDestino.TabIndex = 16;
            // 
            // cmbAlimento
            // 
            cmbAlimento.Font = new Font("Dubai", 8.999999F);
            cmbAlimento.FormattingEnabled = true;
            cmbAlimento.Items.AddRange(new object[] { "Arroz", "Lentejas", "Frejol", "Garbanzos", "Fideos", "Azúcar", "Sal", "Pan", "Galletas", "Harina de trigo", "Avena", "Leche", "Yogur", "Queso", "Manzanas", "Naranjas", "Banano", "Papaya", "Manzanas", "Naranjas", "Banano", "Papaya", "Pollo", "Carne de res", "Huevos", "Pescado", "Agua", "Jugo de naranja", "Jugo de frutas", "Aceite vegetal", "Mantequilla", "Condimentos básicos" });
            cmbAlimento.Location = new Point(87, 28);
            cmbAlimento.Name = "cmbAlimento";
            cmbAlimento.Size = new Size(143, 29);
            cmbAlimento.TabIndex = 15;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            btnEliminar.Location = new Point(407, 16);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(70, 30);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar2
            // 
            btnEditar2.BackColor = Color.Aquamarine;
            btnEditar2.FlatAppearance.BorderSize = 0;
            btnEditar2.FlatStyle = FlatStyle.Flat;
            btnEditar2.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            btnEditar2.Location = new Point(338, 16);
            btnEditar2.Name = "btnEditar2";
            btnEditar2.Size = new Size(67, 30);
            btnEditar2.TabIndex = 13;
            btnEditar2.Text = "Editar";
            btnEditar2.UseVisualStyleBackColor = false;
            btnEditar2.Click += btnEditar_Click;
            // 
            // btnDistribui
            // 
            btnDistribui.BackColor = Color.GreenYellow;
            btnDistribui.FlatAppearance.BorderSize = 0;
            btnDistribui.FlatStyle = FlatStyle.Flat;
            btnDistribui.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            btnDistribui.Location = new Point(261, 16);
            btnDistribui.Name = "btnDistribui";
            btnDistribui.Size = new Size(74, 30);
            btnDistribui.TabIndex = 12;
            btnDistribui.Text = "Distribuir";
            btnDistribui.UseVisualStyleBackColor = false;
            btnDistribui.Click += btnDistribuir_Click;
            // 
            // dtpFechaDist
            // 
            dtpFechaDist.Font = new Font("Segoe Print", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaDist.Location = new Point(371, 99);
            dtpFechaDist.Name = "dtpFechaDist";
            dtpFechaDist.Size = new Size(134, 27);
            dtpFechaDist.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label6.Location = new Point(227, 99);
            label6.Name = "label6";
            label6.Size = new Size(140, 21);
            label6.TabIndex = 6;
            label6.Text = "Fecha de distribución:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label5.Location = new Point(227, 63);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 5;
            label5.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label4.Location = new Point(15, 105);
            label4.Name = "label4";
            label4.Size = new Size(85, 21);
            label4.TabIndex = 4;
            label4.Text = "Responsable:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label3.Location = new Point(15, 66);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 3;
            label3.Text = "Destino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 30);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 2;
            label2.Text = "Alimento:";
            // 
            // DistribucionDeAlimentos
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(536, 439);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgvDistribucion);
            Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DistribucionDeAlimentos";
            Text = "DistribucionDeAlimentos";
            ((System.ComponentModel.ISupportInitialize)dgvDistribucion).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidadDist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDistribucion;
        private Label label1;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbDestino;
        private ComboBox cmbAlimento;
        private NumericUpDown numCantidadDist;
        private TextBox txtResponsable;
        private DateTimePicker dtpFechaDist;
        private Button btnEliminar;
        private Button btnEditar2;
        private Button btnDistribui;
        private ColorDialog colorDialog1;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Alimetos;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Responsable;
    }
}