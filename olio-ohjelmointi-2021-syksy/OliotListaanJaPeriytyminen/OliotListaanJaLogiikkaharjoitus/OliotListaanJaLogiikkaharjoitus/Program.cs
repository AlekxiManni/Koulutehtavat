using System;
using ElainLuokat;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace OliotListaanJaLogiikkaharjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            int elaintenMaara;
            Random rnd = new Random();
            Console.WriteLine("Montako eläintä haluat listaan?");
            elaintenMaara = int.Parse(Console.ReadLine());

            List<Elain> elainLista = new List<Elain>();

            for (int i = 0; i < elaintenMaara; i++)
            {
                if (i % 4 == 3)
                {
                    //luo hevonen
                    Hevonen hevonen = new Hevonen();
                    hevonen.AsetaOnLihanSyoja(false);
                    hevonen.Poikaset=true;
                    elainLista.Add(hevonen);
                }
                else if (i % 3 == 0)
                {
                    //luo kissa
                    Kissa kissa = new Kissa();
                    kissa.AsetaOnLihanSyoja(true);
                    kissa.Poikaset = true;
                    elainLista.Add(kissa);
                }
                else if(i % 3 == 1)
                {
                    //luo koira
                    Koira koira = new Koira();
                    koira.AsetaOnLihanSyoja(true);
                    koira.Poikaset = true;
                    elainLista.Add(koira);
                }
                else
                {
                    //luo papukaija
                    Papukaija papukaija = new Papukaija();
                    papukaija.AsetaOnLihanSyoja(false);
                    papukaija.Lentaa = true;
                    elainLista.Add(papukaija);
                }
                //elainLista[elainLista.Count - 1].AsetaElainNimi("Yleinen eläinnimi");
                //elainLista[elainLista.Count - 1].AsetaElainIka(rnd.Next(0,20));

                elainLista.Last().AsetaElainNimi("Elain numero " + i);
                elainLista.Last().AsetaElainIka(rnd.Next(0, 20));

            }
            foreach (Elain elain in elainLista)
            {
                string lihansyoja = "ei ole lihansyöjä.";
                if (elain.PalautaOnLihanSyoja())
                {
                    lihansyoja = "on lihansyöjä";
                }
                Console.WriteLine(elain.PalautaElainNimi() + " on "+ elain.GetType()+" ja on " + elain.PalautaElainIka() + " vuotias ja " + lihansyoja); ;
            }

            foreach (Nisakkaat nisakas in elainLista.OfType<Nisakkaat>())
            {
                Console.WriteLine("Nisäkäs " +nisakas.Nimi+" onko maaeläin:- " + nisakas.Poikaset);
            }

            foreach (Linnut lintu in elainLista.OfType<Linnut>())
            {
                Console.WriteLine("Lintu " + lintu.Nimi + " Lentääkö lintu:- " + lintu.Lentaa);
            }
        }
    }
}
