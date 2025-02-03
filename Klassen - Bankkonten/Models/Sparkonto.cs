using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Bankkonten.Models
{
    internal class Sparkonto : Konto
    {
        private double _guthabezinsatz;
        public Sparkonto(string name, string nachname, string adresse, string kontonummer, double kontostand, DateTime anlegedatum, double habenzinssatz, double guthabezinsatz) : base(name, nachname, adresse, kontonummer, kontostand, anlegedatum, habenzinssatz)
        {
            _guthabezinsatz = guthabezinsatz;
        }

        public new string KontoInfo()
        {
            return base.KontoInfo() + $"\n\n\tExtra Infos: \n\tGutHabenZinsatz: {Math.Abs(_guthabezinsatz)} %";
        }
    }
}
