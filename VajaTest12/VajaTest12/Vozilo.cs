using System;
using System.Collections.Generic;
using System.Text;

namespace VajaTest12
{
    public abstract class Vozilo
    {
        private string znamka;
        private string model;
        private int leto_izdelave;
        private int cena;
        public event Delegat obvesti = null;
        public string Znamka {
            get { return znamka; }
            set { znamka = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Leto_izdelave
        {
            get { return leto_izdelave; }
            set { leto_izdelave = value; }


        }
        public int Cena
        {
            get { return cena; }
            set { cena = value; }
        }

        public Vozilo()
        {

        }
        public Vozilo(string znamka, string model, int leto_izdelave, int cena)
        {
            this.znamka = znamka;
            this.model = model;
            this.leto_izdelave = leto_izdelave;
            this.cena = cena;


        }

        public abstract int Kolesa();
        public abstract int Kon_cena();
       
       


    }
}
