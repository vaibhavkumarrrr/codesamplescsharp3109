using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFGetStarted
{
    public class Blog
    {
        public Blog()
        {
            Console.WriteLine("IN BLOG CONSTRUCTOR");
        }
        private static readonly List<Post> posts = [];
        public int BlogId { get; set; }
        public string Url { get; set; } = string.Empty;
        public int IsDeleted { get; set; } = 0; // Soft delete flag: 0 = not deleted, 1 = deleted
        public List<Post> Posts { get; } = posts;
    }

}
