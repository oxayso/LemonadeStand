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
        //public string amount;
        public int lemonCount;
        public int sugarCount;
        public int iceCount;
        public int cupCount;
        public double totalPrice;
        public Pitcher lemonade;
        public double pitcherCount;
        public double pitcherTotal;
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

        public string PitcherRecipeOption()
        {
            Console.WriteLine("Would you like to utilize the 'Perfect Lemonade Recipe' or customize your own? \n\n[Y] YES, I want the"
                +" Perfect Recipe. \n[N] NO, I want to make my own.\n");
            string option = Console.ReadLine().ToUpper();
            return option;
        }

        public void PitcherResult(string option)
        {
            switch (option)
            {
                case "Y":
                    string amount = GetPitcherAmount();
                    PitcherAmount(amount);
                    Console.ReadLine();
                        break;
                case "N":
                    GetIngredientAmounts();
                    Console.ReadLine();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n*** THERE WAS AN ERROR PROCESSING YOUR REQUEST. PLEASE TRY AGAIN. ***\n");
                    Console.ResetColor();
                    PitcherRecipeOption();
                    break;

            }
        }

        
        public void GetIngredientAmounts()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nYou are now customizing your own lemonade recipe.\n");
            Console.ResetColor();
            Console.WriteLine("-How many lemons will you need?");
            lemonCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-How many spoons of sugar would you like to use?");
            sugarCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-How many cubes of ice will you need?");
            iceCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-How many cups do you need?");
            cupCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-How much will you charge per cup?");
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


        //public void CreatePitcherOfLemonade()
        //{
        //    pitcherCount = double.Parse(Console.ReadLine());
        //    lemonade = new Pitcher();
        //    lemonade.price = totalPrice;
        //}       

        public string GetPitcherAmount()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\n* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * "
                + " * * * * * * * * * * *");
            Console.ResetColor();
            Console.WriteLine("\nGrandma would be proud. \n\nHow many pitchers would you like to make? \n\nA. [3] \nB. [6] \nC. [9] \nX. [RESTART]\n");
            string amount = Console.ReadLine().ToUpper();
            return amount;
        }

        public void PitcherAmount(string amount)
        {
            switch (amount)
            {
                case "A":
                    Console.WriteLine("3 pitchers of Lemonade costs $3.45, giving you a total of 30 cups.\n");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Wallet Status = $16.55");
                    Console.ResetColor();
                    break;
                case "B":
                    Console.WriteLine("6 pitchers of Lemonade costs $6.90, giving you a total of 60 cups.\n");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Wallet Status = $13.10");
                    Console.ResetColor();
                    break;
                case "C":
                    Console.WriteLine("9 pitchers of Lemonade costs $10.35, giving you a total of 90 cups.\n");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Wallet Status = $9.65");
                    Console.ResetColor();
                    break;
                case "X":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\n*** YOU'VE REQUESTED TO RESTART. PLEASE TRY AGAIN. ***\n");
                    Console.ResetColor();
                    Console.ReadLine();
                    GetPitcherAmount();
                    break;

            }
            
        }



    }
}
