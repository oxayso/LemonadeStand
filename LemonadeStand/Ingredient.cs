using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Ingredient
    {
        public int Lemon;
        public int Sugar;
        public int Ice;
        public int Cups;
        public double price;

        public Ingredient(int Lemon, int Sugar, int Ice, int Cups, double price)
        {
            this.Lemon = Lemon;
            this.Sugar = Sugar;
            this.Ice = Ice;
            this.Cups = Cups;
            this.price = price;
        }

        public Ingredient()
        {

        }
    }


}
