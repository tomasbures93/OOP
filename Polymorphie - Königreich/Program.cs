using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Polymorphie___Königreich.Models;

namespace Polymorphie___Königreich
{
    internal class Program
    {
        static List<Einwohner> kingdom = new List<Einwohner>();
        static void Main(string[] args)
        {
            KonigreichErzeugen();
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\tWillkommen in Königreich!");
                int countEinwohner = kingdom.Count;
                if (countEinwohner == 0)
                {
                    Console.WriteLine($"\n\tAlle sind tot");
                }
                else
                {
                    Console.WriteLine($"\n\tDiese Kingdom hat {countEinwohner} Einwohner");
                }
                Console.WriteLine($"\n\t Was willst du machen?");
                Console.WriteLine($"\t 1 - Einwohner Liste.");
                Console.WriteLine($"\t 2 - Finanzamt Einwohner Liste.");
                Console.WriteLine($"\t 3 - SteuerMann fragen.");
                Console.WriteLine($"\t 4 - Alle töten");
                Console.WriteLine($"\t 5 - Exit");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) input = "0";
                switch (input[0])
                {
                    case '1':
                        KonigreichLeute();
                        Console.ReadKey();
                        break;
                    case '2':
                        WieVielSollenBezahlen();
                        Console.ReadKey();
                        break;
                    case '3':
                        SteuerMannFragen();
                        Console.ReadKey();
                        break;
                    case '4':
                        AlleToten();
                        Console.ReadKey();
                        break;
                    case '5':
                        Console.Clear();
                        Console.WriteLine("\n\n\n\tFuck this **** I am out.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n\t Falsche eingabe!!");
                        break;
                }
            } while (true);
            
        }

        static void SteuerMannFragen()
        {
            Console.WriteLine("\t-- Steuer Mann abgefraft");
            Console.WriteLine("\tIch bin alt... muss rechnen ... Gib mir zeit");
            Task.Delay(500).Wait();
            Console.WriteLine("\t1 + 1 = 3");
            Task.Delay(500).Wait();
            Console.WriteLine("\t1 + 2 = 2");
            Task.Delay(500).Wait();
            Console.WriteLine("\tFuck ... bin zu Alt für diese Scheize ... wo ist mein Handy");
            Task.Delay(500).Wait();
            Console.WriteLine("\t1 + 1 = 2");
            Task.Delay(500).Wait();
            Console.WriteLine("\tAhaaaaaaa\n");
            foreach (Einwohner einwohner in kingdom)
            {
                if (einwohner is SteuerMann mann)
                {
                    Console.WriteLine($"\tGesamte Steuer Betrag in ganze Königreich ist: {Math.Round(mann.RechneGesamteSteur(),0)} Talars");
                }
            }
        }

        static void WieVielSollenBezahlen()
        {
            Console.WriteLine("--------------------------------------------------------");
            if (kingdom.Count == 0)
            {
                Console.WriteLine("Alle sind Tot!!! Was hast du gemacht!!");
            }
            else
            {
                foreach (Einwohner einwohner in kingdom)
                {
                    Console.WriteLine($"| Name: {einwohner.GetName(),12} | Soll bezahlen: {Math.Round(einwohner.Steuer(),0),10} Taler |");
                }
            }
            Console.WriteLine("--------------------------------------------------------");
        }

        public static void KonigreichErzeugen()
        {
            kingdom.Add(new Konig("King Tomas", "Burg", 100000));
            kingdom.Add(new SteuerMann("Gib Geld", "Burg", 6000));
            kingdom.Add(new Adel("Sir Dominik", "Stadt", 5000));
            kingdom.Add(new Adel("Sir Nils", "Stadt", 6700));
            kingdom.Add(new Adel("Sir Zima", "Stadt", 10000));
            kingdom.Add(new Burger("Pepa", "Baum 1", 100));
            kingdom.Add(new Liebeigen("Anezka", "Baum 1", 50, kingdom[4]));
            kingdom.Add(new Burger("Lofas", "Baum 2", 100));
            kingdom.Add(new Liebeigen("Alzbeta", "Baum 2", 50, kingdom[6]));
            kingdom.Add(new Burger("Raul", "Farm 1", 100));
            kingdom.Add(new Liebeigen("Iveta", "Farm 1", 50, kingdom[8]));
            foreach(Einwohner einwohner in kingdom)
            {
                if (einwohner is SteuerMann mann)
                {
                    mann.AddListeLeute(kingdom);
                }
            }
        }

        static void KonigreichLeute()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            if(kingdom.Count == 0)
            {
                Console.WriteLine("Alle sind Tot!!! Was hast du gemacht!!");
            } else
            {
                foreach (Einwohner einwohner in kingdom)
                {
                    Console.WriteLine(einwohner.ToString());
                }
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
        }

        static void AlleToten()
        {
            Console.Clear();
            for(int i =0; i < 8; i++)
            {
                Console.SetCursorPosition(5, i);
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀               ⠀⠀");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⠀⣰⣾⣶⣶⣶⣦⣤⡄⠀⣀⠀⠀⠀   ");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⣿⣿⣿⣿⣿⣿⣏⣉⣼⣇⠘⣿⣿⣦⡀   ");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⣠⣴⣿⠿⠿⣿⣿⣆⠈⢿⣿⣿⡟⢉⣀⠘⢿⣿⣿⠀⠀⠀");
                Console.WriteLine("⠀⠀⠀⠀⠀⣠⣾⠟⢉⣠⣶⡆⢈⠙⣿⣧⡈⠻⢿⣿⣿⣿⣷⠀⢈⣉⣤⡀⠀⠀");
                Console.WriteLine("⠀⠀⠀⠀⣼⣿⣿⠀⠛⠛⢋⣀⣈⠛⣿⣿⣿⣶⣶⣿⣿⣿⣿⣷⣤⣿⣿⣧⠀⠀");
                Console.WriteLine("⠀⠀⠀⠀⣿⣿⡿⠀⣿⡄⢸⣿⣿⣿⣿⣿⣿⣿⠋⣉⣠⣤⣤⣿⣿⡿⠸⣿⡄⠀");
                if(i > 6)
                {
                    Console.WriteLine("⠀⠀⠀⢸⣿⣿⣷⣾⣿⣷⣾⣿⣿⣿⣿⣿⣿⢇⣰⣿⣿⣿⣿⣿⡿⢁⣴⣿⠃⠀  BOOOOOOOOOM");
                } else
                {
                    Console.WriteLine("⠀⠀⠀⢸⣿⣿⣷⣾⣿⣷⣾⣿⣿⣿⣿⣿⣿⢇⣰⣿⣿⣿⣿⣿⡿⢁⣴⣿⠃⠀ ");
                }
                Console.WriteLine("⠀⠀⠀⠘⠻⣿⣿⣿⣿⣿⣿⡿⢋⣾⣿⣿⣿⣿⣿⡉⢿⡏⢠⣿⣿⣿⠟⠁⠀⠀");
                Console.WriteLine("⠀⠀⠀⢸⣦⡈⠛⢿⣿⣿⣿⡁⣾⣿⣿⣿⣿⣿⣿⠇⢀⣥⣬⣽⣿⠇⠀⠀⠀");
                Console.WriteLine("⠀⠀⠀⢸⣿⣿⣦⠈⢻⣿⣿⣇⣿⣿⣿⣿⣿⣿⡏⠐⣿⣿⣿⡿⠋⠀⠀⠀");
                Console.WriteLine("⠀⠀⠀⠀⣿⣿⣏⢰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⣤⣶⣿⣿⠟⠁⠀⠀⠀⠀");
                Console.WriteLine("⠀⠀⠀⠀⠈⠛⢻⣿⣿⣿⣿⣿⣿⠿⣯⣁⣉⣉⣹⡿⠛⠁⠀⠀⠀⠀⠀");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠈⠉⢉⣿⣿⣿⣏⣰⣿⡿⠟⠋⠁⠀⠀⠀⠀⠀⠀⠀");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                if(i < 7)
                {
                    Console.SetCursorPosition(5, 20);
                    Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀{Hilfeeeee}⠀⠀⠀⠀⠀⠀⠀⠀");
                    Console.WriteLine("⠀⠀⠀.⠀⠀⠀⠀.⠀⠀.⠀..⠀..⠀⠀⠀");
                } else {
                    
                }
                
                Task.Delay(500).Wait();
            }
            


            kingdom.Clear();
        }
    }
}
