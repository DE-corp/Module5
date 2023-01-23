using System;

namespace Task_5._3._1
{
    class Program
    {
        static void ChangeAge(string age)
        {
            Console.Write("Введите возраст: ");
            age = Console.ReadLine();

        }
        static void Main(string[] args)
        {
            var SomeAge = "31";
            Console.WriteLine(SomeAge);

            ChangeAge(SomeAge);
            Console.WriteLine(SomeAge);

            Console.ReadLine();
        }
    }
}
