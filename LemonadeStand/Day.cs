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

        public void DisplayCurrentWeather()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nDAILY WEATHER REPORT\n");
            Console.ResetColor();
            Console.WriteLine($"The weather today is: {weather.weatherCondition}");
            Console.WriteLine($"\nGiven, the price for lemonade today is: {weather.lemonadePrice}");

        }

        public void DisplayPredictedWeather()
        {
            Console.WriteLine($"\n\nThe predicted weather for tomorrow is: {weather.predictedWeather}");

        }

        public void DisplayCurrentDay()
        {
            for (int i = 1; i < 8; i++)
            {
                if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("CURRENT DAY\n");
                    Console.ResetColor();
                    Console.WriteLine($"Today is: Monday");
                    break;
                }
                if (i == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("CURRENT DAY\n");
                    Console.ResetColor();
                    Console.WriteLine("Today is: Tuesday");
                    break;
                }
                if (i == 3)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("CURRENT DAY\n");
                    Console.ResetColor();
                    Console.WriteLine("Today is: Wednesday");
                    break;
                }
                if (i == 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("CURRENT DAY\n");
                    Console.ResetColor();
                    Console.WriteLine("Today is: Thursday");
                    break;
                }
                if (i == 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("CURRENT DAY\n");
                    Console.ResetColor();
                    Console.WriteLine("Today is: Friday");
                    break;
                }
                if (i == 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("CURRENT DAY\n");
                    Console.ResetColor();
                    Console.WriteLine("Today is: Saturday");
                    break;
                }
                else if (i == 7)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("CURRENT DAY\n");
                    Console.ResetColor();
                    Console.WriteLine("Today is: Sunday");
                    break;
                }
            }
        }
    }
}
