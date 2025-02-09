using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Versandservice.Models
{
    internal class Paket : Postsendung
    {
        private double _gewicht;
        private bool _versichert;
        private static int _idNext = 5000;
        private int _id;

        public Paket(Adresse absender, Adresse empfanger, double gewicht, bool versichert) : base(absender, empfanger)
        {
            _id = _idNext;
            _idNext++;
            _gewicht = gewicht;
            _versichert = versichert;
        }
        public int GetID()
        {
            return _id;
        }

        public bool IsVersichert()
        {
            return _versichert;
        }

        public double GetGewicht()
        {
            return _gewicht;
        }

        public override string SmallInfo()
        {
            return $"\t------------------------------------" +
                   $"\n\t| Package Info ( ID: {GetID()} )\n\t| Wieght: {this.GetGewicht()}\n\t| Insured: {this.IsVersichert()}\n\t| Ausgeliefert: {base.IsAusgeliefert()}\n\n\t| Sender valid Address: {_absender.IsGultig()}\n\t| Reciever valid Address: {_empfanger.IsGultig()}";

        }
        public override string ToString()
        {
            return $"\t------------------------------------" +
                   $"\n\t| Package Info ( ID: {GetID()} )\n\t| Wieght: {this.GetGewicht()}\n\t| Insured: {this.IsVersichert()}\n\t| Ausgeliefert: {base.IsAusgeliefert()}\n\n\t| Sender\n{_absender.ToString()}\n\t| Reciever\n{_empfanger.ToString()}";

        }
    }
}
