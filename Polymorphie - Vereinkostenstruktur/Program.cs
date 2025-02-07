using Polymorphie___Vereinkostenstruktur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Vereinkostenstruktur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mitglied Pepa = new UnterstutzendesMitglied("Pepa");
            Mitglied Koko = new UnterstutzendesMitglied("Koko");
            Mitglied Jozin = new SpitzenSportler("Jozin", 1);
            Mitglied Rado = new SpitzenSportler("Rado", 2);
            Mitglied Tomas = new SpitzenSportler("Tomas", 10);
            Mitglied Hagen = new SpitzenSportler("Hagen", 9);
            Mitglied Balam = new Amateure("Balam", 2);
            Mitglied Salam = new Amateure("Salam", 3);
            Mitglied Matrix = new Trainer("Matrix", 8);
            Mitglied Sindwirvoll = new SpitzenSportler("Dumm", 1);
            Mitglied zmrd = new Vorstandsmitglied("Stay zmrd", 10);
            Verein Bochum = new Verein("FC Bochum", 10);

            Mitglied Homo = new Trainer("#NoHomo", 1);
            Mitglied Pepa2 = new UnterstutzendesMitglied("Pepa2");
            Mitglied Koko2 = new UnterstutzendesMitglied("Koko2");
            Mitglied Pepa3 = new UnterstutzendesMitglied("Pepa3");
            Mitglied Koko3 = new UnterstutzendesMitglied("Koko3");
            Mitglied Pepa4 = new UnterstutzendesMitglied("Pepa4");
            Mitglied Koko4 = new UnterstutzendesMitglied("Koko4");
            Verein Demence = new Verein("FC Demence", 16);

            Verein Oberverein = new Verein("Mega verein", 20);

            Console.WriteLine("Verein und mitglied system\n");

            Console.WriteLine("\n Under construction ....");
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            Console.Clear();
            Bochum.MitgliedHinzufugen(Pepa);
            Bochum.MitgliedHinzufugen(Koko);
            Bochum.MitgliedHinzufugen(Jozin);
            Bochum.MitgliedHinzufugen(Rado);
            Bochum.MitgliedHinzufugen(Balam);
            Bochum.MitgliedHinzufugen(Salam);
            Bochum.MitgliedHinzufugen(Matrix);
            Bochum.MitgliedHinzufugen(zmrd);
            Bochum.MitgliedHinzufugen(Tomas);
            Bochum.MitgliedHinzufugen(Hagen);
            Bochum.MitgliedHinzufugen(Sindwirvoll);

            Bochum.Ausgabe();

            Demence.MitgliedHinzufugen(Sindwirvoll);
            Demence.MitgliedHinzufugen(Homo);
            Demence.MitgliedHinzufugen(Pepa2);
            Demence.MitgliedHinzufugen(Pepa3);
            Demence.MitgliedHinzufugen(Pepa4);
            Demence.MitgliedHinzufugen(Koko2);
            Demence.MitgliedHinzufugen(Koko3);
            Demence.MitgliedHinzufugen(Koko4);
            Demence.Ausgabe();

            Oberverein.MitgliedHinzufugen(Demence);
            Oberverein.MitgliedHinzufugen(Bochum);
            Oberverein.Ausgabe();

            Console.ReadKey();
        }
    }
}
