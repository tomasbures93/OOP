using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen___TennisSpiel.models
{
    internal class TennisSpieler
    {
        private string _name;
        private int _alter;
        private TennisSpieler _nachvolger;

        public TennisSpieler(string name, int alter, TennisSpieler spieler)
        {
            _name = name;
            _alter = alter;
            _nachvolger = spieler;
        }

        public void SetNachvolger(TennisSpieler spieler)
        {
            _nachvolger = spieler; 
        }

        private int GetAge()
        {
            return _alter;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetInfo()
        {
            if(_nachvolger == null)
            {
                return $"Name: {_name,15} | Alter: {_alter,3} || Nachvolger -> || ----------------";
            } else
            {
                return $"Name: {_name,15} | Alter: {_alter,3} || Nachvolger -> || Name: {_nachvolger.GetName(),15} | Age: {_nachvolger.GetAge(),3} | Age difference: {this.AlterDifference(_nachvolger), 4}";
            }
        }

        public bool IsLetzte()
        {
            if(this._nachvolger == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int AlterDifference(TennisSpieler spieler)
        {
            return Math.Abs(this._alter - spieler.GetAge());
        }
    }
}
