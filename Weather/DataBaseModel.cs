using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class DataBaseModel
    {
        public static string GetDataBasePath()
        {
            var location = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
            var result = new FileInfo(location.AbsolutePath).Directory;
            return Path.Combine(result.FullName, "Weather.db");
        }
        public static bool ExistenceOfDatabase()
        {
            string path = GetDataBasePath();
            if (File.Exists(path))
            {
                return true;
            }
            return false;
        }
        public static SqliteConnection ConectionToDataBase()
        {        
                string path = GetDataBasePath();
                SqliteConnection connection;
                connection = new SqliteConnection($"Data Source={path}");
                connection.Open();                     
                return connection;           
        }     
        public static List<StoryWeatherTemplate> GetWeatherArchiveFromDB(string citisname)
        {
            List<StoryWeatherTemplate> storyweathers = new List<StoryWeatherTemplate>();
            if (citisname == "")
            {
                return storyweathers;
            }
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            string nameofcity = myTI.ToTitleCase(citisname);
            using (SqliteCommand command = new SqliteCommand())
            {
                using (SqliteConnection connection = ConectionToDataBase())
                {                 
                    command.Connection = connection;
                    command.CommandText = $"SELECT id,time,temperature,city FROM weather WHERE city = '{nameofcity}' ";
                    using (SqliteDataReader sqliteDataReader = command.ExecuteReader())
                    {
                        while (sqliteDataReader.Read())
                        {
                            StoryWeatherTemplate story = new StoryWeatherTemplate();
                            story.id = sqliteDataReader.GetInt32(0);
                            story.name = sqliteDataReader.GetString(3);
                            story.temperature = sqliteDataReader.GetString(2);
                            var time = sqliteDataReader.GetValue(1);
                            story.time = Convert.ToDateTime(time);
                            storyweathers.Add(story);
                        }
                    }
                }
            }
            return storyweathers;
        }
        public static int GetCityId(WeatherField cityobj)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            string nameofcity = myTI.ToTitleCase(cityobj._citiesname.ToString());
            string countrycity = cityobj._countriesname.ToString().ToUpper();         
            using (var connection = ConectionToDataBase())
            {
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = $"SELECT id FROM cities WHERE name = '{nameofcity}' AND country = '{countrycity}'  ";
                object id1 = command.ExecuteScalar();
                int id2 = Convert.ToInt32(id1);
                return id2;
            }
        }
        public static void InsertToDataBase(DateTime Day, RootObject weathers)
        {          
            string todatabase = $"INSERT INTO weather (time,temperature,city) VALUES ('{Day}','{weathers.main.temp}','{weathers.name}')";
            using (var connection = ConectionToDataBase())
            {             
                SqliteCommand command = new SqliteCommand();
                command.Connection = connection;
                command.CommandText = todatabase;
                command.ExecuteNonQuery();
            }
        }


    }
}
