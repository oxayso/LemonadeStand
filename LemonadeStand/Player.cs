using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand 
{
    public class Player
    {
        public string name;
        public int lemonCount;
        public int sugarCount;
        public int iceCount;
        public int cupCount;
        public int removeCupCount;
        public int removeIceCount;
        public int removeSugarCount;
        public int removeLemonCount;
        public Wallet wallet = new Wallet();
        public Inventory inventory = new Inventory();
        
        public virtual void GetPlayerName()
        {
            Console.WriteLine("\nType your name below to start your business! PRESS [ENTER]");
            name = Console.ReadLine();
        }

        public void PrintPlayerName()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{name}, get ready to make some money! ... or prepare to go bankrupt.");
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
            Console.WriteLine("\nWould you like to utilize the 'Perfect Lemonade Recipe' or customize your own? \n\n[Y] YES, "
                +"I want the Perfect Recipe. \n[N] NO, I want to make my own.\n");
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
                    CustomizeLemonade();
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
      
        public Pitcher CustomizeLemonade()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nYou are now customizing your own lemonade recipe.\n");
            Console.ResetColor();
            Console.WriteLine("-How many lemons will you need? 0.05¢ ");
            lemonCount = int.Parse(Console.ReadLine());
            wallet.totalLemonPrice(lemonCount);
            Console.WriteLine("-How many spoons of sugar would you like to use? 0.03¢");
            sugarCount = int.Parse(Console.ReadLine());
            wallet.totalSugarPrice(sugarCount);
            Console.WriteLine("-How many cubes of ice will you need? 0.01¢");
            iceCount = int.Parse(Console.ReadLine());
            wallet.totalIcePrice(iceCount);
            Console.WriteLine("-How many cups do you need? 0.05¢");
            cupCount = int.Parse(Console.ReadLine());
            wallet.toalCupPrice(cupCount);
            Console.WriteLine($"\n{name}'s Recipe:\n\nLemons: {lemonCount} \nSpoons of Sugar: {sugarCount} \nIce Cubes: {iceCount} "
                +$"\nCups: {cupCount} \n");
            Console.WriteLine($"\nCash: ${wallet.money}.00");
            wallet.CalculateExpenses(wallet.money, wallet.lemonsPrice, wallet.sugarsPrice, wallet.icesPrice, wallet.cupsPrice);
            Console.WriteLine($"Total Expense: ${wallet.expense}"); 
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            wallet.UpdateMoney();
            Console.WriteLine($"\nWallet Status = {wallet.moneyStatus}");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress [ENTER] to Continue");
            Console.ResetColor();
            return new Pitcher(lemonCount, sugarCount, iceCount, cupCount);
                  
        }

        public void BuyLemons()
        {
            for (int i = 0; i < lemonCount; i++)
            {
                Lemon lemon = new Lemon();
                inventory.lemon.Add(lemon);
            }
        }

        public void BuySugar()
        {
            for(int i = 0; i < sugarCount; i++)
            {
                Sugar sugar = new Sugar();
                inventory.sugar.Add(sugar);
            }
        }

        public void BuyIce()
        {
            for(int i = 0; i < iceCount; i++)
            {
                Ice ice = new Ice();
                inventory.ice.Add(ice);
            }
        }

        public void BuyCups()
        {
            for(int i = 0; i < cupCount; i++)
            {
                Cup cup = new Cup();
                inventory.cup.Add(cup);
            }
        }

        public void RemoveLemons()
        {
            for(int i = 0; i < removeLemonCount; i++)
            {
                
                inventory.lemon.RemoveAt(i);
            }
        }

        public void RemoveSugar()
        {
            for (int i = 0; i < removeSugarCount; i++)
            {
                inventory.sugar.RemoveAt(i);
            }
        }

        public void RemoveIce()
        {
            for (int i = 0; i < removeIceCount; i++)
            {
                inventory.ice.RemoveAt(i);
            }
        }

        public string GetPitcherAmount()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\n* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * "
                +"* * * * * * * * * * * * * * *");
            Console.ResetColor();
            Console.WriteLine("\nGrandma would be proud. \n\nHow many pitchers would you like to make? Remember, one pitcher "
                +"= 10 cups. \n\nA. [3] \nB. [6] \nC. [9] \nX. [RESTART]\n");
            string amount = Console.ReadLine().ToUpper();
            return amount;
        }

        public void PitcherAmount(string amount)
        {
            switch (amount)
            {
                case "A":
                    Console.WriteLine("\n3 pitchers of Lemonade costs $3.45, giving you a total of 30 cups.\n");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Wallet Status = $16.55");
                    Console.ResetColor();
                    break;
                case "B":
                    Console.WriteLine("\n6 pitchers of Lemonade costs $6.90, giving you a total of 60 cups.\n");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Wallet Status = $13.10");
                    Console.ResetColor();
                    break;
                case "C":
                    Console.WriteLine("\n9 pitchers of Lemonade costs $10.35, giving you a total of 90 cups.\n");
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
