namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblnombre = new Label();
            lblingnombre = new Label();
            piclogo = new PictureBox();
            textBox1 = new TextBox();
            picinfo = new PictureBox();
            piclogin = new PictureBox();
            picnutri = new PictureBox();
            picsalir = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picinfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)piclogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picnutri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picsalir).BeginInit();
            SuspendLayout();
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.BackColor = Color.Transparent;
            lblnombre.FlatStyle = FlatStyle.Flat;
            lblnombre.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(345, 49);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(244, 55);
            lblnombre.TabIndex = 1;
            lblnombre.Text = "NutriBank";
            // 
            // lblingnombre
            // 
            lblingnombre.AutoSize = true;
            lblingnombre.BackColor = Color.Transparent;
            lblingnombre.FlatStyle = FlatStyle.Flat;
            lblingnombre.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblingnombre.Location = new Point(375, 243);
            lblingnombre.Name = "lblingnombre";
            lblingnombre.Size = new Size(217, 37);
            lblingnombre.TabIndex = 2;
            lblingnombre.Text = "Ingrese su nombre:";
            // 
            // piclogo
            // 
            piclogo.BackColor = Color.Transparent;
            piclogo.Image = (Image)resources.GetObject("piclogo.Image");
            piclogo.Location = new Point(417, 111);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(138, 129);
            piclogo.SizeMode = PictureBoxSizeMode.StretchImage;
            piclogo.TabIndex = 3;
            piclogo.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(396, 289);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 29);
            textBox1.TabIndex = 4;
            // 
            // picinfo
            // 
            picinfo.BackColor = Color.Transparent;
            picinfo.Image = (Image)resources.GetObject("picinfo.Image");
            picinfo.Location = new Point(853, 373);
            picinfo.Name = "picinfo";
            picinfo.Size = new Size(57, 53);
            picinfo.SizeMode = PictureBoxSizeMode.StretchImage;
            picinfo.TabIndex = 5;
            picinfo.TabStop = false;
            picinfo.Click += pictureBox3_Click;
            // 
            // piclogin
            // 
            piclogin.BackColor = Color.Transparent;
            piclogin.Image = (Image)resources.GetObject("piclogin.Image");
            piclogin.Location = new Point(458, 327);
            piclogin.Name = "piclogin";
            piclogin.Size = new Size(57, 53);
            piclogin.SizeMode = PictureBoxSizeMode.StretchImage;
            piclogin.TabIndex = 6;
            piclogin.TabStop = false;
            piclogin.Click += pictureBox4_Click;
            // 
            // picnutri
            // 
            picnutri.BackColor = Color.Transparent;
            picnutri.Image = (Image)resources.GetObject("picnutri.Image");
            picnutri.Location = new Point(305, 13);
            picnutri.Name = "picnutri";
            picnutri.Size = new Size(356, 94);
            picnutri.SizeMode = PictureBoxSizeMode.StretchImage;
            picnutri.TabIndex = 7;
            picnutri.TabStop = false;
            // 
            // picsalir
            // 
            picsalir.BackColor = Color.Transparent;
            picsalir.BackgroundImageLayout = ImageLayout.Stretch;
            picsalir.Image = (Image)resources.GetObject("picsalir.Image");
            picsalir.Location = new Point(878, 12);
            picsalir.Name = "picsalir";
            picsalir.Size = new Size(40, 40);
            picsalir.SizeMode = PictureBoxSizeMode.StretchImage;
            picsalir.TabIndex = 8;
            picsalir.TabStop = false;
            picsalir.Click += picsalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(930, 450);
            Controls.Add(picsalir);
            Controls.Add(picnutri);
            Controls.Add(piclogin);
            Controls.Add(picinfo);
            Controls.Add(textBox1);
            Controls.Add(piclogo);
            Controls.Add(lblingnombre);
            Controls.Add(lblnombre);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picinfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)piclogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picnutri).EndInit();
            ((System.ComponentModel.ISupportInitialize)picsalir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblnombre;
        private Label lblingnombre;
        private PictureBox piclogo;
        private TextBox textBox1;
        private PictureBox picinfo;
        private PictureBox piclogin;
        private PictureBox picnutri;
        private PictureBox picsalir;
    }
}
