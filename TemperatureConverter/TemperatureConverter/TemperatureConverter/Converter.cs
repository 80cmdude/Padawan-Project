using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public class Converter
    {

        public bool GetUserInput(string userinput)
        {
            try
            {
                Convert.ToDouble(userinput);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string CelsiusToFarenheit(decimal userTemperature)
        {
            decimal celciusValue = (userTemperature * (decimal)1.8) + 32;
            return celciusValue.ToString();
        }

        public string FarenheitToCelsius(decimal userTemperature)
        {
            decimal fareheitValue = (userTemperature - 32) / (decimal)1.8;
            return fareheitValue.ToString();
        }

        public string CelsiusToKelvin(decimal userTemperature)
        {
            decimal kelvinValue = userTemperature + 273;
            return kelvinValue.ToString();
        }

        public string KelvinToCelsius(decimal userTemperature)
        {
            decimal celciusValue = userTemperature - 273;
            return celciusValue.ToString();
        }

        public string FarenheitToKelvin(decimal userTemperature)
        {
            decimal kelvinValue = ((userTemperature - 32) / (decimal)1.8) + 273;
            return kelvinValue.ToString();
        }

        public string KelvinToFarenheit(decimal userTemperature)
        {
            decimal farenheitValue = ((userTemperature - 273) * (decimal)1.8) + 32;
            return farenheitValue.ToString();
        }
    }
}
