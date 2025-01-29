using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen___Koordinatensystem.models;

namespace Klassen___Koordinatensystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt punkt1 = new Punkt(1, 1);
            Punkt punkt2 = new Punkt(4, 8);
            Vektor vektor = new Vektor(punkt1, punkt2);
            Console.WriteLine($"Vektor Berechnung von Punkt {punkt1.PrintPunkt()} und {punkt2.PrintPunkt()} ist {vektor.Lange()} .");

            Kreis kreis = new Kreis(20);
            Console.WriteLine(kreis.Umfang());
            Console.WriteLine(kreis.Inhalt());
            Console.ReadKey();
        }
    }
}
