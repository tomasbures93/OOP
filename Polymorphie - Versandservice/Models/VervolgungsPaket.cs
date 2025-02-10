using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Versandservice.Models
{
    internal class VervolgungsPaket : Paket
    {
        private List<Station> _stations = new List<Station>();

        public VervolgungsPaket(Adresse absender, Adresse empfanger, double gewicht, bool versicherung) : base(absender, empfanger, gewicht, versicherung)
        {
            SetzeStation(absender.ToSmallString());
        }

        public void SetzeStation(string ort)
        {
            _stations.Add(new Station(ort));
        }

        public override string SmallInfo()
        {
            string station = "";
            foreach (Station stat in _stations) {
                station = station + $"\n\t| {stat.ToString()}|";
            }
            return $"\t------------------------------------" +
                   $"\n\t| Package Info ( ID: {GetID()} )\n\t| Wieght: {this.GetGewicht()}\n\t| Insured: {this.IsVersichert()}\n\t| Ausgeliefert: {base.IsAusgeliefert()}\n\n\t| Sender valid Address: {_absender.IsGultig()}\n\t| Reciever valid Address: {_empfanger.IsGultig()}\n\t| Tracking: {station}";

        }
        public override string ToString()
        {
            string station = "";
            foreach (Station stat in _stations)
            {
                station = station + $"\n\t| {stat.ToString()}|";
            }
            return $"\t------------------------------------" +
                   $"\n\t| Package Info ( ID: {GetID()} )\n\t| Wieght: {this.GetGewicht()}\n\t| Insured: {this.IsVersichert()}\n\t| Ausgeliefert: {base.IsAusgeliefert()}\n\n\t| Sender\n{_absender.ToString()}\n\t| Reciever\n{_empfanger.ToString()}\n\t| Tracking: {station}";
        }
    }
}
