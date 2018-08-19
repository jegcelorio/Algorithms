using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static int BinarySearch (int[] arr, int searchNum)
        {

            //Binary Search: Looks for an array item by dividing the array in halves
            //Input: Sorted Array and a search Item
            //Return: The position of the item found, -1 if not found. 

            int low = 0;
            int high = arr.Length - 1;
            int mid;

            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (arr[mid] == searchNum)
                {
                    return mid;
                } else if (searchNum < arr[mid])
                {
                    high = mid - 1; 
                } else if (searchNum > arr[mid])
                {
                    low = mid + 1;
                } 
               
            }

            return -1; 
            
        }

        static void Main(string[] args)
        {
            int[] arr = { 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };

            Console.WriteLine("Welcome. The array is: ");
            foreach (var number in arr)
            {
                Console.Write(number + " , ");
            }

            Console.WriteLine("\nPlease type the number you are looking for: ");
            int lookFor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number {lookFor} is located at index {BinarySearch(arr, lookFor)}");
            Console.ReadKey();
        }
    }
}
