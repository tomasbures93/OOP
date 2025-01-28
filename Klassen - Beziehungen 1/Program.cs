using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen___Beziehungen_1.Models;

namespace Klassen___Beziehungen_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person tomas = new Person("Bures", "Tomas", 31);

            tomas.SetAdresse("Beststr.", "20", "44805", "Bochum");
            Console.WriteLine("\nAdresse eingegeben");
            Console.WriteLine(tomas.GetAdresse());

            Console.WriteLine("\nGet Info");
            tomas.GetInfo();
            Console.WriteLine("\nGetName");
            Console.WriteLine(tomas.GetName());
            Console.WriteLine("\nGetAlter");
            Console.WriteLine(tomas.GetAlter());

            Console.WriteLine("\nAdresse und Name Gewechselt");
            tomas.SetNachname("Bober Kurwa");
            tomas.SetAdresse("River", "21", "1", "Amerika");
            tomas.GetInfo();

            Console.WriteLine("\nHund Gekauft");
            tomas.SetHund("Jamal");
            Console.WriteLine(tomas.GetHundeName());
            Console.WriteLine(tomas.GetHund());

            Console.WriteLine("\nHund hat was gegesen");
            tomas.HundFuttern();
            Console.WriteLine(tomas.GetHund());

            Console.WriteLine("\nHund gassi gehen");
            tomas.HundGassi();
            Console.WriteLine(tomas.GetHund());
            Console.WriteLine(tomas.IstHundBesitzer());


            Console.WriteLine("\n\n\nneue Person");
            Person Kind = new Person("Jana", "Helena", 15);
            Kind.SetAdresse("Beststr.", "20", "44805", "Bochum");
            Kind.GetInfo();
            Kind.SetHund("Lamaj");
            Console.WriteLine(Kind.GetHundeName());
            Console.WriteLine(Kind.GetHund());

            Console.WriteLine("\nHund hat was gegesen");
            Kind.HundFuttern();
            Console.WriteLine(Kind.GetHund());

            Console.WriteLine("\nHund gassi gehen");
            Kind.HundGassi();

            Console.WriteLine("\nSie ist zu jung, musste hund abgeben");
            Kind.HundAbgeben();

            Console.WriteLine(Kind.IstHundBesitzer());

            Console.WriteLine("\n\n\nHund Alleine");
            Hund jako = new Hund("jako");
            Console.WriteLine(jako.GetInfo());

            Console.ReadKey();
        }
    }
}
