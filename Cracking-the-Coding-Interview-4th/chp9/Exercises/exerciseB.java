/**
 Problem: Given an unsorted array of size N, use selection sort to sort arr[] in increasing order.

 Your Task:  
    You dont need to read input or print anything. Complete the functions select() and 
    selectionSort(),where select() takes arr[] and starting point of unsorted array i as input parameters and returns the selected element for each iteration in selection sort, and selectionSort() takes the array and it's size and sorts the array.

Expected Time Complexity: O(N2)
Expected Auxiliary Space: O(1)
*/

public class ExerciseB {
    int select(int arr[], int i)
	{
        int n = arr.length;
        int minIndex = i;
        for(int k = i; k < n - 1; k++)
	    {
	        minIndex = i;
	        for(int j = k + 1; j < n ; j++)
	        {
	            if (arr[j] < arr[minIndex])
	            {
	                minIndex = j;
	            }
	        }
	        
	        int temp = arr[k];
	        arr[k] = arr[minIndex];
	        arr[minIndex] = temp; 
	        return arr[minIndex];
	    }
	    return minIndex;
	}
	
	void selectionSort(int arr[], int n)
	{

	    for(int i = 0; i < n - 1; i++)
	    {
	        int minIndex = i;
	        for(int j = i + 1; j < n ; j++)
	        {
	            if (arr[j] < arr[minIndex])
	            {
	                minIndex = j;
	            }
	        }
	        
	        int temp = arr[i];
	        arr[i] = arr[minIndex];
	        arr[minIndex] = temp; 
	    }
	}

	void printArray(int[] numbers)
	{
        for(int x : numbers)
	    {
		    System.out.print(x + " ");
	    }
	    System.out.print("\n");
	}

	public static void main(String[] args)
	{
		ExerciseB exerB = new ExerciseB(); 
        int[] numbers1 = {7, 2, 8, 12, 10, 6, 5, 2, 9, 3, 4, 1, 7, 21};
		System.out.println("Before Sorting: ");
	    exerB.printArray(numbers1);
		exerB.selectionSort(numbers1, numbers1.length);
		System.out.println("After Sorting: ");
		exerB.printArray(numbers1);
	}
}

/**
Output: 
  Before Sorting: 
  7 2 8 12 10 6 5 2 9 3 4 1 7 21 
  After Sorting:
  1 2 2 3 4 5 6 7 7 8 9 10 12 21

Online Resources: 
  https://practice.geeksforgeeks.org/problems/selection-sort/1/#
*/
