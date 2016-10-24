using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamsUsefulApp.Controllers;

using Xamarin.Forms;

namespace SamsUsefulApp.Views
{
    public partial class CurrencyConverterPage : ContentPage
    {
        CurrencyConverter Converter = new CurrencyConverter();

        public CurrencyConverterPage()
        {
            InitializeComponent();

            Converter.GetCurrencyValues();
        }
    }
}
