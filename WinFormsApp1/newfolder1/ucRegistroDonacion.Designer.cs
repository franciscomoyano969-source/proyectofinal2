namespace WindowsFormsApp5.NewFolder1
{
    partial class ucRegistroDonacion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRegistroDonacion));
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            checkBox3 = new CheckBox();
            ControlBio = new Label();
            panel1 = new Panel();
            ConfirmarRegistro = new Button();
            CantidadAlimento = new Label();
            textBox3 = new TextBox();
            DonanteAlimento = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            TipoAlimento = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.19094F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.80906F));
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel2.Size = new Size(541, 269);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(ControlBio);
            panel2.Location = new Point(269, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(18, 19, 18, 19);
            panel2.Size = new Size(265, 255);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(checkBox2);
            flowLayoutPanel1.Controls.Add(checkBox1);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(checkBox3);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(0, 83);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(265, 172);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // checkBox2
            // 
            checkBox2.BackgroundImageLayout = ImageLayout.Zoom;
            checkBox2.CheckAlign = ContentAlignment.BottomCenter;
            checkBox2.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox2.ForeColor = Color.DarkGreen;
            checkBox2.Location = new Point(3, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(164, 50);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Empaquetar";
            checkBox2.TextAlign = ContentAlignment.BottomRight;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += ValidarCheckboxes;
            // 
            // checkBox1
            // 
            checkBox1.BackgroundImageLayout = ImageLayout.Zoom;
            checkBox1.CheckAlign = ContentAlignment.BottomCenter;
            checkBox1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.DarkGreen;
            checkBox1.Location = new Point(3, 59);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(164, 45);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Guantes";
            checkBox1.TextAlign = ContentAlignment.MiddleRight;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += ValidarCheckboxes;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(3, 110);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(14, 8);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // checkBox3
            // 
            checkBox3.BackgroundImageLayout = ImageLayout.Zoom;
            checkBox3.CheckAlign = ContentAlignment.BottomCenter;
            checkBox3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox3.ForeColor = Color.DarkGreen;
            checkBox3.Location = new Point(3, 124);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(164, 44);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Limpieza";
            checkBox3.TextAlign = ContentAlignment.MiddleRight;
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += ValidarCheckboxes;
            // 
            // ControlBio
            // 
            ControlBio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ControlBio.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ControlBio.ImageAlign = ContentAlignment.MiddleRight;
            ControlBio.Location = new Point(0, 1);
            ControlBio.Name = "ControlBio";
            ControlBio.Size = new Size(265, 78);
            ControlBio.TabIndex = 0;
            ControlBio.Text = "Control\r\nDe\r\nBioseguridad\r\n\r\n";
            ControlBio.TextAlign = ContentAlignment.MiddleCenter;
            ControlBio.Click += ControlBio_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(ConfirmarRegistro);
            panel1.Controls.Add(CantidadAlimento);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(DonanteAlimento);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(TipoAlimento);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(18, 19, 18, 19);
            panel1.Size = new Size(260, 255);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // ConfirmarRegistro
            // 
            ConfirmarRegistro.BackgroundImage = (Image)resources.GetObject("ConfirmarRegistro.BackgroundImage");
            ConfirmarRegistro.BackgroundImageLayout = ImageLayout.Stretch;
            ConfirmarRegistro.FlatAppearance.BorderSize = 0;
            ConfirmarRegistro.FlatStyle = FlatStyle.Flat;
            ConfirmarRegistro.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConfirmarRegistro.Location = new Point(204, 198);
            ConfirmarRegistro.Name = "ConfirmarRegistro";
            ConfirmarRegistro.Size = new Size(56, 53);
            ConfirmarRegistro.TabIndex = 9;
            ConfirmarRegistro.UseVisualStyleBackColor = true;
            ConfirmarRegistro.Click += ConfirmarRegistro_Click;
            // 
            // CantidadAlimento
            // 
            CantidadAlimento.AutoSize = true;
            CantidadAlimento.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CantidadAlimento.Location = new Point(10, 81);
            CantidadAlimento.Name = "CantidadAlimento";
            CantidadAlimento.Size = new Size(187, 28);
            CantidadAlimento.TabIndex = 8;
            CantidadAlimento.Text = "Cantidad de alimento";
            CantidadAlimento.Click += CantidadAlimento_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(59, 190);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(88, 21);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // DonanteAlimento
            // 
            DonanteAlimento.AutoSize = true;
            DonanteAlimento.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DonanteAlimento.Location = new Point(10, 159);
            DonanteAlimento.Name = "DonanteAlimento";
            DonanteAlimento.Size = new Size(186, 28);
            DonanteAlimento.TabIndex = 6;
            DonanteAlimento.Text = "Donante del alimento";
            DonanteAlimento.Click += DonanteAlimento_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(59, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(88, 21);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(59, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(88, 21);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // TipoAlimento
            // 
            TipoAlimento.AutoSize = true;
            TipoAlimento.BackColor = Color.Transparent;
            TipoAlimento.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TipoAlimento.Location = new Point(10, 8);
            TipoAlimento.Name = "TipoAlimento";
            TipoAlimento.Size = new Size(148, 28);
            TipoAlimento.TabIndex = 0;
            TipoAlimento.Text = "Tipo de alimento";
            TipoAlimento.Click += TipoAlimento_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(5, 278);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(447, 139);
            listBox1.TabIndex = 11;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkOliveGreen;
            button1.Location = new Point(458, 359);
            button1.Name = "button1";
            button1.Size = new Size(66, 58);
            button1.TabIndex = 12;
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ucRegistroDonacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(tableLayoutPanel2);
            DoubleBuffered = true;
            Name = "ucRegistroDonacion";
            Size = new Size(543, 428);
            Load += ucRegistroDonacion_Load;
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TipoAlimento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ControlBio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label DonanteAlimento;
        private System.Windows.Forms.Label CantidadAlimento;
        private System.Windows.Forms.Button ConfirmarRegistro;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}
