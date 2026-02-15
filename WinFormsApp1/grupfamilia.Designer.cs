namespace WinFormsApp1
{
    partial class grupfamilia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(grupfamilia));
            panelfamilia = new Panel();
            label9 = new Label();
            label10 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            label11 = new Label();
            label12 = new Label();
            panelfamilia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // panelfamilia
            // 
            panelfamilia.BackColor = Color.White;
            panelfamilia.Controls.Add(label9);
            panelfamilia.Controls.Add(label10);
            panelfamilia.Controls.Add(pictureBox8);
            panelfamilia.Controls.Add(pictureBox9);
            panelfamilia.Controls.Add(pictureBox10);
            panelfamilia.Controls.Add(label11);
            panelfamilia.Controls.Add(label12);
            panelfamilia.Location = new Point(0, 0);
            panelfamilia.Name = "panelfamilia";
            panelfamilia.Size = new Size(560, 370);
            panelfamilia.TabIndex = 16;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(148, 278);
            label9.Name = "label9";
            label9.Size = new Size(389, 66);
            label9.TabIndex = 18;
            label9.Text = "Se entregan porciones calculadas según el número de integrantes, asegurando que cada familia tenga suficiente alimento para varias semanas sin desperdiciar recursos.";
            // 
            // label10
            // 
            label10.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(148, 169);
            label10.Name = "label10";
            label10.Size = new Size(389, 64);
            label10.TabIndex = 17;
            label10.Text = "Se recomienda alimentos versátiles y rendidores como arroz, pasta, legumbres y aceites que permitan preparar múltiples comidas económicas y nutritivas para toda la familia.";
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(12, 267);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(127, 91);
            pictureBox8.TabIndex = 16;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.Location = new Point(12, 156);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(127, 91);
            pictureBox9.TabIndex = 15;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = (Image)resources.GetObject("pictureBox10.BackgroundImage");
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.Location = new Point(12, 46);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(127, 91);
            pictureBox10.TabIndex = 14;
            pictureBox10.TabStop = false;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(148, 46);
            label11.Name = "label11";
            label11.Size = new Size(389, 91);
            label11.TabIndex = 13;
            label11.Text = "Las familias reciben paquetes completos y variados que incluyen alimentos de todos los grupos nutricionales para cubrir las necesidades de todos sus miembros en diferentes edades.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(187, 9);
            label12.Name = "label12";
            label12.Size = new Size(155, 28);
            label12.TabIndex = 12;
            label12.Text = "Grupos Familiares\r\n";
            // 
            // grupfamilia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 370);
            Controls.Add(panelfamilia);
            FormBorderStyle = FormBorderStyle.None;
            Name = "grupfamilia";
            Text = "grupfamilia";
            panelfamilia.ResumeLayout(false);
            panelfamilia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelfamilia;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private Label label11;
        private Label label12;
    }
}