using System;
using System.Collections.Generic;
using System.Text;

namespace Loterrija
{
    abstract class Dobitek
    {
        int steviloIzrebanih;
        public int SteviloIzrebanih { get; set; }
        public Dobitek() { }
        public Dobitek(int steviloIzrebanih)
        {
            this.steviloIzrebanih = steviloIzrebanih;
        }
    }
}
