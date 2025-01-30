using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Warteschlange_2.models
{
    internal class Entry
    {
        private string data;
        private Entry next;

        public Entry(string data)
        {
            this.data = data;
            this.next = null;
        }

        public string GetData()
        {
            return data;
        }

        public void SetData(string data)
        {
            this.data = data;
        }

        public Entry GetNext()
        {
            return next;
        }

        public void SetNext(Entry next)
        {
            this.next = next;
        }
    }
}
