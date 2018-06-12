using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    public class AverageTemperatureCalculationProperties
    {
        public double AverageTemperature { get; set; }
        public DateTime Date { get; set; }
        public bool RainCheck { get; set; }
    }
}
