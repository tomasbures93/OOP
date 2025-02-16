using OOP___Zustand_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Zustand_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Steak steak = new Steak("T-Bone");

            steak.IncreaseTemperature(48.9);
            steak.IncreaseTemperature(10);
            steak.IncreaseTemperature(5);
            steak.DecreaseTemperature(15);
            steak.DecreaseTemperature(5);
            steak.IncreaseTemperature(10);
            steak.IncreaseTemperature(20);
        }
    }
}
