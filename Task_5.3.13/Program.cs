using System;

namespace Task_5._3._13
{
    class Program
    {
        static int[] SortArrayDesc(int[] ArrayDesc)
        {
            int temp = 0;
            for (var i = 0; i < ArrayDesc.Length; i++)
            {
                for (var j = i + 1; j < ArrayDesc.Length; j++)
                {
                    if (ArrayDesc[i] < ArrayDesc[j])
                    {
                        temp = ArrayDesc[i];
                        ArrayDesc[i] = ArrayDesc[j];
                        ArrayDesc[j] = temp;
                    }
                }
            }
            return ArrayDesc;
        }

        static int[] SortArrayAsc(int[] ArrayAsc)
        {
            int temp = 0;
            for (var i = 0; i < ArrayAsc.Length; i++)
            {
                for (var j = i + 1; j < ArrayAsc.Length; j++)
                {
                    if (ArrayAsc[i] > ArrayAsc[j])
                    {
                        temp = ArrayAsc[i];
                        ArrayAsc[i] = ArrayAsc[j];
                        ArrayAsc[j] = temp;
                    }
                }
            }

            return ArrayAsc;
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
        
        static void SortArray(in int arrayCount, bool sorted = false)
        {
            if (sorted)
            {
                foreach (var item in SortArrayDesc(GetArrayFromConsole(arrayCount)))
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                foreach (var item in SortArrayAsc(GetArrayFromConsole(arrayCount)))
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {

            SortArray(7, true);

            Console.ReadLine();
        }
    }
}
