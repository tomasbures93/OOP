using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Personen_aus_datei_Lesen.Module
{
    internal class Person
    {
        private string _name;
        private DateTime _geburstdatum;

        public Person(DateTime geburstdatum, string name = "")
        {
            _name = name;
            _geburstdatum = geburstdatum;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDatum()
        {
            string output = $"{_geburstdatum.Day}.{_geburstdatum.Month}.{_geburstdatum.Year}";
            return output;
        }

        public int GetAge()
        {
            // DayOfYear von Person und DayOfYear von Heute
            int dayOfYearPerson = _geburstdatum.DayOfYear;
            int dayOfYear = DateTime.Now.DayOfYear;

            // Jahre berechnen
            int geboren = _geburstdatum.Year;
            int now = DateTime.Today.Year;
            int rest = now - geboren;

            if (dayOfYear < dayOfYearPerson)
            {
                rest -= 1;
            }
            return rest;
        }

        // zu spielen
        public void GetInfo()
        {
            Console.WriteLine($"Year: {_geburstdatum.Year} | Month: {_geburstdatum.Month} | Day: {_geburstdatum.Day} | DayOfYear: {_geburstdatum.DayOfYear}");
        }
    }
}
