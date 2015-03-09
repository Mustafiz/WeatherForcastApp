using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForcastApp
{
    public class WeatherData
    {
        public string Cod { set; get; }
        public double Message { set; get; }
        public City City { set; get; }
        public int Cnt { set; get; }
        public List<List> List { set; get; }
    }

    public class City
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public Coord Coord { set; get; }
        public string Country { set; get; }
        public int Population { set; get; }
    }
    public class List
    {
        public int Dt { set; get; }
        public Temp Temp { set; get; }
        public double Pressure { set; get; }
        public int Humidity { set; get; }
        public List<Weather> Weather { set; get; }
        public double Speed { set; get; }
        public int Deg { set; get; }
        public int Clouds { set; get; }
    }

    public class Temp
    {
        public string Day { set; get; }
        public string Min { set; get; }
        public string Max { set; get; }
        public string Night { set; get; }
        public string Eve { set; get; }
        public string Morn { set; get; }
    }

    public class Weather
    {
        public int Id { set; get; }
        public string Main { set; get; }
        public string Description { set; get; }
        public string Icon { set; get; }
    }

    public class Coord
    {
        public double Lon { set; get; }
        public double Lat { set; get; }
    }
}