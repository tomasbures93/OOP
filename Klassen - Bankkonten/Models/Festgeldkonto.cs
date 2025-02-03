using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Bankkonten.Models
{
    internal class Festgeldkonto : Konto
    {
        private DateTime _mindlaufzeit;
        public Festgeldkonto(string name, string nachname, string adresse, string kontonummer, double kontostand, DateTime anlegedatum, double habenzinssatz, DateTime mindlaufzeit) : base(name, nachname, adresse, kontonummer, kontostand, anlegedatum, habenzinssatz)
        {
            _mindlaufzeit = mindlaufzeit;
        }

        public string RestLaufZeit()
        {
            int restyear = _mindlaufzeit.Year - DateTime.Now.Year;
            int restmonth = _mindlaufzeit.Month - DateTime.Now.Month;
            int restdays = _mindlaufzeit.Day - DateTime.Now.Day;
            return $"\tYou cant touch your savings for next {restyear} years , {restmonth} months, {restdays} days";
        }

        public new string KontoInfo()
        {
            return base.KontoInfo() + $"\n\n\tExtra Infos: \n\tLauft bis: {_mindlaufzeit.Day}.{_mindlaufzeit.Month}.{_mindlaufzeit.Year}";
        }
    }
}
