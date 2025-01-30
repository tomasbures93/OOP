using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

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
                namen = namen +", "+ e.GetName();
            }
            return $"Race Name: {_name} | Max Schnecken: {_maxschnecken} | Beteiligte: {namen}";
        }

        private void LasseSchneckenKriechen()
        {
            foreach(Rennschnecke schnecke in _schliste)
            {
                schnecke.Krieche();
                Console.WriteLine(schnecke.AusgabeInRace());
            }
        }

        public Rennschnecke ErmittleGewinner()
        {
            Rennschnecke gewinner = new Rennschnecke();
            foreach(Rennschnecke schnecke in _schliste)
            {
                if(schnecke.GetStrecke() >= _lange)
                {
                    gewinner = new Rennschnecke(schnecke.GetName());
                } 
            }
            return gewinner;
        }

        public void Durchfuhren()
        {
            bool nochrunde = true;
            int move = 2;
            bool bewegung = false;
            do
            {

                for(int i = 0; i < _schliste.Count; i++)
                {
                    if (_schliste[i].GetStrecke() >= _lange)
                    {
                        nochrunde = false;
                        break;
                    }
                }
                if(nochrunde == true)
                {
                    Task.Delay(1000).Wait();
                    Console.Clear();
                    string schneck;
                    if (bewegung == false)
                    {
                        schneck = "_0*";
                        bewegung= true;
                    }
                    else
                    {
                        schneck = "_o*";
                        bewegung = false;
                    }
                    foreach (Rennschnecke schnecke in _schliste)
                    {
                        Console.SetCursorPosition(schnecke.GetStrecke(), move);
                        Console.WriteLine(schneck);
                        Console.SetCursorPosition(_lange + 2, move);
                        Console.WriteLine("| " +schnecke.GetName());
                        schnecke.Krieche();
                        move = move + 2;
                    }
                    move = 2;
                } else
                {
                    Console.Clear();
                    Console.SetCursorPosition(5, 2);
                    Console.WriteLine("!!! FINISH !!! ");
                    Rennschnecke gewinner = ErmittleGewinner();
                    Console.SetCursorPosition(3, 3);
                    Console.WriteLine("Winner: " + gewinner.GetName());
                }

            } while(nochrunde);
            

        }
    }
}

