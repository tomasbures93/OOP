using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphie___Versandservice.Models;

namespace Polymorphie___Versandservice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Testen ob es geht
            Adresse adresse = new Adresse("Bures", "Tomas", "Harantova 649", "29501 Mnichovo Hradiste", "Czech Republic");
            Adresse adresse2 = new Adresse("Bures", "Tomas", "Zentrum 1", "44805 Bochum");
            Adresse adresse3 = new Adresse("","", "", "");
            Adresse adresse4 = new Adresse("Lalala", "", "", "");
            Adresse adresse5 = new Adresse("Lalala", "Mohamand", "", "");
            Adresse adresse6 = new Adresse("Lalala", "Mohamand", "lempsky", "");


            Console.WriteLine(adresse.ToString());
            Console.WriteLine(adresse.IsGultig());
            Console.WriteLine(adresse2.ToString());
            Console.WriteLine(adresse2.IsGultig());
            Console.WriteLine(adresse3.ToString());
            Console.WriteLine(adresse3.IsGultig());
            Console.WriteLine(adresse4.ToString());
            Console.WriteLine(adresse4.IsGultig());
            Console.WriteLine(adresse5.ToString());
            Console.WriteLine(adresse5.IsGultig());
            Console.WriteLine(adresse6.ToString());
            Console.WriteLine(adresse6.IsGultig());
        }
    }
}
