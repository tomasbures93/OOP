using Klassen___Gehaltsberechnung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Gehaltsberechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angestellte tomas = new Angestellte("Bures", "Tomas", 31, Tarif.B);
            Console.WriteLine("Tomas B: " + tomas.GehaltBerechnen());
            Angestellte tomas2 = new Angestellte("Bures", "Tom", 40, Tarif.A);
            Console.WriteLine("Tomas A: " + tomas2.GehaltBerechnen());
            Angestellte tomas3 = new Angestellte("Bus", "Tomas", 31, Tarif.D);
            Console.WriteLine("Tomas D: " + tomas3.GehaltBerechnen());
            Angestellte tomas4 = new Angestellte("Bures", "Toms", 31, Tarif.C);
            Console.WriteLine("Tomas C: " + tomas4.GehaltBerechnen());

            Extern pepa = new Extern("Pepa", "pepicek", 32, 150);
            Console.WriteLine("Pepa: "+ pepa.GehaltBerechnen());
            Extern pepa2 = new Extern("Pepa2", "pepicek", 32, 50);
            Console.WriteLine("Pepa2 : " + pepa2.GehaltBerechnen());

            Praktikant Karel = new Praktikant("Karel", "Vomacka", 40, Abteilung.Produktion);
            Console.WriteLine("Karel " + Karel.GehaltBerechnen());
            Praktikant Karel3 = new Praktikant("Karel", "Vomacka", 40, Abteilung.Vertrieb);
            Console.WriteLine("Karel3 " + Karel3.GehaltBerechnen());
            Praktikant Karel2 = new Praktikant("Karel", "Vomacka", 40, Abteilung.Entwicklung);
            Console.WriteLine("Karel2 " + Karel2.GehaltBerechnen());

            
        }
    }
}
