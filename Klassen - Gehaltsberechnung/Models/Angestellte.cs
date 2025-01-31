using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Gehaltsberechnung.Models
{
    
    internal class Angestellte : Mitarbeiter
    {
        private Tarif _tarif;

        public Angestellte(string name, string vorname, double alter, Tarif tarif) : base(name, vorname, alter)
        {
            _tarif = tarif;
        }

        public double GehaltBerechnen()
        {
            double output = 1 + ((_alter - 25) / 100);
            output = output * (int)_tarif;
            return output;
        }
    }
}
