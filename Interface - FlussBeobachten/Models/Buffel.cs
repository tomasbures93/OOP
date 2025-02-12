using Interface___FlussBeobachten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface___FlussBeobachten.Models
{
    internal class Buffel : IWeg
    {
        private double _maxWasserStand;
        private bool _offen;

        public Buffel(double maxStand) {
            _maxWasserStand = maxStand;
            _offen = true;
        }

        public double maxWasserStand
        {
            get { return _maxWasserStand; }
            set { _maxWasserStand = value; }
        }

        public bool offen
        {
            get { return _offen; }
            set { _offen = value; }
        }

        public void beobachten(Fluss fluss)
        {
            double wasserStand = fluss.WasserStand;
            if (wasserStand >= maxWasserStand)
            {
                _offen = false;
                Console.WriteLine($"\tBuffeln von den Fluss entfernen.");
            } else if(wasserStand >= 5 && wasserStand < maxWasserStand)
            {
                _offen = false;
                Console.WriteLine($"\tBuffeln in Stahl bringen Bitte.");
            } else if(wasserStand > 0.3)
            {
                _offen = true;
                Console.WriteLine($"\tBuffeln drausen lassen.");
            }
            else
            {
                _offen = true;
                Console.WriteLine($"\tWasserstand zu niedrig, Sie brauchen mehr wasser.");
            }
        }
    }
}
