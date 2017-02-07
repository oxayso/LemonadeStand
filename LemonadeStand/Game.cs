using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game 

    {
        public Player playerOne;
        public Day day;
        public Wallet wallet;
        public Store store;
        public Inventory inventory;
        public Game()
        {
            playerOne = new Player();
            day = new Day();
            wallet = new Wallet();
            store = new Store();
            inventory = new Inventory();
        }

        public void DisplayWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int leftOffSet = (Console.WindowWidth / 8);
            int rightOffSet = (Console.WindowHeight / 38);
            Console.SetCursorPosition(leftOffSet, rightOffSet);
            Console.WriteLine("Welcome to LemonLand! In this game, you are in charge of running your own Lemonade Stand.");
            Console.ResetColor();
        }

        public void DisplayBreakpoint()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\n* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * "
                + " * * * * * * * * * * *");
            Console.ResetColor();
        }

        public void DisplayRules()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nTo efficiently manage your lemonade stand, you will need to make 2 important decisions everyday: "
                + "\n\n1.) How many glasses of lemonade to make \n(Only one batch is made every morning) "
                + "\n\n2.) What price you are going to charge for each glass \n\nThink you're ready to begin? "
                + "To start, you have $20.00 cash. GOOD LUCK!");
            Console.ResetColor();
        }

        public string GiveMoreInformation()
        {
            Console.WriteLine("\nWould you like to know more? \n\n[Y] YES! \n[N] NO.");
            string information = Console.ReadLine().ToUpper();
            return information;
        }
        public void GiveOptionKnowMore(string information)
        {
            switch (information)
            {
                case "Y":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\n-Your expenses are the sum of the cost of lemonade. "
                        + "\n\n-Your profits are the difference between the income from the sales and your expenses. "
                        + "\n\n-The number of glasses you sell each day is dependent upon the price you charge + the weather."
                        + "\n\n-Keep track of your assets, because you can't spend more money than you actually have!");
                    Console.ResetColor();
                    break;
                case "N":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("\nI take it that you're ready to begin? Press [ENTER]");
                    Console.ResetColor();
                    Console.ReadLine();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n*** THERE WAS AN ERROR PROCESSING YOUR REQUEST. PLEASE TRY AGAIN. ***\n");
                    Console.ResetColor();
                    information = GiveMoreInformation();
                    break;

            }

        }

        public void GoSellLemonade()
        {
            Console.WriteLine("\nIT'S TIME TO MAKE SOME MONEY! \nGET OUT THERE AND SELL SOME LEMONADE!");
        }

        public void DisplayDailyReport()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n$$ LEMONLAND DAILY FINANCIAL REPORT $$\n");
            Console.ResetColor();
            Console.WriteLine("Number of Glasses Sold: \nAmount of Money Earned Per Glass: \nSales Income: \nNumber of Glasses"
                +" Made: \nAmount Charged Per Glass: \nLemonade Expense: \n\nPROFIT: \n\nNEW ASSETS: \n");
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
            Console.ReadKey();
            day.weather.GenerateRandomWeather();
            day.DisplayCurrentDay();
            DisplayBreakpoint();
            Console.ReadKey();
            day.DisplayCurrentWeather();
            day.weather.GeneratePredictedWeather();
            day.DisplayPredictedWeather();
            DisplayBreakpoint();
            Console.ReadKey();
            wallet.DisplayMakeLemonade();
            DisplayBreakpoint();
            store.GoToStore();
            DisplayBreakpoint();
            string option = playerOne.PitcherRecipeOption();
            playerOne.PitcherResult(option);
            DisplayBreakpoint();
            //playerOne.CreatePitcherOfLemonade();
            //string amount = playerOne.GetPitcherAmount();
            //playerOne.PitcherAmount(amount);
            // DisplayBreakpoint();
            GoSellLemonade();
            DisplayBreakpoint();
            Console.ReadKey();
            //playerOne.PrintPitcherTotal()
            //DisplayBreakpoint();
            //playerOne.GetIngredientAmounts();
            //Console.ReadKey();  
            DisplayDailyReport();
            DisplayBreakpoint();
            Console.ReadKey();
            inventory.DisplayCurrentInventory();
            DisplayBreakpoint();
            Console.ReadKey();
           

        }
    }
}
