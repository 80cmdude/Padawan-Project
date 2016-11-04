using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace SamsUsefulApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void NavigatePageTempConverter(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TemperaturePage());
        }

        async void NavigatePageDiceRoll(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DiceRollPage());
        }

        async void NavigatePageStopWatchTimer(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StopWatchPage());
        }

        async void NavigatePageCurrencyConverter(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CurrencyConverterPage());
        }

        async void NavigatePageTwitterFeed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TwitterFeedPage());
        }
    }
}
