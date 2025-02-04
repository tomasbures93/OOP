using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Auto_Pickup.Models
{
    public class Pickup : Auto
    {
        private int _ladungsMenge;

        public Pickup() : base("DO-OM 3", 0, false, 2)
        {
            _ladungsMenge = 0;
        }

        public Pickup(string kennzeichen, int kmstand, bool antene, int sitzplatze = 2, int ladungsMenge = 0) : base(kennzeichen, kmstand, antene, sitzplatze)
        {
            _ladungsMenge = ladungsMenge;
        }

        public bool Beladen(int ladungsMenge) {
            if (ladungsMenge <= _ladungsMenge)
            {
                _ladungsMenge += ladungsMenge;
                Console.WriteLine($"{ladungsMenge} dinge. Es passt noch!");
                return true;
            }
            else
            {
                Console.WriteLine("Es passt nicht mehr!");
                return false;
            }
        }

        public bool Entladen(int ladungsMenge) { 
            if(ladungsMenge <= _ladungsMenge)
            {
                Console.WriteLine($"Du hast {ladungsMenge} dinge entladen");
                _ladungsMenge -= ladungsMenge;
                return true;
            } else
            {
                Console.WriteLine($"So viel sachen hast du da nicht");
                return false;
            }
        }

        public override void VorDemWaschen()
        {
            AntenneAusfahren();
            Entladen(_ladungsMenge);
            Console.WriteLine("Pickup bereit für waschstrasse");
        }

        public int GetLadung()
        {
            return _ladungsMenge;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nDinge auf ladungsflacher: {GetLadung()}";
        }

    }
}
