using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using SamsUsefulApp.Models;
using SamsUsefulApp.data;

namespace SamsUsefulApp.Controllers
{
    public class GiphyApi
    {
        public async void GetRandomGif()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://api.giphy.com/v1/gifs/random");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string result = null;
            HttpResponseMessage response = await client.GetAsync("?api_key=dc6zaTOxFJmzC");
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadAsStringAsync();
            }

            Gif gif = JsonConvert.DeserializeObject<Gif>(result);

            foreach (var g in gif.data)
            {
                Queries.InsertGifSource(new GifSource { Type = g.Key, Source = g.Value });
            }
        }
    }
}
