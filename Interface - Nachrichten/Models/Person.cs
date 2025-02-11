using Interface___Nachrichten.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface___Nachrichten.Models
{
    internal class Person : INachrichtenEmpfanger
    {
        private string _name;

        public Person(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void EmpfangeNachricht(string nachricht)
        {
            Console.WriteLine($"{GetName()} - Nachricht: {nachricht}");
        }
    }
}
