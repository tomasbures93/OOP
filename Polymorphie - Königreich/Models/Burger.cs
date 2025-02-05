using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Königreich.Models
{
    internal class Burger : Einwohner
    {
        private int _steuer;
        public Burger(string name, string adresse, double einkommen) : base(name, adresse, einkommen)
        {
            _steuer = 10;
        }
        public override string ToString()
        {
            return base.ToString() + $" Steuer: {_steuer,3}% |";
        }
    }
}
