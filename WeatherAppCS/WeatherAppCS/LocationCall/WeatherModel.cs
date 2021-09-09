using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace WeatherAppCS
{
    public class WeatherModel
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Localtime { get; set; }

        public string last_updated { get; set; }
        public double temp_c { get; set; }
        public int is_day { get; set; }
        public double wind_kph { get; set; }
    }


}

