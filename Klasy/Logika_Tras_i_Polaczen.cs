using System;

namespace graf_od_podstaw.Klasy
{
    class Logika_Tras_i_Polaczen
    {
        private Graf graf;
        private Miejscowosci miejscowosci;

        public Logika_Tras_i_Polaczen(Graf g, Miejscowosci m)
        {
            graf = g;
            miejscowosci = m;
        }

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
    }
}
