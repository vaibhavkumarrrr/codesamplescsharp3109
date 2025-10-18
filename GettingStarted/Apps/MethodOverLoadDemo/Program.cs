using csharp.training.congruent.classes;
namespace csharp.training.congruent.apps
{
    internal class Program
    {
        static void Main(string[] _)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"Sum Int {ExampleOverLoad.Sum(3, 4)}");
            Console.WriteLine($"Sum Int {ExampleOverLoad.Sum(323.3, 41.2)}");
            Console.WriteLine($"Sum Int {ExampleOverLoad.Sum(323.3, (int)41.2)}"); ;
        }
    }
}
