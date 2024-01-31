using System;

namespace main
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] brojevi = new int[100];
            for (int i = 0; i < 100; ++i)
            {
                brojevi[i] = 2 * (i + 1) + 1;
            }

            Array.Sort(brojevi);

            foreach (int n in brojevi)
            {
                Console.Write(String.Format("{0} ", n));
            }
            Console.WriteLine();

            Search search = new Search();
            Console.WriteLine(search.BinarySearch(brojevi, 75));
        }
    }

    class Search
    {
        public int BinarySearch(int[] arr, int x)
        {
            int low = 0;
            int heigh = arr.Length - 1;
            while (low <= heigh)
            {
                int p = low + (heigh - low) / 2;

                if (arr[p] == x)
                {
                    return p;
                }
                else if (arr[p] < x)
                {
                    low = p + 1;
                }
                else
                {
                    heigh = p - 1;
                }
            }
            return -1;
        }
    }
}
