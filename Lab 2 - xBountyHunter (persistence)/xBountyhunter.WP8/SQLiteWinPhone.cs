using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
using xBountyHunter.WP8;
using Xamarin.Forms;
using System.IO;
using Windows.Storage;

[assembly: Dependency(typeof(SQLiteWinPhone))]

namespace xBountyHunter.WP8
{
    class SQLiteWinPhone : DependencyServices.ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            string sqliteFilename = "mFugitivos.db3";
            string path = Path.Combine(ApplicationData.Current.LocalFolder.Path, sqliteFilename);

            SQLiteConnection conn = new SQLiteConnection(path);
            return conn;
        }
    }
}
