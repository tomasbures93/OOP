using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Sparschwein.Module
{
    internal class PiggyBank
    {
        private int _cents;
        private int _maxCents;
        private bool _gebrochen;

        public PiggyBank(int cents, int maxCents = 10000, bool broken = false)
        {
            _cents = cents;
            _maxCents = maxCents;
            _gebrochen = broken;
        }

        public void Bestand()
        {
            Console.WriteLine("Cents inside: " + _cents + " | MaxGroße: " + _maxCents);
        }

        public int Add1Cent(int menge)
        {
            if(menge <= _maxCents - _cents)
            {
                _cents += menge;
                return 0;
            } else
            {
                int rest;
                int stillFits = _maxCents - _cents;     
                rest = stillFits - menge;
                _cents += stillFits;
                return Math.Abs(rest);               
            }
        }

        public int Add10Cents(int menge)
        {
            if (menge * 10 <= _maxCents - _cents)
            {
                _cents += menge * 10;
                return 0;
            }
            else
            {
                int rest;
                int stillFits = _maxCents - _cents;
                rest = stillFits - menge * 10;
                _cents += stillFits;
                return Math.Abs(rest);          
            }
        }

        public int Add50Cents(int menge)
        {
            if (menge * 50 <= _maxCents - _cents)
            {
                _cents += menge * 50;
                return 0;
            }
            else
            {
                int rest;
                int stillFits = _maxCents - _cents;     
                rest = stillFits - menge * 50;
                _cents += stillFits;
                return Math.Abs(rest);             
            }
        }

        public int Add1Euro(int menge)
        {
            if (menge * 100 <= _maxCents - _cents)
            {
                _cents += (menge * 100);
                return 0;
            }
            else
            {
                int rest;
                int stillFits = _maxCents - _cents;     // 100 - 50 = 50
                rest = stillFits - menge * 100;
                _cents += stillFits;
                return Math.Abs(rest);             // return überlauf
            }
        }

        public bool IsBroken()
        {
            return _gebrochen;
        }

        public int BreakInto()
        {
            int centsInSchwein = _cents;
            _cents = 0;
            _gebrochen = true;
            return centsInSchwein;
        }

        public string Shake()
        {
            double procent = ((double)_cents / _maxCents) * 100;
            string output;
            if (_maxCents == _cents)
            {
                output = "Voll";
            } 
            else if (procent <= 99.9 && procent >= 67)
            {
                output = $"etwa zwei drittel voll";
            } 
            else if (procent <= 66 && procent >= 34)
            {
                output = $"etwa halb voll";
            } 
            else if(procent >= 0.1)
            {
                output = $"etwa ein drittel Voll";
            } else
            {
                output = "Leer";
            }
            return output;
        }
    }
}
