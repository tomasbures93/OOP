using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Bankkonten.Models
{
    enum Kategorie
    {
        Standart,
        Schuler,
        Student,
        Gewerblich
    }

    internal class Girokonto : Konto
    {
        private Kategorie _kategorie;

        public Girokonto(string name, string nachname, string adresse, string kontonummer, double kontostand, DateTime anlegedatum, double habenzinssatz, Kategorie kategorie) : base(name, nachname, adresse, kontonummer, kontostand, anlegedatum, habenzinssatz) 
        { 
            _kategorie = kategorie;
        }

        public new bool Auszahlen(double geld)      // new - methode wurde komplett überschrieben
        {
            if (_kontostand - geld < 0)
            {
                _kontostand -= geld;
                _habenzinssatz = -16;
                return true;
            }
            else
            {
                _kontostand -= geld;
                _habenzinssatz = 0;
                return true;
            }
        }

        public new string KontoInfo()
        {
            return base.KontoInfo() + $"\n\n\tExtra Infos: \n\tKonto Kategorie: {_kategorie.ToString()} ";
        }
    }
}
