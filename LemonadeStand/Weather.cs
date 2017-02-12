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
        public string predictedWeather;

        public void GenerateRandomWeather() 
        {
            Random random = new Random();
            string[] weather = { "Sunny, High 80's. Perfect day for business!", "Cloudy with peaks of sunshine.", "High 80's, Abundant Sunshine.", "73 degrees, Sunshine & Comfortable.", "60 degrees & Sunny. Expected to be chilly tonight.", "67 degrees, Partial Sunshine.", "Light showers, Humid." };
            weatherCondition = weather[(random.Next(0, weather.Length))];
        }

        public void GeneratePredictedWeather()
        {
            Random random = new Random();
            string[] weather = { "Sunny, Expected winds of humidity in the evening.", "70 degrees, Possibility for afternoon showers.", "High 70's, Fluffy clouds & Sunshine.", "Low 70's, Humid.", "77 degrees, Mostly Sunny with clear skies.", "75 degrees, Hot & Dry", "A full day of Sunshine." };
            predictedWeather = weather[(random.Next(0, weather.Length))];
        }
    }
}
