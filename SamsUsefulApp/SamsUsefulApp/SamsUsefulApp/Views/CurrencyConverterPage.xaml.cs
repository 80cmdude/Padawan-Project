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
        }

        private void CurrencyPicker()
        {
            var currencies = Queries.GetItems();
            Dictionary<string, decimal> result = currencies.ToDictionary(x => x.Currency, x => x.ConversionRate);

            Picker picker = new Picker
            {
                Title = "Currency"
            };

            foreach (string currencyValues in result.Keys)
            {
                picker.Items.Add(currencyValues);
            }
        }
    }
    
}
