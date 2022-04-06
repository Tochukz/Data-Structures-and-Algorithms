/**
Problem: Determine if the sum of two integers is equal to the given value
    Given an array of integers and a value, determine if there are any two integers in the array whose sum is equal to the given value. 
    Return true if the sum exists and return false if it does not. 

Constraint: 
  Runtime Complexity: Linear, O(n)
  Memory Complexity: Linear, O(n)
*/

using System.Collections.Generic;

class Excercise2
{
    public static bool SumExists(int[] numbers, int value)
    {
        HashSet<int> numberSet = new HashSet<int>();
        for(int i = 0 ; i < numbers.Length; i++)
        {
            int x  = numbers[i];
            numberSet.Add(x);
            int diff = value - x;
            if (numberSet.Contains(diff))
            {
                return true;
            }
        }
        return false;
    }
}

int[] numbers =new int[]{5, 7, 1, 2, 8, 4, 3};
bool exists = Excercise2.SumExists(numbers, 10);
if (exists)
{
    Console.WriteLine("Sum do exists");
}
else
{
    Console.WriteLine("Sum do NOT exists");
}

/**
  Output: 
    Sum do exists

  Online Excercise:  
    https://www.educative.io/m/sum-of-two-values
*/