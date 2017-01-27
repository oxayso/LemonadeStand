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

        public Store()
        {
            inventory = new Inventory(); 
        }

        public void AddIngredient(Ingredient ingredient)
        {
            inventory.ingredient.Add(ingredient);
        }

        public void RemoveIngredient(Ingredient ingredient)
        {
            inventory.ingredient.Remove(ingredient);
        }
    }
}
