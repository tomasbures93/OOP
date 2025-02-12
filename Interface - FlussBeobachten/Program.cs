using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Interface___FlussBeobachten.Models;

namespace Interface___FlussBeobachten
{
    internal class Program
    {
        static Fluss ruhr = new Fluss("Ruhr");
        static Buffel buffel = new Buffel(7);
        static Wanderweg weg = new Wanderweg(6);
        static Strasse str = new Strasse(9);
        static void Main(string[] args)
        {

            Random rand = new Random();
            do
            {
                Console.Clear();
                ruhr.WasserStand = rand.Next(-3, 12);
                Console.WriteLine($"\n\tFluss: { ruhr.Name} | WasserStand: { ruhr.WasserStand} Meter");
                buffel.beobachten(ruhr);
                weg.beobachten(ruhr);
                str.beobachten(ruhr);
                Info();
                Task.Delay(2000).Wait();
            } while (true);
        }

        static void Info()
        {
            Console.WriteLine($"\n\t*****\n\tBuffeln status ok ? {buffel.offen}");
            Console.WriteLine($"\tWanderweg status ok ? {weg.offen}");
            Console.WriteLine($"\tStraße status ok ? {str.offen}");
        }
    }
}
