using OOP___MarioGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___MarioGame.Models
{
    internal class CapeMario : IState           // interface while es ist STATE
    {
        private Mario _mario;

        public CapeMario(Mario mario)
        {
            _mario = mario;
        }
        public void GotMushroom()
        {
            _mario.AddCoins(100);
        }

        public void GotFireFlower()
        {
            _mario.AddCoins(200);
            _mario.ChangeState(new FireMario(_mario));
        }

        public void GotFeather()
        {
            _mario.AddCoins(300);
        }

        public void MetMonster()
        {
            _mario.TakeLife();
            _mario.ChangeState(new SmallMario(_mario));
        }
    }
}
