using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Elain
    {
        private int ika;
        private string nimi;
        private bool OnLihanSyoja;

        public string Nimi { get => nimi; set => nimi = value; }

        public void AsetaOnLihanSyoja(bool onko)
        {
            OnLihanSyoja = onko;
        }
        public bool PalautaOnLihanSyoja()
        {
            return OnLihanSyoja;
        }

        public void AsetaElainIka(int ika)
        {
            if (ika > 0)
            {
                this.ika = ika;
            }

        }
        public void AsetaElainNimi(string uusiNimi)
        {
            nimi = uusiNimi;
        }
        public string PalautaElainNimi()
        {
            return nimi;
        }
        public int PalautaElainIka()
        {
            return ika;
        }
        public virtual void Aantelee()
        {
            Console.WriteLine("Umph!");
        }

    }
}
