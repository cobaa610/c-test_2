using System;
using System.Collections.Generic;
using System.Text;

namespace Loterrija
{
    class Loterija
    {
        string ime;
        int maksNagradniSklad;
        List<Zreb> seznamZrebanj;
        SkupekStevil naborStevil;
        int steviloIzrebanih;
        int cenaKombinacije;
        List<Dobitek> dobitki;
        int garantiranSklad;
        public event LoterijaObvestilo obvesti =null;
        public void obvestilo(string a,string b)
        {
            if (obvesti!=null)
            {
                obvesti(a,b);
            }
        }
        public string Ime { get; set; }
        public int MaksNagradniSklad { get; set; }
        public List<Zreb> SeznamZrebanj { get; set; }
        public SkupekStevil NaborStevil { get; set; }
        public int SteviloIzrebanih { get; set; }
        public int CenaKombinacije { get; set; }
        public List<Dobitek> Dobitki { get; set; }
        public int GarantiranSklad { get; set; }

        public Loterija() { }

        public Loterija(string ime,int maksNagradniSklad,List<Zreb> seznamZrebanj,SkupekStevil naborStevil,int steviloIzrebanih,int cenaKombinacije,List<Dobitek> dobitki,int garantiranSklad)
        {
            this.ime = ime;
            this.maksNagradniSklad = maksNagradniSklad;
            this.seznamZrebanj = seznamZrebanj;
            this.naborStevil = naborStevil;
            this.steviloIzrebanih = steviloIzrebanih;
            this.cenaKombinacije = cenaKombinacije;
            this.dobitki = dobitki;
            this.garantiranSklad = garantiranSklad;


        }
    }
}
