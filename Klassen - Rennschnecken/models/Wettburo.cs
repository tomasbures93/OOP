using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Rennschnecken.models
{
    internal class Wettburo
    {
        private Rennen _rennen;
        private List<Wette> _wetten;
        private int _faktor;

        public Wettburo(Rennen rennen, int faktor)
        {
            _rennen = rennen;
            _faktor = faktor;
            _wetten = new List<Wette>();
        }

        public void WetteAnnehmen(string schneckename, int wettEinsatz, string player)
        {
            _wetten.Add(new Wette(player, wettEinsatz, schneckename));
        }

        public void Ausgabe()
        {
            Console.WriteLine("           Player    |          Schnecke    |                  wettEinsatz");
            Console.WriteLine("----------------------------------------------------------------------------");
            foreach (var w in _wetten)
            {
                Console.WriteLine(w.WetteInfo());
            }
            Console.WriteLine("----------------------------------------------------------------------------");
        }
    }
}
