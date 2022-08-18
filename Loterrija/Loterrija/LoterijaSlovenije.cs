using System;
using System.Collections.Generic;
using System.Text;

namespace Loterrija
{
    class LoterijaSlovenije
    {
        List<Loterija> seznamLoterij;
        public List<Loterija> SeznamLoterij { get; set; }

         Func<List<Loterija>,Zreb> najvecjiSklad = (List<Loterija> seznamLoterij) =>
          {
              Zreb najvecji = new Zreb();
              foreach (var item in seznamLoterij)
              {
                  foreach (var zreb in item.SeznamZrebanj)
                  {
                      if (zreb.DobitniSklad>najvecji.DobitniSklad)
                      {
                          najvecji = zreb;
                      }
                  }
              }
              return najvecji;
          };
        Func<List<Loterija>, List<Zreb>> vsiIzvedeni = (List<Loterija> seznamLoterij) =>
        {
            List<Zreb> vsiIzvedeni = new List<Zreb>();
            foreach (var item in seznamLoterij)
            {
                foreach (var zreb in item.SeznamZrebanj)
                {
                    if (zreb.Izveden)
                    {
                        vsiIzvedeni.Add(zreb);
                    }
                }
            }
            return vsiIzvedeni;
        };
        Func<Zreb,int> NajpogostejsaStevilka = (Zreb zreb) =>
        {
            List<int> vsaStevila=new List<int>();
            foreach (var item in zreb.VplacaneKombinacije)
            {
                foreach (var stevilo in item.IzbranaStevila)
                {
                    vsaStevila.Add(stevilo);
                }
            }
            //najdi najveckrat v vseh stevilih
            return 3;

        };
    }
}
