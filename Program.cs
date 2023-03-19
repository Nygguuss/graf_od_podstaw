using graf_od_podstaw.Klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf_od_podstaw
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] macierz_miejscowosci = new int[,]
            {
                {0, 1, 0, 0, 0},
                {1, 0, 1, 1, 0},
                {0, 1, 0, 1, 1},
                {0, 1, 0, 0, 1},
                {0, 0, 1, 1, 0}
            };
            Graf graf = new Graf(macierz_miejscowosci);
            graf.rysuj();

            //miejscowosci
            Miejscowosci miejcowosci = new Miejscowosci();
            miejcowosci.dodaj_miejscowosci(0, "Otmuchów");
            miejcowosci.dodaj_miejscowosci(1, "Nysa");
            miejcowosci.dodaj_miejscowosci(2, "Biała nyska");
            miejcowosci.dodaj_miejscowosci(3, "Podkamień");
            miejcowosci.dodaj_miejscowosci(4, "Przełęk");

            miejcowosci.wyswietl_miejscowosci();
            Trasy_i_Polaczenia trasy_i_polaczenia = new Trasy_i_Polaczenia(graf,miejcowosci);
            trasy_i_polaczenia.WszystkieDostepneTrasy();
            Console.ReadLine();
        }
    }
}
