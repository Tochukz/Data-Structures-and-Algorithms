/**
Problem: Given an array of integers find the number that appears odd times in the array.
Note: There is only one number in the array that appears odd times
e.g [1, 2, 2, 5 1] => 5
    [1, 4, 6, 2, 4, 2, 1, 6, 4] => 4
*/

class OddTimes
{
    public static int getOddOccurence(int[] numbers)
    {
        List<int> oddOccurance = new List<int>();
        foreach(int x in numbers)
        {
            if (oddOccurance.Contains(x))
            {
               oddOccurance.Remove(x);
            }
            else 
            {
                oddOccurance.Add(x);
            }
        }

        if (oddOccurance.Count > 0)
        {
            return oddOccurance[0];
        }

        return -1;
    }
}

int odd1 = OddTimes.getOddOccurence(new int[]{1, 2, 2, 5, 1});
int odd2 = OddTimes.getOddOccurence(new int[]{1, 4, 6, 2, 4, 2, 1, 6, 4});
int odd3 = OddTimes.getOddOccurence(new int[]{1, 3, 2, 2, 3, 1});

Console.WriteLine($"odd1 = {odd1}");
Console.WriteLine($"odd2 = {odd2}");
Console.WriteLine($"odd3 = {odd3}");

/**
Output:  
  odd1 = 5
  odd2 = 4
  odd3 = -1
*/