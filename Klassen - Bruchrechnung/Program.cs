using Klassen___Bruchrechnung.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Bruchrechnung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] split;
            int zahler = 0, nenner = 0;
            Bruch bruch = new Bruch();
            do
            {
                Console.Clear();
                Console.WriteLine("\tKlassen Bruchrechnung\n");
                Console.WriteLine("Bitte geben sie Bruch ein ( 1/2 )");
                input = Console.ReadLine();
                if (input.Contains('/'))
                {
                    split = input.Split('/');
                    if (int.TryParse(split[0], out zahler) && int.TryParse(split[1], out nenner))
                    {
                        bruch = new Bruch(zahler, nenner);
                        break;
                    } else
                    {
                        Console.WriteLine("Wrong input - Bitte ziffern benutzen!\n");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Fehler - Wrong input ... '/' missing!");
                    Console.ReadKey();
                }
            } while (true);
            Console.WriteLine($"\nBruch ausgabe: {bruch.Ausgabe()}");
            Console.WriteLine($"Kehrwert Bruch: {bruch.Kehrwert().Ausgabe()}");
            Console.WriteLine($"Bruch Kurzen: {bruch.Kurzen().Ausgabe()}\n");

            Bruch bruch1 = new Bruch();
            Bruch bruch2 = new Bruch();
            Console.WriteLine("\n\tRechnen mit Bruch\n");
            do
            {
                Console.WriteLine("Bitte geben sie Bruch nummer 1 ein in format ( 1/4 ):");
                input = Console.ReadLine();
                if (input.Contains('/'))
                {
                    split = input.Split('/');
                    if (int.TryParse(split[0], out zahler) && int.TryParse(split[1], out nenner))
                    {
                        // wenn alles okay ist
                        bruch1 = new Bruch(zahler, nenner);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input - Bitte ziffern benutzen!\n");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Fehler - Wrong input ... '/' missing!\n");
                    Console.ReadKey();
                }
            } while (true);
            do
            {
                Console.WriteLine("Bitte geben sie Bruch nummer 2 ein in format ( 1/4 ):");
                input = Console.ReadLine();
                if (input.Contains('/'))
                {
                    split = input.Split('/');
                    if (int.TryParse(split[0], out zahler) && int.TryParse(split[1], out nenner))
                    {
                        // wenn alles okay ist
                        bruch2 = new Bruch(zahler, nenner);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input - Bitte ziffern benutzen!\n");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Fehler - Wrong input ... '/' missing!\n");
                    Console.ReadKey();
                }
            } while (true);

            Console.WriteLine($"\n Ihre Bruche : {bruch1.Ausgabe()} und {bruch2.Ausgabe()}");
            Bruch adition = Bruch.Addieren(bruch1, bruch2);
            Console.WriteLine($"{bruch1.Ausgabe()} + {bruch2.Ausgabe()} = {adition.Kurzen().Ausgabe()}");

            Bruch substra = bruch1.Substrahieren(bruch2);
            Console.WriteLine($"{bruch1.Ausgabe()} - {bruch2.Ausgabe()} = {substra.Kurzen().Ausgabe()}");

            Bruch multi = bruch1.Multiplizieren(bruch2);
            Console.WriteLine($"{bruch1.Ausgabe()} * {bruch2.Ausgabe()} = {multi.Kurzen().Ausgabe()}");

            Bruch division = Bruch.Dividieren(bruch1, bruch2);
            Console.WriteLine($"{bruch1.Ausgabe()} / {bruch2.Ausgabe()} = {division.Kurzen().Ausgabe()}");

            Console.ReadKey();
        }
    }
}
