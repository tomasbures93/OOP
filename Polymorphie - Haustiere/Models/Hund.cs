using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Haustiere.Models
{
    internal class Hund : Haustier
    {
        protected string _rasse;

        public Hund(string name, double jahresKostenTierarzt, bool steuerpflicht = true, string rasse) : base(name, steuerpflicht, jahresKostenTierarzt)
        {
            _rasse = rasse;
        }

        public string GetRasse()
        {
            return _rasse;
        }

        public override string Beschreibung()
        {
            return base.Beschreibung() + $"\nRasse: {_rasse}";
        }
    }
}
