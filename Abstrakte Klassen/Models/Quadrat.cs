using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakte_Klassen.Models
{
    internal class Quadrat:Object
    {
        private double _a;

        public Quadrat(double a)
        {
            _a = a;
        }

        public override double Flache()
        {
            return Math.Pow(_a, 2);
        }

        public override double Umfang()
        {
            return 4 * _a;
        }

        public override string PrintInfo()
        {
            return $"a: {_a}";
        }
    }
}
