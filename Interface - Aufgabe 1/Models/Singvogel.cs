using Interface___Aufgabe_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface___Aufgabe_1.Models
{
    internal class Singvogel : IFliegen, ISingen
    {
        public void Fliegen()
        {
            Console.WriteLine("Flapflap");
        }

        public void Singen()
        {
            Console.WriteLine("Zwitscherzwitscher");
        }
    }
}
