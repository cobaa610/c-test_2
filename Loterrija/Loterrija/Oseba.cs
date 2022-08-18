using System;
using System.Collections.Generic;
using System.Text;

namespace Loterrija
{
    class Oseba
    {
        string ime;
        string priimek;
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public void izpis(string a,string b )
        {
            Console.WriteLine("Zdravo "+ ime+".Žreb- "+a+", V igri je bilo kar"+a+"€. Izžrebane številke so bile:"+b); 
        }
        public void PrijavaObvesilo(Loterija loterija)
        {
            loterija.obvesti += izpis;
        }
    }
}
