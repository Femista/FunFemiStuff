using System;

namespace Singleton
{
    public class Database
    {
        private static Database _database;
        private string _databaseConnectionString;
        private string _password;

        private Database()
        {
            Console.WriteLine("Database Created");
        }

        public static Database GetInstance()
        {
            return _database ?? (_database = new Database());
        }

        //Init would be used in case the Singleton needs params
        public void Init(string databaseConnectionString, string password)
        {
            _databaseConnectionString = databaseConnectionString;
            _password = password;
        }

        public static void DatabaseQuery(string query)
        {
            Console.WriteLine("Querying Database with query: " + query);
        }

        public override string ToString()
        {
            return $"I am a database with connectionString: {_databaseConnectionString} and password: {_password}";
        }
    }
}