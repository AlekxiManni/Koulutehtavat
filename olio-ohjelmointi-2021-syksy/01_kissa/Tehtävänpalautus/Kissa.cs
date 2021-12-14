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
            nimi = "Miuku";
        }
        public override string ToString()
        {
            return "Kissa: " + nimi + ", ikä " + ika + ".";
        }
        //public Kissa(int ika, string nimi)
        //{
        //    this.ika = ika;
        //    this.nimi = nimi;
        //}
        public bool AsetaKissanIka()
        {
            bool muutos;
            if(ika < 0)
            {
                return false;
            }
            else
            {
                this.ika = ika;
                return true;
            }
            
        }
        public bool AsetaKissanNimi(string uusiNimi)
        {
            bool onnistui;
            if(String.Equals(uusiNimi,"hilda",StringComparison.CurrentCultureIgnoreCase))
            {
                onnistui = false;
            }
            else
            {
                this.nimi = uusiNimi;
                onnistui = true;
            }
            return onnistui;
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
