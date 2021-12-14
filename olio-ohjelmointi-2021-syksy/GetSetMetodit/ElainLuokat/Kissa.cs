using System;
using System.Collections.Generic;
using System.Text;

namespace ElainLuokat
{
    public class Kissa : Nisakkaat
    {
        private List<Kissa> pennut = new List<Kissa>();

        private Kissa emo;

        public List<Kissa> Pennut1 { get => pennut; set => pennut = value; }

        public Kissa Emo { get => emo; set => emo = value; }

        public Kissa(string nimi, int ika)
        {
            this.AsetaElainNimi(nimi);
            this.AsetaElainIka(ika);
        }
        public int LisaaPentu(string nimi, int ika=0)
        {
            Kissa pentu = new Kissa(nimi,this,ika);
            Pennut1.Add(pentu);
            return Pennut1.Count;
        }
        public Kissa()
        {
            string nimi;
            int ika = 0;
        }
        public Kissa(string nimi, Kissa emo, int ika = 0) : this(nimi, ika)
        {
            this.Emo = emo;
        }
    }
}
