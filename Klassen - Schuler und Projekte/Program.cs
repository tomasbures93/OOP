using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen___Schuler_und_Projekte.models;
using System.IO;

namespace Klassen___Schuler_und_Projekte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nicht ferig

            string pfadSchuler = @"C:\Users\ITA7-TN01\Desktop\Schuler.txt";
            string pfadProjekte = @"C:\Users\ITA7-TN01\Desktop\Projekte.txt";

            Console.WriteLine("-- Loading Schuler.txt --");
            FileStream stream = new FileStream(pfadSchuler, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(stream);
            string inhalt = sr.ReadToEnd();
            sr.Close();

            // daten bearbeiten
            List<Schuler> listSchuler = new List<Schuler>();
            string[] split = inhalt.Split('\n');
            foreach (string line in split)
            {
                string[] trennen = line.Split(':');
                listSchuler.Add(new Schuler(int.Parse(trennen[0]), trennen[1]));
            }

            foreach (Schuler schuler in listSchuler)
            {
                Console.WriteLine($"{schuler.GetInfo()}");
            }


            Console.WriteLine("\n");

            Console.WriteLine("-- Loading Projekte.txt --");
            stream = new FileStream(pfadProjekte, FileMode.Open, FileAccess.Read);
            sr = new StreamReader(stream);
            inhalt = sr.ReadToEnd();
            sr.Close();

            // daten bearbeiten
            List<Projekt> listProjekte = new List<Projekt>();
            split = inhalt.Split('\n');
            foreach (string line in split)
            {
                string[] trennen = line.Split(':');
                string schuler = trennen[2];
                string[] beteiligte = schuler.Split(',');
                List<Schuler> list = new List<Schuler>();
                for (int i = 0; i < beteiligte.Length; i++)
                {
                    int id = int.Parse(beteiligte[i]);
                    list.Add(new Schuler(id, listSchuler[id - 1].GetName()));
                    listSchuler[id - 1].AddProjekt(new Projekt(trennen[0], trennen[1]));

                }
                listProjekte.Add(new Projekt(trennen[0], trennen[1], list));
            }

            //Projekt Liste 
            foreach (Projekt projekte in listProjekte)
            {
                Console.WriteLine($"{projekte.GetInfo()}");
            }


            Console.WriteLine("\n");
            // beste Projekt
            Projekt beste = Projekt.GetBesteProject(listProjekte);
            Console.WriteLine("Beste Project -");
            Console.WriteLine(beste.GetInfo());
            Console.WriteLine("Project beteiligte -");
            Console.WriteLine(beste.GetProjectBeteiligte());

            Console.WriteLine("\n");
            Console.WriteLine("Leute und Projekte -");
            foreach (Schuler schuler1 in listSchuler)
            {
                string verkettung = schuler1.GetName();
                Console.WriteLine("\nName: " + verkettung);
                Console.Write(" | Projekte: " + schuler1.GetProjekteVonSchuler() + "\n"); 
            }

            Console.ReadKey();
        }
    }
}
