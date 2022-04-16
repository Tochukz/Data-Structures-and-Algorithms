class BinarySearch 
{
    private static int DivideNSearch(int[] numbers, int start, int end, int val)
    {
        if(start <= end)
        {
            int midIndex = (start + end) / 2;
            int midValue = numbers[midIndex];
            if (val == midValue)
            {
               return midIndex;
            }
            else if (val < midValue)
            {
                return DivideNSearch(numbers, start, midIndex - 1, val);
            }
            else
            {
                return DivideNSearch(numbers, midIndex + 1, end, val);
            }
        }
        return -1;
    }

    public static int FindIndex(int[] numbers, int val)
    {
        return DivideNSearch(numbers, 0, numbers.Length - 1, val);
    }    
}

int[] numbers = { 2, 3, 4, 10, 40 };
int val = 10;
int index = BinarySearch.FindIndex(numbers, val);
if (index == -1)
{
    Console.WriteLine("Element not present");
}
else
{
    Console.WriteLine("Element found at index "+ index);
}

/**
This implementation uses the recursive approach. 

NB: Binary search is used to search in sorted arrays. So the arrays must be sorted for it to work.

Output:  
  Element found at index 3

Online Resource:  
   https://www.geeksforgeeks.org/binary-search/
*/