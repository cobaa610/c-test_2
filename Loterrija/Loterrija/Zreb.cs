using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;


namespace Loterrija
{
    class Zreb:Izreb
    {
        DateTime casovniZigZreba;
        bool izveden;
        List<Kombinacija> vplacaneKombinacije;
        int dobitniSklad;
        List<DobitnaKombinacija> dobitnaKombinacija;
        int koncniSaldo;
        List<int> izrebanaStevila;
        public DateTime CasovniZigZreba { get; set; }
        public bool Izveden { get; set; }
        public List<Kombinacija> VplacaneKombinacije { get; set; }
        public int DobitniSklad { get; set; }
        public List<DobitnaKombinacija> DobitnaKombinacija { get; set; }
        public int KoncniSaldo { get; set; }
        public List<int> IzrebanaStevila { get; set; }

        public void izvedba(Loterija loterija)
        {
            int steviloVplacanih = vplacaneKombinacije.Count();
            int dobitniSklad=(int)Math.Floor(loterija.CenaKombinacije*0.9 *steviloVplacanih+koncniSaldo);
            if (dobitniSklad<loterija.GarantiranSklad)
            {
                dobitniSklad = loterija.GarantiranSklad;
            }
            Random rnd = new Random();
            for (int j = 0; j < loterija.SteviloIzrebanih; j++)
            {
                int nakljucna = rnd.Next(loterija.NaborStevil.Min, loterija.NaborStevil.Max + 1);
                while (izrebanaStevila.Contains(nakljucna))
                {
                    nakljucna = rnd.Next(loterija.NaborStevil.Min, loterija.NaborStevil.Max + 1);
                }
                izrebanaStevila.Add(nakljucna);
            }
            foreach (Kombinacija item in vplacaneKombinacije)
            {
                List<int> izrebana = item.IzbranaStevila.FindAll(x => izrebanaStevila.Contains(x));
                //se dokoncaj

            }

        }

        public void nakljucnaVplacila(Loterija loterija,int n)
        {
            for (int i = 0; i < n; i++)
            {
                List<int> lista = new List<int>();
                Random rnd = new Random();
                for (int j = 0; j < loterija.SteviloIzrebanih; j++)
                {
                    int nakljucna = rnd.Next(loterija.NaborStevil.Min, loterija.NaborStevil.Max + 1);
                    while (lista.Contains(nakljucna))
                    {
                        nakljucna = rnd.Next(loterija.NaborStevil.Min, loterija.NaborStevil.Max + 1);
                    }
                    lista.Add(nakljucna);
                }
                vplacaneKombinacije.Add(new Kombinacija(lista, DateTime.Now));
            }
        }

        public void priprava(Loterija loterija)
        {
            loterija.SeznamZrebanj.Add(this);
        }

        public void vplaciloKombinacije(Kombinacija kombinacija)
        {
            vplacaneKombinacije.Add(kombinacija);
        }
    }
}
