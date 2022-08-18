using System;
using System.Collections.Generic;
using System.Text;

namespace Loterrija
{
    class RelativniDobitek:Dobitek
    {
        int odstotekDobitka;
        public int OdstotekDobitka { get; set; }
        public RelativniDobitek():base()
        {

        }
        public RelativniDobitek(int steviloIzrebanih,int odstotekDobitka):base(steviloIzrebanih)
        {
            this.odstotekDobitka = odstotekDobitka;
        }
    }
}
