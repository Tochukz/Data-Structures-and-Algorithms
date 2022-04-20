/**
Problem: Smallest Positive missing number
  You are given an array arr[] of N integers including 0. The task is to find the smallest positive number missing from the array.
 */

 import java.util.*;

class SmallestPositive
{
    //Function to find the smallest positive number missing from the array.
    static int missingNumber(int numbers[], int size)
    {
        // Your code here
         if (numbers.length == 0)
        {
            return 1;
        }
        Arrays.sort(numbers);
        int max = 0;
        int x;
        for(int i = 0; i < numbers.length - 1; i++)
        {
            
            if (numbers[i+1] - numbers[i] > 1)
            {
                x = numbers[i] + 1;
                while(x < numbers[i+1])
                {
                    if (x > 0)
                    {
                        return x;
                    }
                    x++;
                }
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i+1] > max)
            {
                max = numbers[i+1];
            }
        }

        return max + 1;
    }

    public static void main(String[] args) {
        int numberSet[][] = {
            {0,-10,1,3,-20},
            {1,2,3,4,5}
        }; 
        for(int[] numbers : numberSet)
        {
            int missing = missingNumber(numbers, numbers.length);
            System.out.println(missing);
        }

    }
}

/**
Output:  
  2
  6
  
Online Resource: 
   https://www.geeksforgeeks.org/find-the-smallest-positive-number-missing-from-an-unsorted-array/
   https://practice.geeksforgeeks.org/problems/smallest-positive-missing-number-1587115621/1
 */