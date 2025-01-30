using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Rennschnecken.models
{
    internal class Wette
    {
        private string _player;
        private int _wette;
        private string _schnecke;

        public Wette(string player, int wette, string schnecke)
        {
            _player = player;
            _wette = wette;
            _schnecke = schnecke;
        }

        public string WetteInfo()
        {
            return $"{_player,20} | {_schnecke,20} | {_wette,20} dollars";
        }
    }
}
