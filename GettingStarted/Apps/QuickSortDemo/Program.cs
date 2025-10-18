using csharp.training.congruent.algorithms;
namespace csharp.training.congruent.apps
{
    public class Program
    {
        public static void Main(string[] _)
        {
            // newer style over {} 
            int[] value = [10, 7, 8, 9, 1, 5];
            int[] arr = value;
            int n = arr.Length;

            QuickSortAlgo.PerformQuickSort(arr, 0, n - 1);
            foreach (int val in arr)
            {
                Console.Write(val + " ");
            }
           
        }

    }
}
