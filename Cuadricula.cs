namespace Tasca;

using System;
using System.Collections.Generic;

public class Caudricula
{
    static int filas = 20;
    static int columnas = 20;

    static List<Peix> peces = new List<Peix>();
    static List<Pops> pulpos = new List<Pops>();
    static List<Taurons> taurons = new List<Taurons>();

    static Random rand = new Random();

    static void Main()
    {
        CrearPeces();
        CrearTaurons();
        Pops.CrearPulpos(pulpos, filas, columnas);

        Console.WriteLine("Tiburones:");
        foreach(var t in taurons)
        {
            Console.WriteLine($"X={t.X}, Y={t.Y}, Sexe={t.Sexe}");
        }
        
        Console.WriteLine("Pulpos:");
        foreach(var p in pulpos)
        {
            Console.WriteLine($"X={p.X}, Y={p.Y}, Sexe={p.Sexe}");
        }
    }

    static void CrearPeces()
    {
        for (int i = 0; i < 50; i++)
        {
            int x = rand.Next(0, columnas);
            int y = rand.Next(0, filas);
            int dx = rand.Next(-1, 2);
            int dy = rand.Next(-1, 2);
            peces.Add(new Peix(x, y, dx, dy, Sexe.Mascle));
        }

        for (int i = 0; i < 50; i++)
        {
            int x = rand.Next(0, columnas);
            int y = rand.Next(0, filas);
            int dx = rand.Next(-1, 2);
            int dy = rand.Next(-1, 2);
            peces.Add(new Peix(x, y, dx, dy, Sexe.Femella));
        }
    }

    static void CrearTaurons()
    {
        for (int i = 0; i < 10; i++)
        {
            int x = rand.Next(0, columnas);
            int y = rand.Next(0, filas);
            int dx = rand.Next(-1, 2);
            int dy = rand.Next(-1, 2);
            taurons.Add(new Taurons(x, y, dx, dy, Sexe.Mascle));
        }

        for (int i = 0; i < 10; i++)
        {
            int x = rand.Next(0, columnas);
            int y = rand.Next(0, filas);
            int dx = rand.Next(-1, 2);
            int dy = rand.Next(-1, 2);
            taurons.Add(new Taurons(x, y, dx, dy, Sexe.Femella));
        }

        for (int i = taurons.Count - 1; i >= 0; i--)
        {
            if (!taurons[i].Viure(filas, columnas))
            {
            taurons.RemoveAt(i); 
            }
        }
    }
}