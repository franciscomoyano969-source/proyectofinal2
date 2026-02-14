namespace WinFormsApp1
{
    partial class Intrucciones_sopa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intrucciones_sopa));
            btnNivel1 = new PictureBox();
            label1 = new Label();
            btnNivel2 = new PictureBox();
            btnNivel3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnNivel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNivel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNivel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnNivel1
            // 
            btnNivel1.Image = (Image)resources.GetObject("btnNivel1.Image");
            btnNivel1.Location = new Point(45, 316);
            btnNivel1.Name = "btnNivel1";
            btnNivel1.Size = new Size(85, 85);
            btnNivel1.SizeMode = PictureBoxSizeMode.StretchImage;
            btnNivel1.TabIndex = 0;
            btnNivel1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(523, 283);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // btnNivel2
            // 
            btnNivel2.Image = (Image)resources.GetObject("btnNivel2.Image");
            btnNivel2.Location = new Point(227, 316);
            btnNivel2.Name = "btnNivel2";
            btnNivel2.Size = new Size(85, 85);
            btnNivel2.SizeMode = PictureBoxSizeMode.StretchImage;
            btnNivel2.TabIndex = 2;
            btnNivel2.TabStop = false;
            // 
            // btnNivel3
            // 
            btnNivel3.Image = (Image)resources.GetObject("btnNivel3.Image");
            btnNivel3.Location = new Point(406, 316);
            btnNivel3.Name = "btnNivel3";
            btnNivel3.Size = new Size(85, 85);
            btnNivel3.SizeMode = PictureBoxSizeMode.StretchImage;
            btnNivel3.TabIndex = 3;
            btnNivel3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 318);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(202, 318);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(363, 318);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(120, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 44);
            label3.Name = "label3";
            label3.Size = new Size(476, 234);
            label3.TabIndex = 4;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(149, 9);
            label2.Name = "label2";
            label2.Size = new Size(247, 26);
            label2.TabIndex = 3;
            label2.Text = "Instrucciones – Sopa de Letras";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 278);
            label4.Name = "label4";
            label4.Size = new Size(424, 21);
            label4.TabIndex = 5;
            label4.Text = "El objetivo es encontrar todas las palabras antes de finalizar el nivel.";
            // 
            // Intrucciones_sopa
            // 
            BackColor = Color.White;
            ClientSize = new Size(547, 430);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Intrucciones_sopa";
            ((System.ComponentModel.ISupportInitialize)btnNivel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNivel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNivel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private PictureBox btnNivel1;
        private Label label1;
        private PictureBox btnNivel2;
        private PictureBox btnNivel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}