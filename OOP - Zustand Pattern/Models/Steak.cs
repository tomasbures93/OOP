using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Zustand_Pattern.Models
{
    public class Steak
    {
        private Doneness state;
        private string cut;

        public Steak(string cut)
        {
            this.cut = cut;
            state = new Rare(0.0, this);
        }

        public double CurrentTemperature
        {
            get { return state.CurrentTemperature; }
        }

        public Doneness State
        {
            get { return state; }
            set { state = value; }
        }

        public void IncreaseTemperature(double degrees)
        {
            state.IncreaseTemperature(degrees);
            Console.WriteLine($"Increased degrees by {degrees} degrees");
            Console.WriteLine($"    Current degrees is {CurrentTemperature}");
            Console.WriteLine($"    Doneness is {State.GetType().Name}");
            Console.WriteLine("");
        }

        public void DecreaseTemperature(double degrees)
        {
            state.DecreaseTemperature(degrees);
            Console.WriteLine($"Decreased degrees by {degrees} degrees");
            Console.WriteLine($"    Current degrees is {CurrentTemperature}");
            Console.WriteLine($"    Doneness is {State.GetType().Name}");
            Console.WriteLine("");
        }
    }
}
