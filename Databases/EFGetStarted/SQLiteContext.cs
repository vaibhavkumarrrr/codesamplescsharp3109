using Microsoft.EntityFrameworkCore;
using csharp.training.congruent.classes;

namespace csharp.training.congruent.apps
{
    public class SQLiteContext: DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public string DbPath { get; }
        public SQLiteContext()
        {
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            //DbPath = System.IO.Path.Join(path, "blogging.db");
            DbPath = System.IO.Path.Join(@"e:\data", "blogging.db");
        }


        protected override void OnModelCreating
            (ModelBuilder modelBuilder)
        {
            modelBuilder.
               Entity<Blog>().
               Property(b => b.BlogId).
               ValueGeneratedNever();
        }
    /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string _connectionString = $"Server=(localdb)\\mssqllocaldb;Database=EFSqlServerDB;Trusted_Connection=True;";
            Console.WriteLine($"Using SQL Server with connection string: {_connectionString}");
            optionsBuilder.UseSqlServer(_connectionString);
            optionsBuilder.EnableDetailedErrors().EnableSensitiveDataLogging(true);
        }
      */ 
        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}").EnableDetailedErrors().EnableSensitiveDataLogging(true);
    }
}
