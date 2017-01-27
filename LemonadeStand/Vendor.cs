using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Vendor
    {

        //public void DisplayMakeLemonade()
        //{
        //    Console.ForegroundColor = ConsoleColor.DarkCyan;
        //    Console.WriteLine("Let's Go Shopping!");
        //    Console.ResetColor();
        //}
        public Ingredient MakeLemonade()
        {
            Console.WriteLine("How many lemons will you need?");
            int lemon = int.Parse(Console.ReadLine());
            Console.WriteLine("How many spoons of sugar would you like to use?");
            int sugar = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cubes of ice will you need?");
            int ice = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cups do you need?");
            int cup = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cents will you charge per cup?");
            double price = double.Parse(Console.ReadLine());
            return new Ingredient(lemon, sugar, ice, cup, price);
        }


    }
}
