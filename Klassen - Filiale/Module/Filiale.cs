using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Filiale.Module
{
    internal class Filiale
    {
        private string _name;               // Private immer mit _ anfangen wenn public dann ohne_ ... Immer camelCase benutzen
        private double _kasse;
        private int _warenbestand;

        public Filiale(string name, double kasse = 50, int warenbestand = 10)
        {
            _name = name;
            _kasse = kasse;
            _warenbestand = warenbestand;
        }

        public void Info()
        {
            Console.WriteLine($"Filiale: {_name}, Kassestand: {_kasse} Euro, Warenbestand: {_warenbestand}");
        }

        public void Einkauf(int menge)
        {
            if( menge <= 0)
            {
                Console.WriteLine("Falsche menge eingegeben");
            } else
            {
                if( menge * 10 > _kasse)
                {
                    Console.WriteLine($"Fehler du hast nicht genug geld. | Price: {menge * 10} | Geld in Kasse: {_kasse}");
                }
                else
                {
                    _kasse -= menge * 10;
                    _warenbestand += menge;
                    Console.WriteLine($"Du hast {menge} einheiten Ware gekauft, es hatte dich {menge * 10} gekostet. Neue kasse stand {_kasse}");
                }
            }
        }

        public void Verkauf(int menge)
        {
            if( menge <= 0)
            {
                Console.WriteLine("Falsche menge eingegeben");
            } else
            {
                if(menge <= _warenbestand)
                {
                    _kasse += menge * 20;
                    _warenbestand -= menge;
                    Console.WriteLine($"Du hast {menge} einheiten Ware verkauft, du hast {menge * 20} verdient, Neue Kasse stand {_kasse}");
                }
                else
                {
                    Console.WriteLine($"Fehler du hast nicht genug ware. | Warebestand: {_warenbestand} | Kunde will: {menge}");
                }
            }
        }
    }
}
