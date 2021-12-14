using System;
using System.Collections.Generic;

namespace RandomIlmanToistoa
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] kaksiUlotteinen = new string[5, 5];
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; i < 5; i++)
                {
                    kaksiUlotteinen[i, j] = "x";
                }
            }
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write(kaksiUlotteinen[j, i]);
                    Console.WriteLine();
                }
            }

            
        }
    }
}
