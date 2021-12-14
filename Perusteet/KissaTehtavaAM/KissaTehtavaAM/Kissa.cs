using System;
using System.Collections.Generic;
using System.Text;

namespace KissaTehtavaAM
{
    class Kissa
    {
        private int ika;
        public string nimi;

        public Kissa()
        {
            ika = 0;
            nimi = "Esikoinen";
        }
        public Kissa(int ika, string nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }
        public void AsetaKissanNimi(string nimi)
        {
            this.nimi = nimi;
        }
        public string PalautaKissanNimi()
        {
            return nimi;
        }
        public int PalautaKissanIka()
        {
            return ika;
        }
    }
}
