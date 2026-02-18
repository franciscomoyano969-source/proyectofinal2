namespace ParteInteractivaPY
{
    partial class FACIL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FACIL));
            listHorizontales = new ListBox();
            listVerticales = new ListBox();
            label1 = new Label();
            ptbRegreso = new PictureBox();
            btnVerificar = new Button();
            btnLimpiar = new Button();
            panel1 = new Panel();
            textBox20 = new TextBox();
            textBox19 = new TextBox();
            textBox18 = new TextBox();
            textBox17 = new TextBox();
            textBox16 = new TextBox();
            textBox15 = new TextBox();
            textBox14 = new TextBox();
            textBox13 = new TextBox();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            picsalir = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbRegreso).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picsalir).BeginInit();
            SuspendLayout();
            // 
            // listHorizontales
            // 
            listHorizontales.FormattingEnabled = true;
            listHorizontales.Location = new Point(12, 89);
            listHorizontales.Name = "listHorizontales";
            listHorizontales.Size = new Size(255, 109);
            listHorizontales.TabIndex = 1;
            listHorizontales.SelectedIndexChanged += listHorizontales_SelectedIndexChanged;
            // 
            // listVerticales
            // 
            listVerticales.FormattingEnabled = true;
            listVerticales.Location = new Point(12, 218);
            listVerticales.Name = "listVerticales";
            listVerticales.Size = new Size(255, 124);
            listVerticales.TabIndex = 2;
            listVerticales.SelectedIndexChanged += listVerticales_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 17);
            label1.Name = "label1";
            label1.Size = new Size(310, 47);
            label1.TabIndex = 3;
            label1.Text = "CRUCIGRAMA FACIL";
            // 
            // ptbRegreso
            // 
            ptbRegreso.BackColor = Color.Transparent;
            ptbRegreso.BackgroundImage = (Image)resources.GetObject("ptbRegreso.BackgroundImage");
            ptbRegreso.BackgroundImageLayout = ImageLayout.Stretch;
            ptbRegreso.Cursor = Cursors.Hand;
            ptbRegreso.Location = new Point(12, 12);
            ptbRegreso.Name = "ptbRegreso";
            ptbRegreso.Size = new Size(50, 50);
            ptbRegreso.TabIndex = 6;
            ptbRegreso.TabStop = false;
            ptbRegreso.Click += pictureBox1_Click;
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.GreenYellow;
            btnVerificar.Cursor = Cursors.Hand;
            btnVerificar.FlatAppearance.BorderSize = 0;
            btnVerificar.FlatStyle = FlatStyle.Flat;
            btnVerificar.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificar.Location = new Point(472, 372);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(83, 35);
            btnVerificar.TabIndex = 7;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Salmon;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(594, 372);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(83, 35);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(textBox20);
            panel1.Controls.Add(textBox19);
            panel1.Controls.Add(textBox18);
            panel1.Controls.Add(textBox17);
            panel1.Controls.Add(textBox16);
            panel1.Controls.Add(textBox15);
            panel1.Controls.Add(textBox14);
            panel1.Controls.Add(textBox13);
            panel1.Controls.Add(textBox12);
            panel1.Controls.Add(textBox11);
            panel1.Controls.Add(textBox10);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(345, 107);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 212);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // textBox20
            // 
            textBox20.Location = new Point(119, 157);
            textBox20.Multiline = true;
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(22, 23);
            textBox20.TabIndex = 36;
            textBox20.KeyPress += SoloUnaLetra;
            // 
            // textBox19
            // 
            textBox19.Location = new Point(92, 157);
            textBox19.Multiline = true;
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(22, 23);
            textBox19.TabIndex = 35;
            textBox19.KeyPress += SoloUnaLetra;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(119, 101);
            textBox18.Multiline = true;
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(22, 23);
            textBox18.TabIndex = 34;
            textBox18.KeyPress += SoloUnaLetra;
            // 
            // textBox17
            // 
            textBox17.Location = new Point(92, 101);
            textBox17.Multiline = true;
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(22, 23);
            textBox17.TabIndex = 33;
            textBox17.KeyPress += SoloUnaLetra;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(65, 101);
            textBox16.Multiline = true;
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(22, 23);
            textBox16.TabIndex = 32;
            textBox16.KeyPress += SoloUnaLetra;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(38, 101);
            textBox15.Multiline = true;
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(22, 23);
            textBox15.TabIndex = 31;
            textBox15.KeyPress += SoloUnaLetra;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(149, 157);
            textBox14.Multiline = true;
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(22, 23);
            textBox14.TabIndex = 30;
            textBox14.KeyPress += SoloUnaLetra;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(149, 129);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(22, 23);
            textBox13.TabIndex = 29;
            textBox13.KeyPress += SoloUnaLetra;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(149, 101);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(22, 23);
            textBox12.TabIndex = 28;
            textBox12.KeyPress += SoloUnaLetra;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(176, 74);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(22, 23);
            textBox11.TabIndex = 27;
            textBox11.KeyPress += SoloUnaLetra;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(149, 74);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(22, 23);
            textBox10.TabIndex = 26;
            textBox10.KeyPress += SoloUnaLetra;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(312, 46);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(22, 23);
            textBox9.TabIndex = 25;
            textBox9.KeyPress += SoloUnaLetra;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(284, 46);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(22, 23);
            textBox8.TabIndex = 24;
            textBox8.KeyPress += SoloUnaLetra;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(257, 46);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(22, 23);
            textBox7.TabIndex = 23;
            textBox7.KeyPress += SoloUnaLetra;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(230, 46);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(22, 23);
            textBox6.TabIndex = 22;
            textBox6.KeyPress += SoloUnaLetra;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(203, 129);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(22, 23);
            textBox5.TabIndex = 21;
            textBox5.KeyPress += SoloUnaLetra;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(203, 101);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(22, 23);
            textBox4.TabIndex = 20;
            textBox4.KeyPress += SoloUnaLetra;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(203, 74);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(22, 23);
            textBox3.TabIndex = 19;
            textBox3.KeyPress += SoloUnaLetra;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 46);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(22, 23);
            textBox2.TabIndex = 18;
            textBox2.KeyPress += SoloUnaLetra;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 18);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(22, 23);
            textBox1.TabIndex = 17;
            textBox1.KeyPress += SoloUnaLetra;
            // 
            // picsalir
            // 
            picsalir.BackColor = Color.Transparent;
            picsalir.BackgroundImageLayout = ImageLayout.Stretch;
            picsalir.Cursor = Cursors.Hand;
            picsalir.Image = (Image)resources.GetObject("picsalir.Image");
            picsalir.Location = new Point(748, 12);
            picsalir.Name = "picsalir";
            picsalir.Size = new Size(40, 40);
            picsalir.SizeMode = PictureBoxSizeMode.StretchImage;
            picsalir.TabIndex = 17;
            picsalir.TabStop = false;
            picsalir.Click += picsalir_Click;
            // 
            // FACIL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(picsalir);
            Controls.Add(panel1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnVerificar);
            Controls.Add(ptbRegreso);
            Controls.Add(label1);
            Controls.Add(listVerticales);
            Controls.Add(listHorizontales);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FACIL";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FACIL";
            Load += FACIL_Load;
            ((System.ComponentModel.ISupportInitialize)ptbRegreso).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picsalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listHorizontales;
        private ListBox listVerticales;
        private Label label1;
        private PictureBox ptbRegreso;
        private Button btnVerificar;
        private Button btnLimpiar;
        private Panel panel1;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox20;
        private TextBox textBox19;
        private TextBox textBox18;
        private TextBox textBox17;
        private TextBox textBox16;
        private TextBox textBox15;
        private TextBox textBox14;
        private TextBox textBox13;
        private TextBox textBox12;
        private PictureBox picsalir;
    }
}