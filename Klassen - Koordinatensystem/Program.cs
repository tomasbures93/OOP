using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen___Koordinatensystem.models;

namespace Klassen___Koordinatensystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vektor vektro = new Vektor(new Punkt(2, 21),new Punkt(3, 3));
            Console.WriteLine(vektro.Lange());
        }
    }
}
