using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;


namespace xBountyHunter.Extras
{
    class DataBaseManager
    {
        private static int DATABASE_VERSION = 1;
        private SQLiteConnection db;
        private int oldVersion = 0;

        public DataBaseManager()
        {
            db = DependencyService.Get<DependencyServices.ISQLite>().GetConnection();
            if (xBountyHunterApp.Current.Properties.ContainsKey("DATABASE_VERSION"))
                oldVersion = (int)xBountyHunterApp.Current.Properties["DATABASE_VERSION"];
            if (DATABASE_VERSION != oldVersion && oldVersion != 0)
                onUpgrade();
            if (oldVersion == 0)
                createTable();

        }

        private void createTable()
        {
            db.CreateTable<Models.mFugitivos>();
            xBountyHunterApp.Current.Properties["DATABASE_VERSION"] = DATABASE_VERSION;
        }

        private void onUpgrade()
        {
            db.DropTable<Models.mFugitivos>();
            createTable();
        }

        public List<Models.mFugitivos> selectNotCaptured()
        {
            List<Models.mFugitivos> result = db.Query<Models.mFugitivos>("SELECT * FROM [mFugitivos] WHERE [Capturado] = 0 or [Capturado] is null");
            return result;
        }

        public List<Models.mFugitivos> selectCaptured()
        {
            List<Models.mFugitivos> result = db.Query<Models.mFugitivos>("SELECT * FROM [mFugitivos] WHERE [Capturado] = 1");
            return result;
        }

        public int insertItem(Models.mFugitivos item)
        {
            int result = db.Insert(item);
            return result;
        }

        public int updateItem(Models.mFugitivos item)
        {
            int result = db.Update(item);
            return result;
        }

        public int deleteItem(int id)
        {
            int result = db.Delete<Models.mFugitivos>(id);
            return result;
        }

        public void closeConnection()
        {
            db.Close();
        }
    }
}
