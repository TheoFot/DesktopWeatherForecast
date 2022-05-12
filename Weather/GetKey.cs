using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
  public class GetKey
    {
        public static string GetKeyPath()
        {
            var location = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
            var result = new FileInfo(location.AbsolutePath).Directory;
            return Path.Combine(result.FullName, "apikey.txt");

        }
        public static string GetApiKey()
        {
            string apikey;
            using (StreamReader stream = new StreamReader(GetKeyPath(), System.Text.Encoding.Default))
            {
                apikey = stream.ReadToEnd();
            }
            return apikey;
        }
    }
}
