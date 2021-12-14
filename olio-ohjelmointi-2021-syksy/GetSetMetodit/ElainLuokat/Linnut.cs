using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Linnut : Elain
    {
        private bool lentaa;

        public bool Lentaa { get => lentaa; set => lentaa = value; }

        public void LintuOminaisuus(bool osaaLentaa)
        {
            Lentaa = osaaLentaa;
        }
        public bool LintuOminaisuusPalautus()
        {
            return Lentaa;
        }
        


    }
}
