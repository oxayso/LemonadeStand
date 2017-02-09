using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Pitcher
    {
        public int lemonCount;
        public int sugarCount;
        public int iceCount;
        public int cupCount;
        public double totalPrice;

        public Pitcher(int lemonCount, int sugarCount, int iceCount, int cupCount)
        {
            this.lemonCount = lemonCount;
            this.sugarCount = sugarCount;
            this.iceCount = iceCount;
            this.cupCount = cupCount;

        }
        //public double price = 4 * 0.05 + 5 * 0.03 + 30 * 0.01 + 10 * 0.05;
        //public double lemonCount = 4;
        //public double sugarCount = 5;
        //public double iceCount = 30;
        //public double cupCount = 10;


    }

}


