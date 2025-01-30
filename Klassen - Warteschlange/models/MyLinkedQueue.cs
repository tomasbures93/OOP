using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Warteschlange.models
{
    internal class MyLinkedQueue
    {
        private Entry _head;
        private Entry _tail;

        public MyLinkedQueue() {
            _head = null;
            _tail = null;
        }

        public MyLinkedQueue(Entry head)
        {
            _head = head;
        }

        public MyLinkedQueue(Entry head, Entry tail)
        {
            _head = head;
            _tail = tail;
        }
        public void SetHead(Entry entry)
        {
            _head = entry;
        }

        public void SetTail(Entry entry)
        {
            _tail = entry;
        }

        public bool IsEmpty()
        {
            if (_head == null && _tail == null)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public string Enqueue(string input)
        {
            _tail = new Entry(input);
            return $"Added: {input}";
        }

        public string Dequeue(List<Entry> schlange)
        {
            string output = _head.GetName();
            _head = schlange[1];
            return $"Deleted:  {output}";
        }

        public string GetFirstAndLast()
        {
            string output = "";
            if (_head == null || _tail == null)
            {
                if (_head != null)
                    output = output + $"{_head.GetName()}";
                else if (_tail != null)
                    output = output + $"{_tail.GetName()}";
                return output;
            }
            else
            {
                return $"First: {_head.GetName()} | Last: {_tail.GetName()}";
            }
        }
    }
}
