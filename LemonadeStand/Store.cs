using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public Inventory inventory;
        public double lemonPrice;
        public double sugarPrice;
        public double icePrice;
        public double cupPrice;
        public double customerWallet;

        public Store()
        {
            inventory = new Inventory();
        }

        public void AddLemon(Lemon lemon)
        {
            inventory.lemon.Add(lemon);
        }

        public void AddSugar(Sugar sugar)
        {
            inventory.sugar.Add(sugar);
        }

        public void AddIce(Ice ice)
        {
            inventory.ice.Add(ice);
        }

        public void GoToStore()
        {
            Console.WriteLine("\nRemember to be conscious with your spending."
            + " Your supplies are dependent on the weather, and you cannot spend what you \ndon't have! For your guidance, "
            + "here is Grandma's special recipe.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nGrandma's Lemonade Recipe:");
            Console.ResetColor();
            Console.WriteLine("\n-4 Ripe Lemons @ 0.05¢ per lemon. \n-5 Spoonfuls of Sugar @ 0.03¢ per spoon. "
                + "\n-Served over 3 Cubes of Ice per cup @ 0.01¢ per cube. (30 cubes total)"
                + "\n*NOTE:* This recipe makes one pitcher, consisting of a total of 10 8oz cups.");
        }
    }
}
