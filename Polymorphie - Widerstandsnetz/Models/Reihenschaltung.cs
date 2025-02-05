using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Widerstandsnetz.Models
{
    internal class Reihenschaltung : Widerstandsnetz
    {
        public Reihenschaltung(params Widerstand[] widerstände) : base(widerstände) { }

        public override double BerechneWiderstand()
        {
            return widerstände.Sum(w => w is Widerstandsnetz netz ? netz.BerechneWiderstand() : w.GetWiderstand());
        }
    }
}
