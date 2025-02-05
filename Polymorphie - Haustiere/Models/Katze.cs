using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Haustiere.Models
{
    internal class Katze : Haustier
    {
        protected Vogel _lieblingsVogel;

        public Katze(string name, bool steuerpflicht, double jahresKostenTierarzt) : base(name, steuerpflicht, jahresKostenTierarzt)
        {
            steuerpflicht = false;
        }
        public Katze(string name, bool steuerpflicht, Vogel libelingsVogel, double jahresKostenTierarzt) : base(name, steuerpflicht, jahresKostenTierarzt)
        {
            _lieblingsVogel = libelingsVogel;
            steuerpflicht = false;
        }

        public string Vogel()
        {
            if(_lieblingsVogel == null)
            {
                return "none";
            } else
            {
                return _lieblingsVogel.GetName();
            }
        }

        public bool HatVogel()
        {
            if (_lieblingsVogel == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string Beschreibung()
        {
            return base.Beschreibung() + $"Lieblings Vogel: {Vogel()}\n";
        }

        public void SetVogel(Vogel vogel)
        {
            _lieblingsVogel = vogel;
        }
    }
}
