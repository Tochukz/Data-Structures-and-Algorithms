/**
Problem:  Given an array A of N integers, return the smallest positive integer (greater than 0) that does not occur in A.  
    For example input A = [1, 3, 6, 4, 1, 2] should return 5.   
*/

class SmallestPositive
{
    public static int smallestPositiveInt(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            return 1;
        }
        Array.Sort(numbers);
        int max = 0;
        int x;
        for(int i = 0; i < numbers.Length - 1; i++)
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
}

int[][] cases = {
    new int[]{1, 3, 6, 4, 1, 2},
    new int[]{1, 2, 3},
    new int[]{-1, -3, -6, -4, -1, -2},
    new int[]{0, 0, 0, 0, 0, 0},
    new int[]{1000000, -1000000, 6, -4, 1, -1000000, 1000000},
    new int[]{1,2,3,4,5,6,7,8,9,10},
    new int[]{-1,2,-3,4,-5,6,-7,8,-9,10},
    new int[]{1,-2,3,-4,5,-6,7,-8,9,-10},
    new int[]{1,2,3,4,5,6,7,8,10},
};

for(int i = 0; i < cases.Length; i++)
{
    int[] numbers = cases[i];
    int smallest = SmallestPositive.smallestPositiveInt(numbers);
    Console.WriteLine(smallest);
}

/**
Output: 
    5
    4
    1
    1
    2
    11
    1
    2
    9
*/