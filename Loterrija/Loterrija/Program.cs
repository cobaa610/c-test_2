using System;
using System.Linq;
using System.Collections.Generic;

namespace Loterrija
{
    public delegate void LoterijaObvestilo(string a, string b);
    class Program
    {
        
        static void Main(string[] args)
        {
            SkupekStevil nabor = new SkupekStevil(1, 30);
            Zreb zreb1 = new Zreb();
            List<Zreb> seznam1 = new List<Zreb>();
            seznam1.Add(zreb1);
            List< Dobitek > dobitki1= new List<Dobitek>();
            Dobitek dobitek = new AbsolutniDobitek(3, 80);
            dobitki1.Add(dobitek);
            Loterija Loto = new Loterija("Lotko", 100000000, seznam1, nabor, 6, 1, dobitki1, 10000);
            Oseba oseba = new Oseba();
            oseba.PrijavaObvesilo(Loto);
            Loto.obvestilo("bla", "nla");

        }
    }
}
