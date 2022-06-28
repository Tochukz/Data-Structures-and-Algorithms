/**
Problem: Given an unsorted array A of size N that contains only non-negative integers, find a continuous sub-array which adds to a given number S.
        In case of multiple subarrays, return the subarray which comes first on moving from left to right.
*/

class PositiveArraySum
{
    public List<int> subarraySum(int[] numbers, int len, int S)
    {
        int sum = 0;
        int  startIndex = 0;
        List<int> sub = new List<int> { -1 };
        for(int i = 0; i < len; i++)
        {
            sum += numbers[i];
            while(sum > S)
            {
                sum -= numbers[startIndex];
                startIndex++;   
            }
            if (sum == S && startIndex <= i)
            {
                int startPosition = startIndex + 1;
                int endPosition = i + 1;
                sub = new List<int> {startPosition, endPosition};
                break;
            } 
        }
        return sub;
    }

    public void printList(List<int> list)
    {
        foreach(int n in list)
        {
            Console.Write($"{n} ");
        }
        Console.Write("\n");
    }
}

PositiveArraySum subArraySum = new PositiveArraySum();

int[] numbers1 = {1,2,3,7,5};
int sum1 = 12;
List<int> sub1 = subArraySum.subarraySum(numbers1, numbers1.Length, sum1);
subArraySum.printList(sub1); // 2 4 

int[] numbers2 = {1,2,3,4,5,6,7,8,9,10};
int sum2 = 15;
List<int> sub2 = subArraySum.subarraySum(numbers2, numbers2.Length, sum2);
subArraySum.printList(sub2); // 1 5

int[] numbers3 = {1, 4};
int sum3 = 0;
List<int> sub3 = subArraySum.subarraySum(numbers3, numbers3.Length, sum3);
subArraySum.printList(sub3); // -1

/**
Online Practice: 
  https://practice.geeksforgeeks.org/problems/subarray-with-given-sum-1587115621/1/ 

Online Resource: 
  https://www.geeksforgeeks.org/find-subarray-with-given-sum/
*/