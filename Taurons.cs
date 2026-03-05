namespace Tasca;

using System;
using System.Collections.Generic;

public enum Sexe { Mascle, Femella }

public class Taurons
{
    public int X;
    public int Y;
    public int DireccioX;
    public int DireccioY;
    public Sexe Sexe;
    public int TempsVida;

    public Taurons(int x, int y, int dx, int dy, Sexe sexe, int tempsVida = 75)
    {
        X = x;
        Y = y;
        DireccioX = dx;
        DireccioY = dy;
        Sexe = sexe;
        TempsVida = tempsVida;
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

    public bool Viure(int filas, int columnas)
    {
        TempsVida--;

        if (TempsVida > 0)
        {
            Mou(filas, columnas);
            return true; 
        }
        else
        {
            return false; 
        }
    }
}