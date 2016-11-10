using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamsUsefulApp.Models
{
    public class CurrencyObject
    {
        public string date { get; set; }
        public Dictionary<string, decimal> rates { get; set; }
    }

    public class Rate
    {
        public string Currency { get;  set;}
        public decimal ConversionRate { get; set; }
    }
}
