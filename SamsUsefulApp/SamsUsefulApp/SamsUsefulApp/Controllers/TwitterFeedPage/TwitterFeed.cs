using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;

namespace SamsUsefulApp.Controllers
{
    public class TwitterFeed : Constants
    {
        public void Authenticate()
        {
            Auth.SetUserCredentials(_consumerKey, _consumerSecret, _token, _tokenSecret);
        }
    }
}
