using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Maksukortti
{
    class Maksukortti
    {
        private double saldo;
        public Maksukortti(double alkuSaldo)
        {
            saldo = alkuSaldo;
        }
        public void lataaRahaa(double lisaaRahaa)
        {
            if(lisaaRahaa < 0)
            {
                lisaaRahaa = 0;
            }
            else
            {
                this.saldo = saldo + lisaaRahaa;
            }
        }
        public void syoEdullisesti()
        {
            if(saldo >= 2.60)
            {
                this.saldo = saldo - 2.60;
            }
        }

        public void syoMaukkaasti()
        {
            if (saldo >= 4.60)
            {
                this.saldo = saldo - 4.60;
            }
        }

        public override String ToString()
        {
            return "kortilla on rahaa " + saldo + " euroa";
            //return $"Kortilla on rahaa {saldo:N2} euroa";
            //return "Kortilla on rahaa " + String.Format("{0:0.00}", saldo) + " euroa";
        }
    }
}
