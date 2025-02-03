using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Fussballspiel.Models
{
    internal class Trainer : Person
    {
        private int _erfahrung;

        public Trainer(string name, int alter, int erfahrung) : base(name, alter)
        {
            _erfahrung = erfahrung;
        }

        public int GetErfahrung()
        {
            return _erfahrung;
        }
    }
}
