using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Königreich.Models
{
    internal class Einwohner
    {
        protected string _name;
        protected string _adresse;
        protected double _einkommen;

        public Einwohner(string name, string adresse, double einkommen) 
        {
            _name = name;
            _adresse = adresse;
            _einkommen = einkommen;
        }

        public override string ToString()
        {
            return $"| Status: {GetType().Name,10} | Name: {_name,15} | Adresse: {_adresse,20} | Einkomm: {_einkommen, 6} |";
        }

        public void SetzeEinkommen(double einkommen)
        {
            _einkommen = einkommen;
        }
        public string GetName()
        {
            return _name ;
        }
        public virtual double ZuVersteuerndesEinkommen()
        {
            return _einkommen;
        }

        public virtual double Steuer()
        {
            return (_einkommen / 100) * 10;
        }
    }
}
