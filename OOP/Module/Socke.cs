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
        public string Farbe;
        public bool Trocken;
        public bool Sauber;

        public Socke(string farbe, bool trocken, bool sauber)
        {
            Farbe = farbe;
            Trocken = trocken;
            Sauber = sauber;
        }

        public void Trockne()
        {
            if(Trocken == true)
            {
                Trocken = false;        // nicht trocken
            } else
            {
                Trocken = true;         // Trocken
            }
        }

        public void Wasche() 
        { 
            if(Sauber == true)
            {
                Sauber = false;         // nicht sauber
            } else
            {
                Sauber = true;          // sauber
            }
        }

        public void Ausgabe()
        {
            string statusTrocken;
            string statusSauber;
            if (Trocken == true)
            {
                statusTrocken = "ist";
            } else
            {
                statusTrocken = "ist nicht";
            }
            if(Sauber == true)
            {
                statusSauber = "ist";
            } else
            {
                statusSauber = "ist nicht";
            }
            Console.WriteLine($"Die Socken mit der Farbe {Farbe} {statusTrocken} trocken und {statusSauber} sauber.");
        }
    }
}
