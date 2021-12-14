using System;
using ElainLuokat;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PennutJaEmot
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa emo = new Kissa("Emo 1",4);

            emo.LisaaPentu("Pentu 1", 1);
            emo.LisaaPentu("Pentu 2", 2);
            emo.LisaaPentu("Pentu 3", 3);

            foreach(Kissa pentu in emo.Pennut1)
            {
                Console.WriteLine(pentu.PalautaElainNimi() + " " + pentu.PalautaElainIka() + " vuotias ja emo on " + pentu.Emo.PalautaElainNimi()) ;
            }

            Kissa emo2 = new Kissa("Emo 2", 4);

            emo2.LisaaPentu("Pentu 2-1", 1);
            emo2.LisaaPentu("Pentu 2-2", 2);
            
            foreach (Kissa pentu in emo2.Pennut1)
            {
                Console.WriteLine(pentu.PalautaElainNimi() + " " + pentu.PalautaElainIka() + " vuotias ja emo on " + pentu.Emo.PalautaElainNimi());
            }

        }
    }
}
