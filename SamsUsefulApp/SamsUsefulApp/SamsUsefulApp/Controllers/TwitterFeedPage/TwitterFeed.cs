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
    public class TwitterFeed
    {
        private string _consumerKey = "rOmSJLYQL1XQQzuK3JS8nO3hA";
        private string _consumerSecret = "4CjdOb6CPmn8PnEXHLDPn2NoFeFs5D0Tt6bmnschlHK4tJ8nPd";
        private string _token = "277665844-mDbdcV3zeGPuPQWFAQdjYi4AmzpyLNN2W92hN3hX";
        private string _tokenSecret = "ggjU7GkQ0n0N46MKW5JjZnv1KEEGnRSWA5atASQQnwhVb";

        public void Authenticate()
        {
            Auth.SetUserCredentials(_consumerKey, _consumerSecret, _token, _tokenSecret);
        }
    }
}
