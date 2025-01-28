using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Beziehungen_1.Models
{
    internal class Person
    {
        private string _nachname;
        private string _vorname;
        private int _alter;
        private Adresse _adresse;
        private Hund _hund;

        public Person(string nachname, string vorname, int alter)
        {
            _nachname = nachname;
            _vorname = vorname;
            _alter = alter;
            _hund = null;
        }
        
        public string GetName()
        {
            return $"{_nachname} {_vorname}";
        }

        public void SetNachname(string nachname)
        {
            _nachname = nachname;
        }

        public int GetAlter()
        {
            return _alter;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {this.GetName()} | {this.GetAlter()} jahre alt | {this.GetAdresse()}");
        }

        public void SetAdresse(string strasse, string hausnr, string plz, string ort)
        {
            _adresse = new Adresse(strasse, hausnr, plz, ort);
        }

        public void SetHund(string name)
        {
            _hund = new Hund(name, GetName());
        }

        public string GetHund()
        {
            return _hund.GetInfo();
        }

        public string IstHundBesitzer()
        {
            if (_hund == null)
            {
                return $"{GetName()} besitzt kein Hund";
            } else
            {
                return $"{GetName()} besitzt ein Hund mit name {_hund.GetHundeName()}";
            }
        }

        public string GetHundeName()
        {
            return _hund.GetHundeName();
        }

        public void HundFuttern()
        {
            _hund.Futtern();
        }

        public void HundGassi()
        {
            if(this._alter > 16)
            {
                _hund.Gassi();
            } else
            {
                Console.WriteLine("Du bist zu jung, du darftst nicht mit Hund Gassi Gehen");
            }
        }
        public string GetAdresse()
        {
            return _adresse.GetInfo();
        }

        public void HundAbgeben()
        {
            _hund = null;
        }

    }
}
