namespace Tasca;

public class Pops
{
    public int X;
    public int Y;
    public int DireccioX;
    public int DireccioY;
    public Sexe Sexe = 0;

    static Random rand = new Random();

    public Pops(int x, int y, int dx, int dy, Sexe sexe)
    {
        X = x;
        Y = y;
        DireccioX = dx;
        DireccioY = dy;
        Sexe = sexe;
    }
    public enum Sexe { Mascle, Femella }

    public static void CrearPulpos(List<Pops> listaPulpos, int filas, int columnas)
{
    for (int i = 0; i < 10; i++)
    {
        int borde = rand.Next(4);
        int x = 0, y = 0;

        if (borde == 0) { y = 0; x = rand.Next(0, columnas); }
        else if (borde == 1) { y = filas - 1; x = rand.Next(0, columnas); }
        else if (borde == 2) { x = 0; y = rand.Next(0, filas); }
        else { x = columnas - 1; y = rand.Next(0, filas); }

        int dx = rand.Next(-1, 2);
        int dy = rand.Next(-1, 2);

        listaPulpos.Add(new Pops(x, y, dx, dy, Sexe.Mascle));
    }
}

    public void MouBorde(int filas, int columnes)
{
    int nouX = X + DireccioX;
    int nouY = Y + DireccioY;
    
    if (nouX == 0 || nouX == columnes - 1 || nouY == 0 || nouY == filas - 1)
    {
        X = nouX;
        Y = nouY;
    }
}
}