namespace EFSqlServer
{
    internal class Program
    {
        async static Task Main(string[] _)
        {
            var db = new EFSqlServerContext("Server=(localdb)\\mssqllocaldb;Database=EFSqlServerDB;Trusted_Connection=True;");
            bool x = await db.Database.EnsureCreatedAsync();
            Console.WriteLine($"Database created: {x}");    
        }
    }
}
