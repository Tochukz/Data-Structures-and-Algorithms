/**
 Problem: Given an unsorted array of size N, use selection sort to sort arr[] in increasing order.

 Your Task:  
    You dont need to read input or print anything. Complete the functions select() and 
    selectionSort(),where select() takes arr[] and starting point of unsorted array i as input parameters and returns the selected element for each iteration in selection sort, and selectionSort() takes the array and it's size and sorts the array.

Expected Time Complexity: O(N2)
Expected Auxiliary Space: O(1)
*/

public class exerciseB {
    int  select(int arr[], int i)
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
}
