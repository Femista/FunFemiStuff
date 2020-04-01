using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var databaseSingleton = Database.GetInstance(); //Creating Database
            databaseSingleton.Init("Connectostring", "aaaaaa"); // In case Singleton needs paramas
            Console.WriteLine(databaseSingleton);
            Database.DatabaseQuery("SELECT * GOONS FROM GOONPLATOON");
            Console.ReadLine();
        }
    }
}
