using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFGetStarted
{
    public class Post
    {
        public int PostId { get; set; }
        public int BlogId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public int IsDeleted { get; set; } = 0; // Soft delete flag: 0 = not deleted, 1 = deleted
        private Blog _blog;

        public Blog Blog 
        {
               get { Console.WriteLine("IN pOST GET ");  return _blog; }
               set { Console.WriteLine("IN pOST sET "); _blog = value; }
        }
    }
}
