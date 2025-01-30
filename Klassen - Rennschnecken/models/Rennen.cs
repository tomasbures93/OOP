using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Rennschnecken.models
{
    internal class Rennen
    {
        private string _name;
        private int _maxschnecken;
        private List<Rennschnecke> _schliste;
        private int _lange;

        public Rennen(string name, int maxschnecken, int lange)
        {
            _name = name;
            _maxschnecken = maxschnecken;
            _schliste = new List<Rennschnecke>();
            _lange = lange;
        }

        public void AddSchnecke(Rennschnecke schnecke)
        {
            if (_maxschnecken > _schliste.Count)
            {
                _schliste.Add(schnecke);
            }
            else
            {
                Console.WriteLine("Liste voll");
            }
        }

        public string Ausgabe()
        {
            string namen = "";
            foreach (Rennschnecke e in _schliste) {
                namen = namen +" "+ e.GetName();
            }
            return $"Race Name: {_name} | Max Schnecken: {_maxschnecken} | Beteiligte: {namen}";
        }
    }
}
