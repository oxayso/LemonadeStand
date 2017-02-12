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
        public int currentDay = 0;

        public Day()
        {
            weather = new Weather();
        }

        public void DisplayCurrentWeather()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nDAILY WEATHER REPORT\n");
            Console.ResetColor();
            Console.WriteLine($"The weather today is: {weather.weatherCondition}");
        }

        public void DisplayPredictedWeather()
        {
            Console.WriteLine($"\nThe predicted weather for tomorrow is: {weather.predictedWeather}");
        }

        public int AddDay()
        {
            currentDay += 1;
            return currentDay;
        }

        public void DisplayCurrentDay()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nCURRENT DAY\n");
            Console.ResetColor();
            Console.WriteLine($"Today is: Day #{currentDay}");
        }
    }
}
