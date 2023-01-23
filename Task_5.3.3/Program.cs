using System;

namespace Task_5._3._3
{
    class Program
    {
        static void ChangeName(ref string name)
        {
            Console.Write("Введите имя: ");
            name = Console.ReadLine();

        }
        static void Main(string[] args)
        {
            var SomeName = "Евгения";
            Console.WriteLine(SomeName);

            ChangeName(ref SomeName);
            Console.WriteLine(SomeName);

            Console.ReadLine();
        }
    }
}
