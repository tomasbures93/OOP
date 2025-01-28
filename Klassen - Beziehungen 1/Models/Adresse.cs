using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Beziehungen_1.Models
{
    internal class Adresse
    {
        private string _strasse;
        private string _hausnr;
        private string _PLZ;
        private string _ort;

        public Adresse(string strasse, string hausnr, string pLZ, string ort)
        {
            _strasse = strasse;
            _hausnr = hausnr;
            _PLZ = pLZ;
            _ort = ort;
        }

        public string GetInfo()
        {
            return $"Strasse: {_strasse} | Haus Nr: {_hausnr} | PLZ: {_PLZ} | Ort: {_ort}";
        }
    }
}
