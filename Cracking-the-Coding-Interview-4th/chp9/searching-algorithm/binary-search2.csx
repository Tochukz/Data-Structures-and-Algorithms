class BinarySearch
{
    public static int FindIndex(int[] numbers, int val)
    {
        int start = 0;
        int end = numbers.Length - 1;
        int midIndex, midValue;
        while(start <= end)
        {
           midIndex = (start + end ) / 2;            
           midValue = numbers[midIndex];
           if (val == midValue)
           {
               return midIndex;
           }
           else if (val < midValue)
           {
               end = midIndex - 1;
           }
           else 
           {
               start = midIndex + 1;
           }
        }

        return -1;
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
The implementation uses the iterative approach.

NB: Binary search is used to search in sorted arrays. So the arrays must be sorted for it to work.

Output: 
  Element found at index 3

Online Resource:  
   https://www.geeksforgeeks.org/binary-search/
*/