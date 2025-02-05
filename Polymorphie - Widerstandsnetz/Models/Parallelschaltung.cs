using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Widerstandsnetz.Models
{
    internal class Parallelschaltung : Widerstandsnetz
    {
        public Parallelschaltung(params Widerstand[] widerstände) : base(widerstände) { }

        public override double BerechneWiderstand()
        {
            double summeKehrwerte = widerstände.Sum(w => 1.0 / (w is Widerstandsnetz netz ? netz.BerechneWiderstand() : w.GetWiderstand()));
            return 1.0 / summeKehrwerte;
        }
    }
}
