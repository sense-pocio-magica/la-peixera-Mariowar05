namespace Tasca;

public class Peix
{
    public int X { get; set; }
    public int Y { get; set; }

    public int DireccioX { get; set; }
    public int DireccioY { get; set; }

    public Sexe Sexe { get; set; }

    public Peix(int x, int y, int dx, int dy, Sexe sexe)
    {
        X = x;
        Y = y;
        DireccioX = dx;
        DireccioY = dy;
        Sexe = sexe;
    }

    public void Mou(int filas, int columnas)
    {
        int nouX = X + DireccioX;
        int nouY = Y + DireccioY;

        if (nouX <= 0 || nouX >= columnas - 1) DireccioX *= -1;
        if (nouY <= 0 || nouY >= filas - 1) DireccioY *= -1;

        X += DireccioX;
        Y += DireccioY;
    }
}