using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphie___Haustiere.Models;

namespace Polymorphie___Haustiere
{
    internal class Program
    {
        static Haustier[] pets = new Haustier[8];

        static void Anlegen()
        {
            pets[0] = new Hund("Zerik", 1200, "Malamut", true);
            pets[1] = new Hund("Jason", 2500, "Husky", true);
            pets[2] = new Vogel("Marty", true, 500, false);
            pets[3] = new Vogel("Herbert", true, 500, false);
            pets[4] = new Katze("Maja", false, 100);
            pets[5] = new Katze("Garfield", false, 100);
            pets[6] = new Katze("Blackrock", false, 100);
            pets[7] = new Vogel("Papagay", true, 100, false);
         }

        static void Main(string[] args)
        {
            Anlegen();
            NeuerLieblingsvogel();
            NeuerLieblingsvogel();
            NeuerLieblingsvogel();
            Ausgeben();
        }

        static void NeuerLieblingsvogel()
        {
            Katze katze = null;
            Vogel vogel = null;

            foreach (var tier in pets)
            {
                if (tier is Katze k) katze = k;
                if (tier is Vogel v) vogel = v;
                if (katze != null && katze.HatVogel() == false && vogel != null) break;
            }

            if (katze != null && vogel != null)
            {
                katze.SetVogel(vogel);
                Console.WriteLine($"{katze.GetName()} hat jetzt {vogel.GetName()} als Lieblingsvogel.");
            }
        }

        static void Ausgeben()
        {
            double gesamtKosten = 0;
            foreach (var tier in pets)
            {
                Console.WriteLine($"Typ: {tier.GetType().Name}");
                Console.WriteLine(tier.Beschreibung());
                gesamtKosten += tier.GetKosten();
                Console.WriteLine();
            }
            Console.WriteLine($"Gesamte Tierarztkosten: {gesamtKosten} EUR");
        }

    }
}
