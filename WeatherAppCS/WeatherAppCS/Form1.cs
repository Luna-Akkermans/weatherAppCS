using System;
using System.Windows.Forms;

namespace WeatherAppCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ResultPanel.Visible = false;
        }

        private void BTNuserInput_Click(object sender, EventArgs e)
        {
            ResultPanel.Visible = true;
            UserInputPanel.Visible = false;
        }

        private void BTN_back_Click(object sender, EventArgs e)
        {
            ResultPanel.Visible = false;
            UserInputPanel.Visible = true;
        }

        private void UserInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
