using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___StarWars.Interfaces
{
    internal interface ISchiff
    {
        int Hulle { get; set; }
        int FeuerKraft { get; }
        string CallSign { get; }
        string ASCII { get; }

        ConsoleColor LaserFarbe { get; }

        string Motto {  get; }

    }
}
