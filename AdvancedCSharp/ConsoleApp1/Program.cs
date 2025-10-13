using System.Net.Http;
using System.Runtime.InteropServices.Marshalling;

namespace ConsoleApp1
{
    internal class Program
    {
        public static async Task<int> SquareAsync(int n)
        {
            //if (n < 3) { Thread.Sleep(2000); }
            return n*n;
        }

        public static async Task<int> 
            FetchSquaresAsync(List<int> numbers)
        {
            var tasks = new List<Task<int>>();

            foreach (var number in numbers)
            {
                tasks.Add(SquareAsync(number));
            }

            // Await all tasks to complete
            int[] results = await Task.WhenAll(tasks);
            int x = 0; 
            Task <int> y = await Task.WhenAny(tasks);
            Console.WriteLine(" from some task: "+ y.Result);

            for (int i=0; i<results.Length; i++)
            {
                Console.WriteLine(results[i]);
            }

            int sum = 0;
            foreach (var number in results)
            {
                sum += number;
            }
            return sum;
        }

        static Task <int> GetNumber(int n) {
           // Thread.Sleep(30); 
           return Task.FromResult(n*n);
        }

        static async Task Main(string[] args)
        {
            //Console.WriteLine(GetNumber(10));
            Console.WriteLine("Waiting");
            int d = await GetNumber(4);

            Console.WriteLine("Hello, World!" + d );
            //Task.Delay(1000).Wait();
           //Console.WriteLine("Waking up");
            //Thread.Sleep(1000); 
            //Console.WriteLine("Waking up"); ;
            List<int> list = new() { 1, 2, 3, 4 ,5 };  
            int sum = await FetchSquaresAsync(list);
            Console.WriteLine("SUM :" + sum); 
        }
    }
}
