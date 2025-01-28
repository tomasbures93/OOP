using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Beziehungen_1.Models
{
    internal class Hund
    {
        private string _name;
        private bool _gefuttert;
        private string _nameBesitzer;

        public Hund(string name)
        {
            _name = name;
            _gefuttert = false;
        }
        public Hund(string name, string besitzer)
        {
            _name = name;
            _gefuttert = false;
            _nameBesitzer = besitzer;
        }

        private string FutternInfo()
        {
            if(_gefuttert == true)
            {
                return "Vollgefressen";
            } 
            else
            {
                return "Hungrig";
            }
        }

        public void Futtern()
        {
            if (_gefuttert == false)
            {
                _gefuttert = true;
            }
        }

        public void Gassi()
        {
            _gefuttert = false;
        }

        public string GetHundeName()
        {
            return _name;
        }

        public string GetInfo()
        {
            if(_nameBesitzer == null)
            {
                return $"Hunde besitzer: ------ | Hunde Name: {_name} | Hund ist {this.FutternInfo()}";
            } 
            else
            {
                return $"Hunde besitzer: {_nameBesitzer} | Hunde Name: {_name} | Hund ist {this.FutternInfo()}";

            }
        }
    }
}
