using System;

namespace _08_Maksukortti
{
    class Program
    {
        static void Main(string[] args)
        {
            Maksukortti pekanKortti = new Maksukortti(20);
            Maksukortti matinKortti = new Maksukortti(30);
            pekanKortti.syoMaukkaasti();
            matinKortti.syoEdullisesti();
            Console.WriteLine("Pekka " + pekanKortti.ToString());
            Console.WriteLine("Matti " + matinKortti.ToString());
            pekanKortti.lataaRahaa(20);
            matinKortti.syoMaukkaasti();
            Console.WriteLine("Pekka " + pekanKortti.ToString());
            Console.WriteLine("Matti " + matinKortti.ToString());
            pekanKortti.syoEdullisesti();
            pekanKortti.syoEdullisesti();
            matinKortti.lataaRahaa(50);
            Console.WriteLine("Pekka " + pekanKortti.ToString());
            Console.WriteLine("Matti " + matinKortti.ToString());
        }
    }
}
