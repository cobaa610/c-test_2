using System;
using System.Collections.Generic;
using System.Text;

namespace Loterrija
{
    interface Izreb
    {
        void vplaciloKombinacije(Kombinacija kombinacija);
        void nakljucnaVplacila(Loterija loterija,int n);
        void priprava(Loterija loterija);
        void izvedba(Loterija loterija);
    }
}
