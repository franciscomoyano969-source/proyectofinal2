using System;
using System.Drawing;
using System.Windows.Forms;

public class PanelOpaco : Panel
{
    /*private int _opacity = 80; // Porcentaje por defecto

    public int Opacidad
    {
        get { return _opacity; }
        set { _opacity = value; this.Invalidate(); } // Redibuja al cambiar
    }

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x00000020; // Activa el estilo WS_EX_TRANSPARENT
            return cp;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        // Calcula el alpha basado en el porcentaje (0-100)
        int alpha = (_opacity * 255) / 100;

        using (var brush = new SolidBrush(Color.FromArgb(alpha, this.BackColor)))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }*/
}