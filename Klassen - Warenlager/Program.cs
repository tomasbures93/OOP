using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Klassen___Warenlager.models;

namespace Klassen___Warenlager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Loading warehouse --");
            
            // datei laden
            string pfad = @"C:\Users\ITA7-TN01\Desktop\warehouse.txt";
            FileStream stream = new FileStream(pfad, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(stream);
            string datei = sr.ReadToEnd();
            sr.Close();

            // werte separieren und speichern
            List<string> list = new List<string>();
            string[] array = datei.Split('\n');
            foreach(string str in array)
            {
                list.Add(str);
            }

            // verteilen
            List<Artikel> artikels = new List<Artikel>();
            List<Lager> lager = new List<Lager>();
            List<Dailystats> stats = new List<Dailystats>();
            for(int i = 0; i < list.Count; i++) {
                string[] text = list[i].Split(':');
                artikels.Add(new Artikel(int.Parse(text[0]), text[1], double.Parse(text[4]), int.Parse(text[3])));
                lager.Add(new Lager(artikels[i], int.Parse(text[2]), int.Parse(text[6])));
                stats.Add(new Dailystats(artikels[i], int.Parse(text[5])));
            }

            // Alles anzeigen
            Console.WriteLine("Artikel-nummer | Bezeichnung | Preis pro Stück |   Bestand | Heute Verkauft | Bestelldauer | Bestellvorgang");
            for(int i = 0;i < artikels.Count; i++)
            {
                Console.WriteLine($"{artikels[i].GetCompleteInfo(lager[i], stats[i])} | {lager[i].SollIchBestellen(stats[i]),-15}");
            }

            // Lagerwert berechnen
            double wert = 0;
            for (int i = 0; i < lager.Count; i++)
            {
                wert = wert + lager[i].GetLagerWert();
            }
            Console.WriteLine($"\nGesamte Lagerwert: {wert} Euro");

            Console.ReadKey();

            Console.WriteLine($"\nWelche artikel möchten sie sehen ( 1 - {artikels.Count} )");
            int showArtikel = int.Parse( Console.ReadLine() );
            Console.WriteLine("Artikel-nummer | Bezeichnung | Preis pro Stück |   Bestand | Heute Verkauft | Bestelldauer | Bestellvorgang");
            Console.WriteLine($"{artikels[showArtikel - 1].GetCompleteInfo(lager[showArtikel - 1], stats[showArtikel - 1])} | {lager[showArtikel - 1].SollIchBestellen(stats[showArtikel - 1]),-15}");

            Console.ReadKey();
        
        }
    }
}
