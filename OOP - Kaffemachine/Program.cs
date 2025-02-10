using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP___Kaffemachine.Models;

namespace OOP___Kaffemachine
{
    internal class Program
    {
        static Kaffemuhle machine = new Kaffemuhle();
        static void Main(string[] args)
        {

            do
            {
                Console.Clear();
                Console.WriteLine("\n\tKaffeMühle 2000 - Menu\n");
                Console.WriteLine("\t1 - Bohnen Einfühlen");
                Console.WriteLine("\t2 - Bohnen Entnehmen");
                Console.WriteLine("\t3 - Kurbel Drehen");
                Console.WriteLine("\t4 - KaffeeMehl entnehmen");
                Console.WriteLine("\t5 - KaffeMühle 2000 Info");
                Console.WriteLine("\t6 - Exit");
                ShowMachine();
                string input = Console.ReadLine().ToLower();
                if (string.IsNullOrEmpty(input)) input = "7";
                switch (input[0])
                {
                    case '1':
                        Console.WriteLine("\tWie viel Bohnen möchtest du einfühlen ? grams");
                        if(int.TryParse(Console.ReadLine(), out int menge))
                        {
                            machine.InsertBohnen(menge);
                        } else
                        {
                            Console.WriteLine("\tFalsche eingabe.");
                        }
                        break;
                    case '2':
                        machine.BohnenEnthnehmen();
                        Console.WriteLine("\tBohnen geleert.");
                        break;
                    case '3':
                        machine.Drehen();
                        break;
                    case '4':
                        Console.WriteLine($"\n\t{machine.KaffeMehlEnthnehmen()} gram Kaffemuhle entgenohmen.");
                        break;
                    case '5':
                        Console.WriteLine($"\n\t{machine.GetInfo()}");
                        break;
                    case '6':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.ReadKey();
            } while (true);
        }

        public static void ShowMachine()
        {
            Console.SetCursorPosition(50, 1);
            Console.WriteLine("     / ~~~~~~~~/| ");
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("    / /######/ / | ");
            Console.SetCursorPosition(50, 3);
            Console.WriteLine("   / /______/ /  | ");
            Console.SetCursorPosition(50, 4);
            Console.WriteLine("  ============ /|| ");
            Console.SetCursorPosition(50, 5);
            Console.WriteLine("| __________ |/ || ");
            Console.SetCursorPosition(50, 6);
            Console.WriteLine(" |\\__,,__ /     || ");
            Console.SetCursorPosition(50, 7);
            Console.WriteLine(" | __,,__       || "); 
            Console.SetCursorPosition(50, 8);
            Console.WriteLine(" |  _\\====/%____|| ");
            Console.SetCursorPosition(50, 9);
            Console.WriteLine(" |   /~~~~\\ %  / | ");
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("_ | /      \\%_/  | ");
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("|  |        | | / ");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("|__\\______ /__|/ ");
            Console.SetCursorPosition(50, 13);
            Console.WriteLine("~~~~~~~~~~~~~~");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine($"{machine.GetInfo()}");
        }
    }
}
