﻿using System;
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
        public void GenerateRandomWeather() // SOLID DESIGN PRNCPLE S: SINGLE RESPONSIBILITY
        {
            Random random = new Random();
            string[] weather = { "Sunny, High 80's. Perfect day for business!", "Cloudy with a chance of meatballs. :(", "High 80's, Abundant Sunshine.", "73 degrees, Sunshine & Comfortable.", "60 degrees & Sunny. Expected wind chills tonight.", "67 degrees, Partial Sunshine.", "Rain with thickening clouds... oh no!" };
            weatherCondition = weather[(random.Next(0, weather.Length))];
        }

            public void GeneratePredictedWeather()
        {
            Random random = new Random();
            string[] weather = { "Sunny, Expected wind chills in the evening.", "70 degrees, Possibility for a little afternoon rain.", "High 70's, Fluffy clouds & Sun.", "Low 70's, Humid.", "77 degrees, Mostly Sunny with clear skies.", "75 degrees, ", "A full day of Sunshine." };
            predictedWeather = weather[(random.Next(0, weather.Length))];
        }
    }
}
