using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{   
    
    [JsonObject]
    public class WeatherDataProperties
    {
        public List<TemperatureData> list { get; set; } = new List<TemperatureData>();
    }

    public class TemperatureData
    {
        public Temperature main { get; set; }
        public List<CurrentWeather> weather { get; set; } = new List<CurrentWeather>();
        public string dt_txt { get; set; }
    }

    public class Temperature
    {
        public double temp_min { get; set; }
        public double temp_max { get; set; }
    }

    public class CurrentWeather
    {
        public string main { get; set; }
    }
}
