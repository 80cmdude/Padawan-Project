using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SamsUsefulApp.Models;
using SamsUsefulApp.data;
using Xamarin.Forms;

namespace SamsUsefulApp.Controllers
{
    public class CurrencyConverter
    {
        public async void GetCurrencyValues()
        {
            HttpClient client = new HttpClient();
            
            client.BaseAddress = new Uri("http://api.fixer.io/latest");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string result = null;
            HttpResponseMessage response = await client.GetAsync("?base=GBP");
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
            }

            CurrencyObject CurrentCurrency = JsonConvert.DeserializeObject<CurrencyObject>(result);
            foreach (var r in CurrentCurrency.rates)
               {
                    Queries.InsertRate(new Rate { Currency = r.Key, ConversionRate = r.Value });
               }
        }
    }
}
