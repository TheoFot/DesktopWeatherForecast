using Microsoft.Data.Sqlite;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal class CityObject
    {      
        public string Request(float id)
        {
            if (id == 0)
            {
                return "No";
            }
            HttpClient client = new HttpClient();
            string apikey = GetKey.GetApiKey();
            HttpResponseMessage requesrresult =  client.GetAsync($"http://api.openweathermap.org/data/2.5/weather?id={id}&units=metric&appid={apikey}").Result;
            string Jsonweather = requesrresult.Content.ReadAsStringAsync().Result;
            return Jsonweather;
        }
        public static List<City> ReadCities(string filepath)
        {
            string jsonString = File.ReadAllText(filepath);
            List<City> weatherForecast =
               System.Text.Json.JsonSerializer.Deserialize<List<City>>(jsonString);
            return weatherForecast;
        }
        public DateTime ConvertFromUnix(int unixTime)
        {
            System.DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            dt = dt.AddSeconds(unixTime).ToLocalTime();
            return dt;
        }
        public string GetWeather(WeatherField citysearch)
        {
            float cityId =DataBaseModel.GetCityId(citysearch);
            string result = Request(cityId);
            
            if (result =="No")
            {
                return "This city does not exist! Try again";
            }
            var weathers = JsonConvert.DeserializeObject<RootObject>(result);
            
            double speedOfWind = weathers.wind.gust * 3.6;
            string Windsspeed = String.Format("{0:f2}", speedOfWind);

            DateTime SunRise = ConvertFromUnix(weathers.sys.sunrise);
            DateTime SunSet = ConvertFromUnix(weathers.sys.sunset);
            DateTime Day = ConvertFromUnix(weathers.dt);
            DataBaseModel.InsertToDataBase(Day,weathers);
            string weather = (" Weather at : " + "\n"
               + " Country : " + weathers.sys.country.ToString() + "\n | " + " City : " + weathers.name + "\n | "
               + " At moment : " + Day + "\n | "
               + " Temperature : " + weathers.main.temp.ToString() + " °C" + "\n | "
               + " speed of wind : " + Windsspeed + " km/h " + "\n | "
               + " Sunrise time : " + SunRise + "\n | "
               + " Sunset time : " + SunSet);
            return weather;
        }
    }
}
