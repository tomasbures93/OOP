using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Fussballspiel.Models
{
    internal class Torwart : Person
    {
        private int _reaktion;

        public Torwart(string name, int alter, int starke, int torschuss, int motivation, int reaktion) : base(name, alter, starke, torschuss, motivation)
        {
            _reaktion = reaktion;
        }

        public int GetReaktion()
        {
            return _reaktion;
        }

        public bool HältDenSchuss(int schussQualität)
        {
            Random random = new Random();
            int halteQualität = Math.Max(1, Math.Min(10, _reaktion + random.Next(3) - 1));
            if (halteQualität >= schussQualität)
            {
                return true; // gehalten
            }
            else
            {
                return false; // TOR!!!
            }
        }
    }
}
