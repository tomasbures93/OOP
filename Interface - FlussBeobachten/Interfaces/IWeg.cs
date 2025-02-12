using Interface___FlussBeobachten.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface___FlussBeobachten.Interfaces
{
    internal interface IWeg
    {
        double maxWasserStand { get; set; }

        bool offen {  get; set; }

        void beobachten(Fluss fluss);
    }
}
