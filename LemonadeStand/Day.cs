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
        public Day currentDay;

        public Day()
        {
            weather = new Weather();
        }

        //public string currentDay;


        public void DisplayCurrentWeather()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nDAILY WEATHER REPORT\n");
            Console.ResetColor();
            Console.WriteLine($"The weather today is: {weather.weatherCondition}");
        }

        public void DisplayPredictedWeather()
        {
            Console.WriteLine($"\n\nThe predicted weather for tomorrow is: {weather.predictedWeather}");

        }

        public void GetCurrentDay()
        {
            for (int d = 0; d < 7; d++)
            {
                if (d == 1)
                {
                    Console.WriteLine("Monday");
                }
            }
        }

        public void DisplayCurrentDay()
        {
            Console.WriteLine($"Today is day: # 1");
        }

    }
}
