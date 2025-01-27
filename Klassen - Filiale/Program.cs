using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen___Filiale.Module;

namespace Klassen___Filiale
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nWillkomen in Filiale erestellen\n");
            Console.WriteLine("Bitte geben sie name der Filiale ein:");
            string name = Console.ReadLine();
            Filiale Kartofeln = new Filiale(name);

            Console.WriteLine("\nIhre filiale wurde erstellt\n\nInfo:");
            Kartofeln.Info();

            Console.ReadKey();
            do
            {
                Console.Clear();
                Kartofeln.Info();
                Console.WriteLine("\nMenu\n1 - Info\n2 - Verkauf\n3 - Einkauf\n4 - Exit");
                int menu = int.Parse(Console.ReadLine());
                switch(menu)
                {
                    case 1:
                        Kartofeln.Info();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Wie viel einheiten wollen sie verkaufen?");
                        int verkauf = int.Parse(Console.ReadLine());
                        Kartofeln.Verkauf(verkauf);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Wie viel einheiten wollen sie einkaufen?");
                        int einkauf = int.Parse(Console.ReadLine());
                        Kartofeln.Einkauf(einkauf);
                        Console.ReadKey();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Du hast fette finger | falsche eingabe");
                        Console.ReadKey();
                        break;
                }
            } while (true);


        }
    }
}
