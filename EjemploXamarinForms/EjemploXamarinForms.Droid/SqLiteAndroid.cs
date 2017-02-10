using Xamarin.Forms;
using EjemploXamarinForms.Droid;
using EjemploXamarinForms.DAL;
using System;
using System.IO;

[assembly: Dependency(typeof(SQLite_Android))]
namespace EjemploXamarinForms.Droid
{

    public class SQLite_Android : ISQLite

    {

        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var filename = "Student.db3";
            var documentspath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentspath, filename);

            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var connection = new SQLite.Net.SQLiteConnection(platform, path);
            return connection;
        }
    }

}