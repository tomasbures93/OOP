using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Warenlager.models
{
    internal class Artikel
    {
        private int _artnr;
        private string _bezeichnung;
        private double _preis;
        private int _maxbestand;

        public Artikel(int artnr, string bezeichnung, double preis, int maxbestand)
        {
            _artnr = artnr;
            _bezeichnung = bezeichnung;
            _preis = preis;
            _maxbestand = maxbestand;
        }

        public string GetName()
        {
            return _bezeichnung;
        }

        public int GetMaxBestand()
        {
            return _maxbestand;
        }

        public double GetPreis()
        {
            return _preis;
        }

        public string GetCompleteInfo(Lager lager, Dailystats stats)
        {
            return $"{_artnr,-14} | {_bezeichnung,11} | {_preis,15} | {lager.GetBestand(),3} / {_maxbestand,3} | {stats.GetVerkauft(),-14} | {lager.GetBestelldauer(),12}";
        }
    }
}
