using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public void GoToStore()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Welcome to Lime 'n Save. Where we paint lemons GOLD.");
            Console.ResetColor();
            Console.WriteLine("\nRemember to be conscious with your spending."
            + " Your supplies are dependent on the weather, and you cannot spend what you \ndon't have! For your guidance, here is"
            + " Grandma's special recipe.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nThe Perfect Lemonade Recipe is as follows:");
            Console.ResetColor();
            Console.WriteLine("\n-4 Ripe Lemons @ 0.05 cents per lemon. \n-5 Spoonfuls of Sugar @ 0.03 cents per spoon. \n-Served over 3 Cubes of Ice"
                + " per cup @ 0.01 cents per cube. "
                + "\n*NOTE:* This recipe"
                +" makes one pitcher, consisting of a total of 10 cups @ 0.05 cents per cup.");
        }

    }
}
