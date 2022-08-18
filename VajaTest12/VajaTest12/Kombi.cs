using System;
using System.Collections.Generic;
using System.Text;

namespace VajaTest12
{
    class Kombi:Vozilo
    {
        private int st_oseb;
        public int St_oseb
        {
            get { return st_oseb; }
            set { st_oseb = value; }


        }

        public Kombi() 
        
        { 
       
        }
        public Kombi(string znamka, string model, int leto_izdelave, int cena,int st_oseb) :base(znamka, model, leto_izdelave, cena)
        {

            this.st_oseb = st_oseb;
        
        
        }
        public override int Kolesa()
        {
            return 4;
        }
        public override int Kon_cena()
        {
            return Cena;
        }
        public override string ToString()
        {
            return "Znamka: " + Znamka + "Model: " + Model + "Leto izdelave: " + Leto_izdelave + "Cena: " + Cena + "Število Oseb:" + St_oseb;
        }
    }
}
