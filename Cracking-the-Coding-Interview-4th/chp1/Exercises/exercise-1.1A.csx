/**
  Problem:  
    Implement an algorithm to determine if a string has all unique characters.
*/

using System.Collections.Generic;

public class Exercise11A
{
    public bool isAllUnique(string str)
    {
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
               return false;
            }
        }

        return true;
    }

    public bool isAllUnique2(string str)
    {
        HashSet<char> charOccurance = new HashSet<char>();
        for(int i = 0; i < str.Length; i++)
        {
            char x = str[i];
            if (charOccurance.Contains(x))
            {
                return false;
            }
            else 
            {
                charOccurance.Add(x);
            }
        }
        return true;
    }
}


Exercise11A exc1 = new Exercise11A();
bool unique1 = exc1.isAllUnique2("Hippopotamous"); // False
bool unique2 = exc1.isAllUnique2("Kalvin C"); // True

Console.WriteLine(unique1);
Console.WriteLine(unique2);

/**
  Solution: 
    Time Complexity:  O(n)
    Space Complexity: O(n)

    Where n is the length the string
*/