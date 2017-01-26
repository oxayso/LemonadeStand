using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Weather
    {
        public string weatherCondition;
        public void GenerateRandomWeather()
        {
            Random random = new Random();
            string[] weather = { "Sunny, High 80's", "Cloudy with a chance of meatballs", "Rain and Thunder", "Foggy Conditions", "Hot and Humid", "Partial Sunshine", "Cold with thickening clouds" };
            weatherCondition = weather[(random.Next(0, weather.Length))];
        }



    }
}
