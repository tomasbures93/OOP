using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface___Temperatur.Models;

namespace Interface___Temperatur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatur tempnow = new Temperatur();
            tempnow.Celsius = 10;
            Console.WriteLine(tempnow.ToString());

            tempnow.Fahrenheit = 60;
            Console.WriteLine(tempnow.ToString());

            tempnow.Celsius = 0;
            Console.WriteLine(tempnow.ToString());

            tempnow.Kelvin = 300;
            Console.WriteLine(tempnow.ToString());
        }
    }
}
