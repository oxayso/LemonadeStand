using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public Weather weather;

        public Day day;

        public Day()
        {
            weather = new Weather();
        }
        public void DisplayCurrentWeather()
        {
            Console.WriteLine($"The weather today is: {weather.weatherCondition}.");
        }

        //public void GetCurrentDay()
        //{
        //    for (int i = 0; i < 7; i++)
        //    {
                
        //    }
        //}
        //public void DisplayCurrentDay()
        //{
        //    Console.WriteLine("Today is day: ");
        //}
      
    }
}
