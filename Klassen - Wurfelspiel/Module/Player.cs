using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Klassen___Wurfelspiel.Module
{
    internal class Player
    {
        private string _name;
        private int _score;

        public Player(string name)
        {
            _name = name;
            _score = 0;
        }

        public void Gamble()
        {
            Random randomZahl = new Random();
            for (int i = 0; i < 5; i++)
            {
                Task.Delay(1200).Wait();
                int zahl = randomZahl.Next(1, 7);       // 1 - 6
                Console.Write($" {zahl} |");
                _score += zahl;
            }
        }

        public string GetName()
        {
            return _name;
        }

        public int GetScore()
        {
            return _score;
        }
    }
}
