using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Haustiere.Models
{
    internal class Vogel : Haustier
    {
        protected bool _singvogel;

        public Vogel(string name, bool singvogel, double jahresKostenTierarzt, bool steuerpflicht = false) : base(name, steuerpflicht, jahresKostenTierarzt)
        {
            _singvogel = singvogel;
        }

        public void VogelAn()
        {
            _singvogel = true;
        }
        public void VogelAus()
        {
            _singvogel = false;
        }

        public override string Beschreibung()
        {
            return base.Beschreibung() + $"Vogel is singing: {_singvogel}\n";
        }


    }
}
