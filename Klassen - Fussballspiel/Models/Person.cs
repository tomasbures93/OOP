using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Fussballspiel.Models
{
    internal class Person
    {
        protected string _name;
        protected int _alter;
        protected int _starke;
        protected int _torschuss;
        protected int _motivation;

        public Person(string name, int alter)
        {
            _name = name;
            _alter = alter;
        }

        public Person(string name, int alter, int starke, int torschuss, int motivation)
        {
            _name = name;
            _alter = alter;
            _starke = starke;
            _motivation = motivation;
            _torschuss = torschuss;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetAlter()
        {
            return _alter;
        }

        public int GetStarke()
        {
            return _starke;
        }

        public int GetTroschuss()
        {
            return _torschuss;
        }

        public int GetMotivation()
        {
            return _motivation;
        }
    }
}
