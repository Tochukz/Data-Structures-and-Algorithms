/**
  Problem:  
    Implement an algorithm to determine if a string has all unique characters.
*/

using System.Collections.Generic;

public class Exercise11A
{
    public bool isAllUnique(string str)
    {
        bool isUnique = true;
        Dictionary<char, int> charOccurance = new Dictionary<char, int>();
        for(int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if (!charOccurance.ContainsKey(c))
            {
                charOccurance[c] = 0;
            }
            charOccurance[c] += 1; 
            if (charOccurance[c] > 1) {
                isUnique = false;
                break;
            }
        }

        return isUnique;
    }
}


Exercise11A exc1 = new Exercise11A();
bool unique1 = exc1.isAllUnique("Hippopotamous"); // False
bool unique2 = exc1.isAllUnique("Kalvin C"); // True

Console.WriteLine(unique1);
Console.WriteLine(unique2);

/**
  Solution: 
    Time Complexity:  O(n)
    Space Complexity: O(n)

    Where n is the length the string
*/