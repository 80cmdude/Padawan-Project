using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SamsUsefulApp.Controllers;
using SamsUsefulApp.data;

using Xamarin.Forms;

namespace SamsUsefulApp.Views
{
    public partial class GiphyPage : ContentPage
    {
        public GiphyPage()
        {
            InitializeComponent();
            
            var Gifs = Queries.GetGifSources();
            Dictionary<string, string> result = Gifs.ToDictionary(x => x.Type, x => x.Source);

            gifView.Source = result["image_url"];
        }
    }
}
