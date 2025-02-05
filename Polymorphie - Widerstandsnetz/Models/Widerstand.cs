using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Widerstandsnetz.Models
{
    public class Widerstand
    {
        protected string _name;
        protected double _widerstand;

        public Widerstand()
        {
        }

        public Widerstand(string name, double widerstand)
        {
            _name = name;
            _widerstand = widerstand;
        }

        public virtual string GetName()
        {
            return _name;
        }

        public double GetWiderstand()
        {
            return _widerstand;
        }

        public override string ToString()
        {
            return $"Name: {_name,5} | Widerstand: {_widerstand, 6} Ohm";
        }
    }
}
