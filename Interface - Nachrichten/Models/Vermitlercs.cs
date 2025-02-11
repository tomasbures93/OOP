using Interface___Nachrichten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface___Nachrichten.Models
{
    internal class Vermitler : INachrichtenEmpfanger, INachrichtenQuelle
    {
        private List<INachrichtenEmpfanger> leute = new List<INachrichtenEmpfanger>();
        private string _name;

        public Vermitler(string name) {
            _name = name;
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
            foreach (INachrichtenEmpfanger nachrichtenEmpfangers in leute)
            {
                nachrichtenEmpfangers.EmpfangeNachricht(nachricht);
            }
        }

        public void EmpfangeNachricht(string nachricht)
        {
            Console.WriteLine($"{_name} - Nachricht: {nachricht}");
        }
    }
}
