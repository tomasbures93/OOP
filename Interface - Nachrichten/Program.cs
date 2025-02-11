using Interface___Nachrichten.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface___Nachrichten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TV kokotov = new TV("Kokot TV");
            TV RadioBlau = new TV("Blau ist die Zukunft!");
            Person Tomas = new Person("Tomas");
            Person Hanz = new Person("Hanz");
            Person Iveta = new Person("Iveta");
            Vermitler alles = new Vermitler("Mr. Alles");

            RadioBlau.Anmelden(Tomas);
            kokotov.Anmelden(Tomas);
            RadioBlau.Anmelden(Hanz);
            RadioBlau.Anmelden(Iveta);
            RadioBlau.Anmelden(alles);
            alles.Anmelden(Tomas);

            RadioBlau.SendeNachricht("Grüne politiker gehören in knasst-");
            kokotov.SendeNachricht("Habeck ist Schwachkopf");
            alles.SendeNachricht("Habeck ist Hü******hn");

            RadioBlau.Abmelden(Iveta);

            RadioBlau.SendeNachricht("Jo genau, er ist ein H***********");

        }
    }
}
