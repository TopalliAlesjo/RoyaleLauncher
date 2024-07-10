using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class MyPanel : Panel
{
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

    public MyPanel()
    {
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        GraphicsPath path = new GraphicsPath(); // Dichiarazione del percorso fuori dal blocco using

        // Creare una regione con bordi arrotondati
        path.AddArc(0, 0, 20, 20, 180, 90);
        path.AddArc(Width - 20, 0, 20, 20, 270, 90);
        path.AddArc(Width - 20, Height - 20, 20, 20, 0, 90);
        path.AddArc(0, Height - 20, 20, 20, 90, 90);
        path.CloseAllFigures();

        this.Region = new Region(path);

    }
}
