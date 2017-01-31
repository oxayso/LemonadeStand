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
            Console.WriteLine("\n-4 Ripe Lemons \n-5 Spoonfuls of Sugar \n-Served over 3 Cubes of Ice per cup \n*NOTE:* This recipe"
                +" makes one pitcher, consisting of a total of 10 cups");
        }
    }
}
