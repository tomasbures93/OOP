using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphie___Auto_Pickup.Models;

namespace Polymorphie___Auto_Pickup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto[] autos =
            {
                new Auto("BO OQ 249", 192000, false, 5),
                new Auto(),
                new Pickup("BO OQ 29", 1920, false, 2, 200),
                new Auto("kekekeke", 192, true, 5),
                new Pickup("lol", 2000, false, 2, 200),
                new Pickup()
            };

            foreach(Auto auticko in autos)
            {
                Console.WriteLine(auticko + "\n");
            }
            Console.WriteLine("\n\nWasch Tag\n\n");
            foreach (Auto auticko in autos)
            {
                auticko.Waschen();
            }
        }
    }
}
