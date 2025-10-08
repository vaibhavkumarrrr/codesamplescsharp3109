namespace PolymorphismExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine($"Sum Int {ExampleOverLoad.Sum(3,4)}");
            Console.WriteLine($"Sum Int {ExampleOverLoad.Sum(323.3, 41.2)}");
            Console.WriteLine($"Sum Int {ExampleOverLoad.Sum(323.3, (int)41.2)}");

        }
    }
}
