using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie___Versandservice.Models
{
    internal abstract class Postsendung : Packstation
    {
        protected static int _id = 1000;
        protected Adresse _absender;
        protected Adresse _empfanger;
        protected bool _flag;

        public Postsendung(Adresse absender, Adresse empfanger)
        {
            _id = _id + 1;
            _absender = absender;
            _empfanger = empfanger;
            _flag = false;
        }
    }
}
