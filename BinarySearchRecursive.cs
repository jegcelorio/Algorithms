using System;
					
public class Program
{
	static int BinarySearchRec(int[] arr, int target, int low,  int high){
		
		while (low <= high){
		
			int mid = (low + high ) / 2; 

			if (arr[mid] == target){
					return 1;
			}

			if (arr[mid] < target){
					low = mid + 1;
					BinarySearchRec(arr, target, low, high);
			} else if(arr[mid] > target){
					high = mid -1;
					BinarySearchRec(arr, target, low, high); 		
			}
			
		}
	
		return 0;
		
	}
	
	
	public static void Main()
	{
		int[] arraySearch = { 4, 5, 6, 9, 10, 11, 13, 15, 16 };
		int high = arraySearch.Length - 1;
		Console.WriteLine(BinarySearchRec(arraySearch, 16, 0, high));
		
	} 
}
