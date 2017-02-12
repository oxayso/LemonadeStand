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
        public int daysToPlay = 7;
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
            Console.WriteLine("\n\n* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * "
                +"* * * * * * * * * * * * * * *");
            Console.ResetColor();
        }

        public void DisplayRules()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nTo efficiently manage your lemonade stand, you will need to keep careful consideration of "
                +"how many glasses of lemonade \nto make. (Only one pitcher is made every morning) "
                + "\n\nSimple enough, right? "
                + $"To start, I am lending you ${wallet.money}.00 cash. GOOD LUCK!");
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

        public void MakingLemonade()
        {
            Console.WriteLine("\n. . . . MAKING LEMONADE . . . .");
            Console.WriteLine("\n▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ "
            +"[_]P");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n100% COMPLETE");
            Console.ResetColor(); 
        }

        public void GoSellLemonade()
        {
            Console.WriteLine("\nIT'S TIME TO MAKE SOME MONEY! \nGET OUT THERE AND SELL SOME LEMONADE!");
        }

        public void DisplayDailyReport()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n$$ YOUR DAILY FINANCIAL REPORT $$\n");
            Console.ResetColor();
            Console.WriteLine($"\nPROFIT:");
            Console.WriteLine($"LOSS:");
            Console.WriteLine($"TOTAL EXPENSES: {wallet.expense}");
            Console.WriteLine($"WALLET STATUS:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nTHANKS FOR VISITING LEMONLAND!");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nPRESS [ENTER] TO CONTINUE.");
            Console.ResetColor();
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
            StartDay();
        }
        public void StartDay()
        {
            for (var i = 0; i < daysToPlay; i++)
            {
                day.AddDay();
                day.DisplayCurrentDay();
                day.weather.GenerateRandomWeather();
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
                MakingLemonade();
                DisplayBreakpoint();
                Console.ReadKey();
                GoSellLemonade();
                DisplayBreakpoint();
                Console.ReadKey();
                //wallet.GenerateProfit();
                //wallet.GenerateLoss();
                DisplayDailyReport();
                DisplayBreakpoint();
                Console.ReadKey();
            }           
        }
    }
}
