using Klassen___Zahnartzpraxis.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Zahnartzpraxis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------- Start");
            Krankenkasse tw = new Krankenkasse(1, "Technische Witz");
            Krankenkasse aok = new Krankenkasse(2, "All organs Kaputt");
            Krankenkasse ibtz = new Krankenkasse(3, "Wir sind teuer :(");
            Person tomas = new Person(1, "Tomas Bures", tw);
            Person martin = new Person(2, "Martin Kign", aok);

            Console.WriteLine(tomas.GetInfo());
            Console.WriteLine(martin.GetInfo());

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("------------- Set / GetDatum");

            tomas.SetGeburstdatum("6.6.1993");
            martin.SetGeburstdatum("1.1.2000");


            Console.WriteLine(tomas.GetInfo());
            Console.WriteLine(martin.GetInfo());

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("------------- Show Patienten");
            tw.GetPatienten();
            aok.GetPatienten();
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("------------- SetAdresse / GetInfo");
            tomas.SetAdresse("Hoho 23, Bochum 44805");
            martin.SetAdresse("Arsch der Welt 1");

            Console.WriteLine(tomas.GetInfo());
            Console.WriteLine(martin.GetInfo());

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("------------- SetKrankenkasse");
            tomas.SetKrankenKasse(aok);
            martin.SetKrankenKasse(tw);
            Console.WriteLine(tomas.GetInfo());
            Console.WriteLine(martin.GetInfo());

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("------------- Neue patient");
            Person pica = new Person(3, "Pepicek Cabajka", aok);
            pica.SetAdresse("Hallo wtf");
            Console.WriteLine(pica.GetInfo());
            pica.SetKrankenKasse(aok);
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("------------- KassePatienten");
            Console.WriteLine(tw.GetInfo());
            tw.GetPatienten();
            Console.WriteLine(aok.GetInfo());
            aok.GetPatienten();
            Console.WriteLine(ibtz.GetInfo());
            ibtz.GetPatienten();


            Console.ReadLine();
            Console.Clear();

            tomas.SetKrankenKasse(aok);
            martin.SetKrankenKasse(aok);
            pica.SetKrankenKasse(aok);

            Console.WriteLine("------------- KassePatienten Gemischt");
            Console.WriteLine(tw.GetInfo());
            tw.GetPatienten();
            Console.WriteLine(aok.GetInfo());
            aok.GetPatienten();
            Console.WriteLine(ibtz.GetInfo());
            ibtz.GetPatienten();


            Console.ReadLine();
            Console.Clear();
            tomas.SetKrankenKasse(tw);
            martin.SetKrankenKasse(tw);
            pica.SetKrankenKasse(aok);

            Console.WriteLine("------------- KassePatienten Gemischt 2");
            Console.WriteLine(tw.GetInfo());
            tw.GetPatienten();
            Console.WriteLine(aok.GetInfo());
            aok.GetPatienten();
            Console.WriteLine(ibtz.GetInfo());
            ibtz.GetPatienten();

            Console.ReadLine();
            Console.Clear();
        }
    }
}
