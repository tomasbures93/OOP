﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface___FlussBeobachten.Models
{
    internal class Fluss
    {
        private string _name;
        private double _wasserStand;

        public Fluss(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    

        public double WasserStand
        {
            get { return _wasserStand; }
            set { _wasserStand = value; }
        }
    }
}
