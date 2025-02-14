using OOP___MarioGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP___MarioGame.Models
{
    internal class Mario            // Keine Interface while es ist objekt und nicht state
    {
        private readonly SmallMario _smallmario;
        private readonly SuperMario _superMario;
        private readonly FireMario _fireMario;
        private readonly CapeMario _capeMario;

        public int lifecount { get; set; }
        public int coins {  get; set; }
        private IState state { get; set; }

        public Mario()
        {
            _smallmario = new SmallMario(this);         // das ist nicht instanz aber zustand
            _superMario = new SuperMario(this);         // das ist nicht instanz aber zustand
            _fireMario = new FireMario(this);           // das ist nicht instanz aber zustand
            _capeMario = new CapeMario(this);           // das ist nicht instanz aber zustand

            lifecount = 3;
            coins = 0;
            state = _smallmario;
        }


        public void GotMushroom()
        {
            state.GotMushroom();
        }

        public void GotFireFlower()
        {
            state.GotFireFlower();
        }

        public void GotFeather()
        {
            state.GotFeather();
        }

        public void MetMonster()
        {
            state.MetMonster();
        }

        public void ChangeState(IState state)
        {
            this.state = state;
        }
        public void AddLife()
        {
            lifecount++;
        }
        public void TakeLife()
        {
            if (lifecount == 1)
            {
                GameOver();
            }
            else
            {
                lifecount--;
            }
        }
        public void GameOver()
        {
            lifecount--;
            Console.Clear();
            Console.WriteLine("Game Over");
            Environment.Exit(0);
        }

        public void AddCoins(int value)
        {
            coins += value;
            if (coins > 500)
            {
                AddLife();
                Console.WriteLine("\t-500 coins -> +1 HP");
                TakeCoins(500);
            }
        }

        public void TakeCoins(int value)
        {
            coins -= value;
        }


        public override string ToString()
        {
            return $"Life: {lifecount} | Coins: {coins,3} | State: {state.GetType().Name} |";
        }
    }
}
