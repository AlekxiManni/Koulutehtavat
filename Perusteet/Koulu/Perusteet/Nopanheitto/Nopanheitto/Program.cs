using System;
using System.Linq;

namespace Nopanheitto
{
    class Program
    {

        static void Main(string[] args)
        {
           
            Random noppa = new Random();
            
            int summa = 0;
            int[] luku = new int[5];
            int[] luku2 = new int[5];

            for (int i = 0; i < 5; i++)
            {
                luku[i] = noppa.Next(1, 7);
                luku2[i] = noppa.Next(1, 7);

                Console.WriteLine("Noppa 1: " + luku[i]);
                Console.WriteLine("Noppa 2: " + luku2[i]);
                Console.WriteLine();

                summa = luku.Sum() + luku2.Sum();

            }
            Console.WriteLine("Nopanheittojen tulosten summa = " + summa);

        }
    }
}
