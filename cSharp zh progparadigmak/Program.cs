using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_zh_progparadigmak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 6. Feladat (10 pont)
                /* Nyissa meg a teszt.txt-t, olvassa ki a vektorok számát, 
                 * hozzon létre egy pont akkora Vektor2 típusú tömböt. 
                 * A vektorok adatait olvassa ki a tömbből és hozzon
                 * létre belőlük Vektor2 példányokat, majd ezeket tárolja a Vektor2 típusú tömbben. 
                 * Listázza ki a tömböt. */
                StreamReader read = new StreamReader("teszt.txt");
                // Elso sor beolvasasa, darab meghatarozasa:
                int db = int.Parse(read.ReadLine());
                Console.WriteLine("Vektorok száma a fileban: "+db);
                // Vektor2 tipusu, darab elemu tomb:
                vektor2[] vektor2s = new vektor2[db];
                for (int i = 0; i < vektor2s.Length; i++)
                {
                    // Beolvassuk az egesz sort,
                    string sor = read.ReadLine();
                    // Darabokra tordeljuk a whitespaceknel es a zarojelnel a sort,
                    string[] d = sor.Split(' ', '(');
                    // a 0. elemet beodobjuk nevnek amit a konstruktor fog parameternek varni letrehozasnal
                    string nev = d[0];
                    // masodik es harmadik elemet int-re kovertaljuk es bedobjuk xy koordinatanak
                    int x = int.Parse(d[2]);
                    int y = int.Parse(d[3]);
                    // uj objektum letrehozasa fenti parameterekkel
                    //MIVEL MINDEN SORBAN EGY VEKTOR VAN, MINDEN LEFUTASNAL
                    //UJ SORT FOG BEOLVASNI A FOR CIKLUS, EZERT AZ ELOZO ERTEKEKET
                    //MINDIG FELUL FOGJA IRNI.
                    vektor2s[i] = new vektor2(x, y, nev);
                }

                // Itemek kilistazasa konzolra
                foreach (var item in vektor2s)
                {
                    Console.WriteLine(item.ToString());
                }


                // 7. Feladat (5 pont)
                // Egy kettos for ciklusban vizsgalja meg mely vektorok merolegesek egymasra!
                // (Minden vektort minden vektorral vizsgaljon!)
                for (int i = 0; i < vektor2s.Length; i++)
                {
                    for (int j = i + 1; j < vektor2s.Length; j++)
                    {
                        if (vektor2.Meroleges(vektor2s[i], vektor2s[j]))
                        {
                            Console.WriteLine(vektor2s[i] + " - " + vektor2s[j] + " merolegesek egymasra.");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
