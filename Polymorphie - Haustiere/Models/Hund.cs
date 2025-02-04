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

        public Hund(string name, double jahresKostenTierarzt, string rasse, bool steuerpflicht) : base(name, steuerpflicht, jahresKostenTierarzt)
        {
            _rasse = rasse;
            steuerpflicht = true;
        }

        public string GetRasse()
        {
            return _rasse;
        }

        public override string Beschreibung()
        {
            return base.Beschreibung() + $"Rasse: {_rasse}\n";
        }
    }
}
