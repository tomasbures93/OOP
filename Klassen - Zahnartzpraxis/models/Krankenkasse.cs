using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Zahnartzpraxis.models
{
    internal class Krankenkasse
    {
        private int _kassennummer;
        private string _kassenname;
        private string[] _patient;

        public Krankenkasse(int kassennummer, string kassenname)
        {
            _kassennummer = kassennummer;
            _kassenname = kassenname;
            _patient = new string[10];
        }

        public string GetInfo() 
        {
            int counter = 0;
            foreach (string person in _patient)
            {
                if (!string.IsNullOrEmpty(person))
                {
                    counter++;
                }
            }
            return $"KasseNummer: {_kassennummer} | KasseName: {_kassenname} | Patienten: {counter}/10\n";               
        }

        public void RemovePatient(Person person)            // ganze klasse übergenen aber nur ein teil benutzt = Association
        {
            for (int i = 0; i < _patient.Length; i++)
            {
                if (person.GetName() == _patient[i])
                {
                    _patient[i] = "";
                    break;
                }
            }
        }

        public void AddPatient(Person person)
        {
            for (int i = 0; i < _patient.Length; i++)
            {
                if (string.IsNullOrEmpty(_patient[i]))
                {
                    _patient[i] = person.GetName();
                    break;
                } else
                {
                    continue;
                }
            }
        }

        public void GetPatienten()
        {
            Console.WriteLine($"Patienten von {_kassenname}");
            foreach (string person in _patient)
            {
                if (string.IsNullOrEmpty(person))
                {
                    continue;
                 
                } else
                {
                    Console.WriteLine($"{person}");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
