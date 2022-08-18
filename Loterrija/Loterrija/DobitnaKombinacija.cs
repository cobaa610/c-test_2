using System;
using System.Collections.Generic;
using System.Text;

namespace Loterrija
{
    class DobitnaKombinacija:Kombinacija
    {
        int vrednostDobitka;
        int steviloIzrebanih;
        List<int> izrebanaStevila;
        public int VrednostDobitka { get; set; }
        public int SteviloIzrebanih { get; set; }
        public List<int> IzrebanaStevila { get; set; }
    }
}
