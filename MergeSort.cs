using System;

namespace MergeSort
{
    class Program
    {
        
          // Split original array into halves until only one element is obtained
         // Single elements are already sorted
        static void MergeSort(int[] arr, int left, int right)
        {
            
            if (left < right)
            {

               int mid = (left + right) / 2;
               //The left section of the array goes from the start of the array up to middle index
               MergeSort(arr, left, mid); 
               //The right section of the array starts from one element after mid until the final index
               MergeSort(arr, mid + 1, right); 
               //Merge both array sections
               Merge(arr, left, mid, right);

            }

        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {

            // Use a helper array to merge both sections
            // since right starts at arr.length - 1, we need to add 1 to have the same number of elements as the original array
            int[] helperArray = new int[right - left + 1]; 


            int i = left;           //  index for left section of the array
            int j = mid + 1;        //  index for right section of the array
            int k = 0;              //  index for helper array
            
            // As long as both the left and right sections contain elements, compare each element of left with an element of right
            while (i <= mid &&  j <= right)
            {

                if(arr[i] < arr[j])
                {
                    helperArray[k] = arr[i];
                    k++; // move to next index in helper array
                    i++; // move to next index in left section
                } else
                {
                    helperArray[k] = arr[j];
                    k++; // move to next index in helper array
                    j++; // move to next index in right section

                }

            }

            // assign remaining left section elements to helper array
            while ( i <= mid)
            {
                helperArray[k] = arr[i];
                i++;
                k++;
            }
        
            // assign remaining right section elements to helper array
            while (j <= right)
            {
                helperArray[k] = arr[j];
                j++;
                k++;
            }

            PrintArray(helperArray);
            
            
            // Some magic here, hehe. Assign elements of helper array to the original array. The reason
            // why i - left is used as an index, is to fill consecutive elements into the original array as they are merged. 
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
