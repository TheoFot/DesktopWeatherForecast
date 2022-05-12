using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    internal static class Program
    {

        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DataBaseModel.ConectionToDataBase();

            Application.Run(new WeatherForecast());



        }
          
    }
}
