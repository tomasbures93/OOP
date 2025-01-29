using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Warenlager.models
{
    internal class Dailystats
    {
        private Artikel _artikel;
        private int _vebrauch;

        public Dailystats(Artikel artikel, int vebrauch) 
        {
            _artikel = artikel;
            _vebrauch = vebrauch;
        }

        public string GetInfo()
        {
            return $"{_artikel.GetName()} war heute {_vebrauch}";
        }
        public int GetVerkauft()
        {
            return _vebrauch;
        }
    }
}
