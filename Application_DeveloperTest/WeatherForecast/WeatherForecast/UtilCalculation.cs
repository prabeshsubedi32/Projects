using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    public class UtilCalculation
    {
        
        public static List<AverageTemperatureCalculationProperties> CalculateAverage(WeatherDataProperties data)
        {      
            var TempDataCalc = data.list.Select(x => new TemeperatureDataCalculation()
            {
                Date = Convert.ToDateTime(x.dt_txt).Date,
                MaxTemperature = x.main.temp_max,
                MinTemperature = x.main.temp_min,
                CheckForRain = x.weather

            }).ToList();

            var AverageTemperatureCalculation = TempDataCalc.GroupBy(x => x.Date)
                                        .Select(x => new AverageTemperatureCalculationProperties
                                        {
                                            AverageTemperature = (x.Sum(y => y.MinTemperature) + x.Sum(y => y.MaxTemperature)) / (x.Count() * 2),
                                            Date = x.Select(y=>y.Date.Date).FirstOrDefault(),
                                            RainCheck = !x.Select(y=>y.CheckForRain.ToList().Where(z=>z.main==Forecast.Rain.ToString())).ToList().Any()
                                        }).ToList();
            return AverageTemperatureCalculation;
        }

        
        



    }
}
