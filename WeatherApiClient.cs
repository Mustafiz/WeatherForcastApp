using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace WeatherForcastApp
{
    class WeatherApiClient
    {
        private const string baseUrl = "http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&mode=json&units=metric&cnt={1}";

        public WeatherData GetWeatherForcast(string city, int numberOfDays)
        {
            string url = string.Format(baseUrl, city, numberOfDays);
            WebClient aWebClient = new WebClient();
            string content = aWebClient.DownloadString(url);
            WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(content);
            return weatherData;
        }
    }
}
