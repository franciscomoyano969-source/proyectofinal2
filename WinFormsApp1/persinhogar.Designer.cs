namespace WinFormsApp1
{
    partial class persinhogar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(persinhogar));
            panelpersonas = new Panel();
            label13 = new Label();
            label14 = new Label();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            label15 = new Label();
            label16 = new Label();
            panelpersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SuspendLayout();
            // 
            // panelpersonas
            // 
            panelpersonas.BackColor = Color.White;
            panelpersonas.Controls.Add(label13);
            panelpersonas.Controls.Add(label14);
            panelpersonas.Controls.Add(pictureBox11);
            panelpersonas.Controls.Add(pictureBox12);
            panelpersonas.Controls.Add(pictureBox13);
            panelpersonas.Controls.Add(label15);
            panelpersonas.Controls.Add(label16);
            panelpersonas.Location = new Point(1, 0);
            panelpersonas.Name = "panelpersonas";
            panelpersonas.Size = new Size(560, 370);
            panelpersonas.TabIndex = 17;
            // 
            // label13
            // 
            label13.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(148, 272);
            label13.Name = "label13";
            label13.Size = new Size(398, 86);
            label13.TabIndex = 25;
            label13.Text = "Se distribuyen productos fortificados que compensen posibles deficiencias nutricionales por la falta de acceso regular a comidas balanceadas, protegiendo su salud en condiciones vulnerables.";
            // 
            // label14
            // 
            label14.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(151, 170);
            label14.Name = "label14";
            label14.Size = new Size(398, 69);
            label14.TabIndex = 24;
            label14.Text = "Alimentos de alto valor calórico y nutritivo en porciones individuales que puedan transportarse fácilmente y consumirse en cualquier momento y lugar.";
            // 
            // pictureBox11
            // 
            pictureBox11.BackgroundImage = (Image)resources.GetObject("pictureBox11.BackgroundImage");
            pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox11.Location = new Point(15, 272);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(127, 86);
            pictureBox11.TabIndex = 23;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackgroundImage = (Image)resources.GetObject("pictureBox12.BackgroundImage");
            pictureBox12.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox12.Location = new Point(15, 161);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(127, 91);
            pictureBox12.TabIndex = 22;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackgroundImage = (Image)resources.GetObject("pictureBox13.BackgroundImage");
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox13.Location = new Point(15, 47);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(127, 91);
            pictureBox13.TabIndex = 21;
            pictureBox13.TabStop = false;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(151, 57);
            label15.Name = "label15";
            label15.Size = new Size(398, 68);
            label15.TabIndex = 20;
            label15.Text = "Las personas sin hogar reciben alimentos listos para consumir o de fácil preparación que no requieran cocina ni refrigeración, como enlatados, galletas, frutas y jugos.";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(200, 9);
            label16.Name = "label16";
            label16.Size = new Size(168, 28);
            label16.TabIndex = 19;
            label16.Text = "Personas Sin Hogar\r\n";
            // 
            // persinhogar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 370);
            Controls.Add(panelpersonas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "persinhogar";
            Text = "persinhogar";
            panelpersonas.ResumeLayout(false);
            panelpersonas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelpersonas;
        private Label label13;
        private Label label14;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private Label label15;
        private Label label16;
    }
}