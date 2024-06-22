/**
* Problem:  
*   Write a method to decide if two strings are anagrams or not.
*   An anagram is a word, phrase, or name formed by rearranging the letters of another, such as spar, formed from rasp.
*/
using System;
using System.Collections.Generic;

class Practice14 {
   public bool IsAnagram(string str1, string str2) {
      // Write your solution here
      return false;
   }

   public void Test(Dictionary<string[], bool> testCases) {
     foreach (KeyValuePair<string[], bool> item in testCases) {
        string[] args = item.Key;
        bool result = IsAnagram(args[0], args[1]);
        if (item.Value == result) {
           Console.WriteLine("Passed!");
        } else {
          Console.WriteLine($"Failed: Expected {item.Value}, got {result}");
        }        
     }  
   }
}

Practice14 Practice = new Practice14();
Dictionary<string[], bool> testCases = new Dictionary<string[], bool> {
  { new string[] {"secure", "rescue"}, true},
  { new string[] {"spar", "rasp"}, true},
  { new string[] {"master", "sister"}, false}
};

Practice.Test(testCases)
