using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Gehaltsberechnung.Models
{
    enum Tarif
    {
        A = 2560,
        B = 3000,
        C = 3200,
        D = 5400
    }

    enum Abteilung
    {
        Vertrieb = 820,
        Produktion = 710,
        Entwicklung = 935
    }
    internal class Mitarbeiter
    {
        protected string _name;
        protected string _vorname;
        protected double _alter;

        public Mitarbeiter(string name, string vorname, double alter)
        { 
            _name = name;
            _vorname = vorname;
            _alter = alter;
        }
    }
}
