using System;

namespace SalaryOfYear
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("-------------WELCOME TO SALARY COUNTING APP-----------------\n\n\n\n\n\n");

            Console.WriteLine("Give Year that you want to calculate the salary \n\n");
            int year = int.Parse(Console.ReadLine());

            int months = 12 * year;
            int day = 365 * year;

            Console.WriteLine("Give amount of salary Per Month\n\n");
            var salaryPerMonth = int.Parse(Console.ReadLine());


            Console.WriteLine("Give amount of salary of Per Day\n\n");
            var salaryPerDay = int.Parse(Console.ReadLine());



            int oneYearSalayByPerMonth = 12 * salaryPerMonth;
            Console.WriteLine("One year month wise salary: " + oneYearSalayByPerMonth + "\n\n");

            int oneYearSalaryDayWise = 1;
            while (day > 0)
            {
                if (oneYearSalaryDayWise == 1)
                {
                    oneYearSalaryDayWise *= salaryPerDay;
                }
                else
                {
                    oneYearSalaryDayWise *= oneYearSalaryDayWise;
                }
                day--;
            }

            Console.WriteLine("One year Day wise salary: " + oneYearSalaryDayWise + "\n\n");
            Console.ReadKey();
        }
    }
}
