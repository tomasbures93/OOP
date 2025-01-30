using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen___Warteschlange_2.models;

namespace Klassen___Warteschlange_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedQueue queue = new MyLinkedQueue();

            queue.Enqueue("Alice");
            queue.Enqueue("Bob");
            queue.Enqueue("Charlie");

            Console.WriteLine("Warteschlange:");
            queue.Print();

            Console.WriteLine("Entfernt: " + queue.Dequeue());
            Console.WriteLine("Neue Warteschlange:");
            queue.Print();
            queue.Enqueue("Lofas");
            queue.Print();
        }
    }
}
