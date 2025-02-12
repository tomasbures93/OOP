using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP___StarWars.Models;

namespace OOP___StarWars
{
    internal class Program
    {
        static List<Rebelen> rebelen = new List<Rebelen>();
        static List<Imperial> imperial = new List<Imperial>();
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tGenerating .....");
            NewFlottile(6);
            Console.Clear();
            //ShiffeLesen();
            Console.WriteLine("\n\tPress Enter to Start a fight....");
            Console.ReadKey();
            StartFight();
        }

        static void StartFight()
        {
            Rebelen shiff;
            Imperial shiff2;
            int position1 = 0, position2 = 0;
            int lange = rebelen.Count;
            shiff = rebelen[position1];
            shiff2 = imperial[position2];
            do
            {
                if(shiff.Hulle + shiff.Shielde > 0)
                {
                    shiff.Fire(shiff2);
                } else
                {
                    position1++;
                    shiff = rebelen[position1];
                }
                if (shiff2.Hulle > 0)
                {
                    shiff2.Fire(shiff);
                }
                else
                {
                    position2++;
                    shiff2 = imperial[position2];
                }
                Console.ReadKey();
            } while (true);
            
        }

        static void NewFlottile(int menge)
        {
            Random rnd = new Random();
            for (int i = 0; i < menge; i++)
            {
                int random = rnd.Next(0, 3);
                if (Enum.IsDefined(typeof(ShifftypR), random))
                {
                    rebelen.Add(new Rebelen((ShifftypR)random));
                }
                random = rnd.Next(0, 3);
                if (Enum.IsDefined(typeof(ShifftypI), random))
                {
                    imperial.Add(new Imperial((ShifftypI)random));
                }
                Task.Delay(1000).Wait();
            }
        }

        static void ShiffeLesen()
        {
            Console.WriteLine("\n\t Rebels");
            foreach (Rebelen rebelen_ in rebelen)
            {
                Console.WriteLine(rebelen_.ToString());
            }
            Console.WriteLine("\n\t Dark Side");
            foreach (Imperial imperial_ in imperial)
            {
                Console.WriteLine(imperial_.ToString());
            }
        }
    }
}
