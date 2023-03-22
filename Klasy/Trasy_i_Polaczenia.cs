using System;
using System.Collections.Generic;
using System.Linq;
using graf_od_podstaw.Klasy;

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
        //wyszukuje wszsystkie dostepne trasy 
        public void WszystkieDostepneTrasy()
        {
            for (int i = 0; i < miejscowosci.LiczbaMiejscowosci(); i++)
            {
                for (int j = 0; j < miejscowosci.LiczbaMiejscowosci(); j++)
                {
                    if (graf.PobierzWartoscM(i, j) == 1)
                    {
                        Console.WriteLine("Możliwe połączenie: {0} - {1}", miejscowosci.PobierzMiejscowosc(i), miejscowosci.PobierzMiejscowosc(j));
                    }
                    else if (graf.PobierzWartoscM(j, i) == 1)
                    {
                        Console.WriteLine("Możliwe połączenie: {0} - {1}", miejscowosci.PobierzMiejscowosc(j), miejscowosci.PobierzMiejscowosc(i));
                    }
                }
            }
        }
    }
}
