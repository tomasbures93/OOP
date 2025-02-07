using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Versandservice.Models
{
    internal class Adresse
    {
        private string _nachname;
        private string _vorname;
        private string _strhaus;
        private string _plzort;
        private string _land;

        public Adresse(string nachname, string vorname, string strhaus, string plzort, string land = "Deutschland")
        {
            _nachname = nachname;
            _vorname = vorname;
            _strhaus = strhaus;
            _plzort = plzort;
            _land = land;
        }

        public bool IsGultig()
        {
            if(string.IsNullOrEmpty(_nachname)) return false;
            if(string.IsNullOrEmpty(_vorname)) return false;
            if (string.IsNullOrEmpty(_strhaus)) return false;
            if (string.IsNullOrEmpty(_plzort)) return false;
            return true;
        }

        public override string ToString()
        {
            return $"-----\n{_vorname} {_nachname}\n{_strhaus}\n{_plzort}\n{_land}";
        }
    }
}
