using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using csharp.training.congruent.classes;

namespace csharp.training.congruent.apps
{
    internal class Program
    {
        static async Task Main(string[] _)
        {
            using var db = new SQLiteContext();
            Console.WriteLine($"Database path: {db.DbPath}.");
            // Create
            Console.WriteLine("Inserting a new blog");
            db.Add(new Blog { Name = "Test Blog", Url = "http://blogs.msdn.com/adonet" });
            await db.SaveChangesAsync();

            // Read
            Console.WriteLine("Querying for a blog");
            var blog = await db.Blogs
                .OrderBy(b => b.BlogId).LastAsync();

            // Update0
            Console.WriteLine("Updating the blog and adding a post");
            //blog.Url = "https://devblogs.microsoft.com/dotnet";
            // so where did the BlogId go?
            blog.Posts.Add(new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });
            blog.Posts.Add(new Post { Title = "Demo", Content = "Next Post I wrote an app using EF Core!" });
            // Console.WriteLine("**DEBUG: " +   blog.BlogId); 
            blog.Posts.Add(new Post { Title = "Demo", Content = $"For Blog id {blog.BlogId} Next Post I wrote an app using EF Core!" });

            Post x = new()
            {
                Title = "Third Post",
                Content = "Third Post I wrote an app using EF Core!",
                Blog = blog
            };

            Console.WriteLine(x.Blog.BlogId);   

            await db.SaveChangesAsync();
            foreach (var t in blog.Posts)
            {
                Console.WriteLine($"Post {t.Title}: {t.Content}, Blog URL: {t.Blog.Url}, Blog Name: {t.Blog.Name}");
            }

            //Console.WriteLine("Updating the post");
            //Console.ReadKey();

            var posts = await db.Posts.Include(p=>p.Blog).ToListAsync();  
            foreach(var t in posts)
            {
                Console.WriteLine($"Post in db {t.PostId}, {t.BlogId}, {t.Title}: {t.Content}, {t.Blog.Url}, {t.Blog.Name}");
            }   

  
            var post = await db.Posts
                //.Where(p => p.BlogId == blog.BlogId && p.PostId ==2)
                .Where(p => p.BlogId == blog.BlogId)
                .FirstAsync();
            post.Title = "Hello EF Core - I am updating";
            await db.SaveChangesAsync();

            // Delete
            Console.WriteLine("Delete the blog");
            //db.Remove(blog);
            //await db.SaveChangesAsync();


        }
    }
}
