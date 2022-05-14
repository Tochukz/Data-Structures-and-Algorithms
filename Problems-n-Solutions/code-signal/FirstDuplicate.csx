/**
Problem: Given an array a that contains only numbers in the range from 1 to a.length, 
         find the first duplicate number for which the second occurrence has the minimal index. 
         In other words, if there are more than 1 duplicated numbers, return the number for which 
         the second occurrence has a smaller index than the second occurrence of the other number does. 
         If there are no such elements, return -1.
*/
class FirstDuplicate 
{
    int solution(int[] numbers) {
        HashSet<int> set = new HashSet<int>();
        for(int i = 0; i < numbers.Length; i++)
        {
            int x = numbers[i];
            if (set.Contains(x))
            {
                return x;
            }
            else 
            {
                set.Add(x);
            }
        }
        return -1;
    }
}