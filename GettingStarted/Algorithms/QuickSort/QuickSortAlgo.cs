namespace csharp.training.congruent.algorithms
{
    public class QuickSortAlgo
    {
        // partition function
        private static int Partition(int[] arr, int low, int high)
        {

            // choose the pivot
            int pivot = arr[high];

            // index of smaller element and indicates 
            // the right position of pivot found so far
            int i = low - 1;

            // traverse arr[low..high] and move all smaller
            // elements to the left side. Elements from low to 
            // i are smaller after every iteration
            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            // move pivot after smaller elements and
            // return its position
            Swap(arr, i + 1, high);
            return i + 1;
        }

        // swap function
        private static void Swap(int[] arr, int i, int j)
        {
            // no more temporary values.... 
            // this is the same as 
            // a = a+b
            // b = a-b
            // a = a-b; 
            (arr[j], arr[i]) = (arr[i], arr[j]);
        }

        // The QuickSort function implementation
        public static void PerformQuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                // pi is the partition return index of pivot
                int pi = Partition(arr, low, high);

                // recursion calls for smaller elements
                // and greater or equals elements
                PerformQuickSort(arr, low, pi - 1);
                PerformQuickSort(arr, pi + 1, high);
            }
        }

    }
}
