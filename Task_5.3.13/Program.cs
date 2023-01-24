using System;

namespace Task_5._3._13
{
    class Program
    {
        static int[] SortArrayDesc(int[] ArrayDesc)
        {
            var newArrayDesc = new int[ArrayDesc.Length];
            Array.Copy(ArrayDesc, newArrayDesc, ArrayDesc.Length);
            
            int temp = 0;
            for (var i = 0; i < newArrayDesc.Length; i++)
            {
                for (var j = i + 1; j < newArrayDesc.Length; j++)
                {
                    if (newArrayDesc[i] < newArrayDesc[j])
                    {
                        temp = newArrayDesc[i];
                        newArrayDesc[i] = newArrayDesc[j];
                        newArrayDesc[j] = temp;
                    }
                }
            }
            return newArrayDesc;
        }

        static int[] SortArrayAsc(int[] ArrayAsc)
        {
            var newArrayAsc = new int[ArrayAsc.Length];
            Array.Copy(ArrayAsc, newArrayAsc, ArrayAsc.Length);

            int temp = 0;
            for (var i = 0; i < newArrayAsc.Length; i++)
            {
                for (var j = i + 1; j < newArrayAsc.Length; j++)
                {
                    if (newArrayAsc[i] > newArrayAsc[j])
                    {
                        temp = newArrayAsc[i];
                        newArrayAsc[i] = newArrayAsc[j];
                        newArrayAsc[j] = temp;
                    }
                }
            }

            return newArrayAsc;
        }

        static int[] GetArrayFromConsole(int num)
        {
            var result = new int[num];

            for (var i = 0; i < result.Length; i++)
            {
                Console.Write("Введи элемент массива №{0}: ", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static void ShowArray(int[] arr)
        {

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

        }

        static void SortArray(int[] array_to_sort, out int[] sorteddesk, out int[] sortedasc)
        {
            sorteddesk = SortArrayDesc(array_to_sort);
            sortedasc = SortArrayAsc(array_to_sort);
        }

        static void Main(string[] args)
        {
            var arrayCount = 4;
            var array = GetArrayFromConsole(arrayCount);

            SortArray(array, out int[] sorteddesk, out int[] sortedasc);

            ShowArray(sorteddesk);
            ShowArray(sortedasc);

            Console.ReadLine();
        }
    }
}
