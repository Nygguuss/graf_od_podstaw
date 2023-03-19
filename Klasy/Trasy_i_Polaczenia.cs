using System;
using System.Collections.Generic;
using System.Linq;

namespace graf_od_podstaw.Klasy
{
    class Trasy_i_Polaczenia
    {
        private Graf graf;
        private Miejscowosci miejscowosci;

        public Trasy_i_Polaczenia(Graf g, Miejscowosci m)
        {
            graf = g;
            miejscowosci = m;
        }
        //wyświetla dostępne miejscowości zależne od grafu oraz od miejscowości które dodajemy w Programie.cs
        public void WyswietlDostepneMiejscowosci(int wierzcholek)
        {
            Console.Write("Dostępne miejscowości dla wierzchołka {0}: ", wierzcholek);
            for (int i = 0; i < graf.WielkoscX; i++)
            {
                if (graf.PobierzWartoscM(wierzcholek, i) == 1)
                {
                    Console.Write("{0}, ", miejscowosci.PobierzMiejscowosc(i));
                }
            }
            Console.WriteLine();
        }

        public void WyswietlTrasy()
        {
            List<string> trasy = new List<string>();
            bool[] odwiedzone = new bool[graf.WielkoscX];
            DFS(0, "", odwiedzone, trasy);
            Console.WriteLine("Dostępne trasy:");
            foreach (string trasa in trasy)
            {
                Console.WriteLine(trasa);
            }
        }
        //Do zrobienia wyszukiwana trasa |NIE WYWOŁYWAĆ|
        private void DFS(int wierzcholek, string trasa, bool[] odwiedzone, List<string> trasy)
        {
            odwiedzone[wierzcholek] = true;
            trasa += miejscowosci.PobierzMiejscowosc(wierzcholek) + " -> ";
            for (int i = 0; i < graf.WielkoscX; i++)
            {
                if (graf.PobierzWartoscM(wierzcholek, i) == 1 && !odwiedzone[i])
                {
                    DFS(i, trasa, odwiedzone, trasy);
                }
            }
            if (graf.WezSasiadow(wierzcholek).Count() == 0) // koniec trasy
            {
                trasa = trasa.Remove(trasa.Length - 4); // usunięcie ostatnich 4 znaków (" -> ")
                trasy.Add(trasa);
            }
            odwiedzone[wierzcholek] = false;
        }



    }
}
