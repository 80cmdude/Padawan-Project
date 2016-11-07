using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamsUsefulApp.Controllers;

using Xamarin.Forms;
using Tweetinvi;
using Tweetinvi.Models;

namespace SamsUsefulApp.Views
{
    public partial class TwitterFeedPage : ContentPage
    {
        TwitterFeed Feed = new TwitterFeed();
        public TwitterFeedPage()
        {
            InitializeComponent();

            GetLastTweet();
        }

        public async void GetLastTweet()
        {
            Feed.Authenticate();
            var userTweets = Timeline.GetUserTimeline("tomopagu", 30);
            var tweets = userTweets as ITweet[] ?? userTweets.ToArray();

            List<string> userTimeline = new List<string>();

            foreach (var tweet in tweets)
            {
                var currentTweet = tweet.Text;
                userTimeline.Add(currentTweet);
            }

            string allTweets = string.Join("\r\n\r\n", userTimeline);
            firstTweet.Text = allTweets;
        }
    }
}
