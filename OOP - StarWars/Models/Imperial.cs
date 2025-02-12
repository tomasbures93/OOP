using OOP___StarWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___StarWars.Models
{
    enum ShifftypI
    {
        TIEFighter,
        TIEInterceptor,
        TIEBomber
    }
    internal class Imperial : ISchiff
    {
        private ShifftypI _shifttyp;
        private int _hulle;
        private int _fauerkraft;
        private ConsoleColor _laserfarbe;
        private string _motto;
        private string _art;
        private string _callsign;
        private bool _abgeschossen;
        private bool _repairt;

        public Imperial(ShifftypI typ)
        {
            _shifttyp = typ;
            SetShiff(typ);
            _repairt = false;
            _laserfarbe = ConsoleColor.Red;
            _abgeschossen = false;
            _motto = "Möge die Macht mit dir sein!";
        }

        private void SetShiff(ShifftypI typ)
        {
            if (typ == ShifftypI.TIEFighter)
            {
                _hulle = 1000;
                _fauerkraft = 50;
                _callsign = "Delta One";
                _art = "|-o-|";
            }
            else if (typ == ShifftypI.TIEInterceptor)
            {
                _hulle = 1000;
                _fauerkraft = 50;
                _callsign = "Gamma One";
                _art = "<-o->";
            }
            else if (typ == ShifftypI.TIEBomber)
            {
                _hulle = 1000;
                _fauerkraft = 50;
                _callsign = "Beta One";
                _art = "(=Oo=)";
            }
        }
        public int Hulle
        {
            get { return _hulle; }
            set { _hulle = value; }
        }
        public int FeuerKraft
        {
            get { return _fauerkraft; }
        }

        public void Fire(Rebelen shiff)
        {
            string shiffn;
            if (shiff.Ship == ShifftypR.XWing)
            {
                shiffn = "X-Wing";
            }
            else if (shiff.Ship == ShifftypR.YWing)
            {
                shiffn = "Y-Wing";
            }
            else
            {
                shiffn = "A-Wing";
            }
            string shiffnn;
            if (_shifttyp == ShifftypI.TIEFighter)
            {
                shiffnn = "TIE-Fighter";
            }
            else if (_shifttyp == ShifftypI.TIEInterceptor)
            {
                shiffnn = "TIE-Interceptor";
            }
            else
            {
                shiffnn = "TIE-Bomber";
            }
            if(shiff.Shield > 0)
            {
                shiff.Shield -= this.FeuerKraft;
            } else
            {
                shiff.Hulle -= this.FeuerKraft;
            }
            Console.WriteLine($"\tHP: {_hulle} | {this._art} {this.CallSign} ({shiffnn}) firing at {shiff.ASCII} {shiff.CallSign} ({shiffn}) | HP: {shiff.Hulle + shiff.Shield}");
        }

        public ShifftypI Ship
        {
            get { return _shifttyp; }
        }
        public string CallSign
        {
            get { return _callsign; }
        }

        public string ASCII
        {
            get { return _art; }
        }

        public ConsoleColor LaserFarbe
        {
            get { return _laserfarbe; }
        }

        public string Motto
        {
            get { return _motto; }
        }

        public override string ToString()
        {
            string shiff;
            if (_shifttyp == ShifftypI.TIEFighter)
            {
                shiff = "TIE-Fighter";
            }
            else if (_shifttyp == ShifftypI.TIEInterceptor)
            {
                shiff = "TIE-Interceptor";
            }
            else
            {
                shiff = "TIE-Bomber";
            }
            string text = $"\n\tShiff: {shiff}\n\tHülle: {_hulle}" +
                $"\n\tFeuerkraft: {_fauerkraft}" +
                $"\n\tCallSing: {_callsign}" +
                $"\n\tFoto: {_art}";
            return text;
        }
    }
}
