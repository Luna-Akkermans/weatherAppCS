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
    public partial class Form1 : Form
    {

    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ResultPanel.Visible = false;
        }

        
        private async void GetLocationData()
        {
            var locationInfo = await LocationProcessor.LoadLocation(UserInputTextBox.Text);
            CityPlaceHolder.Text = locationInfo.Name;
            CountryPlaceholder.Text = locationInfo.Country;

            
        }



        private void BTNuserInput_Click(object sender, EventArgs e)
        {
            //Check if the user has entered any data.
            if (!String.IsNullOrEmpty(UserInputTextBox.Text))
            {
                //Go to next panel.
                ResultPanel.Visible = true;
                UserInputPanel.Visible = false;

                //Load location data
                GetLocationData();


            }
            //Show error
            else
            {
                MessageBox.Show("Make sure you have filled the input correctly.");
            }


        }

        private void BTN_back_Click(object sender, EventArgs e)
        {
            
            ResultPanel.Visible = false;
            UserInputPanel.Visible = true;
        }


    }
}
