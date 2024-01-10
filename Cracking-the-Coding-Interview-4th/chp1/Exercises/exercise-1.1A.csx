/**
  Problem:
    Implement an algorithm to determine if a string has all unique characters.
*/

using System.Collections.Generic;

public class Exercise11A
{
    public bool isUniqueChars(string word)
    {
       //Todo: solve in O(n) time without using any data structure
       //Hint: Use bitwise operator. See the corresponding Java code example.
    }

    // This is the most efficient solution
    public bool isUnique(string word)
    {
        bool[] chars = new bool[256];
        for(int i = 0; i < word.Length; i++) {
            int x = word[i];
            if (chars[x]) {
                return false;
            }
            chars[x] = true;
        }
        return true;
    }

    public bool isUnique2(string word)
    {
        Stack<char> stack = new Stack<char>();
        for(int i = 0; i < word.Length; i++)
        {
            if (stack.Contains(word[i])) {
                return false;
            } else {
                stack.Push(word[i]);
            }
        }
        return true;
    }

    public bool isUnique3(string str)
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

string[] words = {"Jerusalem", "Maskur", "Hippopotamous", "Kalvin C"};
Exercise11A exer = new Exercise11A();
foreach(string word in words) {
  Console.WriteLine($"{word} is unique? {exer.isUnique(word)} , {exer.isUnique2(word)},  {exer.isUnique3(word)}");
}
/**
Ouput:
  Jerusalem is unique? False , False,  False
  Maskur is unique? True , True,  True
  Hippopotamous is unique? False , False,  False
  Kalvin C is unique? True , True,  True
*/

/**
Solution:
  Time Complexity:  O(n)
  Space Complexity: O(n)

  Where n is the length the string
*/
