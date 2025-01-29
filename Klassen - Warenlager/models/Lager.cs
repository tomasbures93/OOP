using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Warenlager.models
{
    internal class Lager
    {
        private Artikel _artikel;
        private int _istbestand;
        private int _bestelldauer;
        public Lager(Artikel artikel, int istbestand, int bestelldauer)
        {
            _artikel = artikel;
            _istbestand = istbestand;
            _bestelldauer = bestelldauer;
        }

        public int GetBestand()
        {
            return _istbestand;
        }

        public int GetBestelldauer()
        {
            return _bestelldauer;
        }

        public double GetLagerWert()
        {
            double wert = _artikel.GetPreis() * _istbestand;
            return wert;
        }

        private int MeldeBestand(Dailystats stat)
        {
            return stat.GetVerkauft() * GetBestelldauer() + (stat.GetVerkauft() * 2);
        }

        public string SollIchBestellen(Dailystats stat)
        {
            if(_istbestand <= MeldeBestand(stat))
            {
                return $"Bitte {MeldeBestand(stat) - _istbestand} stück nachbestellen!! ";
            } else
            {
                return "Wir haben genug!";
            }
        }
    }
}
