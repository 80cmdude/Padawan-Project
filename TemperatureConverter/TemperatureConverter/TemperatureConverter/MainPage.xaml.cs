using System;
using Xamarin.Forms;

namespace TemperatureConverter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void ConvertTemperature(object sender, EventArgs e)
        {
            Converter ConvertTemp = new Converter();

            bool convertedSuccessfully = ConvertTemp.GetUserInput(txtTemperatureEntry.Text);

            if (convertedSuccessfully)
            {
                int userTemperature = Convert.ToInt32(txtTemperatureEntry.Text);
                string convertedTemperature = ConvertTemp.ConvertToCelcius(userTemperature);
                txtConvertedTemperature.Text = convertedTemperature + " C";
            }
            else
            {
                txtConvertedTemperature.Text = "Please enter a number";
            }
        }
    }
}
