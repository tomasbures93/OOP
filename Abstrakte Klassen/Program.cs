using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstrakte_Klassen.Models;

namespace Abstrakte_Klassen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rechteck rechteck = new Rechteck(2, 3);
            Kreis kreis = new Kreis(4);
            Quadrat quadrat = new Quadrat(5);
            Ellipse Ellipse = new Ellipse(6, 7);

            List<double> umfang = new List<double>();
            List<double> Flache = new List<double>();

            umfang.Add(rechteck.Umfang());
            umfang.Add(kreis.Umfang());
            umfang.Add(quadrat.Umfang());
            umfang.Add(Ellipse.Umfang());

            Flache.Add(rechteck.Flache());
            Flache.Add(kreis.Flache());
            Flache.Add(quadrat.Flache());
            Flache.Add(Ellipse.Flache());

            Console.WriteLine("\tAbstrakte Klassen\n");
            Console.WriteLine($"\tRechteck ( {rechteck.PrintInfo()} ) cm\n\tUmfang: {rechteck.Umfang(),2} cm\n\tFlache: {rechteck.Flache(),2} cm2\n");
            Console.WriteLine($"\tQuadrat ( {quadrat.PrintInfo()} ) cm\n\tUmfang: {quadrat.Umfang(),2} cm\n\tFlache: {quadrat.Flache(),2} cm2\n");
            Console.WriteLine($"\tKreis ( {kreis.PrintInfo()} ) cm\n\tUmfang: {kreis.Umfang():F2} cm\n\tFlache: {kreis.Flache():F2} cm2\n");
            Console.WriteLine($"\tEllipse ( {Ellipse.PrintInfo()} ) cm\n\tUmfang: {Ellipse.Umfang():F2} cm\n\tFlache: {Ellipse.Flache():F2} cm2");

            Console.WriteLine("\n\n Umfang Nich sortiert");
            foreach( double v in umfang)
            {
                Console.WriteLine(v);
            }

            Sort(umfang);

            Console.WriteLine("\n\n Umfang sortiert");
            foreach (double v in umfang)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\n\n Flache Nich sortiert");
            foreach (double v in Flache)
            {
                Console.WriteLine(v);
            }

            Sort(Flache);

            Console.WriteLine("\n\n Flache sortiert");
            foreach (double v in Flache)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }

        public static void Sort(List<double> umfang)
        {
            for(int i = 0; i < umfang.Count - 1; i++)
            {
                for(int j = 0; j < umfang.Count - i -1; j++)
                {
                    if (umfang[j] > umfang[j + 1])
                    {
                        double temp = umfang[j];
                        umfang[j] = umfang[j + 1];
                        umfang[j + 1] = temp;
                    }
                }
            }

        }
    }
}
