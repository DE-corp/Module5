using System;

namespace Task_5._2._8
{
    class Program
    {
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (var i = 0; i < result.Length; i++)
            {
                Console.Write("Введи элемент массива №{0}: ", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            var sorted_array = SortArray(result);
            return sorted_array;
        }
        static int[] SortArray(int[] array)
        {
            int temp = 0;
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
        static void Main(string[] args)
        {
            foreach (var item in GetArrayFromConsole())
            {
                Console.Write(item + " ");
            }


            Console.ReadLine();
        }
    }
}
