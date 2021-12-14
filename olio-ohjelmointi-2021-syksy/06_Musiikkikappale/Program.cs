using System;

namespace _06_Musiikkikappale
{
    class Program
    {
        static void Main(string[] args)
        {
            string nimi = "In The Garden";
            int pituus = 10910;

            Musiikkikappale garden = new Musiikkikappale(nimi, pituus);
            Console.WriteLine("Kappaleen " + garden.Nimi() + " pituus on " + garden.Pituus() + " sekuntia.");
        }
    }
}
