using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Zustand_Pattern.Models
{
    public class Well : Doneness
    {
        public Well(Doneness state) : this(state.CurrentTemperature, state.Steak) { }

        public Well(double currentTemperature, Steak steak)
        {
            this.currentTemperature = currentTemperature;
            this.steak = steak;
            isSafe = true;

            lowerTemperature = 62.9;
            upperTemperature = 68.3;
        }

        public override void DecreaseTemperature(double degrees)
        {
            currentTemperature -= degrees;
            DonenessCheck();
        }

        public override void DonenessCheck()
        {
            if (currentTemperature < lowerTemperature)
                steak.State = new Medium(this);

            if (currentTemperature > upperTemperature)
                steak.State = new WellDone(this);
        }

        public override void IncreaseTemperature(double degrees)
        {
            currentTemperature += degrees;
            DonenessCheck();
        }
    }
}
