using System;

namespace Task_5._5._7
{
    class Program
    {
        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(20));
            Console.ReadLine();
        }
    }
}
