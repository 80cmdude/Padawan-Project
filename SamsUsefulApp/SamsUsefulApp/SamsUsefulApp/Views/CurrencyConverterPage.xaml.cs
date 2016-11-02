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

            var test = Queries.GetItems();
        }
    }
    
}
