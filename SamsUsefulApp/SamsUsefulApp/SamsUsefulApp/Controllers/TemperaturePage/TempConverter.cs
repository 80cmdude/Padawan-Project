using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamsUsefulApp.Controllers
{
    public class TempConverter
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
            return Math.Round(celciusValue,2).ToString();
        }

        public string FarenheitToCelsius(decimal userTemperature)
        {
            decimal fareheitValue = (userTemperature - 32) / (decimal)1.8;
            return Math.Round(fareheitValue,2).ToString();
        }

        public string CelsiusToKelvin(decimal userTemperature)
        {
            decimal kelvinValue = userTemperature + 273;
            return Math.Round(kelvinValue,2).ToString();
        }

        public string KelvinToCelsius(decimal userTemperature)
        {
            decimal celciusValue = userTemperature - 273;
            return Math.Round(celciusValue,2).ToString();
        }

        public string FarenheitToKelvin(decimal userTemperature)
        {
            decimal kelvinValue = ((userTemperature - 32) / (decimal)1.8) + 273;
            return Math.Round(kelvinValue,2).ToString();
        }

        public string KelvinToFarenheit(decimal userTemperature)
        {
            decimal farenheitValue = ((userTemperature - 273) * (decimal)1.8) + 32;
            return Math.Round(farenheitValue,2).ToString();
        }
    }
}
