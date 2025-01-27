using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Module
{
    internal class Socke
    {
        private string _Farbe;
        private bool _Trocken;
        private bool _Sauber;

        public Socke(string farbe, bool trocken, bool sauber)
        {
            _Farbe = farbe;
            _Trocken = trocken;
            _Sauber = sauber;
        }

        public void Trockne()
        {
            if(_Trocken == true)
            {
                _Trocken = false;        // nicht trocken
            } 
            else
            {
                _Trocken = true;         // Trocken
            }
        }

        public void Wasche() 
        { 
            if(_Sauber == true)
            {
                _Sauber = false;         // nicht sauber
            } 
            else
            {
                _Sauber = true;          // sauber
            }
        }

        public void Ausgabe()
        {
            string statusTrocken;
            string statusSauber;
            if (_Trocken == true)
            {
                statusTrocken = "ist";
            } 
            else
            {
                statusTrocken = "ist nicht";
            }
            if(_Sauber == true)
            {
                statusSauber = "ist";
            } 
            else
            {
                statusSauber = "ist nicht";
            }
            Console.WriteLine($"Die Socken mit der Farbe {_Farbe} {statusTrocken} trocken und {statusSauber} sauber.");
        }
    }
}
