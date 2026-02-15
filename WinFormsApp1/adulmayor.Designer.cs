namespace WinFormsApp1
{
    partial class adulmayor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adulmayor));
            panelAdultos = new Panel();
            label4 = new Label();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panelAdultos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelAdultos
            // 
            panelAdultos.BackColor = Color.White;
            panelAdultos.Controls.Add(label4);
            panelAdultos.Controls.Add(label3);
            panelAdultos.Controls.Add(pictureBox4);
            panelAdultos.Controls.Add(pictureBox1);
            panelAdultos.Controls.Add(label2);
            panelAdultos.Controls.Add(pictureBox2);
            panelAdultos.Controls.Add(label1);
            panelAdultos.Location = new Point(0, 0);
            panelAdultos.Name = "panelAdultos";
            panelAdultos.Size = new Size(560, 370);
            panelAdultos.TabIndex = 1;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(153, 278);
            label4.Name = "label4";
            label4.Size = new Size(389, 69);
            label4.TabIndex = 10;
            label4.Text = "El banco distribuye alimentos de fácil digestión y preparación como avena, purés y sopas instantáneas, adaptándose a sus limitaciones físicas y necesidades nutricionales especiales.";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(153, 165);
            label3.Name = "label3";
            label3.Size = new Size(389, 66);
            label3.TabIndex = 9;
            label3.Text = "Necesitan dietas bajas en sodio y azúcares para controlar la presión arterial y diabetes, recibiendo alimentos saludables que cuiden su salud cardiovascular y metabólica.";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(20, 267);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(127, 91);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(20, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 91);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(153, 41);
            label2.Name = "label2";
            label2.Size = new Size(395, 86);
            label2.TabIndex = 6;
            label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(20, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 91);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 28);
            label1.TabIndex = 1;
            label1.Text = "Adultos Mayores (Tercera edad)\r\n";
            // 
            // adulmayor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 370);
            Controls.Add(panelAdultos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adulmayor";
            Text = "adulmayor";
            panelAdultos.ResumeLayout(false);
            panelAdultos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAdultos;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
    }
}