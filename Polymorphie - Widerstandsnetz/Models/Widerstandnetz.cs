using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Widerstandsnetz.Models
{
    public abstract class Widerstandsnetz : Widerstand
    {
        protected List<Widerstand> widerstände;

        public Widerstandsnetz(params Widerstand[] widerstände)
        {
            this.widerstände = widerstände.ToList();
        }

        public abstract double BerechneWiderstand();

        public override string ToString()
        {
            string namen = string.Join(",", widerstände.Select(w => w.GetName()));
            return $"{this.GetType().Name}: {namen}";
        }
    }
}
