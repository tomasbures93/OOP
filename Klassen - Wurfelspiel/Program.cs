using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen___Wurfelspiel.Module;

namespace Klassen___Wurfelspiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Player1 name: ");
                string playerName = Console.ReadLine();
                Player player1 = new Player(playerName);
                Console.WriteLine("Player2 name: ");
                playerName = Console.ReadLine();
                Player player2 = new Player(playerName);

                Console.WriteLine($"-- Würfelspiel\n");
                Console.WriteLine($"{player1.GetName()} vs {player2.GetName()}");
                Console.WriteLine("Press Enter to play!");
                Console.ReadKey();

                Console.WriteLine("\nPlayer 1 is Playing");
                player1.Gamble();
                Console.WriteLine("\nPlayer 2 is Playing");
                player2.Gamble();

                Console.WriteLine("\nPress enter to see the score");
                Console.ReadKey();

                Console.WriteLine($"\n-- Scoreboard");
                Console.WriteLine($"{player1.GetName()} vs {player2.GetName()}");
                Console.WriteLine($"{player1.GetScore()} : {player2.GetScore()}");

                if (player1.GetScore() == player2.GetScore())
                {
                    Console.WriteLine("Nobody won.");
                }
                else if (player1.GetScore() > player2.GetScore())
                {
                    Console.WriteLine($"{player1.GetName()} won!!");
                }
                else
                {
                    Console.WriteLine($"{player2.GetName()} won!!");
                }

                Console.WriteLine("Would you like to play again ? ( j / n )");
                string input = Console.ReadLine().ToLower();
                switch (input[0])
                {
                    case 'j':
                        Console.Clear();
                        break;
                    case 'n':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Du hast fette finger");
                        break;
                }
            } while (true);
           

        }
    }
}
