using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.RunGame();
            //Store store = new Store();
            //Ingredient ingredient = new Ingredient();
            //store.AddIngredient(ingredient);
            //Vendor vendor = new Vendor();
            //Ingredient lemonade = vendor.MakeLemonade();
            //store.inventory.ingredient.Add(ingredient);
            Console.ReadLine();           
        }
    }
}
