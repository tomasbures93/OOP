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
        public void NeuePaket(Adresse absender, Adresse empfanger, double gewicht, bool versicherung, bool tracking)
        {
            if(tracking == true)
            {
                postsendungen.Add(new VervolgungsPaket(absender, empfanger, gewicht, versicherung));
            } else
            {
                postsendungen.Add(new Paket(absender, empfanger, gewicht, versicherung));
            }

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
            Console.WriteLine("\t\tHitman service - SOON");
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

        public int GetLastID()
        {
            int ID = 0;
            foreach (Postsendung post in postsendungen)
            {
                ID = post.GetID();
            }
            return ID;
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
            Console.WriteLine($"\n\t------------------- \"{_name}\" - Packstation Info - Packages ---------------------");
            foreach (Postsendung post in postsendungen)
            {
                if (post is Paket)
                {
                    Console.WriteLine(post.ToString());
                }
            }
            Console.WriteLine($"\n\t---------------------------------------------------------------------");
        }
        public void PaketVerfolgung(int id)
        {
            foreach (Postsendung post in postsendungen)
            {
                if (post.GetID() == id)
                {
                    Console.WriteLine(post.ToString());
                }
            }
        }

        public void PackstationVerPaketInfo()
        {
            Console.WriteLine($"\n\t------------------- \"{_name}\" - Packstation Info - Packages with Tracking ---------------------");
            foreach (Postsendung post in postsendungen)
            {
                if (post is VervolgungsPaket)
                {
                    Console.WriteLine($"\tID: {post.GetID()}");
                }
            }
            Console.WriteLine($"\n\t---------------------------------------------------------------------");
        }

        public void MovePackage(int id, string ort)
        {
            foreach (Postsendung post in postsendungen)
            {
                if (post is VervolgungsPaket paket && post.GetID() == id)
                {
                    paket.SetzeStation(ort);
                }
            }
        }

        public int GetOccupancy()
        {
            return postsendungen.Count;
        }

        public void Ausliefern()
        {
            Console.WriteLine("\n\tMail service checking system\n");

            foreach (Postsendung post in postsendungen)
            {
                if(post.GetAbsender().IsGultig() && post.GetEmpfanger().IsGultig())
                {
                    if(post.GetID() >= 1000 && post.GetID() <= 4999)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\tLetter ID {post.GetID()} has been send. Adresses are OK.");
                        Console.ForegroundColor = ConsoleColor.White;
                    } 
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\tPackage ID {post.GetID()} has been send. Adresses are OK.");
                        Console.ForegroundColor = ConsoleColor.White;
                        if(post is VervolgungsPaket paket)
                        {
                            string adress = post.GetEmpfanger().ToSmallString();
                            paket.SetzeStation(adress);
                        }
                    }
                    post.SetAuslieferung();
                }
                else
                {
                    if (post.GetID() >= 1000 && post.GetID() <= 4999)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\tLetter ID {post.GetID()} has not been send! Adresse is not OK");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\tPackage ID {post.GetID()} has not been send. Adresse is not okay");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
        }
    }
}
