/**
Problem: You are given two sorted arrays, A and B, and A has a large enough buffer at the end to hold B. 
         Write a method to merge B into A in sorted order.
*/

class Exercise91B
{
    public static void SortMerge(int[] big, int[] small)
    {
        int i = (big.Length - small.Length) -1;
        int j = small.Length - 1;
        int k = big.Length - 1;
        while(i >= 0 || j >= 0)
        {
            if (i >= 0 && j >= 0)
            {
                if (i >= big.Length || j >= small.Length)
                {
                    Console.WriteLine($"{i} >= {big.Length} || {j} >= {small.Length}");
                    return;
                }
                if (big[i] > small[j])
                {
                    big[k] = big[i];
                    i--;
                }
                else 
                {
                   big[k] = small[j];
                   j--;
                }
            }
            else if (i >= 0)
            {
                big[k] = big[i];
                i--;
            }
            else if (j >= 0)
            {
               big[k] = small[j];
               j--;
            }
            k--;
        }
    }

    public static void PrintArray(int[] numbers)
    {
        foreach(int x in numbers)
        {
            Console.Write($"{x} ");
        }
        Console.Write("\n");
    }
}

// int[] big = {10, 12, 13, 14, 18, 0, 0, 0, 0, 0};
// int[] small = {16, 17, 19, 20, 22};


int[] big = {10, 12, 13, 14, 18, 0, 0, 0, 0, 0};
int[] small = {11, 15, 19, 20, 22};

Exercise91B.SortMerge(big, small);
Exercise91B.PrintArray(big);

/**
 Method       | Time Complexity | Space Complexity 
--------------|-----------------|------------------
  SortMerge   |     O(m+n)      |    O(m)

This solution does not make any copy but rather sort and fills the larger array starting from it's last slot.  

Output: 
  10 11 12 13 14 15 18 19 20 22 

Online Resource: 
  https://www.geeksforgeeks.org/sorted-merge-one-array/

*/