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
        static List<Raumschiff> rebelen = new List<Raumschiff>();
        static List<Raumschiff> imperial = new List<Raumschiff>();
        static void Main(string[] args)
        {
            Intro();
            Console.ReadKey();
            string input = "";
            Console.WriteLine("\n\tGenerating .....");
            NewFlottile(2);
            do
            {
                Console.Clear();
                Console.WriteLine("\n\tStar Wars - Destruction Derby\n");
                Console.WriteLine("\tMenu");
                Console.WriteLine("\t1 - Rebel ships");
                Console.WriteLine("\t2 - Imperium ships");
                Console.WriteLine("\t3 - Start Derby");
                Console.WriteLine("\t4 - Exit");
                ShowFalcon();
                input = Console.ReadLine().ToLower();
                if (string.IsNullOrEmpty(input)) input = "5";
                switch (input[0])
                {
                    case '1':
                        Console.Clear();
                        ShiffeLesenRebelen();
                        Console.ReadKey();
                        break;
                    case '2':
                        Console.Clear();
                        ShiffeLesenImperial();
                        Console.ReadKey();
                        break;
                    case '3':
                        StartFight();
                        break;
                    case '4':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\tWrong input - Try again.");
                        break;
                }
            } while (true);
        }

        static void StartFight()
        {
            Raumschiff shiff;
            Raumschiff shiff2;
            int pointsRebelen = 0, pointsImperial = 0, dmgRebelen = 0, dmgImperial = 0;
            int lange = rebelen.Count;
            string winner = "";
            Random random = new Random();
            do
            {
                shiff = rebelen[random.Next(0, rebelen.Count)];
                shiff2 = imperial[random.Next(0, imperial.Count)];
                Console.Clear();
                int whofights = random.Next(1, 11);
                Console.WriteLine("\t--------------------------------------------------------------------------------------");
                Console.Write("\t");
                foreach (Imperial imperial_ in imperial)
                {
                    Console.Write($"| {imperial_.GetArt(), 8} - {imperial_.FullHP(),5} HP ");
                }
                Console.Write("\n");
                Console.Write("\t");
                foreach (Rebelen rebelen_ in rebelen)
                {
                    Console.Write($"| {rebelen_.GetArt(), 8} - {rebelen_.FullHP(),5} HP ");
                }
                Console.Write("\n");
                Console.WriteLine("\t--------------------------------------------------------------------------------------");
                Console.WriteLine($"\t\t   {shiff.GetInfo()} ( HP: {shiff.FullHP()} ) vs {shiff2.GetInfo()} ( HP: {shiff2.FullHP()} ) \n");
                Console.WriteLine($"\t\t\t\t\t      {pointsRebelen} : {pointsImperial} ");
                Console.WriteLine("\t-------------------------------------DMG DONE-----------------------------------------");
                Console.WriteLine($"\t\t\t\t\t  {dmgRebelen,5} : {dmgImperial,-5} ");
                Console.WriteLine("\t--------------------------------------------------------------------------------------\n");
                if(whofights < 6)
                {
                    if (shiff.FullHP() > 0 && shiff.StillAlive() == true)
                    {
                        dmgRebelen = shiff.Fire(shiff2) + dmgRebelen;
                    }
                    else
                    {
                        pointsImperial++;
                        rebelen.Remove(shiff);
                        if (rebelen.Count == 0)
                        {
                            winner = "Imperial";
                            break;
                        }
                        shiff = rebelen[0];
                        Console.WriteLine($"\t{shiff.GetInfo()} has been destroyed.");
                        Task.Delay(500).Wait();
                    }
                } else
                {
                    if (shiff2.FullHP() > 0 && shiff2.StillAlive() == true)
                    {
                        dmgImperial = shiff2.Fire(shiff) + dmgImperial;
                    }
                    else
                    {
                        pointsRebelen++;
                        imperial.Remove(shiff2);
                        if (imperial.Count == 0)
                        {
                            winner = "Rebels";
                            break;
                        }
                        shiff2 = imperial[0];
                        Console.WriteLine($"\t{shiff2.GetInfo()} has been destroyed.");
                        Task.Delay(500).Wait();
                    }
                }
                Task.Delay(500).Wait();
            } while (true);
            Console.Clear();
            Console.WriteLine("\n\n\t********************************************************************************************");
            Console.WriteLine("\t****************************************** WINNER ******************************************");
            Console.WriteLine($"\t*************************************** {winner,10} *****************************************");
            Console.WriteLine("\t********************************************************************************************");
            Console.WriteLine("\t********************************************************************************************\n");
            Console.WriteLine("\n\t------------------------------------- Statistics -----------------------------------------");
            Console.WriteLine($"\t\t\t\t\t  REBELS : IMPERIUM ");
            Console.WriteLine($"\t\t\t\t\t       {pointsRebelen} : {pointsImperial} ");
            Console.WriteLine($"\t\t\t\tDMG DONE:  {dmgRebelen,5} : {dmgImperial,-5} ");
            Console.WriteLine($"\t\t\t  SHIPS LEFT - Rebels  {rebelen.Count} | Imperium {imperial.Count} ");
            Console.ReadKey();
            Environment.Exit(0);
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
                } else
                {
                    Console.WriteLine("\tSystem Fehler");
                }
                random = rnd.Next(0, 3);
                if (Enum.IsDefined(typeof(ShifftypI), random))
                {
                    imperial.Add(new Imperial(ConsoleColor.Green,(ShifftypI)random));
                }
                else
                {
                    Console.WriteLine("\tSystem Fehler");
                }
                Task.Delay(1000).Wait();
            }
        }

        static void ShiffeLesenRebelen()
        {
            Console.WriteLine($"\n\tRebels");
            Console.WriteLine("\t----------------------------------------------------------------------------------");
            Console.WriteLine("\t|    Name    |  HP  |  Shields |    DMG   |  Call Sing  |   R2   |      Foto     |");
            foreach (Rebelen rebelen_ in rebelen)
            {
                Console.WriteLine(rebelen_.ToString());
            }
            Console.WriteLine("\t----------------------------------------------------------------------------------");
        }
        static void ShiffeLesenImperial()
        {
            Console.WriteLine("\n\tImperial");
            Console.WriteLine("\t-------------------------------------------------------------------------");
            Console.WriteLine("\t|          Name       |     HP |    DMG   |  Call Sing  |      Foto     |");
            foreach (Imperial imperial_ in imperial)
            {
                Console.WriteLine(imperial_.ToString());
            }
            Console.WriteLine("\t-------------------------------------------------------------------------");
        }

        static void ShowFalcon()
        {
            Console.SetCursorPosition(50, 1);
            Console.WriteLine("                 c == o");
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("              _ / ____\\_");
            Console.SetCursorPosition(50, 3);
            Console.WriteLine("         _.,--'\" || ^ || \"`z._");
            Console.SetCursorPosition(50, 4);
            Console.WriteLine("      / _ / ^___\\||  || _ / o\\ \"`-._");
            Console.SetCursorPosition(50, 5);
            Console.WriteLine("    _ /  ]. L_ | || .||  \\_ / _._`--._");
            Console.SetCursorPosition(50, 6);
            Console.WriteLine("   / _~7  _. \" ||. || /] \\ ]. (_)  . \"`--.");
            Console.SetCursorPosition(50, 7);
            Console.WriteLine("  | __7~.(_)_[]| +--+|/ ____T_____________L|");
            Console.SetCursorPosition(50, 8);
            Console.WriteLine("  | __ | _ ^ (_) /^  __\\____ _   _|");
            Console.SetCursorPosition(50, 9);
            Console.WriteLine("  | __ | (_){ _) J ]K{__L___ _   _]     ");
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("  | __ | ._(_)   \\v   / __________|________");
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("  l__l_(_). [] | +-+-<\\^    L . _   - ---L |");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("   \\__\\    __. || ^l  \\Y] / _]  (_) . _,--'");
            Console.SetCursorPosition(50, 13);
            Console.WriteLine("     \\~_] L_ | || .\\ .\\/ ~.     _,--'\"");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("      \\_\\ . __/||  |\\  \\`-+-< '\"");
            Console.SetCursorPosition(50, 15);
            Console.WriteLine("        \"`---._|J__L|X o~~|[\\\\");
            Console.SetCursorPosition(50, 16);
            Console.WriteLine("              \\____/ \\___| [//  ");
            Console.SetCursorPosition(50, 17);
            Console.WriteLine("              `--'   `--+-'");
        }

        static void Intro()
        {
            Console.WriteLine("\n         .      .     T h i s   i s   t h e g a l a x y o f. . .             .");
            Console.WriteLine("                                  .              .       .                    .      .");
            Console.WriteLine(" .        .               .       .     .            .");
            Console.WriteLine("    .           .        .                     .        .            .");
            Console.WriteLine("              .               .    .          .              .   .         .");
            Console.WriteLine("                _________________      ____         __________");
            Console.WriteLine("  .       .    /                 |    /    \\    .  |          \\");
            Console.WriteLine("      .       /   ______   _____ | . /      \\      |    ___   |     .     .");
            Console.WriteLine("              \\    \\   |   |        /   /\\   \\     |   |___>  |");
            Console.WriteLine("            .  \\    \\  |   |       /   /__\\   \\  . |        _/               .");
            Console.WriteLine("        ._______>    | |   | .    /            \\   |   |\\    \\_______.");
            Console.WriteLine("        |           /  |   |     /    ______    \\  |   | \\           |");
            Console.WriteLine("        |__________/   |___|    /____/      \\____\\ |___|  \\__________|    .");
             Console.WriteLine("  .      ____    __.   _____   ____      .  __________.     _________\\");
            Console.WriteLine("        \\    \\  /  \\  /    /  /    \\       |          \\    /         |      .");
            Console.WriteLine("         \\    \\/    \\/    /  /      \\      |    ___    |  /    ______|  .");
            Console.WriteLine("          \\              /  /   /\\   \\ .   |   |___>   |  \\    \\");
            Console.WriteLine("    .      \\            /  /   /__\\   \\    |          _/.  \\    \\            +");
            Console.WriteLine("            \\    /\\    /  /            \\   |   |\\    \\______>    |   .");
            Console.WriteLine("             \\  /  \\  /  /    ______    \\  |   | \\              /          .");
            Console.WriteLine("  .       .   \\/    \\/  /____/      \\____\\ |___|  \\____________/ LS");
             Console.WriteLine("                               .                                        .");
             Console.WriteLine("     .                           .         .               .                 .");
             Console.WriteLine("                .                                   .            .");
        }
    }
}
