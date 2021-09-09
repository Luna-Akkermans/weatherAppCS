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


    }
    public class Condition
    {
        public string text { get; set; }
        public string icon { get; set; }
        public int code { get; set; }
    }

    public class CurrentModel
    {
        public string last_updated { get; set; }
        public double temp_c { get; set; }
        public Condition condition { get; set; }
  
    }





}

