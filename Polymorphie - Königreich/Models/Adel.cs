using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Königreich.Models
{
    internal class Adel : Einwohner
    {
        private int _steuer;

        public Adel(string name, string adresse, double einkommen) : base(name, adresse, einkommen)
        {
            _steuer = 10;
        }

        public override double Steuer()
        {
            double mussBezahlen = (_einkommen / 100) * _steuer;
            if (mussBezahlen <= 20)     // wenn steuer unter 20 muss er trozdem minimum 20 bezahlen
            {
                return 20;
            }
            else
            {
                return mussBezahlen;    
            } 
        }

        public override string ToString()
        {
            return base.ToString() + $" Steuer: {_steuer,3}% |";
        }
    }
}
