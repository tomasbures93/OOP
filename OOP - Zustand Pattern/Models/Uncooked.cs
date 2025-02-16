using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Zustand_Pattern.Models
{
    public class Uncooked : Doneness
    {
        public Uncooked(Doneness state)
        {
            currentTemperature = state.CurrentTemperature;
            steak = state.Steak;

            lowerTemperature = 0;
            upperTemperature = 48.9;
            isSafe = false;
        }

        public override void DecreaseTemperature(double degrees)
        {
            currentTemperature -= degrees;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemperature > upperTemperature)
                steak.State = new Rare(this);
        }

        public override void IncreaseTemperature(double degrees)
        {
            currentTemperature += degrees;
            DonenessCheck();
        }
    }
}
