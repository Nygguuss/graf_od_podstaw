using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using graf_od_podstaw.Klasy;

namespace graf_od_podstaw.Klasy
{
    class Graf
    {
        private int[,] macierz;
        private int wielkosc_x;
        private int wielkosc_y;
        //konstruktor tworzy nam macierz/ macierz mozna zedytowac w każdym momęcie i on dostosuje się do tego 
        public Graf(int[,] m)
        {
            macierz = m;
            wielkosc_x = macierz.GetLength(0);
            wielkosc_y = macierz.GetLength(1);
        }

        public void rysuj()
        {
            for (int wiersz = 0; wiersz < macierz.GetLength(0); wiersz++)
            {
                for (int kolumna = 0; kolumna < macierz.GetLength(1); kolumna++)
                {
                    Console.Write("{0,3}", macierz[wiersz, kolumna]);
                }
                Console.WriteLine();
            }
        }
        public int PobierzWartoscM(int wiersz, int kolumna)
        {
            return macierz[wiersz, kolumna];
        }
        public int WielkoscX
        {
            get { return macierz.GetLength(0); }
        }
    }
}

