using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Vereinkostenstruktur.Models
{
    internal abstract class Mitglied
    {
        private static int Mitgliedsnummer = 1;

        protected string _name;
        protected int _mitgliednummer;

        public Mitglied(string name)
        {
            _name = name;
            _mitgliednummer = Mitgliedsnummer++;
        }

        public abstract double GetEinnahmen();

        public abstract double GetAusgaben();

        public abstract double GetUberschuss();

        public abstract void Ausgabe();

        public int GetMitgliedsnummer()
        {
            return _mitgliednummer;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
