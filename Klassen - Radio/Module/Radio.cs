using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Radio.Module
{
    internal class Radio
    {
        private bool _Eingeschaltet;
        private int _Lautstarke;
        private double _Frequenz;

        public Radio (bool eingeschaltet, int lautstarke)
        {
            eingeschaltet = _Eingeschaltet;
            lautstarke = _Lautstarke;
        }

        public void Lauter()
        {
            if(_Eingeschaltet == true && (_Lautstarke >= 0 && _Lautstarke <= 100))
            {
                _Lautstarke++;
            }
        }

        public void Leiser()
        {
            if(_Eingeschaltet == true && (_Lautstarke >= 0 && _Lautstarke <= 100))
            {
                _Lautstarke--;
            }
        }

        public void An()
        {
            if(_Eingeschaltet == false)
            {
                _Eingeschaltet = true;
                Console.WriteLine("Radio an");
            }
        }

        public void Aus()
        {
            if(_Eingeschaltet == true)
            {
                _Eingeschaltet = false;
                _Lautstarke = 0;
                _Frequenz = 0;
                Console.WriteLine("Radio aus");
            }
        }

        public bool IstAn()
        {
            return _Eingeschaltet;
        }
        
        public void WahleSender(double neueFrequenz)
        {
            _Frequenz = neueFrequenz;
        }

        public string RadioInfo()
        {
            if(IstAn() == true)
            {
                return $"Radio an: Frequenz={_Frequenz}, Lautstarke={_Lautstarke}";
            }
            else
            {
                return "Radio aus";
            }
        }
    }
}
