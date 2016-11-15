using System;
using SQLite.Net;
using SamsUsefulApp;
using SamsUsefulApp.iOS;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_iOS))]
namespace SamsUsefulApp.iOS
{
    public class SQLite_iOS : ISQLite
    {
        SQLiteConnection ISQLite.GetConnection()
        {
            var sqliteFilename = "TodoSQLite.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, sqliteFilename);
            // Create the connection
            var conn = new SQLiteConnection(new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS(), path);
            // Return the database connection
            return conn;
        }
    }
}
