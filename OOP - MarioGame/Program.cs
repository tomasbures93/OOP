using OOP___MarioGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___MarioGame
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // ZUSTAND PATTERN
            Mario mario = new Mario();
            string marioArt = "|";
            int x = Console.CursorLeft;
            int y = 2;
            bool erst = false, zwei = false, drei = false, vier = false , funf = false , sechs = false, sieben = false ;
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true); 
                Console.Clear();
                Console.WriteLine("\t"+ mario);
                if(erst == false)
                {
                    Console.SetCursorPosition(10, y);
                    Console.WriteLine("m");
                }
                if(zwei == false)
                {
                    Console.SetCursorPosition(15, y);
                    Console.WriteLine("f");
                }
                if (drei == false)
                {
                    Console.SetCursorPosition(20, y);
                    Console.WriteLine("F");
                }
                if (vier == false)
                {
                    Console.SetCursorPosition(25, y);
                    Console.WriteLine("M");
                }
                if (funf == false)
                {
                    Console.SetCursorPosition(30, y);
                    Console.WriteLine("M");
                }
                if (sechs == false)
                {
                    Console.SetCursorPosition(50, y);
                    Console.WriteLine("M");
                }
                if (sieben == false)
                {
                    Console.SetCursorPosition(71, y);
                    Console.WriteLine("M");
                }

                if (keyInfo.Key == ConsoleKey.D)  
                {
                    if(x == 9)
                    {
                        erst = true;
                        mario.GotMushroom();
                    }
                    if (x == 14)
                    {
                        zwei = true;
                        mario.GotFireFlower();
                    }
                    if (x == 19)
                    {
                        drei = true;
                        mario.GotFeather();
                    }
                    if (x == 24)
                    {
                        vier = true;
                        mario.MetMonster();
                    }
                    if (x == 29)
                    {
                        funf = true;
                        mario.MetMonster();
                    }
                    if (x == 49)
                    {
                        sechs = true;
                        mario.MetMonster();
                    }
                    if (x == 70)
                    {
                        sieben = true;
                        mario.MetMonster();
                    }
                    x++; 
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(marioArt);
                }
                if (keyInfo.Key == ConsoleKey.A) 
                {
                    x--; 
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(marioArt);
                }
                else if (keyInfo.Key == ConsoleKey.Q) 
                {
                    break;
                }
            }
        }
    }
}
