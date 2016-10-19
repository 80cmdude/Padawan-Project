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
            Converter ConvertTemp = new Converter(); // Create new instance of the converter page.

            bool convertedSuccessfully = ConvertTemp.GetUserInput(txtTemperatureEntry.Text); // Check the user has entered a valid string

            var convertedTo = ConvertTo.SelectedIndex; // Get the value of picker TO
            var convertedFrom = ConvertFrom.SelectedIndex;// get the value of picker FROM

            if (convertedSuccessfully)
            {
                decimal userTemperature = Convert.ToDecimal(txtTemperatureEntry.Text); // Convert user entry to int
                if (convertedFrom == 0 && convertedTo == 1)// celcius to farenheit
                {
                    string convertedTemperature = ConvertTemp.CelciusToFarenheit(userTemperature);
                    txtConvertedTemperature.Text = convertedTemperature + " F";
                }
                else if (convertedFrom == 1 && convertedTo == 0) //Farenheit to celcius
                {
                    string convertedTemperature = ConvertTemp.FarenheitToCelcius(userTemperature);
                    txtConvertedTemperature.Text = convertedTemperature + " C";
                }
                else if(convertedFrom == 0 && convertedTo == 2)//Celcius to Kelvin
                {
                    string convertedTemperature = ConvertTemp.CelciusToKelvin(userTemperature);
                    txtConvertedTemperature.Text = convertedTemperature + " K";
                }
                else if (convertedFrom == 2 && convertedTo == 0)// Kelvin to celcius
                {
                    string convertedTemperature = ConvertTemp.KelvinToCelcius(userTemperature);
                    txtConvertedTemperature.Text = convertedTemperature + " C";
                }
                else if (convertedFrom == 1 && convertedTo == 2)// Farenheit to Kelvin
                {
                    string convertedTemperature = ConvertTemp.FarenheitToKelvin(userTemperature);
                    txtConvertedTemperature.Text = convertedTemperature + " K";
                }
                else if (convertedFrom == 2 && convertedTo == 1)// Kelcin to Farenheit
                {
                    string convertedTemperature = ConvertTemp.KelvinToFarenheit(userTemperature);
                    txtConvertedTemperature.Text = convertedTemperature + " F";
                }
                else if (convertedFrom == convertedTo) // are the same
                {
                    txtConvertedTemperature.Text = userTemperature.ToString(); 
                }
                else
                {
                    txtConvertedTemperature.Text = "Choose a convert type";
                }
            }
            else
            {
                txtConvertedTemperature.Text = "Please enter a number";
            }
        }
    }
}
