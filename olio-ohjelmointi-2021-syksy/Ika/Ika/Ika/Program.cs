using System;
using ElainLuokat;

namespace Ika
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random();

            //for(int i = 0; i < 10; i++)
            //{

            //    Koira koira = new Koira();
            //    Kissa kissa = new Kissa();
            //    int koiranIka = random.Next(1, 15);
            //    int kissanIka = random.Next(1, 10);

            //    koira.AsetaKoiranIka(koiranIka);
            //    kissa.AsetaKissanIka(kissanIka);

            //    Console.WriteLine("Koira on: " + koira.PalautaKoiranIka() + " vuotta, Kissa on: " + kissa.PalautaKissanIka() + " vuotta.");

            //    if (koira.PalautaKoiranIka() == kissa.PalautaKissanIka())
            //    {
            //        Console.WriteLine("Koira ja kissa ovat saman ikäisiä");
            //    }
            //    if (koira.PalautaKoiranIka() > kissa.PalautaKissanIka())
            //    {
            //        Console.WriteLine("Koira on vanhempi");
            //    }
            //    if (koira.PalautaKoiranIka() < kissa.PalautaKissanIka())
            //    {
            //        Console.WriteLine("Kissa on vanhempi");
            //    }


            //}

            Elain elukka = new Elain();
            elukka.AsetaOnLihanSyoja(false);
            Console.WriteLine(elukka.PalautaOnLihanSyoja());
        }
    }
}
