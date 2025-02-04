using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Auto_Pickup.Models
{
    public class Auto
    {
        private string _kennzeichen;
        private int _kmstand;
        private int _sitzplatze;
        private bool _antene;   // false = antene ist eingefahren

        public Auto(string kennzeichen = "DO-OM 3", int kmstand = 0, bool antene = false, int sitzplatze = 5)
        {
            _kennzeichen = kennzeichen;
            _kmstand = kmstand;
            _sitzplatze = sitzplatze;
            _antene = antene;
        }

        public string GetKennzeichen()
        {
            return _kennzeichen;
        }

        public int GetKMstand()
        {
            return _kmstand;
        }

        public void Fahre(int km)
        {
            _kmstand += km;
        }

        public void AntenneEinfahren()
        {
            if(_antene == true)
            {
                _antene = false;
            }
        }

        public void AntenneAusfahren()
        {
            if (_antene == false)
            {
                _antene = true;
            }
        }

        public bool IsAntenneDrausen()
        {
            if(_antene == true)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public virtual void VorDemWaschen()
        {
            if (IsAntenneDrausen())
            {
                AntenneAusfahren();
                Console.WriteLine("Antene war drassen aber ich habe die reingefahren");
            }
            Console.WriteLine("Wagen darf in Waschstrasse");
        }

        public void Waschen()
        {
            VorDemWaschen();
            Console.WriteLine("Wagen wurde gewascht!");
        }

        public int GetSitzplätze()
        {
            return _sitzplatze;
        }

        public override string ToString()                       // ToString() methode gibst es schon ... wir überschreiben die nur! Darum auch hier override und nicht virtual
        {
            return $"Kennzeichen: {GetKennzeichen()}\n" +
                $"KM-Stand: {GetKMstand()}\n" +
                $"Sitz-Platze: {GetSitzplätze()}";
        }
    }
}
