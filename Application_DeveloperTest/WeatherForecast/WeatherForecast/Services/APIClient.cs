using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.Services
{
    public class APIClient
    {
        public async Task<List<AverageTemperatureCalculationProperties>> GetLocation(string ZipCode)
        {
            var baseUrl = "http://api.openweathermap.org/";
            string apiID = "23cec8184bb1af7935514df3bb1bbdc7";
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();

                //define request data format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                //checking the response is successful or not which is sent using HttpClient 
                var response = await client.GetStringAsync("data/2.5/forecast?zip=" + ZipCode + ",us&appid=" + apiID);
                var responseData = JsonConvert.DeserializeObject<WeatherDataProperties>(response);

                return UtilCalculation.CalculateAverage(responseData);
            }
        }
    }
}
