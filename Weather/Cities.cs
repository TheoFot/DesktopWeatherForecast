using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class City
    {
        public float id { get; set; }
        public string name { get; set; }

        public string state { get; set; }

        public string country { get; set; }

        public Coord coord { get; set; }
    }

    public class Coordcity
    {

        public float lon { get; set; }

        public float lat { get; set; }
    }

}
