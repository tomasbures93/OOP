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
        static void Main(string[] args)
        {
            Vogel v = new Vogel("Marty", true, 500, false);

            Haustier[] haustier =
            {
                new Hund("Zerik", 1200, "Malamut", true),
                new Hund("Jason", 2500, "Husky", true),
                new Vogel("Marty", true, 500, false),
                new Vogel("herbert", true, 500, false),
                new Katze("Maja", false, 100),
                new Katze("Garfield", false,v, 100),
                new Katze("Blackrock", false, 100)
            };

            double kosten = 0;
            foreach (Haustier haustier1 in haustier)
            {
                Console.WriteLine(haustier1.Ausgeben());
                kosten = kosten + haustier1.GetKosten();
            }
            Console.WriteLine($"\nGesamte Tierartzkosten: {kosten} Euro");

        }

    }
}
