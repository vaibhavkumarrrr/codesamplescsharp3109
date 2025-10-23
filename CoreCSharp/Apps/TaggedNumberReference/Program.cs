namespace csharp.training.congruent.apps
{
    public struct TaggedInteger(int n)
    {
        public int Number = n;
        private readonly List<string> tags = [];

        public readonly void AddTag(string tag) => tags.Add(tag);
        public override readonly string ToString() => $"{Number} [{string.Join(", ", tags)}]";
    }


    internal class Program
    {
        static void Main(string[] _)
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