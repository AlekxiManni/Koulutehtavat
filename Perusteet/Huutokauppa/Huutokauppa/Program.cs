using System;
using System.Collections.Generic;
using System.Linq;

namespace Huutokauppa
{
    class Program
    {
        static void Main(string[] args)
        {
            int tavoiteHinta;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            tavoiteHinta = TavoiteHinta();
            HuutoKauppaStart(tavoiteHinta);
        }
        /// <summary>
        /// Asetetaan huutokaupan tavoitehinta. Tavoitehinnan mukaan määritellään Seuranta(); aliohjelman laskutoimituksia, mistä voidaan seurata miten huutokauppa etenee.
        /// </summary>
        /// <returns></returns>
        static int TavoiteHinta()
        {
            bool kysyUudelleen;
            int tavoiteHinta;
            Console.WriteLine("Aseta huutokaupan tavoitehinta");
            kysyUudelleen = int.TryParse(Console.ReadLine(), out tavoiteHinta);
            while (!kysyUudelleen)
            {
                Console.WriteLine("Anna hinta ilman kirjaimia");
                kysyUudelleen = int.TryParse(Console.ReadLine(), out tavoiteHinta);
            }
            Console.WriteLine("Asetettu tavoitehinta: " + tavoiteHinta + "€");
            return tavoiteHinta;
        }
        /// <summary>
        /// Jätetty ylempi osa kommentteihin. Testattu ohjelmaa näillä tuotteilla. Lisätty ominaisuus että voidaan itse määrittää myytävät tuotteet.
        /// </summary>
        /// <returns></returns>
        static List<string> HuutokaupattavatTuotteet()
        {
            List<string> tuotteet = new List<string>();
            //tuotteet.Add("Kuparipannu");
            //tuotteet.Add("Markun tekemä linnunpönttö");
            //tuotteet.Add("Muumimuki");

            string tuoteNimi;
            Console.WriteLine("Anna tuotteiden nimiä ja lopeta syöttämällä L");
            tuoteNimi = Console.ReadLine();
            while (tuoteNimi != "L")
            {
                tuotteet.Add(tuoteNimi);
                tuoteNimi = Console.ReadLine();
            }
            return tuotteet;
        }
        /// <summary>
        /// Huutokaupan aloitus. Luetellaan for-loopilla listattuja tuotteita vuorotellen. Jokaisen loopin aikana käydään Seuranta(); aliohjelmassa mistä näkee huutokaupan kulkua.
        /// Tässä aliohjelmassa kuitenkin kerrotaan suoraan oliko edellinen tuote kalliimpi vai halvempi kuin edellinen.
        /// </summary>
        /// <param name="tavoiteHinta"></param>
        static void HuutoKauppaStart(int tavoiteHinta)
        {
            List<string> tuotteet = HuutokaupattavatTuotteet();
            int kappaleMaara = tuotteet.Count;
            int[] hinnat = new int[kappaleMaara];
            Console.WriteLine("Huutokaupan tavoitehinta: " + tavoiteHinta + "€");
            Console.WriteLine();
            Console.WriteLine("Aloitetaan huutokauppa!");
            Console.WriteLine();
            for(int i= 0; i < kappaleMaara; i++)
            {
                Console.WriteLine("Huudetaan " + tuotteet[i]);
                Console.WriteLine();
                hinnat[i] = HuudettavaTuote();
                Seuranta(hinnat, tavoiteHinta);//jokainen silmukan kierros menee Seuranta(); aliohjelmaan mistä näkee huutokaupan kulun.
                if (i > 0)
                {
                    if (hinnat[i] > hinnat[i - 1])
                    {
                        Console.WriteLine("Tuote oli kalliimpi kuin edellinen");
                    }
                    else
                    {
                        Console.WriteLine("Tuote oli halvempi kuin edellinen");
                    }
                }
            }
            LoppuTulostus(hinnat, tuotteet);//kun huutokaupan silmukka on ohi, siirrytään lopputulostukseen.

            /// Seurantaan tuodaan parametrina hinnat ja tavoitehinta mitä lasketaan ja vertaillaan. Meklarille kerrotaan huutokaupan kulun aikana tietoja onko tavoitehinta saavutettu, onko voittoa yms.
            static void Seuranta(int[] hinnat, int tavoiteHinta)
            {
                
                int summa = hinnat.Sum();
                
                if (tavoiteHinta <= summa)
                {
                    Console.WriteLine("Tavoitehinta saavutettu!");
                }
                if(summa>tavoiteHinta)
                {
                    Console.Write("Voittoa yhteensä: ");Console.WriteLine(summa - tavoiteHinta + "€");
                }
                else
                {
                    Console.Write("Tavoitehintaan jäljellä "); Console.WriteLine(tavoiteHinta - summa + "€");
                }
            }
            ///Lopputulostuksessa nähdään kaikki tuotteet ja niille määräytynyt hinta sekä mikä oli kallein tuote.
            static void LoppuTulostus(int[] hinnat, List<string> tuotteet)
            {
                int maksimiHinta;
                Console.WriteLine("Huutokaupatut tuotteet: ");
                for (int i = 0; i < tuotteet.Count; i++)
                {
                    Console.WriteLine(tuotteet[i] + ": " + hinnat[i] + "€");
                }
                maksimiHinta = hinnat.Max();
                int paikka = Array.IndexOf(hinnat, maksimiHinta);


                Console.WriteLine("Kallein tuote oli " + tuotteet[paikka] +" "+ hinnat.Max() + " €");
            }
            ///Yksittäisen huudettavan tuotteen valikko. Ohjelma ohjeistaa käyttäjää miten toimia. Tuotteen hinta viedään HuutokauppaStart(); aliohjelman taulukkoon.
            static int HuudettavaTuote()
            {
                int jatketaanko = 1;
                bool onnistui = true;
                int hinta = 0;
                bool huutoFail;
                while (onnistui)
                {
                    if (hinta > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Paina 1 jos haluat vastaanottaa huutoja. Paina 2 jos huudot on ohi");
                        Console.WriteLine("Jatketaanko?");
                        Console.WriteLine();
                        jatketaanko = int.Parse(Console.ReadLine());
                    }
                    switch (jatketaanko)
                    {
                        case 1:
                            Console.WriteLine("Huudettu tähän mennessä " + hinta + "€");
                            Console.WriteLine("Anna hinta");
                            huutoFail = int.TryParse(Console.ReadLine(), out hinta);
                            while (!huutoFail)
                            {
                                if (huutoFail)
                                {
                                    Console.WriteLine(hinta);
                                    onnistui = true;
                                }
                                else
                                {
                                    Console.WriteLine("Yritä uudelleen ilman kirjaimia.");
                                    huutoFail = int.TryParse(Console.ReadLine(), out hinta);
                                }
                            }
                            break;
                        case 2:
                            onnistui = false;
                            break;

                        default:
                            Console.WriteLine("Yritä uudelleen");
                            onnistui = true;
                            break;
                    }
                }
                return hinta;
            }
        }
    }
}
