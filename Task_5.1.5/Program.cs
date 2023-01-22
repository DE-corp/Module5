using System;

namespace Task_5._1._5
{
    class Program
    {
        static string ShowColor()
        {
            Console.Write("Напишите свой любимый цвет на английском с маленькой буквы: ");
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            return color;
        }
        static void Main(string[] args)
        {
            string[] ColorsList = new string[3];

            for(var i = 0; i < ColorsList.Length; i++)
            {
                ColorsList[i] = ShowColor();
            }

            foreach (var item in ColorsList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
