using System;

namespace Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            LinearSearch aLinearSearch = new LinearSearch();

            var result = aLinearSearch.Linear_Search(new[] { 1, 2, 3, 4, 5 }, 5, 4);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
