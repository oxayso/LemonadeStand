using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public string dailyProfit;
        public string dailyLoss;
        public void DisplayMakeLemonade()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Before we get squeeze crazy, let's go shopping!");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\nWallet Status = $20.00");
            Console.ResetColor();
        }

        public void GenerateProfit()
        {
            Random random = new Random();
            string[] profit = { "$2.00", "$3.50", "$4.00", "$5.00" };
            dailyProfit = profit[(random.Next(0, profit.Length))];
        }

        public void GenerateLoss()
        {
            Random random = new Random();
            string[] loss = { "$ -3.50", "$ -2.00", "$ -5.00", "$ -4.00" };
            dailyLoss = loss[(random.Next(0, loss.Length))];
        }
    }
}
