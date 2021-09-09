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
    public class WeatherProcessor
    {
        public static async Task<ApiResultModel> LoadLocation(string city)
        {
            string url = $"http://api.weatherapi.com/v1/current.json?key=c70a004070bf4ddb87793146210609&q={city}&aqi=no";

            using (HttpResponseMessage respone = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (respone.IsSuccessStatusCode)
                {



                    ApiResultModel DataSet = await respone.Content.ReadAsAsync<ApiResultModel>();
                       
                    return new ApiResultModel
                    {
                        Location = DataSet.Location,
                        Current = DataSet.Current,
                    };
               }
                else
                {
                    throw new Exception(respone.ReasonPhrase);
                }
            }
        }
    }
}
