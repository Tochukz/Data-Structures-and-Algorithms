/**
Problem:  
 Given an array arr[], its starting position l and its ending position r. 
 Sort the array using merge sort algorithm.

Your Task:
  You don't need to take the input or print anything. 
  Your task is to complete the function merge() which takes arr[], l, m, r as its input parameters and modifies arr[] in-place such that it is sorted from position l to position r, and function mergeSort() which uses merge() to sort the array in ascending order using merge sort algorithm.
*/

class exerciseC
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
}


/**
 
NB: This solution works but it is not optimal enough. 
    In the online coding platform, the cases were not completed in the alloted time. 

Online Resource: 
  https://practice.geeksforgeeks.org/problems/merge-sort/1/
*/