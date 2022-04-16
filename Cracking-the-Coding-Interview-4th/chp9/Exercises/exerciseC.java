/**
Problem:  
 Given an array arr[], its starting position l and its ending position r. 
 Sort the array using merge sort algorithm.

Your Task:
  You don't need to take the input or print anything. 
  Your task is to complete the function merge() which takes arr[], l, m, r as its input parameters and modifies arr[] in-place such that it is sorted from position l to position r, and function mergeSort() which uses merge() to sort the array in ascending order using merge sort algorithm.
*/

class ExerciseC
{
    void merge(int arr[], int start, int mid, int end)
    {
         int len1 = mid - start + 1;
         int len2 = end - mid;
         
         int[] half1 = new int[len1];
         int i;
         for(i = 0; i < len1; i++)
         {
             half1[i] = arr[start + i];
         }
         
         int[] half2 = new int[len2];
         int j;
         for(j = 0; j < len2; j++)
         {
             half2[j] = arr[j + mid + 1];
         }
         
         int k = start;
         i = 0;
         j = 0;
         while(i < len1 || j < len2)
         {
             if (i < len1 && j < len2)
             {
                 if (half1[i] <= half2[j])
                 {
                     arr[k] = half1[i];
                     i++;
                 }
                 else
                 {
                     arr[k] = half2[j];
                     j++;
                 }
             }
             else if (i < len1)
             {
                 arr[k] = half1[i];
                 i++;
             }
             else if (j < len2)
             {
                 arr[k] = half2[j];
                 j++;
             }
             k++;
         }
    }
    
    void mergeSort(int arr[], int start, int end)
    {
        if(start < end)
        {
            int mid = (start + end) / 2;
            mergeSort(arr, start, mid);
            mergeSort(arr, mid + 1, end);
            
            merge(arr, start, mid, end);
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
        ExerciseC exerC =  new ExerciseC();
        int[] numbers = {7, 2, 8, 12, 10, 6, 5, 2, 9, 3, 4, 1, 7, 21};
        System.out.println("Before Sorting: ");
        exerC.printArray(numbers);
        exerC.mergeSort(numbers, 0, numbers.length -1);
        System.out.println("After Sorting: ");
        exerC.printArray(numbers);
    }
}


/**
NB: This solution works but it is not optimal enough. 
    In the online coding platform, the cases were not completed in the alloted time. i.e: Time Limit Exceeded

Output:  
  Before Sorting: 
  7 2 8 12 10 6 5 2 9 3 4 1 7 21 
  After Sorting:
  1 2 2 3 4 5 6 7 7 8 9 10 12 21
  
Online Resource: 
  https://practice.geeksforgeeks.org/problems/merge-sort/1/
*/