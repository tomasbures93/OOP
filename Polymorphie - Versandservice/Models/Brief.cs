using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Versandservice.Models
{
    enum BriefTyp
    {
        Standartbrief,
        Eilbrief,
        Einschreiben
    }

    internal class Brief : Postsendung
    {
        private BriefTyp _briefTyp;
        private static int _idNext = 1000;
        private int _id;

        public Brief(Adresse absender, Adresse empfanger, BriefTyp briefTyp = BriefTyp.Standartbrief) : base(absender, empfanger)
        {
            _id = _idNext;
            _idNext++;
            _briefTyp = briefTyp;
        }

        public override int GetID()
        {
            return _id;
        }

        public override string SmallInfo()
        {
            return $"\t------------------------------------" +
                $"\n\t| Letter Info ( ID: {GetID()} )\n\t| Letter Type: {_briefTyp.ToString()}\n\t| Ausgeliefert: {base.IsAusgeliefert()}\n\n\t| Sender valid address: {_absender.IsGultig()}\n\t| Reciever valid address: {_empfanger.IsGultig()}";
        }
        public override string ToString()
        {
            return $"\t------------------------------------" +
                $"\n\t| Letter Info ( ID: {GetID()} )\n\t| Letter Type: {_briefTyp.ToString()}\n\t| Ausgeliefert: {base.IsAusgeliefert()}\n\n\t| Sender\n{_absender.ToString()}\n\t| Reciever\n{_empfanger.ToString()}";
        }
    }
}
