using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Fussballspiel.Models
{
    internal class Spieler : Person
    {
        private int _tore;

        public Spieler(string name, int alter, int starke, int torschuss, int motivation) : base(name, alter, starke, torschuss, motivation)
        {
        }
        public Spieler(string name, int alter, int starke, int torschuss, int motivation, int tore) : base(name, alter, starke, torschuss, motivation)
        {
            _tore = tore;
        }

        public void AddTor()
        {
            _tore++;
        }

        public int SchiesstAufTor()
        {
            Random random = new Random();
            int torschuss = Math.Max(1, Math.Min(10, _torschuss - random.Next(3)));
            int schussQualität = Math.Max(1, Math.Min(10, torschuss + random.Next(3) - 1));
            return schussQualität;
        }

        public int GetTore()
        {
            return _tore;
        }
    }
}
