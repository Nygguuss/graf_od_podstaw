using System;
using System.Collections.Generic;
using graf_od_podstaw.Klasy;

namespace graf_od_podstaw.Klasy
{
    class Miejscowosci
    {
        private Dictionary<int, string> Miejsca;

        public Miejscowosci()
        {
            Miejsca = new Dictionary<int, string>();
        }
        //miejscowosci dodajemy w Program.cs
        public void dodaj_miejscowosci(int numer, string miasto)
        {
            Miejsca.Add(numer, miasto);
        }

        public void wyswietl_miejscowosci()
        {
            foreach (KeyValuePair<int, string> item in Miejsca)
            {
                Console.WriteLine("Numer: {0}, Miejsce: {1}", item.Key, item.Value);
            }
        }

        public int LiczbaMiejscowosci()
        {
            return this.Miejsca.Count;
        }

        public string PobierzMiejscowosc(int indeks)
        {
            return Miejsca[indeks];
        }

    }
}
