
using System;
 
namespace main
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] brojevi = { 1, 5, 2, 4, 3 , 6};
            Sort.QuickSort(brojevi, 0, brojevi.Length - 1);
            foreach (int n in brojevi)
            {
                Console.Write(String.Format("{0} ", n));
            }
        }
    }

    class Sort
    {

        static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j < right; ++j)
            {
                if (arr[j] <= pivot)
                {
                    ++i;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, right);
            return i + 1;
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int p = Partition(arr, left, right);
                QuickSort(arr, left, p - 1);
                QuickSort(arr, p + 1, right);
            }
        }

        static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[b];
            arr[b] = arr[a];
            arr[a] = temp;
        }
    }
}