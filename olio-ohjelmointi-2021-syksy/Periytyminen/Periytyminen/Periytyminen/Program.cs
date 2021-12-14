using System;
using ElainLuokat;
namespace Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa kisu = new Kissa();
            kisu.AsetaElainNimi("Jooseppi");
            kisu.AsetaElainIka(13);
            kisu.AsetaOnLihanSyoja(true);

            Console.WriteLine(kisu.PalautaElainNimi() + " " + kisu.PalautaElainIka() + " " + kisu.PalautaOnLihanSyoja());
            kisu.Kehraa();

            Koira doge = new Koira();
            doge.AsetaElainNimi("Naamanka");
            doge.AsetaElainIka(8);
            doge.AsetaOnLihanSyoja(true);
            Console.WriteLine(doge.PalautaElainNimi() + " " + doge.PalautaElainIka() + " " + doge.PalautaOnLihanSyoja());

            Nisakkaat nisakas = new Nisakkaat();



            doge.Aantelee();
            kisu.Aantelee();
            nisakas.Aantelee();


            Koira koira5 = new Koira();
            

            Papukaija parrot = new Papukaija();
            parrot.AsetaElainNimi("Merirosvokaija");
            parrot.AsetaElainIka(14);
            parrot.LintuOminaisuus(true);

            koira5.AsetaElainNimi("PabloEscobar");
            koira5.AsetaElainIka(4);
            koira5.NisakasOminaisuus(true);


            Console.WriteLine("Eläimen nimi " + parrot.PalautaElainNimi()+", Eläimen ikä: "+ parrot.PalautaElainIka()+" linnun ominaisuus: " + parrot.LintuOminaisuusPalautus());
            Console.WriteLine("Eläimen nimi " + koira5.PalautaElainNimi() + ", Eläimen ikä: " + koira5.PalautaElainIka() + " koiran ominaisuus: " + koira5.NisakasOminaisuusPalautus());



            //while (true)
            //{
            //    Hevonen polle = new Hevonen();
            //}

            //Hevonen rusko;
            //while (true)
            //{
            //    rusko= new Hevonen();
            //}




        }
    }
}
