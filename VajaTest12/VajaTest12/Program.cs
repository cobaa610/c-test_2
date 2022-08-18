using System;
using System.Collections.Generic;
using System.Linq;

namespace VajaTest12
{
    public delegate void Delegat(Vozilo vozilo);
    class Program
    {
        static void Main(string[] args)
        {
            List<Vozilo> CentralnoSkladisce = new List<Vozilo>();
            Oprema o1 = new Oprema();
            o1.Cena_o = 300;
            Oprema o2 = new Oprema();
            o2.Cena_o = 400;
            Oprema o3 = new Oprema();
            o3.Cena_o = 500;
            Oprema o4 = new Oprema();
            o4.Cena_o = 200;
            List<Oprema> list1 = new List<Oprema>();
            list1.Add(o1);
            list1.Add(o2);
            list1.Add(o3);




            //zaka se overridajo cene

            Avto a1 = new Avto();
            a1.Cena = 1300;
            a1.Oprema = list1;




            Console.WriteLine(a1.Kon_cena()); a1.Kon_cena();



            Func<List<Vozilo>, int> NajvisjaCena = (List<Vozilo> CentralnoSkladisce) =>
           {
               int x = 0;
               foreach (var item in CentralnoSkladisce)
               {

                   if (x < item.Cena)
                   {
                       x = item.Cena;
                   }
               }

               return x;
           };
            Func<List<Vozilo>, String> Leto2018 = (List<Vozilo> CentralnoSkladisce) =>
             {
                 int leto = 2018;
                 string pravo_leto = "";
                 foreach (var item in CentralnoSkladisce)
                 {
                     if (item.Leto_izdelave == leto)
                     {
                         pravo_leto += item.Znamka + item.Model + ";";
                     }


                 }

                 return pravo_leto;

             };
            Func<List<Vozilo>, List < Vozilo >> Lambda3 = (List<Vozilo> CentralnoSkladisce) =>
            {
                int x=0;
                List<Vozilo> blabla = new List<Vozilo>();


                foreach (var item in CentralnoSkladisce)
                {
                    x = item.Kolesa();
                    if (x==4)
                    {
                        blabla.Add(item);
                    }
                } 

                return blabla;

            };
             Func<List<Vozilo>, string, List<Vozilo>> Lambda4 = (List<Vozilo> bljat, string kurva) =>
            {
                List<Vozilo> lalala = new List<Vozilo>();

                foreach (var item in bljat)
                {
                    if (item.Znamka == kurva)
                    {
                        lalala.Add(item);
                    }

                }

                return lalala;
            };
            
           





        }
    }
}
