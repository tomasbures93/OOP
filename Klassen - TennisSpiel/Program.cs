using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen___TennisSpiel.models;

namespace Klassen___TennisSpiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- TennisSpiel");

            Console.WriteLine("\neinfach");
            TennisSpieler tomas = new TennisSpieler("Tomas", 31, null);
            TennisSpieler bober = new TennisSpieler("Bober", 5, tomas);

            Console.WriteLine($"Age difference between {tomas.GetName()} and {bober.GetName()} is {tomas.AlterDifference(bober)} years");

            Console.WriteLine($"\nListe etc\n");
            List<TennisSpieler> spieler = new List<TennisSpieler>();
            bool getout = false;
            do
            {
                Console.WriteLine("-- Spieler liste erzeugen");
                Console.WriteLine("Bitte geben sie name ein:");
                string name = Console.ReadLine();
                Console.WriteLine("Bitte geben sie ihre age ein");
                int age = int.Parse(Console.ReadLine());
                if(spieler.Count() == 0)
                {
                    spieler.Add(new TennisSpieler(name, age, null));
                } else
                {
                    spieler[spieler.Count() - 1].SetNachvolger(new TennisSpieler(name, age, null));
                    spieler.Add(new TennisSpieler(name, age, null));
                }
                Console.WriteLine("Noch mehr spieler? ( j / n )");
                string input = Console.ReadLine().ToLower();
                switch (input[0])
                {
                    case 'j':
                        break;
                    case 'n':
                        getout = true;
                        break;
                }
            } while (getout == false);
            
            foreach(TennisSpieler list in spieler)
            {
                Console.WriteLine(list.GetInfo());
            }

            Console.WriteLine("\n");

            foreach(TennisSpieler list in spieler)
            {
                Console.WriteLine($"{list.GetName()} Letzte? {list.IsLetzte()}");
            }
        }
    }
}
