using Interface___Nachrichten.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface___Nachrichten.Models
{
    internal class TV : INachrichtenQuelle
    {
        private string _name;
        private List<INachrichtenEmpfanger> leute = new List<INachrichtenEmpfanger>();

        public TV(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void Anmelden(INachrichtenEmpfanger empfanger)
        {
            leute.Add(empfanger);
        }

        public void Abmelden(INachrichtenEmpfanger empfanger)
        {
            leute.Remove(empfanger);
        }

        public void SendeNachricht(string nachricht)
        {
            Console.WriteLine($"\n{_name} sendet:");
            foreach(INachrichtenEmpfanger nachrichtenEmpfangers in leute)
            {
                nachrichtenEmpfangers.EmpfangeNachricht(nachricht);
            }
        }
    }
}
