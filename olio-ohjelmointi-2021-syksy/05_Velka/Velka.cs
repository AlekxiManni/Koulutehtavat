using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Velka
{
    class Velka
    {
        private double saldo;
        private double korkokerroin;

        public Velka(double saldoAlussa, double korkokerroinAlussa)
        {
            saldo = saldoAlussa;
            korkokerroin = korkokerroinAlussa;
        }
        public void tulostaSaldo()
        {
            Console.WriteLine(saldo);
        }
        public void odotaVuosi()
        {
            Console.WriteLine(saldo = saldo * 1 + korkokerroin);
        }
    }
}
