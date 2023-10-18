using System.Data;
using System.Data.SQLite;


namespace DoAnCS_Demo1.Data
{
    public sealed class SQLiteHandler
    {
        private static SQLiteHandler? instance;
        private static readonly object lockObject = new object();
        private SQLiteConnection connection;

        private SQLiteHandler()
        {
            string databasePath = @"Data Source=Data\\data.db";
            // check if database exists
            if (!System.IO.File.Exists(databasePath))
            {
                throw new Exception("Database file not found");
            }
            else
            {
                string connectionString = $"Data Source={databasePath};Version=3;";
                connection = new SQLiteConnection(connectionString);
            }
        }

        public static SQLiteHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    // Lock the object to prevent multiple threads from accessing it at the same time
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new SQLiteHandler();
                        }
                    }
                }
                return instance;
            }
        }

        public void OpenConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        // Execute a query that does not return any data
        public void ExecuteNonQuery(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();
        }
        // Execute a query that returns a single integer value
        public int IntExecuteScalar(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, connection);
            return Convert.ToInt32(command.ExecuteScalar());
        }
        // Execute a query that returns a single <T> value
        public T ExecuteScalar<T>(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, connection);
            return (T)command.ExecuteScalar();
            // can you use this for any type?
            // answer: yes, but you have to cast it to the type you want
            // for example: int i = ExecuteScalar<int>("SELECT COUNT(*) FROM table");
        }

        // Execute a query that returns a single string value
        public string StringExecuteScalar(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, connection);

            if (command.ExecuteScalar() == null)
            {
                return "";
            }

#pragma warning disable CS8603 // Possible null reference return.
            return command.ExecuteScalar().ToString();
#pragma warning restore CS8603 // Possible null reference return.
        }

        // Execute a query that returns a single real value
        public double DoubleExecuteScalar(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, connection);
            return Convert.ToDouble(command.ExecuteScalar());
        }

        // Execute a query that returns a single row of data to a List<string>
        public List<string> GetASingleRowQuery(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            // if reader has no data, return empty list
            if (!reader.HasRows)
            {
                return new List<string>();
            }

            List<string> result = new List<string>();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    result.Add(reader[i].ToString());
                }
            }
            return result;
        }

        // Execute a query that returns a single column of data to a List<string>
        public List<string> GetASingleColumnQuery(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();

            // if reader has no data, return empty list
            if (!reader.HasRows)
            {
                return new List<string>();
            }

            List<string> result = new List<string>();
            while (reader.Read())
            {
                result.Add(reader[0].ToString());
            }
            return result;
        }


        // Execute a query that returns a table to DataTable
        public DataTable ExecuteQueryTable(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            DataTable result = new DataTable();
            result.Load(reader);
            return result;
        }
    }
}
