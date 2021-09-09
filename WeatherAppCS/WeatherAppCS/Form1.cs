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

        
        private async void GetData()
        {
            var dataInformation = await WeatherProcessor.LoadLocation(UserInputTextBox.Text);
            LocationPlaceHolder.Text = $"{dataInformation.Location.Name}, {dataInformation.Location.Country}";
            ConditionPlaceholder.Text = $"{ dataInformation.Location.temp_c} {System.Environment.NewLine} test";



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
                GetData();


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

        private void CityPlaceHolder_Click(object sender, EventArgs e)
        {

        }

        private void ExtraAddition_Click(object sender, EventArgs e)
        {

        }
    }
}
