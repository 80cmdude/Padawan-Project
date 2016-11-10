using System;
using System.Collections.Generic;
using System.Linq;

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
                if (convertedValue.Text != null)
                {
                    string finalConvertedValue = Math.Round((Convert.ToDecimal(GBP.Text) * result[currencyValue]), 2).ToString();
                    convertedValue.Text = finalConvertedValue;
                }
                ExchangeRate.Text = exchangeRate;
            };
        }

        public void ConvertCurrency()
        {
            var currencies = Queries.GetItems();
            Dictionary<string, decimal> result = currencies.ToDictionary(x => x.Currency, x => x.ConversionRate);

            if (CurrencyPicker.SelectedIndex == -1)
            {
                Alerts.InvalidInput(messageToUser:"Please Choose an Exchange Rate");
            }
            else
            {
                string currencyValue = CurrencyPicker.Items[CurrencyPicker.SelectedIndex];
                string finalConvertedValue = Math.Round((Convert.ToDecimal(GBP.Text) * result[currencyValue]), 2).ToString();
                convertedValue.Text = finalConvertedValue;
            }
            
        }
    }
    
}
