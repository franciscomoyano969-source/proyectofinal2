namespace WinFormsApp1
{
    partial class reguladores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reguladores));
            panelReguladores = new Panel();
            label14 = new Label();
            label13 = new Label();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            label12 = new Label();
            pictureBox8 = new PictureBox();
            label11 = new Label();
            panelReguladores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panelReguladores
            // 
            panelReguladores.BackColor = Color.White;
            panelReguladores.Controls.Add(label14);
            panelReguladores.Controls.Add(label13);
            panelReguladores.Controls.Add(pictureBox10);
            panelReguladores.Controls.Add(pictureBox9);
            panelReguladores.Controls.Add(label12);
            panelReguladores.Controls.Add(pictureBox8);
            panelReguladores.Controls.Add(label11);
            panelReguladores.Location = new Point(0, 0);
            panelReguladores.Name = "panelReguladores";
            panelReguladores.Size = new Size(560, 369);
            panelReguladores.TabIndex = 16;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(148, 266);
            label14.Name = "label14";
            label14.Size = new Size(391, 93);
            label14.TabIndex = 23;
            label14.Text = resources.GetString("label14.Text");
            // 
            // label13
            // 
            label13.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(148, 157);
            label13.Name = "label13";
            label13.Size = new Size(394, 86);
            label13.TabIndex = 22;
            label13.Text = "Son fundamentales en el cuidado nutricional del banco porque previenen enfermedades, fortalecen las defensas del organismo y aseguran el correcto funcionamiento de todos los sistemas corporales";
            // 
            // pictureBox10
            // 
            pictureBox10.BackgroundImage = (Image)resources.GetObject("pictureBox10.BackgroundImage");
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox10.Location = new Point(12, 43);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(127, 90);
            pictureBox10.TabIndex = 21;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackgroundImage = (Image)resources.GetObject("pictureBox9.BackgroundImage");
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox9.Location = new Point(12, 266);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(127, 90);
            pictureBox9.TabIndex = 20;
            pictureBox9.TabStop = false;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(148, 43);
            label12.Name = "label12";
            label12.Size = new Size(394, 71);
            label12.TabIndex = 19;
            label12.Text = "Los alimentos reguladores se llaman así porque aportan vitaminas y minerales que regulan las funciones del cuerpo como la digestión, el sistema inmune y el metabolismo.";
            label12.Click += label12_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImage = (Image)resources.GetObject("pictureBox8.BackgroundImage");
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Location = new Point(12, 157);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(127, 90);
            pictureBox8.TabIndex = 18;
            pictureBox8.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(187, 9);
            label11.Name = "label11";
            label11.Size = new Size(182, 26);
            label11.TabIndex = 17;
            label11.Text = "Alimentos Reguladores\r\n";
            // 
            // reguladores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 369);
            Controls.Add(panelReguladores);
            FormBorderStyle = FormBorderStyle.None;
            Name = "reguladores";
            Text = "reguladores";
            panelReguladores.ResumeLayout(false);
            panelReguladores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelReguladores;
        private Label label14;
        private Label label13;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private Label label12;
        private PictureBox pictureBox8;
        private Label label11;
    }
}