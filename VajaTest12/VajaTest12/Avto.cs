using System;
using System.Collections.Generic;
using System.Text;

namespace VajaTest12
{
    class Avto  :  Vozilo
    {
        private List<Oprema> oprema;
        public List<Oprema> Oprema {
            get { return oprema; }
            set { oprema = value; }
        }

        public Avto()
        { 
        
        
        }
        public Avto(List<Oprema> oprema, string znamka, string model, int leto_izdelave, int cena):base(znamka,model,leto_izdelave,cena)
        {
            this.oprema = oprema;
        
        }

        public override int Kolesa()
        {
            return 4;
        }
        public override int Kon_cena()
        {
            int x=0;
            foreach (var item in oprema)
            {
                x = item.Cena_o;
                x = Cena + x;
            }

            return x;
        }
        public override string ToString()
        {
            return "Znamka: " + Znamka + "Model: " + Model + "Leto izdelave: " + Leto_izdelave + "Cena: " + Cena + "Oprema: " + Oprema;
        }

    }
}
