using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphie___Widerstandsnetz.Models;

namespace Polymorphie___Widerstandsnetz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Widerstand R1 = new Widerstand("R1", 100);
            Widerstand R2 = new Widerstand("R2", 200);
            Widerstand R3 = new Widerstand("R3", 300);
            Widerstand R4 = new Widerstand("R4", 400);
            Widerstand R5 = new Widerstand("R5", 500);
            Widerstand R6 = new Widerstand("R6", 600);

            // Netze aufbauen gemäß der Schaltung
            var rp1 = new Parallelschaltung(R1, R3);        // 75
            var rp2 = new Reihenschaltung(R2, rp1);         // 275
            var rr1 = new Reihenschaltung(R4, R5);          // 900
            var rrrr = new Parallelschaltung(rr1, R6);      // 360    
            var rrr = new Parallelschaltung(rrrr, rp2);     // 155,9055

            // Gesamtwiderstand berechnen
            double gesamtwiderstand = rrr.BerechneWiderstand();
            Console.WriteLine($"Gesamtwiderstand: {gesamtwiderstand:F4} Ohm");


        }
    }
}
