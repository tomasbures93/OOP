using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen___Radio.Module;

namespace Klassen___Radio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio bombastic = new Radio(false, 0);

            Console.WriteLine(bombastic.RadioInfo());
            bombastic.An();
            Console.WriteLine(bombastic.RadioInfo());
            for(int i = 0; i < 10; i++)
            {
                bombastic.Lauter();
            }
            bombastic.WahleSender(138);
            Console.WriteLine(bombastic.RadioInfo());
            Console.WriteLine(bombastic.IstAn());

            bombastic.Aus();
            Console.WriteLine(bombastic.IstAn());

            bombastic.An();
            Console.WriteLine(bombastic.RadioInfo());
            for (int i = 0; i < 25; i++)
            {
                bombastic.Lauter();
            }
            bombastic.WahleSender(92.1);
            Console.WriteLine(bombastic.RadioInfo());
            for (int i = 0; i < 10; i++)
            {
                bombastic.Leiser();
            }
            Console.WriteLine(bombastic.RadioInfo());

            Console.ReadKey();
        }
    }
}
