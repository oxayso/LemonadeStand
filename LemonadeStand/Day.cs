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
        //public Day currentDay;

        public Day()
        {
            weather = new Weather();
        }

        public string currentDay;


        public void DisplayCurrentWeather()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nWEATHER REPORT\n");
            Console.ResetColor();
            Console.WriteLine($"The weather today is: {weather.weatherCondition}.");
        }

        public void DisplayPredictedWeather()
        {
            Console.WriteLine($"\n\nThe predicted weather for tomorrow is: {weather.predictedWeather}.");

        }
        public void GenerateCurrentDay()
        {
            List<int> days = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int currentDay in days)
            {
                Console.WriteLine(currentDay);
            }
        }

        public void DisplayCurrentDay()
        {
            Console.WriteLine($"Today is day:{currentDay}");
        }

    }
}
