using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Module;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socke roteSocke = new Socke("Rot", true, false);
            Socke grueneSocke = new Socke("Grün", false, false);
            Socke freshSocke = new Socke("Weiß", true, true);

            roteSocke.Ausgabe();
            grueneSocke.Ausgabe();
            freshSocke.Ausgabe();

            Console.WriteLine("Grüne socke gewascht und getrocknet");

            grueneSocke.Trockne();
            grueneSocke.Wasche();
            grueneSocke.Ausgabe();
        }
    }
}
