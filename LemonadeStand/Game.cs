using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public void DisplayWelcomeMsg()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int leftOffSet = (Console.WindowWidth / 5);
            int rightOffSet = (Console.WindowHeight / 38);
            Console.SetCursorPosition(leftOffSet, rightOffSet);
            Console.WriteLine("Welcome to Lemonade Stand! The place where you will: Mix, Work && Play.");
            Console.ResetColor();
        }

        public void RunGame()
        {
            DisplayWelcomeMsg();
        }
    }
}
