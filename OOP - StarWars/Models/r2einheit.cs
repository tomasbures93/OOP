using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___StarWars.Models
{
    internal class r2einheit
    {
        private string _name;
        private int _skill;
        Random random = new Random();

        public r2einheit(string name)
        {
            _name = name;
            _skill = random.Next(0, 11);
        }

        public string GetName()
        {
            return _name;
        }

        public int GetSkill()
        {
            return _skill;
        }
    }
}
