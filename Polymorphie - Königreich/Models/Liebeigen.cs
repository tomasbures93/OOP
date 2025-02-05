using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Königreich.Models
{
    internal class Liebeigen : Einwohner
    {
        private int _steuer;
        private Einwohner Einwohner;

        public Liebeigen(string name, string adresse, double einkommen, Einwohner einwohner) : base(name, adresse, einkommen)
        {
            _steuer = 10;
            Einwohner = einwohner;
        }

        public override double ZuVersteuerndesEinkommen()
        {
            return _einkommen - 12;         // 12 Taler steuer frei
        }
        public override double Steuer()
        {
            return (_einkommen - 12) / 100 * _steuer;
        }

        public override string ToString()
        {
            return base.ToString() + $" Steuer: {_steuer,3}% |";
        }
    }
}
