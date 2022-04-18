class MergeSort
{
    private void SplitNMerge(int[] numbers, int start, int mid, int end)
    {
        int len1 = mid - start + 1;
        int len2 = end - mid;

        int i;
        int[] half1 = new int[len1];
        for(i = 0; i < len1; i++)
        {
            half1[i] = numbers[i + start];
        }

        int j;
        int[] half2 = new int[len2];
        for(j = 0; j < len2; j++)
        {
             
            half2[j] = numbers[j + mid + 1];
        }        

        int k = start;
        i = 0;
        j = 0;
        while(i < len1 || j < len2)
        {
            Console.Write($"k = {k} ");
            if (i < len1 && j < len2)
            {
               if (half1[i] <= half2[j])
               {
                   numbers[k] = half1[i];
                   i++;
               }
               else 
               {
                   numbers[k] = half2[j];
                   j++;
               }
            }
            else if (i < len1)
            {
                numbers[k] = half1[i];
                i++;   
            }
            else if (j < len2)
            {
                numbers[k] = half2[j];
                j++;
            }
            k++;
        }
         Console.Write("\n");
    }

    public void SortnMerge(int[] numbers, int start, int end)
    {
        if (start < end)
        {
            int mid = (start +  end)/ 2;
            SortnMerge(numbers, start, mid);
            SortnMerge(numbers, mid + 1, end);

            SplitNMerge(numbers, start, mid, end);
        }   
    }

    public void Sort(int[] numbers)
    {
        SortnMerge(numbers, 0, numbers.Length -1);
    }

    public void PrintArray(int[] numbers)
    {
        foreach(int x in numbers)
        {
            Console.Write($"{x} ");
        }
        Console.Write("\n");
    }
}


int[] numbers = {12, 11, 13, 5, 6, 7};
MergeSort mergeSort = new MergeSort();
Console.WriteLine("Before Sorting: ");
mergeSort.PrintArray(numbers);
mergeSort.Sort(numbers);
Console.WriteLine("After Sorting: ");
mergeSort.PrintArray(numbers);

int[] numbers2 = {53, 12, 27, 13, 41, 10, 19};
Console.WriteLine("Before Sorting: ");
mergeSort.PrintArray(numbers2);
mergeSort.Sort(numbers2);
Console.WriteLine("After Sorting: ");
mergeSort.PrintArray(numbers2);

/**
 Method  | Time Complexity | Space Complexity 
---------|-----------------|------------------
  Sort   |     O(nLogn)    |    O(n)

Merge Sort is a stable sort algorithm

Output: 
    Before Sorting: 
    12 11 13 5 6 7 
    After Sorting:
    5 6 7 11 12 13
    Before Sorting:
    53 12 27 13 41 10 19
    After Sorting:
    10 12 13 19 27 41 53
    
Online Resource:  
  https://www.geeksforgeeks.org/merge-sort/
  https://practice.geeksforgeeks.org/problems/merge-sort/1/ 
**/
