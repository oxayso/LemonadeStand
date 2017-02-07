using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Inventory 
    {
            public List<Ingredient> ingredient;
            public List<Lemon> lemons = new List<Lemon>();
            public List<Sugar> sugars = new List<Sugar>();
            public List<Ice> ices = new List<Ice>();
            public List<Cup> cups = new List<Cup>();
            public List<Pitcher> priceS = new List<Pitcher>();

        public void DisplayCurrentInventory()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("INVENTORY STATUS: \n");
            Console.ResetColor();
            Console.WriteLine("Lemons: \nSugar: \nIce: \nCups: \n");

        }
    }

}

