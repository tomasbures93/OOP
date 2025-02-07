using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Vereinkostenstruktur.Models
{
    internal class Trainer : AktiveMitglied
    {
        public Trainer(string name, int aktivitatsgrad) : base(name, aktivitatsgrad)
        {
            _monatlichebetrag = 10;
        }

        public override double GetEinnahmen()
        {
            return _monatlichebetrag * 12;
        }

        public override double GetAusgaben()
        {
            return _aktivitatsgrad * 50 * 12;
        }

        public override double GetUberschuss()
        {
            if (GetAusgaben() - GetEinnahmen() > 0)
            {
                return Math.Abs(GetAusgaben() - GetEinnahmen());
            }
            else
            {
                return 0;
            }
        }

        public override void Ausgabe()
        {
            Console.WriteLine($"| Position: {GetType().Name} |Name: {this.GetName()}| Einnahme pro Jahr: {this.GetEinnahmen()} | Ausgabe pro Jahr: {this.GetAusgaben()} | Überschuss pro Jahr: {this.GetUberschuss()} ");
        }
    }
}
