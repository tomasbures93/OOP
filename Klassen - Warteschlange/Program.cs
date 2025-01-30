using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen___Warteschlange.models;

namespace Klassen___Warteschlange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Entry> schlange = new List<Entry>();
            bool getout = false;
            MyLinkedQueue myqueue = new MyLinkedQueue();
            do
            {
                Console.WriteLine("Bitte satz ein eingeben");
                string input = Console.ReadLine();
                if(schlange.Count() == 0)
                {
                    schlange.Add(new Entry(input));
                    myqueue.SetHead(new Entry(input));
                } else
                {
                    schlange[schlange.Count() - 1].SetNext(new Entry(input));
                    schlange.Add(new Entry(input));
                    myqueue.SetTail(new Entry(input));
                }
                Console.WriteLine("Wollen sie mehr hinzufügen? ( j / n )");
                string wantOut = Console.ReadLine().ToLower();
                switch (wantOut[0])
                {
                    case 'j':
                        break;
                    default:
                        getout = true;
                        break;
                }
            } while (getout == false);

            Console.WriteLine("\n\n");

            // keine hinzufügen
            Console.WriteLine("Nur liste auslesen");
            foreach (Entry entry in schlange)
            {
                Console.WriteLine(entry.GetInfo());
            }
            Console.WriteLine(myqueue.GetFirstAndLast());

            Console.WriteLine("\n\n");
            Console.WriteLine("\nPlus ein etwas");
            string text = "johoho";
            string added = myqueue.Enqueue(text);
            Console.WriteLine(added);
            schlange[schlange.Count() - 1].SetNext(new Entry(text));
            schlange.Add(new Entry(text));
            foreach (Entry entry in schlange)
            {
                Console.WriteLine(entry.GetInfo());
            }
            Console.WriteLine(myqueue.GetFirstAndLast());
            //
            Console.WriteLine("\n\n");

            Console.WriteLine("\nMinus erste");
            string delete = myqueue.Dequeue(schlange);
            Console.WriteLine(delete);
            schlange.Remove(schlange[0]);
            foreach (Entry entry in schlange)
            {
                Console.WriteLine(entry.GetInfo());
            }

            Console.WriteLine(myqueue.GetFirstAndLast());

            Console.ReadKey();
        }
    }
}
