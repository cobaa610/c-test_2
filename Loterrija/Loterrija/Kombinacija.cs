using System;
using System.Collections.Generic;
using System.Text;

namespace Loterrija
{
    class Kombinacija
    {
        List<int> izbranaStevila;
        DateTime datumVplacila;
        public List<int> IzbranaStevila { get; set; }
        public DateTime DatumVplacila { get; set; }
        public Kombinacija() { }
        public Kombinacija(List<int> izbranaStevila_, DateTime datumVplacila_)
        {
            izbranaStevila = izbranaStevila_;
            datumVplacila = datumVplacila_;
        }
    }
}
