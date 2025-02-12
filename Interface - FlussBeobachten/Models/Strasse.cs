using Interface___FlussBeobachten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface___FlussBeobachten.Models
{
    internal class Strasse : IWeg
    {
        private double _maxWasserStand;
        private bool _offen;

        public Strasse(double maxStand)
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
            set { _offen = false; }
        }

        public void beobachten(Fluss fluss)
        {
            double wasserStand = fluss.WasserStand;
            if (wasserStand >= maxWasserStand)
            {
                _offen = false;
                Console.WriteLine($"\tWasserstand zu hoch! Strasse ist gesspert!");
            }
            else
            {
                if(_offen == true)
                {
                    Console.WriteLine($"\tWasserstand okay! Strasse ist offen. Gute Fahrt!");
                } else
                {
                    Console.WriteLine($"\tWasserstand wieder OKAY, leider andere behörde sind faule Säcke und die strasse ist immer noch gesspert!! :(");
                }
            }
        }
    }
}
