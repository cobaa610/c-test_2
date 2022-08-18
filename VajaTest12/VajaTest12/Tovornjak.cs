using System;
using System.Collections.Generic;
using System.Text;

namespace VajaTest12
{
    class Tovornjak:Vozilo
    {
        private int nosilnost;
        private char kat_izpit;
        private int st_koles;

        public int Nosilnost
        {
            get { return nosilnost; }
            set { nosilnost = value; }


        }
        public char Kat_izpit
        {
            get { return kat_izpit; }
            set { kat_izpit = value; }


        }
        public int St_koles
        {
            get { return st_koles; }
            set { st_koles = value; }


        }
        public Tovornjak()

        {

        }
        public Tovornjak(string znamka, string model, int leto_izdelave, int cena, int nosilnost,char kat_izpit,int st_koles) : base(znamka, model, leto_izdelave, cena)
        {

            this.nosilnost = nosilnost;
            this.kat_izpit = kat_izpit;
            this.st_koles = st_koles;


        }
        public override int Kolesa()
        {
            return st_koles;
        }
        public override int Kon_cena()
        {
            return Cena;
            
        }
        public override string ToString()
        {
            return "Znamka: " + Znamka + "Model: " + Model + "Leto izdelave: " + Leto_izdelave + "Cena: " + Cena + "Nosilnost: " + Nosilnost + "Kategorija izpita: " + Kat_izpit + "Število koles: " + St_koles;
        }

    }
}
