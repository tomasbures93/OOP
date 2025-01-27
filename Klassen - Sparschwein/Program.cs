using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen___Sparschwein.Module;

namespace Klassen___Sparschwein
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Welcome to PiggyBank");
            Console.WriteLine("Wie groß sollte dein SparSchwein sein (wie viel cent passt da rein)?");

            int grose = int.Parse(Console.ReadLine());
            PiggyBank sparschwein = new PiggyBank(0, grose);

            Console.WriteLine($"\nSparSchwein erstellt, mit maximale große {grose} Cents.\n");

            Console.ReadKey();

            do
            {
                Console.Clear();
                Console.WriteLine("\nSparSchwein menu\n1 - Bestand\n2 - Add 1 cents\n3 - Add 10 cents\n4 - Add 50 cents\n5 - Add 1 Euro\n6 - IsBroken\n7 - BreakInto\n8 - Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("-- Sparschwein Bestand");
                        Console.WriteLine(sparschwein.Shake());
                        break;
                    case 2:
                        Console.WriteLine("-- Sparschwein Add 1 cents\n");
                        Console.WriteLine("How much cents would you like to insert?");
                        input = int.Parse(Console.ReadLine());
                        Console.WriteLine(sparschwein.Add1Cent(input) + " Cents does not fit inside.");
                        break;
                    case 3:
                        Console.WriteLine("-- Sparschwein Add 10 cents\n");
                        Console.WriteLine("How much 10 cents would you like to insert?");
                        input = int.Parse(Console.ReadLine());
                        Console.WriteLine(sparschwein.Add10Cents(input) + " Cents does not fit inside.");
                        break;
                    case 4:
                        Console.WriteLine("-- Sparschwein Add 50 cents\n");
                        Console.WriteLine("How much 50 cents would you like to insert?");
                        input = int.Parse(Console.ReadLine());
                        Console.WriteLine(sparschwein.Add50Cents(input) + " Cents does not fit inside.");
                        break;
                    case 5:
                        Console.WriteLine("-- Sparschwein Add 1 Euro\n");
                        Console.WriteLine("How much 1 Euros would you like to insert?");
                        input = int.Parse(Console.ReadLine());
                        Console.WriteLine(sparschwein.Add1Euro(input) + " Cents does not fit inside.");
                        break;
                    case 6: 
                        if(sparschwein.IsBroken() == true)
                        {
                            Console.WriteLine("Your pig is broken");
                        } else
                        {
                            Console.WriteLine("Your pig is fine");
                        }
                        break;
                    case 7:
                        Console.WriteLine($"You have broken your Pig. Inside were: {sparschwein.BreakInto()}");
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        sparschwein.Bestand();
                        Console.WriteLine("Du hast fette finger");
                        break;
                }
                Console.ReadKey();
            } while (true);
        }
    }
}
