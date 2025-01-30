using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Schuler_und_Projekte.models
{
    internal class Projekt
    {
        private string _id;
        private string _name;
        private List<Schuler> _beteiligte;

        public Projekt(string id, string name)
        {
            _id = id;
            _name = name;
        }

        public Projekt(string id, string name, List<Schuler> schuler)
        {
            _id = id;
            _name = name;
            _beteiligte = schuler;
        }

        public string GetInfo()
        {
            return $"Projekt ID: {_id,3} | Projekt name: {_name,15} | Projekt besetzung: {_beteiligte.Count} Leute";
        }

        public string GetProjectBeteiligte()
        {
            string output = "";
            foreach(Schuler schuler in _beteiligte)
            {
                output = $"{schuler.GetName()}\n" + output;
            }
            return output ;
        }

        private int GetBeteiligteCount()
        {
            return _beteiligte.Count;
        }

        public string GetName()
        {
            return _name;
        }

        public static Projekt GetBesteProject(List<Projekt> projekte)
        {
            Projekt best = null;
            int leute = 0;
            foreach(Projekt projekt in projekte)
            {
                if (projekt.GetBeteiligteCount() > leute)
                {
                    leute = projekt.GetBeteiligteCount();
                    best = projekt;
                }
            }
            return best;
        }
    }
}
