using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Vereinkostenstruktur.Models
{
    internal class UnterstutzendesMitglied : Mitglied
    {
        private double _jahresbetrag;
        private double _ausgaben;

        public UnterstutzendesMitglied(string name) : base(name)
        {
            _jahresbetrag = 100;
            _ausgaben = 15;
        }

        public override double GetEinnahmen()
        {
            return _jahresbetrag;
        }

        public override double GetAusgaben()
        {
            return _ausgaben;
        }

        public override double GetUberschuss()
        {
            if(GetAusgaben() - GetEinnahmen() > 0)
            {
                return Math.Abs(GetAusgaben() - GetEinnahmen());
            } else
            {
                return 0;
            }
        }

        public override void Ausgabe()
        {
            Console.WriteLine($"| Position: {GetType().Name} | Name: {this.GetName()}| Einnahme pro Jahr: {this.GetEinnahmen()} | Ausgabe pro Jahr: {this.GetAusgaben()} | Überschuss pro Jahr: {this.GetUberschuss()} ");
        }
    }
}
