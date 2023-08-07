/**
* Problem: Assume you have a method isSubstring which checks if one word is a substring of another. 
*   Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using only one 
*   call to isSubstring (e.g "waterbottle" is a rotation of "erbottlewat")
*/

using System;
using System.Collections.Generic;

class Exercise18 {
   public bool IsRotationOf(string word1, string word2) {
       // Write your solution here
      return false;
   }

   public void Test(Dictionary<string[], bool> testCases) {
      foreach(KeyValuePair<string[], bool> item in testCases) {
         if (item.Key.Length != 2) {
            throw new Exception("Array of string must have length of 2");
         }
         string[] words = item.Key;
         bool result = IsRotationOf(words[0], words[1]);
         if (result == item.Value) {
            Console.WriteLine("Pass!");
         } else {
            Console.WriteLine($"Failed: expected {item.Value} got {result}");
         }
      }
   }
} 


Exercise18 exercise = new Exercise18();
Dictionary<string[], bool> testCases = new Dictionary<string[], bool> {
  {new string[]{"waterbottle", "erbottlewat"}, true},
  {new string[]{"rellay", "layrel"}, true},
  {new string[]{"mackitask", "kimactask"}, false},
};
exercise.Test(testCases);