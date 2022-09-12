using System;
using Newtonsoft.Json.Linq;

namespace OpenWeatherAPI
{
    public class WeatherMap
    {
        public static double GetTemp(string weatherURL)
        {
            var client = new HttpClient();

            var weatherResponse = client.GetStringAsync(weatherURL).Result;

            var temp = double.Parse(JObject.Parse(weatherResponse)["main"]["temp"].ToString());

             return temp;
        }
    }
}

