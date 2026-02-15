namespace PROYECTO
{
    partial class GestionDeMate
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            FechadeIngreso = new DataGridViewTextBoxColumn();
            FechadeCaducida = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            btnEliminar2 = new Button();
            btnEditar1 = new Button();
            btnRegistrar = new Button();
            cmbEstado = new ComboBox();
            cmbTipo = new ComboBox();
            dtpCaducidad = new DateTimePicker();
            dtpIngreso = new DateTimePicker();
            txtNombre = new TextBox();
            numCantidad = new NumericUpDown();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Tipo, FechadeIngreso, FechadeCaducida, Cantidad, Estado });
            dataGridView1.Location = new Point(5, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(558, 222);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.Width = 80;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.Width = 75;
            // 
            // FechadeIngreso
            // 
            FechadeIngreso.HeaderText = "Fecha de Ingreso";
            FechadeIngreso.Name = "FechadeIngreso";
            // 
            // FechadeCaducida
            // 
            FechadeCaducida.HeaderText = "Fecha de Caducidad";
            FechadeCaducida.Name = "FechadeCaducida";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 80;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, -2);
            label1.Name = "label1";
            label1.Size = new Size(231, 33);
            label1.TabIndex = 1;
            label1.Text = "Catálogo de Alimentos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label2.Location = new Point(7, 41);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 2;
            label2.Text = "Nombre de alimentos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label3.Location = new Point(3, 74);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 3;
            label3.Text = "Fecha de ingreso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label4.Location = new Point(3, 100);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 4;
            label4.Text = "Cantidad:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label5.Location = new Point(300, 41);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 5;
            label5.Text = "Tipo de alimentos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label6.Location = new Point(300, 74);
            label6.Name = "label6";
            label6.Size = new Size(131, 21);
            label6.TabIndex = 6;
            label6.Text = "Fecha de caducidad:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label7.Location = new Point(300, 100);
            label7.Name = "label7";
            label7.Size = new Size(55, 21);
            label7.TabIndex = 7;
            label7.Text = "Estado:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnEliminar2);
            panel1.Controls.Add(btnEditar1);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(cmbEstado);
            panel1.Controls.Add(cmbTipo);
            panel1.Controls.Add(dtpCaducidad);
            panel1.Controls.Add(dtpIngreso);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(numCantidad);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(5, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 138);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // btnEliminar2
            // 
            btnEliminar2.BackColor = Color.Red;
            btnEliminar2.FlatAppearance.BorderSize = 0;
            btnEliminar2.FlatStyle = FlatStyle.Flat;
            btnEliminar2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar2.Location = new Point(447, 3);
            btnEliminar2.Name = "btnEliminar2";
            btnEliminar2.Size = new Size(80, 29);
            btnEliminar2.TabIndex = 16;
            btnEliminar2.Text = "Eliminar";
            btnEliminar2.UseVisualStyleBackColor = false;
            btnEliminar2.Click += btnEliminar1_Click;
            // 
            // btnEditar1
            // 
            btnEditar1.BackColor = Color.Aquamarine;
            btnEditar1.FlatAppearance.BorderSize = 0;
            btnEditar1.FlatStyle = FlatStyle.Flat;
            btnEditar1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar1.Location = new Point(366, 3);
            btnEditar1.Name = "btnEditar1";
            btnEditar1.Size = new Size(75, 29);
            btnEditar1.TabIndex = 15;
            btnEditar1.Text = "Editar";
            btnEditar1.UseVisualStyleBackColor = false;
            btnEditar1.Click += btnEditar1_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.GreenYellow;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(285, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 29);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.Font = new Font("Dubai Medium", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Disponible", "Reservado", "Distribuido", "Agotado", "Próximo a caducar", "Caducado" });
            cmbEstado.Location = new Point(352, 100);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(187, 29);
            cmbEstado.TabIndex = 13;
            // 
            // cmbTipo
            // 
            cmbTipo.Font = new Font("Dubai", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Granos", "Cereales", "Harinas", "Legumbres", "Lácteos", "Carnes", "Pescados y mariscos", "Huevos", "Frutas", "Verduras", "Productos horneados", "Productos procesados", "Embutidos", "Bebidas", "Bebidas lácteas", "Condimentos", "Aceites y grasas" });
            cmbTipo.Location = new Point(415, 38);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(124, 29);
            cmbTipo.TabIndex = 12;
            // 
            // dtpCaducidad
            // 
            dtpCaducidad.Font = new Font("Segoe Print", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpCaducidad.Location = new Point(425, 69);
            dtpCaducidad.Name = "dtpCaducidad";
            dtpCaducidad.Size = new Size(124, 27);
            dtpCaducidad.TabIndex = 11;
            // 
            // dtpIngreso
            // 
            dtpIngreso.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpIngreso.Location = new Point(120, 71);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(174, 29);
            dtpIngreso.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Dubai", 8.999999F);
            txtNombre.Location = new Point(146, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(148, 28);
            txtNombre.TabIndex = 9;
            // 
            // numCantidad
            // 
            numCantidad.Font = new Font("Dubai", 8.999999F);
            numCantidad.Location = new Point(80, 98);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(64, 28);
            numCantidad.TabIndex = 8;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // GestionDeMate
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(569, 405);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionDeMate";
            Opacity = 0.8D;
            Text = "GestionDeMate";
            Load += GestionDeMate_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private TextBox txtNombre;
        private NumericUpDown numCantidad;
        private FileSystemWatcher fileSystemWatcher1;
        private DateTimePicker dtpIngreso;
        private ComboBox cmbEstado;
        private ComboBox cmbTipo;
        private DateTimePicker dtpCaducidad;
        private Button btnEliminar2;
        private Button btnEditar1;
        private Button btnRegistrar;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn FechadeIngreso;
        private DataGridViewTextBoxColumn FechadeCaducida;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Estado;
    }
}