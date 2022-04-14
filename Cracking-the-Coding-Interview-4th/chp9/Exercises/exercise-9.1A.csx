/**
Problem: You are given two sorted arrays, A and B, and A has a large enough buffer at the end to hold B. 
         Write a method to merge B into A in sorted order.
*/

class Exercise91A
{
    public static void SortMerge(int[] big, int[] small)
    {
        int len = big.Length - small.Length;
        int[] copyBig = new int[len];
        int i;
        for(i = 0; i < len; i++)
        {
           copyBig[i] = big[i];
        }

        i = 0;
        int j = 0;
        int k = 0;
        int len2 = small.Length;
        while(i < len || j < len2)
        {
            if (i < len && j < len2)
            { 
                if (copyBig[i] < small[j])
                {
                    big[k] = copyBig[i];
                    i++;
                }
                else 
                {
                    big[k] = small[j];
                    j++;
                }

            }
            else if(i < len) 
            {
                big[k] = copyBig[i];
                i++;
            }
            else if (j < len2)
            {
                big[k] = small[j];
                j++;
            }
            k++;
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

int[] big = {10, 12, 13, 14, 18, 0, 0, 0, 0, 0};
int[] small = {16, 17, 19, 20, 22};

Exercise91A.SortMerge(big, small);
Exercise91A.PrintArray(big);

/**
 Method       | Time Complexity | Space Complexity 
--------------|-----------------|------------------
  SortMerge   |     O(m+n)      |    O(m)

This solution copies the occupied spots of the larger array to a buffer.

Output: 
  10 12 13 14 16 17 18 19 20 22 
*/