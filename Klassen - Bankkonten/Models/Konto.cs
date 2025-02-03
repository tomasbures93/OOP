using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Bankkonten.Models
{
    internal class Konto
    {
        protected string _name;
        protected string _nachname;
        protected string _adresse;
        protected string _kontonr;
        protected double _kontostand;
        protected DateTime _anlegedatum;
        protected double _habenzinssatz;

        public Konto(string name, string nachname, string adresse, string kontonr, double kontostand, DateTime anlegedatum, double habenzinssatz)
        {
            _name = name;
            _nachname = nachname;
            _adresse = adresse;
            _kontonr = kontonr;
            _kontostand = kontostand;
            _anlegedatum = anlegedatum;
            _habenzinssatz = habenzinssatz;
        }

        public bool Einzahlen(double geld)
        {
            _kontostand += geld;
            return true;
        }

        public bool Auszahlen(double geld)
        {
            if (_kontostand - geld < 0)
            {
                return false;
            }
            else
            {
                _kontostand -= geld;
                return true;
            }
        }

        public double Zinsen()
        {
            return _habenzinssatz;
        }

        public double KontoStand()
        {
            return _kontostand;
        }

        public string KontoInfo()
        {
            return $"\tKonto\n\tKontoinhaber: {_name} {_nachname}\n\tAdresse: {_adresse}\n\tErstellt: {_anlegedatum.Day}.{_anlegedatum.Month}.{_anlegedatum.Year}" +
                $"\n\tKonto-NR: {_kontonr} \n\tKontoStand: {_kontostand}\n\tZinssatz: {_habenzinssatz} %";
        }
    }
}
