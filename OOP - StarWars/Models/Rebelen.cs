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
        private double _shielde;
        private bool _r2;
        private double _hulle;
        private int _feuerkraft;
        private string _motto;
        private r2einheit _r2Einheit;
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
            Random rnd = new Random();
            if(_shielde > 0)
            {
                _shielde = _shielde - dmg;
            } 
            else
            {
                if(_hulle < 300 && _repariert == false && _r2 == true)
                {
                    _repariert = true;
                    if(rnd.Next(0,11) < 7)
                    {
                        int multiply = _r2Einheit.GetSkill();
                        double repair = _hulle * 0.25 * multiply;
                        _hulle = _hulle + repair ;
                        Console.WriteLine($"\t\t\t{_r2Einheit.GetName()} has repaired {this.GetInfo()}.  +{repair}HP\n");
                        Console.WriteLine($"\t\t\t    .---.   ");
                        Console.WriteLine($"\t\t\t  .'_:___\". ");
                        Console.WriteLine($"\t\t\t  |__-- ==| ");
                        Console.WriteLine($"\t\t\t  [  ]  :[|  ");
                        Console.WriteLine("\t\t\t  |__| I=[|   {BEEP BOOP REPAIR BEEP}");
                        Console.WriteLine($"\t\t\t  / / ____|   ");
                        Console.WriteLine($"\t\t\t |-/.____.'  ");
                        Console.WriteLine($"\t\t\t/___\\ /___\\ ");
                    }
                    else
                    {
                        Console.WriteLine($"\t\t\t{_r2Einheit.GetName()} was shot. He is not able to repair anything.\n");
                        Console.WriteLine($"\t\t\t    .---.   ");
                        Console.WriteLine($"\t\t\t  .'_:___\". ");
                        Console.WriteLine("\t\t\t  |__-- ==| {AAAAAAAAAAAAAAAAAAAAAAAAAAA}");
                    }
                    Task.Delay(3000).Wait();
                }
                _hulle = _hulle - dmg;
                if(_hulle < 0)
                {
                    _abgeschossen = true;
                }
            }
        }

        public override bool StillAlive()
        {
            if(_abgeschossen == false)
            {
                return true;
            } else
            {
                return false;
            }
        }
        public override int Fire(Raumschiff shiff)
        {
            Raumschiff raumshiff = shiff;
            Random rnd = new Random();
            int dmg = this.GetFeuerkraft() * rnd.Next(0, 3);
            raumshiff.IsHit(dmg);          
            Console.Write($"\t\t\t\t{this.GetArt()}");
            Console.ForegroundColor = _color;
            Console.Write($"------------- ");
            Console.ForegroundColor = ConsoleColor.White;
            if (dmg == 0)
            {
                Console.Write($"{raumshiff.GetArt()} MISS\n\n");
            }
            else
            {
                Console.Write($"{raumshiff.GetArt()} -{dmg}HP\n\n");
            }
            Console.WriteLine($"\n\n\n\t\t\t{this.GetInfo()} firing at {shiff.GetInfo()} dealing {dmg} dmg!");
            return dmg;
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
        public override double GetShielde()
        {
            return _shielde;
        }
        public override double GetHulle()
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
            string text = $"\t|   {shiff,4}   | {_hulle,4} |   {_shielde,4}   | {_feuerkraft,8} " +
                $"| {_callsign,11} | {_r2,6} |   {_art,10}  |";
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
                _r2Einheit = new r2einheit("R2-D2");
            }
            else if (typ == ShifftypR.YWing)
            {
                _hulle = 600;
                _shielde = 400;
                _feuerkraft = 50;
                _callsign = "Gold One";
                _r2 = true;
                _art = "O=<^>=O";
                _r2Einheit = new r2einheit("C1-10P");
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
