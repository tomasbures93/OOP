using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen___Bankkonten.Models;

namespace Klassen___Bankkonten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tGirokonto");
            Girokonto giro = new Girokonto("Tomas", "Bures", "123 Bambus str., Bochum", "DE12345", 3000, new DateTime(2000, 3, 25), 0, Kategorie.Schuler);

            Console.WriteLine(giro.Zinsen());
            Console.WriteLine(giro.KontoStand());
            giro.Einzahlen(2000);
            Console.WriteLine(giro.KontoStand());
            giro.Auszahlen(5300);
            Console.WriteLine(giro.KontoStand());
            Console.WriteLine(giro.Zinsen());
            Console.WriteLine(giro.KontoInfo());

            Console.WriteLine("\n\tSparkonto");
            Sparkonto sparkonto = new Sparkonto("Tomas", "Bures", "123 Bambus str., Bochum", "DE12345", 2000, new DateTime(2000, 3, 25), 0, 0.5);
            Console.WriteLine(sparkonto.Zinsen());
            Console.WriteLine(sparkonto.KontoStand());
            sparkonto.Einzahlen(2000);
            Console.WriteLine(sparkonto.KontoStand());
            sparkonto.Auszahlen(5300);
            Console.WriteLine(sparkonto.KontoStand());
            Console.WriteLine(sparkonto.Zinsen());
            Console.WriteLine(sparkonto.KontoInfo());

            Console.WriteLine("\n\tFestgeldkonto");
            Festgeldkonto festgeldkonto = new Festgeldkonto("Tomas", "Bures", "123 Bambus str., Bochum", "DE12345", 2000, new DateTime(2000, 3, 25), 2, new DateTime(2026, 3, 25));
            Console.WriteLine(festgeldkonto.Zinsen());
            Console.WriteLine(festgeldkonto.KontoStand());
            festgeldkonto.Einzahlen(2000);
            Console.WriteLine(festgeldkonto.KontoStand());
            festgeldkonto.Auszahlen(5300);
            Console.WriteLine(festgeldkonto.KontoStand());
            Console.WriteLine(festgeldkonto.Zinsen());
            Console.WriteLine(festgeldkonto.RestLaufZeit());
            Console.WriteLine(festgeldkonto.KontoInfo());
        }
    }
}
