/**
* Problem:  
*  Design an algorithm and write code to remove the duplicate characters in a string without using any additional buffer.
*     NOTE: One or two additional variables are fine. An extra copy of the array is not.
*/
using System;
using System.Collections.Generic;

class Practice13 {
   public void RemoveDuplicates(char[] str) {
      // Write your solution here
   }

   public void Test(Dictionary<string, string> testCases) {
     foreach (KeyValuePair<string, string> item in testCases) {
        char[] argArry = item.Key.ToCharArray();
        RemoveDuplicates(argArry);
        string argStr = string.Join("", argArry);
        if (item.Value == argStr) {
           Console.WriteLine("Passed!");
        } else {
          Console.WriteLine($"Failed: Expected {item.Value}, got {argStr}");
        }        
     }  
   }
}

Practice13 Practice = new Practice13();
Dictionary<string, string> testCases = new Dictionary<string, string> {
   {"hippopotamus", "hipotamus"},
   {"geeksforgeeks", "geksfor"},
};

Practice.Test(testCases)
