using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakte_Klassen.Models
{
    internal class Rechteck:Object
    {
        private double _a;
        private double _b;

        public Rechteck(double a, double b) 
        {
            _a = a;
            _b = b;
        }

        public override double Flache()
        {
            return _a * _b;
        }

        public override double Umfang()
        {
            return 2 * (_a + _b);
        }

        public override string PrintInfo()
        {
            return $"a: {_a} | b: {_b}";
        }
    }
}
