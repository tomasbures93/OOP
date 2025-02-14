using OOP___MarioGame.Interfaces;
using OOP___MarioGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___MarioGame
{
    internal class SmallMario : IState
    {
        private Mario _mario;

        public SmallMario(Mario mario)
        {
            _mario = mario;
        }
        public void GotMushroom()
        {
            _mario.AddCoins(100);
            _mario.ChangeState(new SuperMario(_mario));
        }

        public void GotFireFlower()
        {
            _mario.AddCoins(200);
            _mario.ChangeState(new FireMario(_mario));
        }

        public void GotFeather()
        {
            _mario.AddCoins(300);
            _mario.ChangeState(new CapeMario(_mario));
        }

        public void MetMonster()
        {
            _mario.TakeLife();
        }

    }
}
