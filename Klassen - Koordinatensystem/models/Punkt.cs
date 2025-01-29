using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Koordinatensystem.models
{
    internal class Punkt
    {
        private int _x;
        private int _y;

        public Punkt(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int Getx()
        {
            return _x;
        }

        public int Gety()
        {
            return _y;
        }
    }
}
