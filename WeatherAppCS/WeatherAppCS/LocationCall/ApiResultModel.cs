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
    public class ApiResultModel
    {
        public WeatherModel Location { get; set; }
        public CurrentModel Current { get; set; }

        


    }

}