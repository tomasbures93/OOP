using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Vereinkostenstruktur.Models
{
    internal class Vorstandsmitglied : Mitglied
    {
        private int _kompetenzwert;
        private double _provision;

        public Vorstandsmitglied(string name, int kompetenzwert) : base(name)
        {
            if(kompetenzwert < 0)
            {
                _kompetenzwert = 0;
            } else if (kompetenzwert > 10) {
                _kompetenzwert = 10;
            } else
            {
                _kompetenzwert = kompetenzwert;
            }
            
        }

        public override double GetEinnahmen()
        {
            return _kompetenzwert * 100;
        }

        public override double GetAusgaben()
        {
            _provision = GetEinnahmen() / 100 * 20;
            return GetEinnahmen() / 100 * 80 * 12;
        }

        public override double GetUberschuss()
        {
            if (GetAusgaben() - (GetEinnahmen()) > 0)
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
