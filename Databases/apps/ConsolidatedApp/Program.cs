using csharp.training.congruent.classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
namespace ConsolidatedApp
{
    public class Program
    {
        public async static Task DoStuff(SQLServerContext db)
        {
            Console.WriteLine("Inserting a new Normal blog");
            db.Add(new Blog
            {
                Name = "Test Blog 2184",
                Url = "http://blogspot.com/seshagirisriram/ontech"
            });

            Console.WriteLine("Inserting a new Rss blog");
            db.Add(new RSSBlog
            {
             Name = "Test Blog 2184",
             Url = "http://blogspot.com/seshagirisriram/ontech"
             ,
             RSSUrl = "http://rssblogspot.com/seshagirisriram/ontech/rss"
            });
            // Save Changes
            await db.SaveChangesAsync();
            // Read
            Console.WriteLine("Querying for a blog");
            var blog = await db.Blogs
                .OrderBy(b => b.BlogId).LastAsync();
            //string url = (blog is RSSBlog) ? ((RSSBlog)blog).Url : blog.Url;
            string url = (blog is RSSBlog blog1) ? blog1.Url : blog.Url;
            // Update0
            Console.WriteLine("Updating the blog and adding a post");
            //blog.Url = "https://devblogs.microsoft.com/dotnet";
            // so where did the BlogId go?
            blog.Posts.Add(new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });
            blog.Posts.Add(new Post { Title = "Demo", Content = "Next Post I wrote an app using EF Core!" });
            // Console.WriteLine("**DEBUG: " +   blog.BlogId); 
            blog.Posts.Add(new Post { Title = "Demo", Content = $"For Blog id {blog.BlogId} Next Post I wrote an app using EF Core!" });
            int pCount = 1;
            //blog.Posts(0).Comments.Add(new Comments { Content = "First Comment on First Post" });
            foreach (var t in blog.Posts)
            {

                t.Comments.Add(new Comments { Content = $"First Comment on Post {t.Title}" });
                if (pCount++ == 1)
                {
                    t.Comments.Add(new Comments { Content = $"Second Comment on Post {t.Title}" });
                }
            }
            //x.Comments.Add(new Comments { Content = "First Comment on Third Post" });
            //Console.WriteLine(x.Blog.BlogId);

            await db.SaveChangesAsync();
            foreach (var t in blog.Posts)
            {
                Console.WriteLine($"Post {t.Title}: {t.Content}, Blog URL: {t.Blog.Url}, Blog Name: {t.Blog.Name}");
            }

            //Console.WriteLine("Updating the post");
            //Console.ReadKey();

            var posts = await db.Posts.Include(p => p.Blog).ToListAsync();
            foreach (var t in posts)
            {
                Console.WriteLine($"Post in db {t.PostId}, {t.Title}: {t.Content}, {t.Blog.Url}, {t.Blog.Name}");
            }
            var c = await db.Posts.Include(p => p.Blog).Include(c => c.Comments).ToListAsync();
            foreach (var t in c)
            {
                Console.WriteLine($"Post in db {t.PostId}, {t.Title}: {t.Content}, {t.Blog.Url}, {t.Blog.Name}, Number of comments: {t.Comments.Count}");
                foreach (var com in t.Comments)
                {
                    Console.WriteLine($"   Comment: {com.Content}");
                }
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

        async static Task Main(string[] _)
        {
            string DBType = ConfigurationManager.AppSettings["BasicDBType"] ?? "Empty";
            Console.WriteLine($"Basic DB Type: {DBType}");
            string ConnectionString = ConfigurationManager.ConnectionStrings[DBType].ConnectionString;
            Console.WriteLine($"Connection String: {ConnectionString}");
            
            if (DBType == "SQLServer")
            {
                await DoStuff(new SQLServerContext(ConnectionString));
            }
            else
            {
                //await DoStuff(new SQLiteContext(ConnectionString));
            }
        }
    }
}