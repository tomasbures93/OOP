using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___Zahnartzpraxis.models
{
    internal class Person
    {
        private int _patientNR;
        private string _name;
        private string _adresse;
        private string _geburstDatum;
        private bool _versicherungKarte;
        private Krankenkasse _krankenkasse;     // Ganze Klasse Übergeben - Agregation

        public Person(int patientnr, string name, Krankenkasse krankenkasse)
        {
            _patientNR = patientnr;
            _name = name;
            _krankenkasse = krankenkasse;
            _versicherungKarte = true;
            SetKrankenKasse(krankenkasse);
        }

        public void SetAdresse(string adresse)
        {
            _adresse = adresse;
        }

        public void SetGeburstdatum(string datum)
        {
            _geburstDatum = datum;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetKrankenKasse(Krankenkasse krankenkasse)
        {
            _krankenkasse.RemovePatient(this);
            _krankenkasse = krankenkasse;
            krankenkasse.AddPatient(this);
        }

        public string GetInfo()
        {
            string output = $"Patient NR: {_patientNR}\nName: {_name}\nAdresse: {_adresse}\nGeburstdatum: {_geburstDatum}\nVersicherung Karte: {_versicherungKarte}\nKrankenkasse: {_krankenkasse.GetInfo()}";
            return output;
        }
    }
}
