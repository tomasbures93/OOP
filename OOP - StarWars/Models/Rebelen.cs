using OOP___StarWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OOP___StarWars.Models
{
   
    internal class Rebelen : Raumschiff
    {
        private ShifftypR _shifttyp;
        private int _shielde;
        private bool _r2;
        private int _hulle;
        private int _feuerkraft;
        private string _motto;
        private string _art;
        private string _callsign;

        public Rebelen(ConsoleColor color,ShifftypR typ) : base(color) 
        {
            _shifttyp = typ;
            _color = color;
            SetShiff(typ);
            _motto = "Möge die Macht mit dir sein!";
        }
        public override void IsHit(int dmg)
        {
            if(_shielde > 0)
            {
                _shielde = _shielde - dmg;
            } else
            {
                _hulle = _hulle - dmg;
            }
        }
        public override void Fire(Raumschiff shiff)
        {
            Raumschiff raumshiff = shiff;
            Random rnd = new Random();
            int dmg = this.GetFeuerkraft() * rnd.Next(0, 3);
            raumshiff.IsHit(dmg);
            Console.WriteLine($"\t{this.GetInfo()} ({Shiff()}) ({Shiff()}) firing at {shiff.GetInfo()} dealing {dmg} dmg!");
            Console.Write($"\t{this.GetArt()}");
            Console.ForegroundColor = _color;
            Console.Write($"-------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{shiff.GetArt()}\n\n");
        }
        public override string GetArt()
        {
            return _art;
        }

        public override string GetInfo()
        {
            return _art + " " + _callsign;
        }
        public override int FullHP()
        {
            return GetShielde() + GetHulle();
        }
        public override int GetShielde()
        {
            return _shielde;
        }
        public override int GetHulle()
        {
            return _hulle;
        }

        public override int GetFeuerkraft()
        {
            return _feuerkraft;
        }

        public override string ToString()
        {
            string shiff = Shiff();
            string text = $"\n\tShiff: {shiff}\n\tHülle: {_hulle}" +
                $"\n\tShilde: {_shielde}\n\tFeuerkraft: {_feuerkraft}" +
                $"\n\tCallSing: {_callsign}\n\tR2-Einheit: {_r2}" +
                $"\n\tFoto: {_art}";
            return text;
        }

        private string Shiff()
        {
            string shiff;
            if (_shifttyp == ShifftypR.XWing)
            {
                return shiff = "X-Wing";
            }
            else if (_shifttyp == ShifftypR.YWing)
            {
                return shiff = "Y-Wing";
            }
            else 
            {
                return shiff = "A-Wing";
            }
        }

        private void SetShiff(ShifftypR typ)
        {
            if (typ == ShifftypR.XWing)
            {
                _hulle = 500;
                _shielde = 500;
                _feuerkraft = 60;
                _callsign = "Red One";
                _r2 = true;
                _art = ":>o<:";
            }
            else if (typ == ShifftypR.YWing)
            {
                _hulle = 600;
                _shielde = 400;
                _feuerkraft = 50;
                _callsign = "Gold One";
                _r2 = true;
                _art = "O=<^>=O";
            }
            else if (typ == ShifftypR.AWing)
            {
                _hulle = 400;
                _shielde = 600;
                _feuerkraft = 40;
                _callsign = "Green One";
                _r2 = false;
                _art = "iAi";
            }
        }
    }
}
