namespace csharp.training.congruent.classes
{
    public class Comments
    {
        public int CommentsId { get; set; }
        public int PostId { get; set; }
        public string Content { get; set; } = string.Empty;
        public Post Post { get; set; } = new Post();
    }
}
