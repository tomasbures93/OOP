using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OOP___StarWars.Models
{
    enum ShifftypR
    {
        XWing,
        YWing,
        AWing
    }
    enum ShifftypI
    {
        TIEFighter,
        TIEInterceptor,
        TIEBomber
    }
    internal abstract class Raumschiff

    {
        protected ConsoleColor _color;
        protected bool _abgeschossen;
        protected bool _repariert;

        public Raumschiff(ConsoleColor color)
        {
            _color = color;
            _abgeschossen = false;
            _repariert = false;
        }

        public abstract void IsHit(int dmg);
        public abstract int Fire(Raumschiff shiff);
        public abstract double FullHP();
        public abstract double GetHulle();
        public abstract double GetShielde();
        public abstract int GetFeuerkraft();
        public abstract string GetInfo();
        public abstract string GetArt();

        public abstract bool StillAlive();

    }
}
