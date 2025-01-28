using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen___Personen_aus_datei_Lesen.Module;

namespace Klassen___Personen_aus_datei_Lesen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Daten werden eingelesen\n");
            // datei Lesen
            string pfad = @"C:\Users\ITA7-TN01\Desktop\Personen.txt";
            FileStream stream = new FileStream(pfad, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(stream);
            string output = sr.ReadToEnd();         
            sr.Close();

            // daten speichern in Array-Person 
            string[] split = output.Split('\n');            
            Person[] person = new Person[split.Length];     
            int counter = 0;
            foreach (string line in split)

            {
                Console.WriteLine(line);                    
                string[] teilen = line.Split(':');
                person[counter] = new Person(Convert.ToDateTime(teilen[1]), teilen[0]);    
                counter++;
            }

            //person[1].GetInfo();      Test Zwecken

            //daten augeben     aus array
            Console.WriteLine("\n-- Daten bearbeitet");
            int gesamteAlter = 0;
            Console.WriteLine("\nName\t\tGeboren\t\t\tAlter\n");
            foreach(Person mensch in person)
            {
                Console.WriteLine($"{mensch.GetName()}\t\t{mensch.GetDatum()} \t\t{mensch.GetAge()}");
                gesamteAlter += mensch.GetAge();
            }
            Console.WriteLine($"\nGesamtalter : {gesamteAlter} Jahre | Durchsnittliche Alter : {gesamteAlter / split.Length} Jahre");

            Console.ReadKey();
        }
    }
}
