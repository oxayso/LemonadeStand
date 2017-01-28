using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand //buy, sell
{
    public class Player
    {
        public string name;
        public int lemonCount;
        public int sugarCount;
        public int iceCount;
        public double totalPrice;
        

        public Inventory inventory = new Inventory();
        
        public virtual void GetPlayerName()
        {
            Console.WriteLine("\nType your name below to start your business! PRESS [ENTER]");
            name = Console.ReadLine();
        }

        public void PrintPlayerName()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{name}, get ready to make some money! ... or prepare to lose some.");
            Console.ResetColor();
        }

        public void DisplayMakeLemonade()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Let's Go Shopping!");
            Console.ResetColor();
        }
        public void MakeLemonade()
        {
            Console.WriteLine("How many lemons will you need?");
            lemonCount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many spoons of sugar would you like to use?");
            int sugar = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cubes of ice will you need?");
            int ice = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cups do you need?");
            int cup = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cents will you charge per cup?");
            double price = double.Parse(Console.ReadLine());
        }
        public void BuyLemons()
        {
            for(int i = 0; i < lemonCount; i++)
            {
                Lemon lemon = new Lemon();
                inventory.lemons.Add(lemon);
            }
        }

        public void BuySugar()
        {
            for(int i = 0; i < sugarCount; i++)
            {
                Sugar sugar = new Sugar();
                inventory.sugars.Add(sugar);
            }
        }

        public void BuyIce()
        {
            for(int i = 0; i < iceCount; i++)
            {
                Ice ice = new Ice();
                inventory.ices.Add(ice);
            }
        }

        //public void SetPrice()
        //{
        //    for(int i = 0; i < totalPrice; i++)
        //    {
        //        Price price = new Price
        //        inventory.priceS.Add(price);
        //    }
        //}

    }
}
