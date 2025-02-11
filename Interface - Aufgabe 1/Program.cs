using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface___Aufgabe_1.Models;

namespace Interface___Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Biene biene = new Biene();
            biene.Fliegen();

            Fledermaus fledermaus = new Fledermaus();
            fledermaus.Fliegen();

            Singvogel singvogel = new Singvogel();
            singvogel.Fliegen();
            singvogel.Singen();

            Console.ReadKey();
        }
    }
}
