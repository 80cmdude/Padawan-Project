using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamsUsefulApp.Controllers;

using Xamarin.Forms;

namespace SamsUsefulApp.Views
{
    public partial class TwitterFeedPage : ContentPage
    {
        TwitterFeed Feed = new TwitterFeed();
        public TwitterFeedPage()
        {
            InitializeComponent();

            Feed.GetLastTweet();
        }
    }
}
