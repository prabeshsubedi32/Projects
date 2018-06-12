using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecast.DataRepository;
using WeatherForecast.Services;

namespace WeatherForecast
{
    public class Program
    {
        public static void Main(string[] args)
        {
            APIClient apiClient = new APIClient();
            CityDataRepository LocationData = new CityDataRepository();

            foreach (var items in LocationData.GetLocation())
            {

                var CityAverageWeatherData = apiClient.GetLocation(items.ZipCode).Result;
                Console.WriteLine("__________________________________________");
                Console.WriteLine(items.CityName + ", " + items.StateCode + "\t(" + items.ZipCode + ")\n");
                Console.WriteLine("Date\t\tAvg. Temp (F)");
                Console.WriteLine("------------------------------------------");
                foreach (var data in CityAverageWeatherData)
                {
                    Console.WriteLine("{0}{1}\t{2} F", data.Date.ToString("MM/dd/yyyy"),(data.RainCheck)?"*":"", ((1.8 * (data.AverageTemperature - 273)) + 32).ToString("0.00"));
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
