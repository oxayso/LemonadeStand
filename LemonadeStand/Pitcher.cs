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

        //one pitcher = 4 lemons, 5 sugar, 30 ice, = 10 cups

    }

}


