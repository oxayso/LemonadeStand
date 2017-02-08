using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public double customerMoney = 20;
        //public string dailyProfit;
        //public string dailyLoss;
        public void DisplayMakeLemonade()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nBefore we get squeeze crazy, let's go shopping!");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\nWallet Status = $20.00");
            Console.ResetColor();
        }

        //public void GenerateProfit()
        //{
        //    Random random = new Random();
        //    string[] profit = { "$1.15", "$2.35", "$3.00", "$4.10" };
        //    dailyProfit = profit[(random.Next(0, profit.Length))];
        //}

        //public void GenerateLoss()
        //{
        //    Random random = new Random();
        //    string[] loss = { "$ -2.20", "$ -1.13", "$ -3.10" };
        //    dailyLoss = loss[(random.Next(0, loss.Length))];
        //}
    }
}
