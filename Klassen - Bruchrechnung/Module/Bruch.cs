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
            return $"{_zahler}/{_nenner}";
        }

        public Bruch Kehrwert()
        {
            Bruch kehr = new Bruch(_nenner, _zahler);
            return kehr; 
        }

        public Bruch Kurzen()
        {
            int ggt = GGT(_zahler, _nenner);
            int nenner = _nenner / ggt;
            int zahler = _zahler / ggt;
            return new Bruch(zahler, nenner);
        }

        public static Bruch Addieren(Bruch bruch1, Bruch bruch2)
        {
            int zahler = bruch1._zahler * bruch2._nenner + bruch2._zahler * bruch1._nenner;
            int nenner = bruch1._nenner * bruch2._nenner;
            return new Bruch(zahler, nenner);
        }

        public Bruch Substrahieren(Bruch bruch2)
        {
            int zahler = this._zahler * bruch2._nenner - bruch2._zahler * this._nenner;
            int nenner = this._nenner * bruch2._nenner;
            return new Bruch(zahler, nenner);
        }

        public static Bruch Dividieren(Bruch bruch1, Bruch bruch2)
        {
            if(bruch1._nenner != 0 || bruch2._nenner != 0)
            {
                int zahler = bruch1._zahler * bruch2._nenner;
                int nenner = bruch1._nenner * bruch2._zahler;
                return new Bruch(zahler, nenner);
            }
            else
            {
                Console.WriteLine("Mit 0 darfst du nicht dividieren");
                return new Bruch();
            }

        }

        public Bruch Multiplizieren(Bruch bruch2)
        {
            int zahler = this._zahler * bruch2._zahler;
            int nenner = this._nenner * bruch2._nenner;
            return new Bruch(zahler, nenner);
        }

        static int GGT(int a, int b)
        {
            int ergebniss = a % b;
            if (ergebniss == 0)
            {
                return b;
            }
            else
            {
                a = b;
                b = ergebniss;
                return GGT(a, b);
            }
        }
    }
}
