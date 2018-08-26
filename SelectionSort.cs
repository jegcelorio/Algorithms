using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelSort
{
    class Program
    {
        static int[] SelSort(int[] arrSort)
        {
            // minIndex will help us to find the position of the minimum value
            // temp is a temporary variable to swap two values
            int minIndex;
            int temp; 

            // the first for is used to advance the counter (ctr) at each iteration
            for (int ctr = 0; ctr < arrSort.Length; ctr++)
            {
                minIndex = ctr;

                // the second for is used to find the position of the minimum value
                for(int i = ctr; i < arrSort.Length; i++)
                {
                    if (arrSort[i] < arrSort[minIndex])
                    {
                        minIndex = i; 
                    }
                }

                // swap values. Could be refactored as a new function Swap(int ctrIndex, int minIndex); 
                temp = arrSort[minIndex];
                arrSort[minIndex] = arrSort[ctr];
                arrSort[ctr] = temp; 

            }

            return arrSort;
        }


        // Created a PrintArray function to follow the DRY principle: Don't Repeat Yourself!
        static void PrintArray(int[] arr)
        {
            foreach (var num in arr)
                Console.Write(num + " , ");
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 4, 3, 9, 8, 6, 18 };
            Console.WriteLine($"The unsorted array is: ");
            PrintArray(arr);
            Console.WriteLine($"\nThe sorted array is: ");
            PrintArray(SelSort(arr));

            Console.ReadKey(true);
        }
    }
}
