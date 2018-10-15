using System;

namespace MergeSort
{
    class Program
    {

        static void MergeSort(int[] arr, int left, int right)
        {
            
            if (left < right)
            {

               int mid = (left + right) / 2;
               MergeSort(arr, left, mid);
               MergeSort(arr, mid + 1, right);
               Merge(arr, left, mid, right);

            }

        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {

            
            int[] helperArray = new int[right - left + 1];

            int i = left;
            int j = mid + 1;
            int k = 0;

            
            while (i <= mid &&  j <= right)
            {

                if(arr[i] < arr[j])
                {
                    helperArray[k] = arr[i];
                    k++;
                    i++;
                } else
                {
                    helperArray[k] = arr[j];
                    k++;
                    j++;

                }

            }

            while ( i <= mid)
            {
                helperArray[k] = arr[i];
                i++;
                k++;
            }
        
            while (j <= right)
            {
                helperArray[k] = arr[j];
                j++;
                k++;
            }

            PrintArray(helperArray);

            for (i = left; i <= right; i++)
            {
                arr[i] = helperArray[i - left];
            }

        }

        static void PrintArray(int[] arr)
        {
        
            foreach(var num in arr)
                Console.Write(num + ",");
            Console.WriteLine("\n");
        }
        
 
        static void Main(string[] args)
        {
            int[] arrayToSort = { 8, 3, 1, 7, 6, 9, 4, 2 };

            Console.WriteLine("Unsorted Array: ");
            PrintArray(arrayToSort);
            MergeSort(arrayToSort, 0, arrayToSort.Length-1);
            Console.WriteLine("\n\nSortedArray:");
            PrintArray(arrayToSort);
            Console.ReadKey(true);
                
        }
    }
}
