﻿using Microsoft.EntityFrameworkCore;
using csharp.training.congruent.classes;
namespace csharp.training.congruent.apps
{
    public class SQLiteContext : AbstractDBContext
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

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}").EnableDetailedErrors().EnableSensitiveDataLogging(true);
    }
}
