using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Versandservice.Models
{
    internal class Station
    {
        private string _ort;
        private DateTime _date;

        public Station(string ort)
        {
            _ort = ort;
            _date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{_ort} | {_date}";
        }
    }
}
