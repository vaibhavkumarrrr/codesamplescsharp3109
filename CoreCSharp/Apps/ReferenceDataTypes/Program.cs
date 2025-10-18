// See https://aka.ms/new-console-template for more information
namespace csharp.training.congruent.apps
{
    public struct MutablePoint
    {
        public int X; public int Y; 
        public MutablePoint(int x, int y) => (X, Y) = (x, y);
        public override readonly string ToString() => $"({X}, {Y})";
    }

    public class Program
    {
        public static void Main(string[] _)
        {
            MutablePoint p1 = new(1, 2);        // p1  = 1, 2
            MutablePoint p2 = p1;
            p2.Y = 200;   
             // p2 = 1,200, p1 Is still 1,2 
            Console.WriteLine($"{nameof(p1)} after {nameof(p2)} is modified: {p1}");
            Console.WriteLine($"{nameof(p2)}: {p2}");
            MutateAndDisplay(p2);
            Console.WriteLine($"{nameof(p2)} after passing to a method: {p2}");
            //p2 = null; 
        }

        private static void MutateAndDisplay(MutablePoint p)
        {
            p.X = 100;
            Console.WriteLine($"Point mutated in a method: {p}");
        }

    }
}