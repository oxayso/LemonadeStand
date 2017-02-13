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
        public double moneyStatus;
        //public double pitcherChange;
        public double lemonsPrice;
        public double sugarsPrice;
        public double icesPrice;
        public double cupsPrice;

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
            expense = lemonsPrice + sugarsPrice + icesPrice + cupsPrice;
            return expense;
        }

        public double UpdateMoney()
        {
            moneyStatus = money - expense;
            return moneyStatus;
        }

        //public double CalculatePitcherChange(double money, double lemonsPrice, double sugarsPrice, double icesPrice, double cupsPrice)
        //{
        //    double pitcherChange = money - lemonsPrice - sugarsPrice - icesPrice - cupsPrice;
        //    return pitcherChange;
        //}

        public double totalLemonPrice(int lemonCount)
        {
            lemonsPrice = lemonCount * lemonPrice;
            return lemonsPrice;
        }
        public double SubtractLemonPrice(double lemonsPrice)
        {
            double lemonSubTotal = lemonsPrice - money;
            return lemonSubTotal;
        }

        public double SubtractSugarPrice(double sugarsPrice)
        {
            double sugarSubTotal = sugarsPrice - money;
            return sugarSubTotal;
        }
        public double SubtractIcePrice(double icesPrice)
        {
            double iceSubTotal = icesPrice - money;
            return iceSubTotal;
        }
        public double SubtractCupPrice(double cupsPrice)
        {
            double cupSubTotal = cupsPrice - money;
            return cupSubTotal;
        }
        public double totalSugarPrice(int sugarCount)
        {
            sugarsPrice = sugarCount * sugarPrice;
            return sugarsPrice;
        }

        public double totalIcePrice(int iceCount)
        {
            icesPrice = iceCount * icePrice;
            return icesPrice;
        }

        public double toalCupPrice(int cupCount)
        {
            cupsPrice = cupCount * cupPrice;
            return cupsPrice;
        }

    
    }
}
