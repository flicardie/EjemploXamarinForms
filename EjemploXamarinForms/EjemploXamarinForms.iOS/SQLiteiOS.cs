using System;
using Xamarin.Forms;
using EjemploXamarinForms.DAL;
using EjemploXamarinForms.iOS;
using System.IO;

[assembly: Dependency(typeof(SQLiteiOS))]
namespace EjemploXamarinForms.iOS
{

    public class SQLiteiOS : ISQLite
    {
        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var fileName = "Student.db3";
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);

            var platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
            var connection = new SQLite.Net.SQLiteConnection(platform, path);

            return connection;
        }
    }

}