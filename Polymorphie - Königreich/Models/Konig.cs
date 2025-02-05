using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Königreich.Models
{
    internal class Konig : Einwohner
    {
        private int _steuer;

        public Konig(string name, string adresse, int einkommen) : base(name, adresse, einkommen)
        {
            _steuer = 0;
        }

        public override double ZuVersteuerndesEinkommen()
        {
            return 0;
        }

        public override double Steuer()
        {
            return 0;
        }

        public override string ToString()
        {
            return base.ToString() + $" Steuer: {_steuer, 3}% |";
        }
    }
}
