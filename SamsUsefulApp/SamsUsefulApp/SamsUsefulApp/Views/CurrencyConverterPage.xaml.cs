using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamsUsefulApp.Controllers;
using Newtonsoft.Json;

using Xamarin.Forms;

namespace SamsUsefulApp.Views
{
    public partial class CurrencyConverterPage : ContentPage
    {
        CurrencyConverter Converter = new CurrencyConverter();
        CurrencyObject ConvertedCurrencyObject = new CurrencyObject();

        public CurrencyConverterPage()
        {
            InitializeComponent();

            Converter.GetCurrencyValues();
        }
    }
}
