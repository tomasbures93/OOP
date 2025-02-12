using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP___StarWars.Models;

namespace OOP___StarWars
{
    internal class Program
    {
        /*
         TO DO
            1) Show Rebels ships
            2) Show Imperium ships
            3) Rebels can use shield
            4) Imperium can go back and repair
            5) Control fight strings something is not right there
         */
        static List<Raumschiff> rebelen = new List<Raumschiff>();
        static List<Raumschiff> imperial = new List<Raumschiff>();
        static void Main(string[] args)
        {
            string input = "";
            Console.WriteLine("\n\tGenerating .....");
            NewFlottile(7);
            Console.Clear();
            Console.WriteLine("\n\tStar Wars - Destruction Derby\n");
            Console.WriteLine("\tMenu");
            Console.WriteLine("\t1 - Show Rebels");
            Console.WriteLine("\t2 - Show Imperium");
            Console.WriteLine("\t3 - Start Fight");
            Console.WriteLine("\t4 - Exit");
            input = Console.ReadLine().ToLower();
            if (string.IsNullOrEmpty(input)) input = "5";
            switch (input[0])
            {
                case '1':
                    ShiffeLesen();
                    break;
                case '2':
                    ShiffeLesen();
                    break;
                case '3':
                    StartFight();
                    break;
                case '4':
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\tWrong input");
                    break;
            } 
        }

        static void StartFight()
        {
            Raumschiff shiff;
            Raumschiff shiff2;
            int position1 = 0, position2 = 0, pointsRebelen = 0, pointsImperial = 0 ;
            int lange = rebelen.Count;
            shiff = rebelen[position1];
            shiff2 = imperial[position2];
            do
            {
                Console.Clear();
                Console.WriteLine($"\n\t{shiff.GetInfo()} ( HP: {shiff.FullHP()} ) vs {shiff2.GetInfo()} ( HP: {shiff2.FullHP()} ) \n");
                Console.WriteLine($"\tScore {pointsRebelen} vs {pointsImperial} ) \n");
                if (shiff.FullHP() > 0)
                {
                    shiff.Fire(shiff2);
                } 
                else
                {
                    position1++;
                    pointsImperial++;
                    shiff = rebelen[position1];
                    Console.WriteLine($"{shiff.GetInfo()} has been destroyed");
                }
                Task.Delay(1500).Wait();
                if (shiff2.FullHP() > 0)
                {
                    shiff2.Fire(shiff);
                }
                else
                {
                    position2++;
                    pointsRebelen++;
                    shiff2 = imperial[position2];
                    Console.WriteLine($"{shiff.GetInfo()} has been destroyed");
                }
                Console.ReadKey();
            } while (true);

        }

        static void NewFlottile(int menge)
        {
            Random rnd = new Random();
            for (int i = 0; i < menge; i++)
            {
                int random = rnd.Next(0, 3);
                if (Enum.IsDefined(typeof(ShifftypR), random))
                {
                    rebelen.Add(new Rebelen(ConsoleColor.Red,(ShifftypR)random));
                }
                random = rnd.Next(0, 3);
                if (Enum.IsDefined(typeof(ShifftypI), random))
                {
                    imperial.Add(new Imperial(ConsoleColor.Green,(ShifftypI)random));
                }
                Task.Delay(1000).Wait();
            }
        }

        static void ShiffeLesen()
        {
            Console.WriteLine("\n\t Rebels");
            foreach (Rebelen rebelen_ in rebelen)
            {
                Console.WriteLine(rebelen_.ToString());
            }
            Console.WriteLine("\n\t Dark Side");
            foreach (Imperial imperial_ in imperial)
            {
                Console.WriteLine(imperial_.ToString());
            }
        }
    }
}
