using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Koordinatensystem.models
{
    internal class Kreis
    {
        private Punkt _mittlepunkt;
        private int _radius;

        public Kreis(int radius)
        {
            _radius = radius;
        }

        public double Umfang()
        {
            return 2 * Math.PI * _radius;
        }

        public double Inhalt()
        {
            return Math.PI * _radius;
        }
    } 
}
