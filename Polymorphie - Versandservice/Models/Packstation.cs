using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Versandservice.Models
{
    internal class Packstation
    {
        protected List<Postsendung> postsendungen = new List<Postsendung>();
        private string _name;

        public Packstation(string name = "Unknown Packstation") {
            _name = name;
        }

        public void NeueBrief(Adresse absender, Adresse Empfanger, BriefTyp typ = BriefTyp.Standartbrief)
        {
            postsendungen.Add(new Brief(absender, Empfanger, typ));
        }

        public void NeuePaket(Adresse absender, Adresse empfanger, double gewicht, bool versicherung)
        {
            postsendungen.Add(new Paket(absender, empfanger, gewicht, versicherung));
        }

        public string GetName()
        {
            return _name;
        }

        public void PackstationPublicInfo()
        {
            Console.WriteLine($"\tPackstation Name: {_name}");
            Console.WriteLine("\tOpen: 24/7!");
            Console.WriteLine("\tWe ship worldwide.");
            Console.WriteLine("\tWe are offering: ");
            Console.WriteLine("\t\t3 types of Letters.");
            Console.WriteLine("\t\tUnlimited weight pro Package.");
            Console.WriteLine("\t\tHitman service.");
        }

        public void PackstationPrivateInfo()
        {
            Console.WriteLine($"\n\t----------------------- \"{_name}\" - Packstation Info ------------------------");
            foreach (Postsendung post in postsendungen)
            {
                Console.WriteLine(post.SmallInfo());
            }
            Console.WriteLine($"\n\t---------------------------------------------------------------------");
        }

        public void PackstationBriefInfo()
        {
            Console.WriteLine($"\n\t------------------- \"{_name}\" - Packstation Info - Letters ---------------------");
            foreach (Postsendung post in postsendungen)
            {
                if(post is Brief)
                {
                    Console.WriteLine(post.ToString());
                }
            }
            Console.WriteLine($"\n\t---------------------------------------------------------------------");
        }

        public void PackstationPaketInfo()
        {
            Console.WriteLine($"\n\t------------------- \"{_name}\" - Packstation Info - Letters ---------------------");
            foreach (Postsendung post in postsendungen)
            {
                if (post is Paket)
                {
                    Console.WriteLine(post.ToString());
                }
            }
            Console.WriteLine($"\n\t---------------------------------------------------------------------");
        }

        public int GetOccupancy()
        {
            return postsendungen.Count;
        }

        public void Ausliefern()
        {
            // TO DO
            foreach (Postsendung post in postsendungen)
            {
                Console.WriteLine(post.GetAbsender().IsGultig());
                Console.WriteLine(post.GetEmpfanger().IsGultig());
                if(post.GetAbsender().IsGultig() && post.GetEmpfanger().IsGultig())
                {
                    Console.WriteLine($"Sendung: ");
                    post.SetAuslieferung();
                }
                else
                {
                    Console.WriteLine("Nein");
                }
            }
        }
    }
}
