using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakte_Klassen.Models
{
    internal abstract class Object
    {
        public abstract double Flache();

        public abstract double Umfang();

        public abstract string PrintInfo();
    }
}
