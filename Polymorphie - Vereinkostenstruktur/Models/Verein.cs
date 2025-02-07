using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Polymorphie___Vereinkostenstruktur.Models
{
    internal class Verein : Mitglied
    {
        private int _maxanzahl;
        private List<Mitglied> mitglieds = new List<Mitglied>();
        private int anzahlmitglieder = 0;
        public Verein(string name, int maxanzahl) : base(name)
        {
            _maxanzahl = maxanzahl;
        }
        public override double GetEinnahmen()
        {
            double zwischen = 0;
            foreach (Mitglied mitglied in mitglieds) {
                zwischen = zwischen + mitglied.GetEinnahmen();
            }
            return zwischen;
        }

        public override double GetAusgaben()
        {
            double zwischen = 0;
            foreach (Mitglied mitglied in mitglieds)
            {
                zwischen = zwischen + mitglied.GetAusgaben();
            }
            return zwischen;
        }

        public int GesamtMitglieder()
        {
            int summe = 0;
            foreach (var mitglied in mitglieds)
            {
                if (mitglied is Verein unterVerein)
                {
                    summe += unterVerein.GesamtMitglieder();
                }
                else
                {
                    summe++;
                }
            }
            return summe;
        }
        public void MitgliedHinzufugen(Mitglied mitglied)
        {
            int neueMitglieder = 1;

            if (mitglied is Verein unterVerein)
            {
                neueMitglieder = unterVerein.GesamtMitglieder();
            }

            if (anzahlmitglieder + neueMitglieder <= _maxanzahl)
            {
                mitglieds.Add(mitglied);
                anzahlmitglieder += neueMitglieder;
            }
            else
            {
                Console.WriteLine($"\n{GetName()} ist voll. {mitglied.GetName()} sollte einen anderen Verein versuchen.");
            }
        }

        public override double GetUberschuss()
        {
            return GetAusgaben() - GetEinnahmen();
        }

        public override void Ausgabe()
        {
            Console.WriteLine($"\nMitglied liste von : {this.GetName()} | Mitglieds: {anzahlmitglieder}/{_maxanzahl}\n");
            Console.WriteLine($"-----------------------------------------------------------------------------------------------------------------------------------------------------------------");
            foreach (Mitglied mitglied in mitglieds)
            {
                Console.WriteLine($"| Position: {mitglied.GetType().Name,28} | Name: {mitglied.GetName(),12} | Nummer: {mitglied.GetMitgliedsnummer(),3}| Einnahme pro Jahr: {mitglied.GetEinnahmen(),6} | Ausgabe pro Jahr: {mitglied.GetAusgaben(),6} | Überschuss pro Jahr: {mitglied.GetUberschuss(),6} |");
            }
            Console.WriteLine($"-----------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"\nEinnahmen pro Jahr: {this.GetEinnahmen()} Euro");
            Console.WriteLine($"Ausgaben pro Jahr: {this.GetAusgaben()} Euro");
            Console.WriteLine($"Uberschuss pro Jahr: {this.GetUberschuss()} Euro");
        }
    }
}
