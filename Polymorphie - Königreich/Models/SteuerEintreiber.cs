using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Königreich.Models
{
    internal class SteuerMann : Einwohner
    {
        private List<Einwohner> _leute;
        private int _steuer;

        public SteuerMann(string name, string adresse, double einkommen) : base(name, adresse, einkommen)
        {
            _steuer = 10;
        }

        public override string ToString()
        {
            return base.ToString() + $" Steuer: {_steuer,3}% |";
        }

        public void AddListeLeute(List<Einwohner> leute)
        {
            _leute = leute;
        }

        public double RechneGesamteSteur()
        {
            double zuBezahlen = 0;
            foreach(Einwohner person in _leute)
            {
                zuBezahlen = zuBezahlen + person.Steuer();
            }
            return zuBezahlen;
        }
    }
}
