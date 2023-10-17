using System.Data.SQLite;


namespace DoAnCS_Demo1.Data
{
    public sealed class SQLiteHandler
    {
        private static SQLiteHandler instance;
        private static readonly object lockObject = new object();
        private SQLiteConnection connection;

        private SQLiteHandler()
        {
            string databasePath = @"Data Source=Data\\data.db";
            // check if database exists
            if (!System.IO.File.Exists(databasePath))
            {
                
            }
        }
    }
}
