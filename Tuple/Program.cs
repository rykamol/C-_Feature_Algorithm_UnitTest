using System;
using System.Collections.Generic;

namespace Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            //problem: print two integer in a comma seperated way form and array

            //input : [1,2,3,4,5,6,7.8]

            // output:
            // 1,2
            // 3,4
            // 5,6
            // 7,8


            //Declare tuple=
            //Tuple<int, string, string> person = new Tuple<int, string, string>(1, "Steve", "Jobs");


            List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            for (int i = 0; i < intList.Count; i += 2)
            {
                var value = Tuple.Create(intList[i], intList[i + 1]);
                var output = value.ToString().Replace("(", "").Replace(")", "");
                Console.WriteLine(output);
            }

            Console.ReadKey();
        }
    }
}
