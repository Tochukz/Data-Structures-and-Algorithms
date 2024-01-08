/**
* Problem:  
*  Assume you have a method isSubstring which checks if one word is a substring of another. Given two strings, s1 and s2, 
*    write code to check if s2 is a rotation of s1 using only one call to isSubstring (i.e., “waterbottle” is a rotation of “erbottlewat”)
*/
using System;
using System.Collections.Generic;

class Practice18 {
   public bool IsRotationOf(string str1, string str2) {
      // Write your solution here
     return false;
   }

   public void Test(Dictionary<string[], bool> testCases) {
     foreach (KeyValuePair<string[], bool> item in testCases) {
        string[] args = item.Key;
        bool result = IsRotationOf(args[0], args[1]);
        if (item.Value == result) {
           Console.WriteLine("Passed!");
        } else {
          Console.WriteLine($"Failed: Expected {item.Value}, got {result}");
        }        
     }  
   }
}

Practice18 Practice = new Practice18();
Dictionary<string[], bool> testCases = new Dictionary<string[], bool> {
   { new string[]{"apple", "pleap"}, true},
   { new string[]{"waterbottle", "erbottlewat"}, true},
   { new string[]{"camera", "macera"}, false},
};
Practice.Test(testCases)
