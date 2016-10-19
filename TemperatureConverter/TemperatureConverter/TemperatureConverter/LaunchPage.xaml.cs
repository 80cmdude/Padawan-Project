using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TemperatureConverter
{
    public partial class LaunchPage : ContentPage
    {
        public LaunchPage()
        {
            InitializeComponent();
        }

        async void NavigatePageTempConverter(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        async void NavigatePageDiceRoll(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DiceRollPage());
        }
    }
}
