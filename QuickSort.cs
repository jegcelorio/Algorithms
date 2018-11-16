using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        public static void QuickSort(int[] arr, int start, int end)
        {
            if (start >= end)
                return;
            
              int pIndex =  Partition(arr, start, end);
              QuickSort(arr, start, pIndex - 1);
              QuickSort(arr, pIndex + 1, end);

        }

        public static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int pIndex = start;
            for(int i = start; i < end; i++)
            {
                if(arr[i] <= pivot)
                {
                    if(pIndex != i) {
                        Swap(ref arr[i], ref arr[pIndex]);
                        pIndex++;
                    }
                }
            }

            Swap(ref arr[pIndex], ref arr[end]);

            return pIndex;
        }


        public static void Swap(ref int a, ref int b)
        {
            int tmp;
            tmp = b;
            b = a;
            a = tmp;
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var elem in arr)
                Console.Write(elem + ",");
        }

        static void Main(string[] args)
        {
            int[] arr = { 7, 6, 8, 3, 2, 1, 9, 5, 10 , 4};
            PrintArray(arr);
            int start = 0;
            int end = arr.Length - 1;
            QuickSort(arr, start, end);
            Console.WriteLine("\n");
            PrintArray(arr);

            Console.ReadKey(true);
        }
    }
}
