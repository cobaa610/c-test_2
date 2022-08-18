using System;
using System.Collections.Generic;
using System.Text;

namespace VajaTest12
{
    class Motor:Vozilo
    {
        private int max_hitrost;
        private double pospešek;

        public int Max_hitrost
        {
            get { return max_hitrost; }
            set { max_hitrost = value; }


        }
        public double Pospešek
        {
            get { return pospešek; }
            set { pospešek = value; }


        }
        public Motor()

        {

        }
        public Motor(string znamka, string model, int leto_izdelave, int cena, int max_hitrost, double pospešek) : base(znamka, model, leto_izdelave, cena)
        {

            this.max_hitrost = max_hitrost;
            this.pospešek = pospešek;


        }
        public override int Kolesa()
        {
            return 2;
        }
        public override int Kon_cena()
        {
            return Cena;
        }
        public override string ToString()
        {
            return "Znamka: " + Znamka + "Model: " + Model + "Leto izdelave: " + Leto_izdelave + "Cena: " + Cena + "Maksimalna Hitrost:: " + Max_hitrost + "OD 1 do 100  " + Pospešek;
        }
    }

}
