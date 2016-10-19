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
                if (convertedFrom == 0 && convertedTo == 1)// celsius to farenheit
                {
                    string convertedTemperature = ConvertTemp.CelsiusToFarenheit(userTemperature);
                    txtConvertedTemperature.Text = convertedTemperature + " ºF";
                }
                else if (convertedFrom == 1 && convertedTo == 0) //Farenheit to celsius
                {
                    string convertedTemperature = ConvertTemp.FarenheitToCelsius(userTemperature);
                    txtConvertedTemperature.Text = convertedTemperature + " ºC";
                }
                else if(convertedFrom == 0 && convertedTo == 2)//Celsius to Kelvin
                {
                    string convertedTemperature = ConvertTemp.CelsiusToKelvin(userTemperature);
                    txtConvertedTemperature.Text = convertedTemperature + " K";
                }
                else if (convertedFrom == 2 && convertedTo == 0)// Kelvin to celsius
                {
                    string convertedTemperature = ConvertTemp.KelvinToCelsius(userTemperature);
                    txtConvertedTemperature.Text = convertedTemperature + " ºC";
                }
                else if (convertedFrom == 1 && convertedTo == 2)// Farenheit to Kelvin
                {
                    string convertedTemperature = ConvertTemp.FarenheitToKelvin(userTemperature);
                    txtConvertedTemperature.Text = convertedTemperature + " K";
                }
                else if (convertedFrom == 2 && convertedTo == 1)// Kelcin to Farenheit
                {
                    string convertedTemperature = ConvertTemp.KelvinToFarenheit(userTemperature);
                    txtConvertedTemperature.Text = convertedTemperature + " ºF";
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
