using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Vereinkostenstruktur.Models
{
    internal class AktiveMitglied : Mitglied
    {
        protected int _aktivitatsgrad;
        protected double _monatlichebetrag;
        protected double _ausgaben;

        public AktiveMitglied(string name, int aktivitatsgrad) : base(name)
        {
            if (_aktivitatsgrad < 0)
            {
                _aktivitatsgrad = 0;
            }
            else if (_aktivitatsgrad > 10)
            {
                _aktivitatsgrad = 10;
            }
            else
            {
                _aktivitatsgrad = aktivitatsgrad;
            }
        }

        public override double GetEinnahmen() { return 0; }

        public override double GetAusgaben() { return 0; }

        public override double GetUberschuss() { return 0; }

        public override void Ausgabe() { }
    }
}
