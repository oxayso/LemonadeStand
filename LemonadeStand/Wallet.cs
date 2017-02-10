using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public double money = 20;
        public double lemonPrice = 0.05;
        public double sugarPrice = 0.03;
        public double icePrice = 0.01;
        public double cupPrice = 0.05;
        public double expense;
        public double pitcherChange;

        public void DisplayMakeLemonade()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nBefore we get squeeze crazy, let's go shopping!");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n\nWallet Status = ${money}.00 ");
            Console.ResetColor();
        }

        public double CalculateExpenses(double money, double lemonsPrice, double sugarsPrice, double icesPrice, double cupsPrice)
        {
            double expense = money - lemonsPrice - sugarsPrice - icesPrice - cupsPrice;
            return expense;
        }

        public double CalculatePitcherChange(double money, double lemonsPrice, double sugarsPrice, double icesPrice, double cupsPrice)
        {
            double pitcherChange = money - lemonsPrice - sugarsPrice - icesPrice - cupsPrice;
            return pitcherChange;
        }

        public double totalLemonPrice(int lemonCount)
        {
            double lemonsPrice = lemonCount * lemonPrice;
            return lemonsPrice;
        }

        public double totalSugarPrice(int sugarCount)
        {
            double sugarsPrice = sugarCount * sugarPrice;
            return sugarsPrice;
        }

        public double totalIcePrice(int iceCount)
        {
            double icesPrice = iceCount * icePrice;
            return icesPrice;
        }

        public double toalCupPrice(int cupCount)
        {
            double cupsPrice = cupCount * cupPrice;
            return cupsPrice;
        }

    
    }
}
