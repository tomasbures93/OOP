﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Haustiere.Models
{
    internal class Haustier
    {
        protected string _name;
        protected bool _steuerpflicht;
        protected double _jahresKostenTierarzt;

        public Haustier(string name, bool steuerpflicht, double jahresKostenTierarzt)
        {
            _name = name;
            _steuerpflicht = steuerpflicht;
            _jahresKostenTierarzt = jahresKostenTierarzt;
        }

        public string GetName()
        {
            return _name;
        }

        public bool IsSteuerpflicht() 
        { 
            return _steuerpflicht; 
        }

        public double GetKosten()
        {
            return _jahresKostenTierarzt;
        }

        public string Beschreibung()
        {
            return $"Name: {_name} \n" +
                $"SteuerPflicht: {_steuerpflicht}\n" +
                $"JahresKosten: {_jahresKostenTierarzt}";
        }
    }
}
