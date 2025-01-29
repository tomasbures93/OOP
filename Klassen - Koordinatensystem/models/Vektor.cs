using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Koordinatensystem.models
{
    internal class Vektor
    {
        private Punkt _startpunkt;
        private Punkt _endpunkt;

        public Vektor(Punkt startpunkt, Punkt endpunkt)
        {
            _startpunkt = startpunkt;
            _endpunkt = endpunkt;
        }

        public double Lange()
        {
            return Math.Round(Math.Sqrt(Math.Pow(_endpunkt.Getx()-_startpunkt.Getx(),2)+Math.Pow(_endpunkt.Gety()-_startpunkt.Gety(),2)),3);
        }
    }
}
