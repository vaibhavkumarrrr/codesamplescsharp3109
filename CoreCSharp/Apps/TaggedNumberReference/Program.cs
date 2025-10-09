namespace csharp.training.congruent.aps
{
    public struct TaggedInteger
    {
        public int Number;
        private List<string> tags;
        public TaggedInteger(int n)
        {
            Number = n; tags = new List<string>();
        }
        public void AddTag(string tag) => tags.Add(tag);
        public override string ToString() => $"{Number} [{string.Join(", ", tags)}]";
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var n1 = new TaggedInteger(0); n1.AddTag("A"); 
            Console.WriteLine(n1);// output: 0 [A]        
            var n2 = n1;
            Console.WriteLine(n2);// output: O [A ]         

            n2.Number = 7; n2.AddTag("B");
            Console.WriteLine(n1);  // output: 0 [A, B]
            Console.WriteLine(n2);  // output: 7 [A, B]    

        }
    }
}