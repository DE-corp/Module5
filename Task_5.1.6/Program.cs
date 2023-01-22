using System;

namespace Task_5._1._6
{
    class Program
    {
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for(var i = 0; i < result.Length; i++)
            {
                Console.Write("Введи элемент массива №{0}: ", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            int temp = 0;
            for (var i = 0; i < result.Length; i++)
            {
                for (var j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            foreach(var item in GetArrayFromConsole())
            {
                Console.Write(item + " ");
            }


            Console.ReadLine();
        }
    }
}
