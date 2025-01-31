using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Klassen___Gehaltsberechnung.Models
{
    
    internal class Praktikant : Mitarbeiter
    {
        private Abteilung _abteilung;

        public Praktikant(string name, string vorname, int alter, Abteilung abteilung) : base(name, vorname, alter)
        {
            _abteilung = abteilung;
        }

        public double GehaltBerechnen()
        {
            return (int)_abteilung;
        }
    }
}
