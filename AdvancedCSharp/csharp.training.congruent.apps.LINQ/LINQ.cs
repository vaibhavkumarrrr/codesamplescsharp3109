using System.Diagnostics;

namespace csharp.training.congruent.apps.LINQ
{
    internal class LINQ
    {
        static void DisplayResults(int min, int max, double average, double time)
        {
            Console.WriteLine($"Min: {min}\nMax: {max}\n" + $"Average: {average:F}\nTotal time in milliseconds: {time}");
        }
        private static void doRandomTest() {
            var random = new Random();
            int[] values = Enumerable.Range(1, 99999999)
                .Select(x => random.Next(1, 500000000))
                .ToArray();
            //Min, Max and Average LINQ extension methods
            Console.WriteLine("Min, Max and Average with LINQ");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // var linqStart = DateTime.Now; 
            var linqMin = values.Min();
            var linqMax = values.Max();
            var linqAverage = values.Average();
            stopwatch.Stop();
            var linqTimeMS = stopwatch.ElapsedMilliseconds;
            DisplayResults(linqMin, linqMax, linqAverage, linqTimeMS);
            //Min, Max and Average PLINQ extension methods
            Console.WriteLine("\nMin, Max and Average with PLINQ");
            stopwatch.Restart();
            var plinqMin = values.AsParallel().Min();
            var plinqMax = values.AsParallel().Max();
            var plinqAverage = values.AsParallel().Average();
            stopwatch.Stop();
            var plinqTimeMS = stopwatch.ElapsedMilliseconds;
            DisplayResults(plinqMin, plinqMax, plinqAverage, plinqTimeMS);

            Console.ReadKey();
        }

       static void Main(string[] _)
        {
			// Normal LINQ 
			//Creating a Collection of integer numbers
            var numbers = Enumerable.Range(1, 20);

            //Fetching the List of Even Numbers using LINQ
            var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Even Numbers Between 1 and 20");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
			Console.ReadKey();
			// Using Parallel LINQ Part 1 
			evenNumbers = numbers.AsParallel().Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Even Numbers Between 1 and 20");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
			Console.ReadKey();
			// Using Parallel LINQ Part 2 
			evenNumbers = numbers.AsParallel().AsOrdered().Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Even Numbers Between 1 and 20");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
			Console.ReadKey();
			// Using Parallel LINQ Part 3
			evenNumbers = numbers.AsParallel().Where(x => x % 2 == 0).OrderBy(z=>z).ToList();
            Console.WriteLine("Even Numbers Between 1 and 20");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
			Console.ReadKey();
			// Using Parallel LINQ Part 4
			 var CTS = new CancellationTokenSource(); 
			 CTS.CancelAfter(TimeSpan.FromMilliseconds(200)); 
			 evenNumbers = numbers.AsParallel().AsOrdered().WithDegreeOfParallelism(4).WithCancellation(CTS.Token).Where(x => x % 2 == 0).ToList();

            Console.WriteLine("Sum, Min, Max and Average with LINQ");

            var Sum = numbers.AsParallel().Sum();
            var Min = numbers.AsParallel().Min();
            var Max = numbers.AsParallel().Max();
            var Average = numbers.AsParallel().Average();
            Console.WriteLine($"Sum:{Sum}\nMin: {Min}\nMax: {Max}\nAverage:{Average}");

            Console.ReadKey();
            doRandomTest(); 
        }
    }
}
