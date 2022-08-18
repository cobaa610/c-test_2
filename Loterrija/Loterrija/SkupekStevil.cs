using System;
using System.Collections.Generic;
using System.Text;

namespace Loterrija
{
    class SkupekStevil
    {
        int min;
        int max;
        public int Min { get; set; }
        public int Max { get; set; }
        public SkupekStevil() { }
        public SkupekStevil(int min,int max)
        {
            this.min = min;
            this.max = max;
        }
    }
}
