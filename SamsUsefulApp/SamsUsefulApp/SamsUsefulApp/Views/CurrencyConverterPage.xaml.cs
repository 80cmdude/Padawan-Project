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

            Label currencyConverter = new Label
            {
                Text = "Currency Converter"
            };
            Label ExchangeRate = new Label
            {
                Text = ""
            };

            Label convertedValue = new Label
            {
                Text = ""
            };

            Entry GBP = new Entry
            {
                Keyboard = Keyboard.Numeric
            };

            Picker picker = new Picker
            {
                Title = "Currency"
            };

            foreach (string currencyValues in result.Keys)
            {
                picker.Items.Add(currencyValues);
            }

            this.Content = new StackLayout
            {
                Children =
                {
                    currencyConverter,
                    GBP,
                    picker,
                    ExchangeRate,
                    convertedValue
                }
            };

            picker.SelectedIndexChanged += (sender, args) =>
            {
                string currencyValue = picker.Items[picker.SelectedIndex];
                string exchangeRate = result[currencyValue].ToString();
                ExchangeRate.Text = exchangeRate;

                string finalConvertedValue = (Convert.ToDecimal(GBP.Text) * result[currencyValue]).ToString();
                convertedValue.Text = finalConvertedValue;
            };

            CurrencyPicker.SelectedIndex
        }
    }
    
}
