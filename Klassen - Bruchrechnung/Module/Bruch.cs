using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Bruchrechnung.Module
{
    internal class Bruch
    {
        private int _zahler;        // das oben
        private int _nenner;        // das unten

        public Bruch(int zahler = 1, int nenner = 1)
        {
            _zahler = zahler;
            _nenner = nenner;
        }

        public string Ausgabe()
        {
            return $"{_zahler} / {_nenner}";
        }

        public Bruch Kehrwert()
        {
            Bruch kehr = new Bruch(_nenner, _zahler);
            return kehr; 
        }

        public Bruch Kurzen()
        {   
            Bruch kurz = new Bruch();
            return kurz;
        }

        public Bruch Addieren(Bruch bruch1, Bruch bruch2)
        {
            Bruch addition = new Bruch();
            return addition;
        }

        public Bruch Substrahieren(Bruch bruch1, Bruch bruch2)
        {
            Bruch sub = new Bruch();
            return sub;
        }

        public Bruch Dividieren(Bruch bruch1, Bruch bruch2)
        {
            Bruch div = new Bruch();
            return div;
        }

        public Bruch Multiplizieren(Bruch bruch1, Bruch bruch2)
        {
            Bruch multi = new Bruch();
            return multi;
        }
    }
}
