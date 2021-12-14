using System;

namespace KissaTehtavaAM
{
    
    
    class Program
    {

        static void Main(string[] args)
        {
            //Kissa miukumauku = new Kissa();

            //Console.WriteLine(miukumauku.nimi);
            //miukumauku.AsetaKissanNimi("Kalle");

            //Console.WriteLine(miukumauku.nimi);
            //Console.WriteLine(miukumauku.PalautaKissanIka());

            //Kissa uusikatti = new Kissa(13, "UusiKissaOlioNimi");
            //Console.WriteLine(uusikatti.PalautaKissanIka() + " " + uusikatti.nimi) ;


            //bool onnistuiko;

            //Kissa katti = new Kissa();
            //onnistuiko = katti.AsetaKissanNimi("Anneli");
            //Console.WriteLine(onnistuiko);

            //Console.WriteLine(katti.PalautaKissanNimi());
            //katti.AsetaKissanNimi("Hilda");
            //onnistuiko = katti.AsetaKissanNimi("Hilda");
            //Console.WriteLine(onnistuiko);
            //Console.WriteLine(katti.PalautaKissanNimi());

            Kissa katti = new Kissa();
            Console.WriteLine(katti);
        }
    }
}
