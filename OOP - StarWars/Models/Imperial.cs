using OOP___StarWars.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___StarWars.Models
{
   
    internal class Imperial : Raumschiff
    {
        private ShifftypI _shifttyp;
        private int _hulle;
        private int _feuerkraft;
        private string _motto;
        private string _art;
        private string _callsign;

        public Imperial(ConsoleColor color, ShifftypI typ) : base(color)
        {
            _shifttyp = typ;
            SetShiff(typ);
            _color = color;
            _motto = "Für den Imperator!";
        }

        public override void IsHit(int dmg)
        {
            _hulle = _hulle - dmg;
        }
        public override int GetShielde()
        {
            return 0;
        }
        public override void Fire(Raumschiff shiff)
        {
            Raumschiff raumshiff = shiff;
            Random rnd2 = new Random();
            int dmg = this.GetFeuerkraft() * rnd2.Next(0, 3);
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
        public override int GetHulle()
        {
            return _hulle;
        }

        public override int GetFeuerkraft()
        {
            return _feuerkraft;
        }

        private void SetShiff(ShifftypI typ)
        {
            if (typ == ShifftypI.TIEFighter)
            {
                _hulle = 1000;
                _feuerkraft = 50;
                _callsign = "Delta One";
                _art = "|-o-|";
            }
            else if (typ == ShifftypI.TIEInterceptor)
            {
                _hulle = 1000;
                _feuerkraft = 50;
                _callsign = "Gamma One";
                _art = "<-o->";
            }
            else if (typ == ShifftypI.TIEBomber)
            {
                _hulle = 1000;
                _feuerkraft = 50;
                _callsign = "Beta One";
                _art = "(=Oo=)";
            }
        }

        private string Shiff()
        {
            string shiff;
            if (_shifttyp == ShifftypI.TIEFighter)
            {
                return shiff = "TIE-Fighter";
            }
            else if (_shifttyp == ShifftypI.TIEInterceptor)
            {
               return shiff = "TIE-Interceptor";
            }
            else
            {
                return shiff = "TIE-Bomber";
            }
        }
        public override string ToString()
        {
            string shiff = Shiff();
            string text = $"\n\tShiff: {shiff}\n\tHülle: {_hulle}" +
                $"\n\tFeuerkraft: {_feuerkraft}" +
                $"\n\tCallSing: {_callsign}" +
                $"\n\tFoto: {_art}";
            return text;
        }
    }
}
