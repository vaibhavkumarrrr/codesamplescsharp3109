using System.Net.Http;
using System.Runtime.InteropServices.Marshalling;

namespace csharp.training.congruent.apps
{
    internal class SimpleThreading
    {
        static async IAsyncEnumerable<int> FetchItemsAsync()
        {
            // Instead of 10, think of a function
            // that takes long time to execute... 
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(1000); // Simulate asynchronous work
                yield return i; // Yield each item as it becomes available
            }
        }


        public static async Task<int> SquareAsync(int n)
        {
            await Task.Delay(1);
            return n * n; 
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

        static Task<int> GetNumber(int n) =>
           // Thread.Sleep(30); 
           Task.FromResult(n * n);

        private async static Task<int> GetSomeNumber()
        { 
            await Task.Delay(1000);
            return 3; 
        } 
        static async Task Main(string[] _)
        {
            //ArgumentNullException.ThrowIfNull(args);
            //Console.WriteLine(GetNumber(10));
            Console.WriteLine("Waiting");
            int d = await GetNumber(4);
            Console.WriteLine("Hello, World!" + d );
            //Task.Delay(1000).Wait();
           //Console.WriteLine("Waking up");
            //Thread.Sleep(1000); 
            //Console.WriteLine("Waking up"); ;
            List<int> list = [ 1, 2, 3, 4 ,5 ];  
            int sum = await FetchSquaresAsync(list);
            //Task<int> f = Task.Run(async () => { return 3; });
            // instead of the above, do this.
            //Task <int> f = await GetSomeNumber(); 
            Task<int> f = Task.Run(GetSomeNumber); 
            // Now this will do await, is async 
            // easier to read... 
            Console.WriteLine(!f.IsFaulted ? f.Result : "failed");
            Console.WriteLine("SUM :" + sum);
            //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/yield 

            // See how it is used ... 
            await foreach (var item in FetchItemsAsync())
            {
                Console.WriteLine("Yield : "+item); // Prints each item as it is yielded
            }

        }
    }
}
