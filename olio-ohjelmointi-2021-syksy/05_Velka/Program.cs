using System;

namespace _05_Velka
{
    class Program
    {
        static void Main(string[] args)
        {
            Velka velanmaara = new Velka(1000, 5);
            velanmaara.tulostaSaldo();
            velanmaara.odotaVuosi();
            velanmaara.tulostaSaldo();
            velanmaara.odotaVuosi();
            velanmaara.tulostaSaldo();
            velanmaara.odotaVuosi();
            velanmaara.tulostaSaldo();
            velanmaara.odotaVuosi();
        }
    }
}
