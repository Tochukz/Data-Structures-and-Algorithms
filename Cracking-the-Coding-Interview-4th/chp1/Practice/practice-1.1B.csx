/**
* Problem:  
*   Implement an algorithm to determine if a string has all unique characters without using an additional data structures.
*/
using System;
using System.Collections.Generic;

class Practice11B {
   public bool IsUniqueChars(string word) {
      // Write your solution here
     return true;
   }

   public void Test(Dictionary<string, bool> testCases) {
     foreach (KeyValuePair<string, bool> item in testCases) {
        bool resultVal = IsUniqueChars(item.Key);
        if (item.Value == resultVal) {
           Console.WriteLine("Passed!");
        } else {
          Console.WriteLine($"Failed: Expected {item.Value}, got {resultVal}");
        }        
     }  
   }
}

Practice11B Practice = new Practice11B();
Dictionary<string, bool> testCases = new Dictionary<string, bool> {
    {"Hello", false},
    {"Chima", true},
    {"Parrot", false},
    {"Lion", true},
    {"Javis", true}
};

Practice.Test(testCases)
