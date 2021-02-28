using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegateClass dClass = new DelegateClass();
            dClass.Execute(Print);
            Console.ReadKey();
        }

        public static void Print(int i)
        {
            Console.WriteLine(i);
        }
    }


    public class DelegateClass
    {
        public delegate void Callback(int i);


        public void Execute(Callback method)
        {
            for (int i = 0; i < 200000; i++)
            {
                //Execute the method logic
                method(i);
            }
        }
    }
}
