using System;

namespace MergeSortB
{
    class Program
    {


        static void MergeSort(int[] arr)
        {

            if (arr.Length == 1)
            {
                return;
            }
                

            int low = 0;
            int high = arr.Length;
            int mid = (low + high) / 2;
            int[] leftArr = new int[mid];
            int[] rightArr = new int[high - mid];

            for(int i = 0; i < mid; i++)
            {
                leftArr[i] = arr[i];
            }

            for(int j = mid; j < arr.Length; j++)
            {
                rightArr[j - mid] = arr[j];
            }

            MergeSort(leftArr);
            MergeSort(rightArr);
            Merge(leftArr, rightArr, arr);
           
        }

        static void Merge(int[] leftArray, int[] rightArray, int[] arr)
        {

            int i = 0;
            int j = 0;
            int k = 0;

            while(i < leftArray.Length && j < rightArray.Length)
            {
                if(leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    k++;
                    i++;
                } else
                {
                    arr[k] = rightArray[j];
                    k++;
                    j++;
                }

            }

            while ( i < leftArray.Length)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }

            while ( j < rightArray.Length)
            {
                arr[k] = rightArray[j];
                j++;
                k++;
            }

        }

        static void PrintArray(int[] arr)
        {
            foreach (var num in arr)
                Console.Write(num +" , ");
            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            int[] arrayToSort = { 7, 6, 9, 4, 1, 8, 5, 3 };
            Console.WriteLine("The unsorted array is: ");
            PrintArray(arrayToSort);

            Console.WriteLine("\nThe sorted array is: ");
            MergeSort(arrayToSort);
            PrintArray(arrayToSort);
            Console.ReadKey(true);
        }
    }
}
