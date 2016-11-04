using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SamsUsefulApp.Views;
using SamsUsefulApp.Controllers;

using Xamarin.Forms;
using SQLite.Net;
using SamsUsefulApp.Models;
using SamsUsefulApp.data;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SamsUsefulApp
{
    public partial class App : Application
    {
        public static SQLiteConnection DatabaseConnection { get; set; }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());

            CurrencyConverter Converter = new CurrencyConverter();
            Converter.GetCurrencyValues();
            DatabaseConnection = DependencyService.Get<ISQLite>().GetConnection();
            Queries.DropTable();
            DatabaseConnection.CreateTable<Rate>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
