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
            Rennschnecke Jeremy = new Rennschnecke("Jeremy Clarkson", 3);
            Rennschnecke James = new Rennschnecke("James May", 2);
            Rennschnecke Bober = new Rennschnecke("Bober Kurwa", 5);
            Rennschnecke speed = new Rennschnecke("I am speed", 4);

            

            // race
            Rennen race = new Rennen("Race or die", 4, 75);
            race.AddSchnecke(Jeremy);
            race.AddSchnecke(James);
            race.AddSchnecke(Bober);
            race.AddSchnecke(speed);
            Console.WriteLine("\tWelcome - Race or die is about to start!\n");
            Console.WriteLine("              Snail  |                    Speed");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(Jeremy.Ausgabe());
            Console.WriteLine(James.Ausgabe());
            Console.WriteLine(Bober.Ausgabe());
            Console.WriteLine(speed.Ausgabe());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("\n\tWettBüro - Wetten\n");
            Wettburo Heuer = new Wettburo(race, 3);
            Heuer.WetteAnnehmen("Jeremy Clarkson", 100, "Harry Potter");
            Heuer.WetteAnnehmen("Bober Kurwa", 1000, "Tomas");
            Heuer.Ausgabe();
            Console.WriteLine("\nPress Enter to start the race!");
            Console.ReadKey();

            bool start = false;
            do
            {
                Console.Clear();
                for (int i = 3; i >= 0; i--)
                {
                    Task.Delay(1000).Wait();
                    
                    if(i == 0)
                    {
                        Console.Clear();
                        start = true;
                        Console.SetCursorPosition(5, 2);
                        Console.WriteLine("GO GO GO GO!");
                    } else
                    {
                        Console.Clear();
                        Console.SetCursorPosition(5, 2);
                        Console.WriteLine(i);
                    }
                }
            } while (start == false);
            race.Durchfuhren();

            Console.ReadKey();
        }
    }
}
