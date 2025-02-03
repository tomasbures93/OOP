using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Fussballspiel.Models
{
    internal class Mannschaft
    {
        private string _name;
        private Trainer _trainer;
        private Torwart _torwart;
        private Spieler[] _spieler;

        public Mannschaft(string name, Trainer trainer, Torwart torwart, Spieler[] spieler)
        {
            _name = name;
            _trainer = trainer;
            _torwart = torwart;
            _spieler = spieler;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetStarke()
        {
            int counter = 0;
            int countStarke = 0;
            foreach(Spieler spieler in _spieler)
            {
                countStarke += spieler.GetStarke();
                counter++;
            }
            return countStarke / counter;
        }

        public int GetMotivation()
        {
            int counter = 0;
            int countMotivation = 0;
            foreach (Spieler spieler in _spieler)
            {
                countMotivation += spieler.GetStarke();
                counter++;
            }
            return countMotivation / counter;
        }

        public Trainer GetTrainer()
        {
            return _trainer;
        }

        public Torwart GetTorwart()
        {
            return _torwart;
        }

        public Spieler[] GetKader()
        {
            return _spieler;
        }

    }
}
