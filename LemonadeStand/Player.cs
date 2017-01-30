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
        public int cupCount;
        public double totalPrice;
        public Pitcher lemonade;

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
        public void GetIngredientAmounts()
        {
            Console.WriteLine("How many lemons will you need?");
            lemonCount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many spoons of sugar would you like to use?");
            sugarCount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cubes of ice will you need?");
            iceCount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many cups do you need?");
            cupCount = int.Parse(Console.ReadLine());
            Console.WriteLine("How much will you charge per cup?");
            totalPrice = double.Parse(Console.ReadLine());
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

        public void BuyCups()
        {
            for(int i = 0; i < cupCount; i++)
            {
                Cup cup = new Cup();
                inventory.cups.Add(cup);
            }
        }

        public void RemoveLemons()
        {
            for(int i = 0; i < lemonCount; i--)
            {
                Lemon lemon = new Lemon();
                inventory.lemons.Remove(lemon);
            }
        }

        public void RemoveSugar()
        {
            for (int i = 0; i < sugarCount; i--)
            {
                Sugar sugar = new Sugar();
                inventory.sugars.Remove(sugar);
            }
        }

        public void RemoveIce()
        {
            for (int i = 0; i < iceCount; i--)
            {
                Ice ice = new Ice();
                inventory.ices.Remove(ice);
            }
        }


        public void CreatePitcherOfLemonade()
        {
            lemonade = new Pitcher();
            lemonade.price = totalPrice;
        }
        
    }
}
