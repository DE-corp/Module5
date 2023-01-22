using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;

            Console.Write("Введи свое имя: ");
            User.Name = Console.ReadLine();

            User.Dishes = new string[5];
            for(var i = 0; i < User.Dishes.Length; i++)
            {
                Console.Write("Введи свое любимое блюдо №{0}: ", i + 1);
                User.Dishes[i] = Console.ReadLine();
            }


            Console.Clear();
            Console.WriteLine("Ваше имя: {0}", User.Name);
            
            Console.WriteLine("Список ваших любимых блюд:\n");
            foreach (var item in User.Dishes)
            {
                Console.WriteLine(item);
            }
     
            Console.ReadLine();
        }
    }
}
