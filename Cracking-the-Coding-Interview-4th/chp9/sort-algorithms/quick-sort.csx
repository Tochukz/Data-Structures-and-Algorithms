class QuickSort
{
    private void Swap(int[] numbers, int i, int j)
    {
        int temp = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = temp;
    }

    private int Partition(int[] numbers, int start, int end)
    {
        int pivot = numbers[end];
        int i = (start - 1);
        for(int j = start; j < end; j++)
        {
            if (numbers[j] < pivot)
            {
                i++;
                Swap(numbers, i, j);            
            }
        }
        Swap(numbers, i + 1, end);
        return (i + 1);
    }

    private void PartitionNSort(int[] numbers, int start, int end)
    {
        if (start < end)
        {
            int parti = Partition(numbers, start, end);
            PartitionNSort(numbers, start, parti - 1);
            PartitionNSort(numbers, parti + 1, end);
        }
    }

    public void Sort(int[] numbers)
    {
        PartitionNSort(numbers, 0, numbers.Length - 1);
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
QuickSort quickSort = new QuickSort();
Console.WriteLine("Before Sorting: ");
quickSort.PrintArray(numbers);
quickSort.Sort(numbers);
Console.WriteLine("After Sorting: ");
quickSort.PrintArray(numbers);

int[] numbers2 = {53, 12, 27, 13, 41, 10, 19};
Console.WriteLine("Before Sorting: ");
quickSort.PrintArray(numbers2);
quickSort.Sort(numbers2);
Console.WriteLine("After Sorting: ");
quickSort.PrintArray(numbers2);

/**
 Method  | Time Complexity | Space Complexity 
---------|-----------------|------------------
  Sort   |     O(n^2)      |    O(n)

Quick Sort is NOT a stable sort algorithm by default 

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
