using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Kaffemachine.Models
{
    internal class Kaffemuhle
    {
        private int _bohnenInhalt;
        private int _mehlInhalt;

        public Kaffemuhle() { }

        public void InsertBohnen(int menge)
        {
            if (menge < 0 || menge > 250)
            {
                Console.WriteLine("\tNur 250grams passt da rein.");
            }
            else if (_bohnenInhalt + menge > 250)
            {
                Console.WriteLine($"\tDa ist noch was drin.");
                Console.WriteLine("\tNur 250grams passt da rein.");
            }
            else
            {
                Console.WriteLine($"\t{menge} gram eingefühlt in machine.");
                _bohnenInhalt = _bohnenInhalt + menge;
            }
        }

        public void Drehen()
        {
            if (_bohnenInhalt == 0)
            {
                Console.WriteLine("\tBitte erst Bohnen einfühlen");
            }
            else
            {
                if(_bohnenInhalt >= 10 && _mehlInhalt <= 240)
                {
                    _bohnenInhalt = _bohnenInhalt - 10;
                    _mehlInhalt = _mehlInhalt + 10;
                } else
                {
                    if(_mehlInhalt == 250)
                    {
                        Console.WriteLine("\tMehl fach ist voll");
                    }
                }
            }
        }

        public void BohnenEnthnehmen()
        {
            _bohnenInhalt = 0;
        }

        public int KaffeMehlEnthnehmen()
        {
            if(_mehlInhalt != 0)
            {
                int getout = _mehlInhalt;
                _mehlInhalt = 0;
                return getout;
            } else
            {
                Console.WriteLine("\tEs ist leer!");
                return 0;
            }

        }

        public string GetInfo()
        {
            return $"KaffeBohnen: {_bohnenInhalt} gram | KaffeMehl: {_mehlInhalt} gram";
        }
    }
}
