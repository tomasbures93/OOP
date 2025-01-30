using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Klassen___Schuler_und_Projekte.models
{
    internal class Schuler
    {
        private int _id;
        private string _name;
        private List<Projekt> _projekte = new List<Projekt>();

        public Schuler(int id)
        {
            _id = id;
        }

        public Schuler(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public Schuler(int id, string name, List<Projekt> projekt)
        {
            _id = id;
            _name = name;
            _projekte = projekt;
        }

        public void AddProjekt(Projekt projekt)
        {
            _projekte.Add(projekt);
        }

        public string GetInfo()
        {
            return $"ID: {_id,2} | Name: {_name}";
        }

        public Schuler GetSchuler(int id)
        {
            return new Schuler(id, _name);
        }
        public string GetProjekteVonSchuler()
        {
            string output = "";
            foreach(Projekt projekt in _projekte)
            {
                output = output + " | " +  projekt.GetName();
            }
            return output;
        }

        public string GetBesteSchuler()
        {
            int zahl = 0;
            foreach(Projekt anzahl in _projekte)
            {
                int temp = _projekte.Count();
                if (temp >= zahl)
                {
                    zahl = temp;
                }
            }
            return zahl.ToString();
        }
        public string GetName()
        {
            return _name;
        }
        public int GetId()
        {
            return _id;
        }

    }
}
