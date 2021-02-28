using System;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 22, 33, 44, 55, 66, 77, 88, 99 };
            Console.WriteLine("Write the number ...");
            int n;
            int.TryParse(Console.ReadLine(), out n);

            Binary aBinary = new Binary();
            Array.Sort(arr);
            var isFound = aBinary.SearchNumber(arr, arr.Length, n);

            Console.WriteLine(isFound);
            Console.ReadKey();
        }


    }
}
