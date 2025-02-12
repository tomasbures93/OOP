using OOP___StarWars.Interfaces;
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
        public abstract void Fire(Raumschiff shiff);
        public abstract int FullHP();
        public abstract int GetHulle();
        public abstract int GetShielde();
        public abstract int GetFeuerkraft();
        public abstract string GetInfo();
        public abstract string GetArt();

    }
}
