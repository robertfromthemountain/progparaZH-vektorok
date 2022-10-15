using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_zh_progparadigmak
{
    internal class vektor2
    {
        // 1. Feladat (5 pont)
        /* Private adattagok letrehozasa, amibol
         * ketto int tipusu egesz, ezek a koordinatak x és y valtozoi,
         * es egy string tipusu valtozo ami a neve. */
        private int x, y;
        private string nev;


        // 2. Feladat (5 pont)
        //Parameteres konstruktor letrehozasa:
        public vektor2(int x, int y, string nev)
        {
            this.x = x;
            this.y = y;
            this.nev = nev;
        }


        // 3. Feladat (10 pont)
        // Hossz metodus, ami a vektor hosszat dobja vissza (sqrt(x*x+y*y))
        public double Hossz()
        {
            return Math.Sqrt(x * x + y * y);
        }

        // 4. Feladat (5 pont)
        // ToString metodus letrehozasa, mely kiirja a vektort koordinataival
        public override string ToString()
        {
            return String.Format($"{nev} ({x} {y})");
        }

        // 5. Feladat: (10 pont)
        //Definialja a Meroleges metodust, amely megmondja hogy adott 2 vektor meroleges e egymasra
        //Akkor merolegesek, ha skalaris szorzatuk egyenlo nullaval.
        //Visszateresi ertek vagy 0 vagy 1 legyen!
        public static bool Meroleges(vektor2 a, vektor2 b)
        {
            return a.x * b.x + a.y * b.y == 0;
        }

    }
}
