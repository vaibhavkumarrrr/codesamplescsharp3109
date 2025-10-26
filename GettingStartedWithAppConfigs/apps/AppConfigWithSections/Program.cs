using System.Configuration;
using System.Reflection;
namespace AppConfigWithSections
{
    internal class Program
    {
        private static CoreAppSettings GetCoreConfig()
        {
            return (CoreAppSettings)ConfigurationManager.GetSection("CoreAppSettings"); 
        }

        private static SQLiteSettings GetSQLiteConfig()
        {
            return (SQLiteSettings)ConfigurationManager.GetSection("SQLiteSettings");
        }

        private static SQLServerSettings GetSQLServerConfig()
        {
            return (SQLServerSettings)ConfigurationManager.GetSection("SQLServerSettings");
        }


        static void Main(string[] _)
        {
            Console.WriteLine($"Assembly Info: {Assembly.GetExecutingAssembly().FullName}"); 
            dynamic config = GetCoreConfig(); 
            Console.WriteLine($"DB Type: {config.DbType}");
            config = GetSQLiteConfig();
            Console.WriteLine($"SQLite Folder: {config.Folder}");
            Console.WriteLine($"SQLite DB: {config.Db}");
            Console.WriteLine($"SQLite Connection String: {config.GetConnectionString()}");
            config = GetSQLServerConfig();
            Console.WriteLine($"SQLServer Server: {config.Server}");
            Console.WriteLine($"SQLServer DB: {config.Db}");
            Console.WriteLine($"SQLServer Connection String: {config.GetConnectionString()}");


        }
    }
}
