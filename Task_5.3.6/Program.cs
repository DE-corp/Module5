using System;

namespace Task_5._3._6
{
    class Program
    {
        static void BigDataOperation(in int[] arr)
        {
            arr[0] = 4;
        }
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3 };
            BigDataOperation(arr);

            Console.WriteLine(arr[0]);

            Console.ReadLine();
        }
    }
}
