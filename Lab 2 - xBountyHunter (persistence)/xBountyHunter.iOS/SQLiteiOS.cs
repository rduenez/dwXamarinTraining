using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SQLite;
using xBountyHunter.iOS;
using Xamarin.Forms;
using System.IO;

[assembly: Dependency(typeof(SQLiteiOS))]
namespace xBountyHunter.iOS
{
    class SQLiteiOS : DependencyServices.ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            string sqliteFilename = "mFugitivos.db3";
            string docPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string libpath = Path.Combine(docPath, "..", "Library");
            string path = Path.Combine(libpath, sqliteFilename);


            SQLiteConnection conn = new SQLiteConnection(path);
            return conn;
        }
    }
}