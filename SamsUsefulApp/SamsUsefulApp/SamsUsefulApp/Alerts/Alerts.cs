using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SamsUsefulApp
{
    public static class Alerts
    {
        public static void InvalidInput(string title = "Warning", string messageToUser = "Invalid Operation!", string dismissText = "OK")
        {
            ContentPage Content = new ContentPage();
            Content.DisplayAlert(title, messageToUser, dismissText);
        }
    }
}
