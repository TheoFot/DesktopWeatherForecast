using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class WeatherField : Form
    {
        public string _citiesname;
        public string _countriesname;
        
        public WeatherField(string CityName, string CountriesName)
        {
            _citiesname = CityName;
            _countriesname = CountriesName;
           
        }

        public WeatherField()
        {
            InitializeComponent();
           
            
        }
        

        private void citiesName_TextChanged(object sender, EventArgs e)
        {
            _citiesname = citiesName.Text;
        }

        private void countriesName_TextChanged(object sender, EventArgs e)
        {
            _countriesname = countriesName.Text;
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            Cityobject cityobject = new Cityobject();

            
            WeatherField citysearch = new WeatherField();
            citysearch._citiesname = citiesName.Text;
            citysearch._countriesname = countriesName.Text;
            string weather = cityobject.GetWeather(citysearch);
            if (weather == null)
            {
                theweatherinformation.Text = "This city does not exist! Try again";

            }
            else
            {
                theweatherinformation.Text = weather;
            }
            
        }

        private void theweatherinformation_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            theweatherinformation.Clear();
            countriesName.Clear();
            citiesName.Clear();

        }

       
    }
}
