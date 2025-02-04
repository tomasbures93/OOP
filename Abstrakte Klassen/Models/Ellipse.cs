using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakte_Klassen.Models
{
    internal class Ellipse:Object
    {
        private double _a;
        private double _b;

        public Ellipse(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public override double Flache()
        {
            return Math.PI * _a * _b;
        }

        public override double Umfang()
        {
            return Math.PI * (3 * (_a + _b) - Math.Sqrt((3 * _a + _b) * (_a + 3 * _b)));
        }

        public override string PrintInfo()
        {
            return $"a: {_a} | b: {_b}";
        }
    }
}
