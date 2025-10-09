using csharp.training.congruent.algorithms;
namespace csharp.training.congruent.apps
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;

            QuickSort.quickSort(arr, 0, n - 1);
            foreach (int val in arr)
            {
                Console.Write(val + " ");
            }
        }

    }
}
