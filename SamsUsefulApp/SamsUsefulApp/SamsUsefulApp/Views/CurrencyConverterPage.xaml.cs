using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamsUsefulApp.Controllers;
using Newtonsoft.Json;

using Xamarin.Forms;
using SamsUsefulApp.data;

namespace SamsUsefulApp.Views
{
    public partial class CurrencyConverterPage : ContentPage
    {
        public CurrencyConverterPage()
        {
            InitializeComponent();

            var currencies = Queries.GetItems();
            Dictionary<string, decimal> result = currencies.ToDictionary(x => x.Currency, x => x.ConversionRate);
            

            foreach (string currencyvalues in result.Keys)
            {
                CurrencyPicker.Items.Add(currencyvalues);
            }

            CurrencyPicker.SelectedIndexChanged += (sender, args) =>
            {
                string currencyValue = CurrencyPicker.Items[CurrencyPicker.SelectedIndex];
                string exchangeRate = result[currencyValue].ToString();
                ExchangeRate.Text = exchangeRate;

                string finalConvertedValue = (Convert.ToDecimal(GBP.Text) * result[currencyValue]).ToString();
                convertedValue.Text = finalConvertedValue;
            };
        }
    }
    
}
