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
                Convert.ToInt32(userinput);
                return true;
            }
            catch (FormatException e)
            {
                return false;
            }
        }
        public string ConvertToCelcius(int userTemperature)
        {
            int celciusValue = (userTemperature - 32) * 5 / 9;
            return celciusValue.ToString();
        }
    }
}
