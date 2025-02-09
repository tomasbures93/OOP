using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Versandservice.Models
{
    internal abstract class Postsendung : Packstation
    {
        protected Adresse _absender;
        protected Adresse _empfanger;
        protected bool _flag;

        public Postsendung(Adresse absender, Adresse empfanger)
        {
            _absender = absender;
            _empfanger = empfanger;
            _flag = false;
        }
       

        public bool IsAusgeliefert()
        {
            return _flag;
        }

        public void SetAuslieferung()
        {
            _flag = true;
        }

        public Adresse GetAbsender()
        {
            return _absender;
        }
        public Adresse GetEmpfanger()
        {
            return _empfanger;
        }

        public abstract string SmallInfo();

        public string SetAbsender()
        {
            // TO DO
            return "Set";
        }

        public string SetEmpfanger()
        {
            // TO DO
            return "";
        }
    }
}
