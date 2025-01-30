using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Warteschlange_2.models
{
    internal class MyLinkedQueue
    {
        private Entry head;
        private Entry tail;

        public MyLinkedQueue()
        {
            head = null;
            tail = null;
        }

        // Prüft, ob die Warteschlange leer ist
        public bool IsEmpty()
        {
            return head == null;
        }

        // Fügt ein Element am Ende der Warteschlange hinzu
        public void Enqueue(string data)
        {
            Entry newEntry = new Entry(data);
            if (IsEmpty())
            {
                head = newEntry;
                tail = newEntry;
            }
            else
            {
                tail.SetNext(newEntry);
                tail = newEntry;
            }
        }

        // Entfernt das erste Element und gibt seinen Wert zurück
        public string Dequeue()
        {
            if (IsEmpty())
            {
                return null;
            }
            string data = head.GetData();
            head = head.GetNext();
            if (head == null) // Falls die Warteschlange leer wird
            {
                tail = null;
            }
            return data;
        }

        // Gibt alle Elemente der Warteschlange aus
        public void Print()
        {
            Entry current = head;
            while (current != null)
            {
                Console.WriteLine(current.GetData());
                current = current.GetNext();
            }
        }
    }
}
