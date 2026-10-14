using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozokLinq13.a
{
    internal class Dolgozo
    {
        public Dolgozo(int azonosito, string nev, string anyjaNeve, string telepules, string cim, int fizetes, int jutalom, DateTime belepes, DateTime szuletes, string szulHely)
        {
            Azonosito = azonosito;
            Nev = nev;
            AnyjaNeve = anyjaNeve;
            Telepules = telepules;
            Cim = cim;
            Fizetes = fizetes;
            Jutalom = jutalom;
            Belepes = belepes;
            Szuletes = szuletes;
            SzulHely = szulHely;
        }

        /*
* Azonosító;Név;Anyjaneve;Település;Cím;Fizetés;Jutalom;Belépés;Születés;Születés helye
1;Gyenge Tamás;Fekete Eszter;Kisvárda;Dugovics Titusz utca u.19;420000;5000;2002-04-15;1958-11-02;Kisvárda
*/

        public int Azonosito { get; set; }
        public string Nev { get; set; }
        public string AnyjaNeve { get; set; }
        public string Telepules { get; set; }
        public string Cim { get; set; }
        public int Fizetes { get; set; }
        public int Jutalom { get; set; }
        public DateTime Belepes { get; set; }
        public DateTime Szuletes { get; set; }
        public string SzulHely { get; set; }


    }
}
