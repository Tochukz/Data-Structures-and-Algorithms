/**
  Problem:  
    Implement an algorithm to determine if a string has all unique characters without using an additional data structures.
*/

public class Exercise11B
{
    public bool isAllUnique(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            for( int j = i + 1; j < str.Length; j++)
            {
                // Console.WriteLine($"{str[i]} == {str[j]}");
                if (str[i] == str[j]) {                  
                    return false;
                }
            }
        }

        return true;
    }
}

Exercise11B exc1 = new Exercise11B();
bool unique1 = exc1.isAllUnique("Hippopotamous"); // False
bool unique2 = exc1.isAllUnique("Kalvin C"); // True

Console.WriteLine(unique1);
Console.WriteLine(unique2);

/**
 Solution: 
   Time Complexity: O(n^2)
   Space COmplexity: no space

   Where n is the length the string
*/