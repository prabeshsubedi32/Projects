using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast.DataRepository
{
    public class CityDataRepository
    {
        //Create a list data to set the location
        public List<LocationData> GetLocation()
        {
            int i = 0;
            List<LocationData> list = new List<LocationData>()
            {
                new LocationData{ID = ++i, CityName = "Marlboro",StateCode="MA",ZipCode="01752"},
                new LocationData{ID = ++i, CityName = "San Diego", StateCode = "CA",ZipCode="92112"},
                new LocationData{ID = ++i, CityName = "Cheyenne", StateCode = "WY",ZipCode="82001"},
                new LocationData{ID = ++i, CityName = "Anchorage", StateCode = "AK",ZipCode="99577"},
                new LocationData{ID = ++i, CityName = "Austin", StateCode = "TX",ZipCode="78759"},
                new LocationData{ID = ++i, CityName = "Orlando", StateCode = "FL",ZipCode="32801"},
                new LocationData{ID = ++i, CityName = "Seattle", StateCode = "WA",ZipCode="98104"},
                new LocationData{ID = ++i, CityName = "Cleveland", StateCode = "OH",ZipCode="44106"},
                new LocationData{ID = ++i, CityName = "Portland", StateCode = "ME",ZipCode="04101"},
                new LocationData{ID = ++i, CityName = "Honolulu",StateCode = "HI",ZipCode="96815"}
            };
            return list;
        }
    }
}
