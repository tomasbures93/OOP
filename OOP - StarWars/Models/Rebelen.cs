using OOP___StarWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOP___StarWars.Models
{
    enum ShifftypR
    {
        XWing,
        YWing,
        AWing
    }
    internal class Rebelen : ISchiff
    {
        private ShifftypR _shifttyp;
        private int _hulle;
        private int _fauerkraft;
        private ConsoleColor _laserfarbe;
        private string _motto;
        private string _art;
        private string _callsign;
        private bool _abgeschossen;
        private bool _repairt;
        private int _shielde;
        private bool _r2;

        public Rebelen(ShifftypR typ)
        {
            _shifttyp = typ;
            SetShiff(typ);
            _laserfarbe = ConsoleColor.Green;
            _repairt = false;
            _abgeschossen = false;
            _motto = "Möge die Macht mit dir sein!";
        }

        public void Fire(Imperial shiff)
        {
            string shiffn;
            if (_shifttyp == ShifftypR.XWing)
            {
                shiffn = "X-Wing";
            }
            else if (_shifttyp == ShifftypR.YWing)
            {
                shiffn = "Y-Wing";
            }
            else
            {
                shiffn = "A-Wing";
            }
            string shiffnn;
            if (shiff.Ship == ShifftypI.TIEFighter)
            {
                shiffnn = "TIE-Fighter";
            }
            else if (shiff.Ship == ShifftypI.TIEInterceptor)
            {
                shiffnn = "TIE-Interceptor";
            }
            else
            {
                shiffnn = "TIE-Bomber";
            }
            shiff.Hulle -= this.FeuerKraft;
            Console.WriteLine($"\tHP: {_hulle + _shielde} | {this._art} {this.CallSign} ({shiffn}) firing at {shiff.ASCII} {shiff.CallSign} ({shiffn}) | HP: {shiff.Hulle}");

        }

        private void SetShiff(ShifftypR typ)
        {
            if(typ == ShifftypR.XWing)
            {
                _hulle = 500;
                _shielde = 500;
                _fauerkraft = 60;
                _callsign = "Red One";
                _r2 = true;
                _art = ":>o<:";
            } 
            else if(typ == ShifftypR.YWing)
            {
                _hulle = 600;
                _shielde = 400;
                _fauerkraft = 50;
                _callsign = "Gold One";
                _r2 = true;
                _art = "O=<^>=O";
            } 
            else if (typ == ShifftypR.AWing)
            {
                _hulle = 400;
                _shielde = 600;
                _fauerkraft = 40;
                _callsign = "Green One";
                _r2 = false;
                _art = "iAi";
            }
        }
        public int Hulle 
        { 
            get { return _hulle; } 
            set { _hulle = value; } 
        }
        public ShifftypR Ship
        {
            get { return _shifttyp; }
        }
        public int Shield
        {
            get { return _shielde; }
            set { _shielde = value; }
        }
        public int FeuerKraft 
        { 
            get { return _fauerkraft;  }
        }
        public string CallSign 
        { 
            get { return _callsign; } 
        }

        public string ASCII 
        {
            get { return _art; } 
        }

        public int Shielde
        {
            get { return _shielde; }
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
            if (_shifttyp == ShifftypR.XWing)
            {
                shiff = "X-Wing";
            }
            else if (_shifttyp == ShifftypR.YWing)
            {
                shiff = "Y-Wing";
            }
            else
            {
                shiff = "A-Wing";
            }
            string text = $"\n\tShiff: {shiff}\n\tHülle: {_hulle}" +
                $"\n\tShilde: {_shielde}\n\tFeuerkraft: {_fauerkraft}" +
                $"\n\tCallSing: {_callsign}\n\tR2-Einheit: {_r2}" +
                $"\n\tFoto: {_art}";
            return text;
        }
    }
}
