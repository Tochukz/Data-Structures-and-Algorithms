/**
  This merge sort implementation is mostly the same as the one in merge-sort.csx.
  The only difference is that a List<int> is unsed instead of int[]. 
*/

class MergeSort
{
    private void Merge(List<int> list, int start, int mid, int end)
    {
        int len1 = mid - start + 1;
        List<int> half1 = new List<int>();
        int i;
        for(i = 0; i < len1; i++)
        {
           half1.Add(list[start + i]);
        }

        int len2 = end - mid;
        List<int> half2 = new List<int>();
        int j;
        for(j = 0; j < len2; j++)
        {
            half2.Add(list[mid + j + 1]);
        }

        i = 0;
        j = 0;
        int k = start;
        while(i < len1 || j < len2)
        {
            if (i < len1 && j < len2)
            {
                if (half1[i] <= half2[j])
                {
                    list[k] = half1[i];
                    i++;
                }
                else 
                {
                    list[k] = half2[j];
                    j++;
                }
            }
            else if (i < len1)
            {
               list[k] = half1[i];
               i++;
            }
            else if(j < len2)
            {  
               list[k] = half2[j];
               j++;
            }
            k++;
        }
     
    }

    private void SortnMarge(List<int> list, int start, int end)
    {
        if (start < end)
        {
            int mid = (start + end) / 2;
            SortnMarge(list, start, mid);
            SortnMarge(list, mid + 1, end);

            Merge(list, start, mid, end);
        }
    }

    public void Sort(List<int> list)
    {
        SortnMarge(list, 0, list.Count-1);
    }

    public void PrintList(List<int>  list)
    {
        foreach(int x in list)
        {
            Console.Write($"{x} ");
        }
        Console.Write("\n");
    }
}

List<int> numbers = new List<int>{12, 11, 13, 5, 6, 7};
MergeSort mergeSort = new MergeSort();
Console.WriteLine("Before Sorting: ");
mergeSort.PrintList(numbers);
mergeSort.Sort(numbers);
Console.WriteLine("After Sorting: ");
mergeSort.PrintList(numbers);

List<int> numbers2 = new List<int>{53, 12, 27, 13, 41, 10, 19};
Console.WriteLine("Before Sorting: ");
mergeSort.PrintList(numbers2);
mergeSort.Sort(numbers2);
Console.WriteLine("After Sorting: ");
mergeSort.PrintList(numbers2);

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
*/