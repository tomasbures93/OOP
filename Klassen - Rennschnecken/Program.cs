using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen___Rennschnecken.models;

namespace Klassen___Rennschnecken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Schnecken
            Rennschnecke Jeremy = new Rennschnecke("Jeremy Clarkson", 5);
            Rennschnecke James = new Rennschnecke("James may", 2);
            Rennschnecke Bober = new Rennschnecke("Bober Kurwa", 4);
            Rennschnecke Tomas = new Rennschnecke("Tomas", 3);

            Console.WriteLine(Jeremy.Ausgabe());
            Console.WriteLine(James.Ausgabe());
            Console.WriteLine("");
            // race
            Rennen race = new Rennen("Race or die", 3, 25);
            Console.WriteLine(race.Ausgabe());

            race.AddSchnecke(Jeremy);
            race.AddSchnecke(James);
            race.AddSchnecke(Bober);
            //race.AddSchnecke(Tomas);

            Console.WriteLine(race.Ausgabe());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
