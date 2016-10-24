using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamsUsefulApp.Controllers
{
    public class CurrencyObject
    {
        public string date { get; set; }
        public Dictionary<string, decimal> rates { get; set; }
    }
}
