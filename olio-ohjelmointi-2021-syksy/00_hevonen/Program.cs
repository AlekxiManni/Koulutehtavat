using System;

namespace OlioOhjelmointi
{
    class Hevonen
    {
        public string nimi;
        public float paino;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Hevonen polle = new Hevonen();
            Console.WriteLine(polle.nimi + "  " + polle.paino);
            polle.nimi = "Histamiini";
            polle.paino = 89;
            Console.WriteLine(polle.nimi + "  " + polle.paino);
        }
    }
}
