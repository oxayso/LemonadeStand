using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game : Player

    {
        public Player playerOne;

        public Game()
        {
            playerOne = new Player();
        }

        public void DisplayWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int leftOffSet = (Console.WindowWidth / 8);
            int rightOffSet = (Console.WindowHeight / 38);
            Console.SetCursorPosition(leftOffSet, rightOffSet);
            Console.WriteLine("Welcome to Lemonsville! In this game, you are in charge of running your own Lemonade Stand.");
            Console.ResetColor();
        }

        public void DisplayBreakpoint()
        {
            Console.WriteLine("\n\n* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * "
                + " * * * * * * * * * * *");
        }

        public void DisplayRules()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nTo efficiently manage your lemonade stand, you will need to make 3 important decisions everyday: "
                + "\n\n1.) How many glasses of lemonade to make \n(Only one batch is made every morning) "
                + "\n\n2.) How many advertising flyers to make \n(Flyers cost fifteen cents each) "
                + "\n\n3.) What price you are going to charge for each glass \n\nThink you're ready to begin? "
                + "To start, you have $20.00 cash. Lucky you, your neighbor lended you some sugar, \ntherefore your cost to make lemonade "
                + " is 10 cents per glass. "
                + "Warning, this may change in the future.");
            Console.ResetColor();
        }

        public string GiveMoreInformation()
        {
            Console.WriteLine("\nWould you like to know more? \n\n[Y] YES \n[N] NO");
            string information = Console.ReadLine().ToUpper();
            return information;
        }
        public void GiveOptionKnowMore(string information)
        {
            switch (information)
            {
                case "Y":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n-Your expenses are the sum of the cost of lemonade + the cost of the flyers. "
                        + "\n\n-Your profits are the difference between the income from the sales and your expenses. "
                        + "\n\n-The number of glasses you sell each day is dependent upon the price you charge, and the number of advertising flyers "
                        + "\nyou post. \n\n-Keep track of your assets, because you can't spend mre money than you actually have!");
                    Console.ResetColor();
                    break;
                case "N":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\nI take it that you're ready to begin? Press [ENTER]");
                    Console.ResetColor();
                    Console.ReadLine();
                    break;
                default:
                    break;

            }

        }
      

        public void RunGame()
        {
            DisplayWelcomeMessage();
            DisplayBreakpoint();
            DisplayRules();
            DisplayBreakpoint();
            string information = GiveMoreInformation();
            GiveOptionKnowMore(information);
            DisplayBreakpoint();
            playerOne.GetPlayerName();
            playerOne.PrintPlayerName();
            DisplayBreakpoint();
        }
    }
}
