using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___StarWars.Models
{
   
    internal class Imperial : Raumschiff
    {
        private ShifftypI _shifttyp;
        private double _hulle;
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
            if(_hulle < 300 && _repariert == false)
            {
                _repariert = true;
                double repair = 500;
                _hulle = _hulle + repair;
                Console.WriteLine($"\tImperator Palpatine has repaired {this.GetInfo()} ( +{repair}HP ) from Star Destroyer!\n");
                Console.WriteLine("\t\t\t      ,_~\"\"\"~-,   ");
                Console.WriteLine("\t\t\t    .'(_)------`,    ");
                Console.WriteLine("\t\t\t    |===========|    { GET SOME HP NOOB }");
                Console.WriteLine("\t\t\t    `,---------,'   ");
                Console.WriteLine("\t\t\t      ~-.___.-~      ");
                Task.Delay(3000).Wait();
            }
            _hulle = _hulle - dmg;
            if (_hulle < 0)
            {
                _abgeschossen = true;
            }
        }

        public override int Fire(Raumschiff shiff)
        {
            Raumschiff raumshiff = shiff;
            Random rnd2 = new Random();
            int dmg = this.GetFeuerkraft() * rnd2.Next(0, 3);
            raumshiff.IsHit(dmg);
            if (dmg == 0)
            {
                Console.Write($"\t\t\t\tMISS {raumshiff.GetArt()}");
            }
            else
            {
                Console.Write($"\t\t\t\t-{dmg}HP {raumshiff.GetArt()}");
            }
            Console.ForegroundColor = _color;
            Console.Write($" -------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{this.GetArt()}\n\n");
            Console.WriteLine($"\n\n\n\t\t\t{this.GetInfo()} firing at {shiff.GetInfo()} dealing {dmg} dmg!");
            return dmg;
        }

        public override bool StillAlive()
        {
            if (_abgeschossen == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string GetArt()
        {
            return _art;
        }
        public override string GetInfo()
        {
            return _art + " " + _callsign;
        }
        public override double FullHP()
        {
            return GetShielde() + GetHulle();
        }
        public override double GetHulle()
        {
            return _hulle;
        }
        public override double GetShielde()
        {
            return 0;
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
            string text = $"\t|   {shiff,15}   | {_hulle,6} | {_feuerkraft,8} " +
                $"| {_callsign,11} |   {_art,10}  |";
            return text;
        }
    }
}
