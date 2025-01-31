using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Gehaltsberechnung.Models
{
    internal class Extern : Mitarbeiter
    {
        private int _projektStunden;

        public Extern(string name, string vorname, int alter, int stunden) : base(name, vorname, alter)
        {
            _projektStunden = stunden;
        }

        public double GehaltBerechnen()
        {
            return _projektStunden * 75;
        }
    }
}
