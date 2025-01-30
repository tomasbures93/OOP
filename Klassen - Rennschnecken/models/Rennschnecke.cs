using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Rennschnecken.models
{
    internal class Rennschnecke
    {
        private string _name;
        private int _maxspeed;
        private int _strecke;

        public Rennschnecke() { }

        public Rennschnecke(string name)
        {
            _name = name;
        }

        public Rennschnecke(string name, int maxspeed)
        {
            _name = name;
            _maxspeed = maxspeed;
            _strecke = 0;
        }

        public void Krieche()
        {
            Random rnd = new Random();
            int bewegen = rnd.Next(1, _maxspeed);
            _strecke += bewegen;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetStrecke()
        {
            return _strecke;
        }

        public string Ausgabe()
        {
            return $"{_name,20} | {_maxspeed,20} mm/h";
        }
        private string AusgabeInRace()
        {
            return $"Name: {_name} | MaxSpeed: {_maxspeed} | Gelaufen : {_strecke}";
        }
    }
}
