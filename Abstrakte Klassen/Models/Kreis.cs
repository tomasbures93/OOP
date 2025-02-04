using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakte_Klassen.Models
{
    internal class Kreis:Object
    {
        private double _radius;

        public Kreis(double radius)
        {
            _radius = radius;
        }

        public override double Flache()
        {
            return Math.PI * Math.Pow(2, _radius);
        }

        public override double Umfang()
        {
            return 2 * Math.PI * _radius;
        }

        public override string PrintInfo()
        {
            return $"radius: {_radius}";
        }
    }
}
