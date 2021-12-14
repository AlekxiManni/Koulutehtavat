using System;

namespace KissaTehtavaAM
{
    
    
    class Program
    {

        static void Main(string[] args)
        {
            Kissa katti = new Kissa();

            Console.WriteLine(katti.nimi);
            katti.AsetaKissanNimi("Kalle");
            
            Console.WriteLine(katti.nimi);
            Console.WriteLine(katti.PalautaKissanIka());

            Kissa uusikatti = new Kissa(13, "UusiKissaOlioNimi");
            Console.WriteLine(uusikatti.PalautaKissanIka() + " " + uusikatti.nimi) ;

        }
    }
}
