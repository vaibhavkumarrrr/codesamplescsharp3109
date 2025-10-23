namespace csharp.training.congruent.classes
{
    public class Post
    {
        public int PostId { get; set; }
        public int BlogId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public Blog Blog { get; set; } = new Blog();
    }
}
