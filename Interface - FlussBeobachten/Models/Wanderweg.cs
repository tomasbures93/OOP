using Interface___FlussBeobachten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface___FlussBeobachten.Models
{
    internal class Wanderweg : IWeg
    {
        private double _maxWasserStand;
        private bool _offen;

        public Wanderweg(double maxStand)
        {
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
                Console.WriteLine($"\tWasserstand zu hoch! Radweg ist zu!");
            }
            else if (wasserStand > 1 && wasserStand < maxWasserStand)
            {
                _offen = true;
                Console.WriteLine($"\tWasserstand bischen hoch! Radweg ist offen aber Sei vorsichtig!");
            }
            else
            {
                _offen = true;
                Console.WriteLine($"\tWasserstand perfekt! Radweg ist offen. Viel Spaß");
            }
        }
    }
}
