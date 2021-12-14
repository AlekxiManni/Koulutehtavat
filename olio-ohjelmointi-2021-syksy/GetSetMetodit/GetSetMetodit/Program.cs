using System;
using ElainLuokat;


namespace GetSetMetodit
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira koira1 = new Koira();
            Console.WriteLine(koira1.AsetaKoiranNimi("Max"));
            Console.WriteLine(koira1.PalautaKoiranNimi());
            Console.WriteLine(koira1.AsetaKoiranNimi("Musti"));
            Console.WriteLine(koira1.PalautaKoiranNimi());
            
            
        }
    }
}
