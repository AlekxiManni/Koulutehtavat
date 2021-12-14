using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Tuote
{
    class Tuote
    {
        double hinta;
        int lukumaara;
        string nimi;

        public Tuote(string nimiAlussa, double hintaAlussa, int maaraAlussa)
        {
            this.hinta = hintaAlussa;
            this.lukumaara = maaraAlussa;
            this.nimi = nimiAlussa;

        }
        public void tulostaTuote()
        {
            Console.WriteLine(nimi + ", hinta " + hinta + ", " + lukumaara + " kpl");
            
        }

    }
}
