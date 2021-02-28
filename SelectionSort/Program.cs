using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

            SortElement(arr, arr.Length);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadKey();
        }

        private static void SortElement(int[] arr, int arrLength)
        {
            int min_index, temp;

            for (int i = 0; i < arrLength - 1; i++)
            {
                min_index = i;

                for (int j = i + 1; j < arrLength; j++)
                {
                    if (arr[j] < arr[min_index])
                    {
                        min_index = j;
                    }
                }

                if (min_index != i)
                {
                    arr[i] = arr[i] + arr[min_index];
                    arr[min_index] = arr[i] - arr[min_index];
                    arr[i] = arr[i] - arr[min_index];
                }
            }
        }
    }
}
