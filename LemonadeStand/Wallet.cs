using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Wallet
    {
        public void DisplayMakeLemonade()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Before we get squeeze crazy, let's go shopping!");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\nWallet Status = $20.00");
            Console.ResetColor();
        }

        //public void CalculateWallet();


    }
}
