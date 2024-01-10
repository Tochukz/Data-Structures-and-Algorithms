/**
* Problem:  
*  Write a method to replace all spaces in a string with ‘%20’.
*/
using System;
using System.Text;
using System.Collections.Generic;

class Practice15 {
   public string ReplaceSpaces(string str) {
     // Write your solution here
      return str;
   }

   public void Test(Dictionary<string, string> testCases) {
     foreach (KeyValuePair<string, string> item in testCases) {
        string result = ReplaceSpaces(item.Key);
        if (item.Value == result) {
           Console.WriteLine("Passed!");
        } else {
          Console.WriteLine($"Failed: Expected {item.Value}, got {result}");
        }        
     }  
   }
}

Practice15 Practice = new Practice15();
Dictionary<string, string> testCases = new Dictionary<string, string> {
   {"Mr John Smith", "Mr%20John%20Smith"},
};

Practice.Test(testCases)
