using SQLite.Net;
using SamsUsefulApp.Droid;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_Android))]
namespace SamsUsefulApp.Droid
{
    
    public class SQLite_Android : ISQLite
        {

        SQLiteConnection ISQLite.GetConnection()
        {
            var sqliteFilename = "TodoSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);
            // Create the connection
            var conn = new SQLiteConnection(new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid(), path);
            // Return the database connection
            return conn;
        }
    }
}