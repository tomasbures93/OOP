using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Warteschlange.models
{
    internal class Entry
    {
        private string _name;
        private Entry _entry;

        public Entry()
        {

        }

        public Entry(string name)
        {
            _name = name;
            _entry = null;
        }

        public Entry(string name, Entry entry)
        {
            _name = name;
            _entry = entry;
        }

        public void SetNext(Entry entry)
        {
            _entry = entry;
        }

        public string GetName()
        {
            return _name;
        }

        public Entry GetNext()
        {
            return _entry;
        }

        public string GetInfo()
        {
            if(_entry == null)
            {
                return $"Data: {_name} | Next: ----";
            } else
            {
                return $"Data: {_name} | Next: {_entry.GetName()}";
            }
        }
    }
}
