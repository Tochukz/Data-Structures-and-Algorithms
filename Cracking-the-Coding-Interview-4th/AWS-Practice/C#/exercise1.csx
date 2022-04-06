/**
Problem: Find the missing number in the array
    You are given an array of positive numbers from 1 to n, such that all numbers from 1 to n are present except one number x. 
    You have to find x. The input array is not sorted. Look at the below array and give it a try before checking the solution.

Constraint: 
  Runtime Complexity: Linear, O(n)
  Memory Complexity: Constant, O(1)

*/
class Exercise1
{
    public static int FindMissingNum(int[] numbers)
    {
        if (numbers.Length < 2)
        {
            return -1;
        }
        int firstElem = 1;
        int commonDiff = 1;
        int trueLen = numbers.Length + 1;
        int trueSum = GetSum(trueLen, firstElem, commonDiff); 
        int actualSum = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            actualSum += numbers[i];
        }
        int missing = trueSum - actualSum;
        return missing;
    }

    private static int GetSum(int n, int a, int d)
    {
        int sum = (n/2) * (2*a + (n-1)*d);
        return sum;
    }
}

int[] numbers = new int[]{3, 7, 1, 2, 8, 4, 5};
int missing = Exercise1.FindMissingNum(numbers);
Console.WriteLine("Missing = {0}", missing);

/**
 Formulas: 
  Arithmtic Sequence Sum to nth term 
    S = n⁄2 {2a + (n − 1) d}
    
  Online Excerise: 
    https://www.educative.io/m/find-the-missing-number
*/