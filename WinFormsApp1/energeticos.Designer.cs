namespace WinFormsApp1
{
    partial class energeticos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(energeticos));
            panelEnergeticos = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panelEnergeticos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelEnergeticos
            // 
            panelEnergeticos.BackColor = Color.White;
            panelEnergeticos.BackgroundImageLayout = ImageLayout.Center;
            panelEnergeticos.Controls.Add(label4);
            panelEnergeticos.Controls.Add(label3);
            panelEnergeticos.Controls.Add(label2);
            panelEnergeticos.Controls.Add(pictureBox5);
            panelEnergeticos.Controls.Add(pictureBox4);
            panelEnergeticos.Controls.Add(pictureBox2);
            panelEnergeticos.Controls.Add(label1);
            panelEnergeticos.Location = new Point(-1, -2);
            panelEnergeticos.Name = "panelEnergeticos";
            panelEnergeticos.Size = new Size(560, 371);
            panelEnergeticos.TabIndex = 12;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(155, 261);
            label4.Name = "label4";
            label4.Size = new Size(389, 85);
            label4.TabIndex = 7;
            label4.Text = resources.GetString("label4.Text");
            // 
            // label3
            // 
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(155, 148);
            label3.Name = "label3";
            label3.Size = new Size(389, 85);
            label3.TabIndex = 6;
            label3.Text = "Se llaman energéticos porque son el combustible del cuerpo, combaten la fatiga y aseguran que las familias tengan vitalidad para sus actividades diarias.";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(155, 36);
            label2.Name = "label2";
            label2.Size = new Size(389, 86);
            label2.TabIndex = 5;
            label2.Text = "Son carbohidratos y grasas saludables que se seleccionan cuidadosamente para garantizar un aporte calórico adecuado y equilibrado a las familias beneficiarias.";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(13, 261);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(127, 91);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(13, 148);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(127, 91);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(15, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 91);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 10);
            label1.Name = "label1";
            label1.Size = new Size(178, 26);
            label1.TabIndex = 0;
            label1.Text = "Alimentos Enérgeticos\r\n";
            // 
            // energeticos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelEnergeticos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "energeticos";
            Text = "energeticos";
            panelEnergeticos.ResumeLayout(false);
            panelEnergeticos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEnergeticos;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private Label label1;
    }
}