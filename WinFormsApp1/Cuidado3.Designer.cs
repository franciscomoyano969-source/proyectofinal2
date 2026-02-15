namespace Cuidado_nutricional
{
    partial class Cuidado3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuidado3));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            pictureBox3 = new PictureBox();
            picsalir = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picsalir).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(32, 101);
            button1.Name = "button1";
            button1.Size = new Size(179, 70);
            button1.TabIndex = 10;
            button1.Text = " Adultos Mayores";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Ivory;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(32, 177);
            button2.Name = "button2";
            button2.Size = new Size(179, 70);
            button2.TabIndex = 11;
            button2.Text = "  Niños y Jóvenes";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Ivory;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(32, 253);
            button3.Name = "button3";
            button3.Size = new Size(179, 70);
            button3.TabIndex = 12;
            button3.Text = "  Grupos Familiares";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Ivory;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(32, 329);
            button4.Name = "button4";
            button4.Size = new Size(179, 70);
            button4.TabIndex = 13;
            button4.Text = "    Personas Sin Hogar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Location = new Point(32, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 50);
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // picsalir
            // 
            picsalir.BackColor = Color.Transparent;
            picsalir.BackgroundImageLayout = ImageLayout.Stretch;
            picsalir.Image = (Image)resources.GetObject("picsalir.Image");
            picsalir.Location = new Point(748, 12);
            picsalir.Name = "picsalir";
            picsalir.Size = new Size(40, 40);
            picsalir.SizeMode = PictureBoxSizeMode.StretchImage;
            picsalir.TabIndex = 18;
            picsalir.TabStop = false;
            picsalir.Click += picsalir_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(228, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 370);
            panel1.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(121, 9);
            label4.Name = "label4";
            label4.Size = new Size(459, 71);
            label4.TabIndex = 20;
            label4.Text = "Población beneficiaria";
            // 
            // Cuidado3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(picsalir);
            Controls.Add(pictureBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cuidado3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picsalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private PictureBox pictureBox3;
        private PictureBox picsalir;
        private Panel panel1;
        private Label label4;
    }
}