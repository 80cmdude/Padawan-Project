using SamsUsefulApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamsUsefulApp.data
{
    public static class Queries
    {

        public static IEnumerable<Rate> GetItems()
        {
            return (from i in App.DatabaseConnection.Table<Rate>() select i).ToList();
        }
        public static void InsertRate(Rate r)
        {
            App.DatabaseConnection.Insert(r);
        }
        public static void InsertAllRate(List<Rate> r)
        {
            App.DatabaseConnection.InsertAll(r);
        }
        public static Rate GetItem(string currency)
        {
            return App.DatabaseConnection.Table<Rate>().FirstOrDefault(x => x.Currency == currency);
        }
        public static int DeleteItem(Rate r)
        {
            return App.DatabaseConnection.Delete(r);
        }
        public static void DropTable()
        {
            App.DatabaseConnection.DropTable<Rate>();
        }
    }
}
