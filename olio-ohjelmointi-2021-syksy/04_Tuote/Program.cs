using System;

namespace _04_Tuote
{
    class Program
    {
        static void Main(string[] args)
        {
            int maara = 13;
            string nimi = "Banaani";
            double hinta = 1.1;
            Tuote tulostus = new Tuote(nimi, hinta, maara);
            tulostus.tulostaTuote();

        }
    }
}
