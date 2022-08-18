using System;
using System.Collections.Generic;
using System.Text;

namespace Loterrija
{
    class AbsolutniDobitek:Dobitek
    {
        int vrednostDobitka;
        public int VrednostDobitka { get; set; }
        public AbsolutniDobitek() : base()
        {

        }
        public AbsolutniDobitek(int steviloIzrebanih, int vrednostDobitka) : base(steviloIzrebanih)
        {
            this.vrednostDobitka = vrednostDobitka;
        }
    }
}
